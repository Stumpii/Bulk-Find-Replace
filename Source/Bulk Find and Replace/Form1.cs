namespace Bulk_Find_and_Replace
{
    using Newtonsoft.Json;
    using ScintillaNET;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        #region Fields

        private ProgramSettings programSettings = new ProgramSettings();

        #endregion Fields

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Form Event Handlers

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save app settings
            programSettings.FindItems = uxFindList.Text;
            programSettings.ReplaceItems = uxReplaceList.Text;
            programSettings.FindText = scintillaFind.Text;
            programSettings.ReplaceText = scintillaReplace.Text;
            programSettings.SelectedInputFile = fileTextboxInput.Text;
            programSettings.SelectedOutputFile = fileTextboxOutput.Text;
            programSettings.InputFilesDropdownList = fileTextboxInput.DropDownList;
            programSettings.OutputFilesDropdownList = fileTextboxOutput.DropDownList;

            // serialize JSON directly to a file
            string settingsFilename = Path.Combine(Application.StartupPath, "Program Settings.json");
            using (StreamWriter file = File.CreateText(settingsFilename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, programSettings);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uxFindList.Markers[3].Symbol = MarkerSymbol.Background;
            uxFindList.Markers[3].SetBackColor(Color.WhiteSmoke);

            uxReplaceList.Markers[3].Symbol = MarkerSymbol.Background;
            uxReplaceList.Markers[3].SetBackColor(Color.WhiteSmoke);

            scintillaFind.Markers[3].Symbol = MarkerSymbol.Background;
            scintillaFind.Markers[3].SetBackColor(Color.WhiteSmoke);

            scintillaReplace.Markers[3].Symbol = MarkerSymbol.Background;
            scintillaReplace.Markers[3].SetBackColor(Color.WhiteSmoke);

            // deserialize JSON directly from a file
            string settingsFilename = Path.Combine(Application.StartupPath, "Program Settings.json");
            if (File.Exists(settingsFilename))
            {
                using (StreamReader file = File.OpenText(settingsFilename))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    programSettings = (ProgramSettings)serializer.Deserialize(file, typeof(ProgramSettings));
                }
            }

            // Use loaded settings
            uxFindList.Text = programSettings.FindItems;
            uxReplaceList.Text = programSettings.ReplaceItems;
            scintillaFind.Text = programSettings.FindText;
            scintillaReplace.Text = "";
            fileTextboxInput.Text = programSettings.SelectedInputFile;
            fileTextboxOutput.Text = programSettings.SelectedOutputFile;
            fileTextboxInput.DropDownList = programSettings.InputFilesDropdownList;
            fileTextboxOutput.DropDownList = programSettings.OutputFilesDropdownList;

            //PerformReplacement();
        }

        #endregion Form Event Handlers

        #region Event Handlers

        private void button1_Click(object sender, EventArgs e)
        {
            PerformReplacement();

            //if (fileTextboxOutput.FileExists)
            System.IO.File.WriteAllText(fileTextboxOutput.AbsolutePath, scintillaReplace.Text);
        }

        private void mnuFileExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            //PerformReplacement();
        }

        #endregion Event Handlers

        #region Methods

        private void fileTextboxInput_FileChanged(bool IsValid)
        {
            scintillaFind.Text = System.IO.File.ReadAllText(fileTextboxInput.AbsolutePath);
        }

        private void PerformReplacement()
        {
            scintillaFind.FindReplace.ClearAllHighlights();
            scintillaReplace.FindReplace.ClearAllHighlights();

            scintillaReplace.Text = scintillaFind.Text;

            if (uxFindList.Lines.Count != uxReplaceList.Lines.Count)
                return;

            //Generate list of intermediate replacments
            List<string> intermediateReplacements = new List<string>();
            for (int i = 0; i < uxFindList.Lines.Count; i++)
            {
                intermediateReplacements.Add(System.Guid.NewGuid().ToString());
            }

            //Replace with intermediate text
            for (int i = 0; i < uxFindList.Lines.Count; i++)
            {
                string FindItem = uxFindList.Lines[i].Text.TrimEnd('\r', '\n');
                if (FindItem == string.Empty)
                    continue;

                if (scintillaFind.FindReplace.FindAll(FindItem, false, true) > 0)
                {
                    string ReplaceItem = uxReplaceList.Lines[i].Text.TrimEnd('\r', '\n');
                    if (ReplaceItem != string.Empty)
                    {
                        string intermediate = intermediateReplacements[i];
                        int count = scintillaReplace.FindReplace.ReplaceAll(FindItem, intermediate, SearchFlags.None, false, true);
                    }
                }
            }

            //Replace intermediate text
            for (int i = 0; i < uxFindList.Lines.Count; i++)
            {
                string FindItem = uxFindList.Lines[i].Text.TrimEnd('\r', '\n');
                if (FindItem == string.Empty)
                    continue;

                if (scintillaFind.FindReplace.FindAll(FindItem, false, true) > 0)
                {
                    string ReplaceItem = uxReplaceList.Lines[i].Text.TrimEnd('\r', '\n');
                    if (ReplaceItem != string.Empty)
                    {
                        string intermediate = intermediateReplacements[i];
                        int count = scintillaReplace.FindReplace.ReplaceAll(intermediate, ReplaceItem, SearchFlags.None, false, true);
                    }
                }
            }
        }

        private void scintillaFind_Scroll(object sender, ScrollEventArgs e)
        {
            //if (scintillaReplace.FirstVisibleLine != scintillaFind.FirstVisibleLine)
            //    scintillaReplace.FirstVisibleLine = scintillaFind.FirstVisibleLine;
        }

        private void scintillaFind_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            switch (e.Change)
            {
                case UpdateChange.Content:
                    break;

                case UpdateChange.HScroll:
                    if (scintillaReplace.XOffset != scintillaFind.XOffset)
                        scintillaReplace.XOffset = scintillaFind.XOffset;
                    break;

                case UpdateChange.Selection:
                    var line = scintillaFind.LineFromPosition(scintillaFind.CurrentPosition);

                    scintillaFind.Markers[3].DeleteAll();
                    scintillaFind.Lines[line].MarkerAdd(3);

                    scintillaReplace.Markers[3].DeleteAll();
                    scintillaReplace.Lines[line].MarkerAdd(3);
              break;

                case UpdateChange.VScroll:
                    if (scintillaReplace.FirstVisibleLine != scintillaFind.FirstVisibleLine)
                        scintillaReplace.FirstVisibleLine = scintillaFind.FirstVisibleLine;
                    break;

                default:
                    break;
            }
        }

        private void scintillaReplace_Scroll(object sender, ScrollEventArgs e)
        {
            //if (scintillaFind.FirstVisibleLine != scintillaReplace.FirstVisibleLine)
            //    scintillaFind.FirstVisibleLine = scintillaReplace.FirstVisibleLine;
        }

        private void scintillaReplace_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            switch (e.Change)
            {
                case UpdateChange.Content:
                    break;

                case UpdateChange.HScroll:
                    if (scintillaFind.XOffset != scintillaReplace.XOffset)
                        scintillaFind.XOffset = scintillaReplace.XOffset;
                    break;

                case UpdateChange.Selection:
                    var line = scintillaReplace.LineFromPosition(scintillaReplace.CurrentPosition);

                    scintillaFind.Markers[3].DeleteAll();
                    scintillaFind.Lines[line].MarkerAdd(3);

                    scintillaReplace.Markers[3].DeleteAll();
                    scintillaReplace.Lines[line].MarkerAdd(3);
                break;

                case UpdateChange.VScroll:
                    if (scintillaFind.FirstVisibleLine != scintillaReplace.FirstVisibleLine)
                        scintillaFind.FirstVisibleLine = scintillaReplace.FirstVisibleLine;
                    break;

                default:
                    break;
            }
        }

        private void uxFindList_TextChanged(object sender, EventArgs e)
        {
            //PerformReplacement();
        }

        private void uxReplaceList_TextChanged(object sender, EventArgs e)
        {
            //PerformReplacement();
        }

        #endregion Methods

        private void uxFindList_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            switch (e.Change)
            {
                case UpdateChange.Content:
                    break;

                case UpdateChange.HScroll:
                    if (uxReplaceList.XOffset != uxFindList.XOffset)
                        uxReplaceList.XOffset = uxFindList.XOffset;
                    break;

                case UpdateChange.Selection:
                    var line = uxFindList.LineFromPosition(uxFindList.CurrentPosition);

                    uxFindList.Markers[3].DeleteAll();
                    uxFindList.Lines[line].MarkerAdd(3);

                    uxReplaceList.Markers[3].DeleteAll();
                    uxReplaceList.Lines[line].MarkerAdd(3);
                    break;

                case UpdateChange.VScroll:
                    if (uxReplaceList.FirstVisibleLine != uxFindList.FirstVisibleLine)
                        uxReplaceList.FirstVisibleLine = uxFindList.FirstVisibleLine;
                    break;

                default:
                    break;
            }
        }

        private void uxReplaceList_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            switch (e.Change)
            {
                case UpdateChange.Content:
                    break;

                case UpdateChange.HScroll:
                    if (uxFindList.XOffset != uxReplaceList.XOffset)
                        uxFindList.XOffset = uxReplaceList.XOffset;
                    break;

                case UpdateChange.Selection:
                    var line = uxReplaceList.LineFromPosition(uxReplaceList.CurrentPosition);

                    uxFindList.Markers[3].DeleteAll();
                    uxFindList.Lines[line].MarkerAdd(3);

                    uxReplaceList.Markers[3].DeleteAll();
                    uxReplaceList.Lines[line].MarkerAdd(3);
                    break;

                case UpdateChange.VScroll:
                    if (uxFindList.FirstVisibleLine != uxReplaceList.FirstVisibleLine)
                        uxFindList.FirstVisibleLine = uxReplaceList.FirstVisibleLine;
                    break;

                default:
                    break;
            }
        }
    }
}