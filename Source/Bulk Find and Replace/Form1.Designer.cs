namespace Bulk_Find_and_Replace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileTextbox2 = new FileTextbox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDirect = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutFind = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.uxFindList = new ScintillaNET.Scintilla();
            this.tableLayoutReplace = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.uxReplaceList = new ScintillaNET.Scintilla();
            this.uxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.tabPageFromFile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scintillaFind = new ScintillaNET.Scintilla();
            this.scintillaReplace = new ScintillaNET.Scintilla();
            this.fileTextboxOutput = new FileTextbox();
            this.fileTextboxInput = new FileTextbox();
            this.tabControl1.SuspendLayout();
            this.tabPageDirect.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutFind.SuspendLayout();
            this.tableLayoutReplace.SuspendLayout();
            this.tabPageFromFile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTextbox2
            // 
            this.fileTextbox2.AutoCompleteList = null;
            this.fileTextbox2.BasePath = null;
            this.fileTextbox2.DragDropFileFilter = ".stf";
            this.fileTextbox2.DropDownList = ((System.Collections.Generic.List<string>)(resources.GetObject("fileTextbox2.DropDownList")));
            this.fileTextbox2.DropDownListString = "";
            this.fileTextbox2.Enabled = false;
            this.fileTextbox2.Filter = "STF files (*.stf)|*.stf";
            this.fileTextbox2.Label = "Second/after STF file:";
            this.fileTextbox2.Location = new System.Drawing.Point(6, 6);
            this.fileTextbox2.Name = "fileTextbox2";
            this.fileTextbox2.ShowRelativePath = false;
            this.fileTextbox2.Size = new System.Drawing.Size(685, 21);
            this.fileTextbox2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDirect);
            this.tabControl1.Controls.Add(this.tabPageFromFile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 257);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPageDirect
            // 
            this.tabPageDirect.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDirect.Controls.Add(this.tableLayoutPanel2);
            this.tabPageDirect.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirect.Name = "tabPageDirect";
            this.tabPageDirect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirect.Size = new System.Drawing.Size(793, 231);
            this.tabPageDirect.TabIndex = 0;
            this.tabPageDirect.Text = "Direct";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutFind, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutReplace, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.uxCaseSensitive, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 225);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutFind
            // 
            this.tableLayoutFind.ColumnCount = 1;
            this.tableLayoutFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFind.Controls.Add(this.label4, 0, 0);
            this.tableLayoutFind.Controls.Add(this.uxFindList, 0, 1);
            this.tableLayoutFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFind.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutFind.Name = "tableLayoutFind";
            this.tableLayoutFind.RowCount = 2;
            this.tableLayoutFind.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutFind.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutFind.Size = new System.Drawing.Size(781, 95);
            this.tableLayoutFind.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Find text:";
            // 
            // uxFindList
            // 
            this.uxFindList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxFindList.Location = new System.Drawing.Point(3, 16);
            this.uxFindList.Name = "uxFindList";
            this.uxFindList.Size = new System.Drawing.Size(775, 76);
            this.uxFindList.TabIndex = 3;
            this.uxFindList.UseTabs = false;
            this.uxFindList.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.uxFindList_UpdateUI);
            this.uxFindList.TextChanged += new System.EventHandler(this.uxFindList_TextChanged);
            // 
            // tableLayoutReplace
            // 
            this.tableLayoutReplace.ColumnCount = 1;
            this.tableLayoutReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutReplace.Controls.Add(this.label2, 0, 2);
            this.tableLayoutReplace.Controls.Add(this.uxReplaceList, 0, 3);
            this.tableLayoutReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutReplace.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutReplace.Name = "tableLayoutReplace";
            this.tableLayoutReplace.RowCount = 4;
            this.tableLayoutReplace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutReplace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutReplace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutReplace.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutReplace.Size = new System.Drawing.Size(781, 95);
            this.tableLayoutReplace.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace text:";
            // 
            // uxReplaceList
            // 
            this.uxReplaceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxReplaceList.Location = new System.Drawing.Point(3, 16);
            this.uxReplaceList.Name = "uxReplaceList";
            this.uxReplaceList.Size = new System.Drawing.Size(775, 76);
            this.uxReplaceList.TabIndex = 4;
            this.uxReplaceList.UseTabs = false;
            this.uxReplaceList.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.uxReplaceList_UpdateUI);
            this.uxReplaceList.TextChanged += new System.EventHandler(this.uxReplaceList_TextChanged);
            // 
            // uxCaseSensitive
            // 
            this.uxCaseSensitive.AutoSize = true;
            this.uxCaseSensitive.Checked = true;
            this.uxCaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxCaseSensitive.Location = new System.Drawing.Point(3, 205);
            this.uxCaseSensitive.Name = "uxCaseSensitive";
            this.uxCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.uxCaseSensitive.TabIndex = 3;
            this.uxCaseSensitive.Text = "Case sensitive";
            this.uxCaseSensitive.UseVisualStyleBackColor = true;
            this.uxCaseSensitive.CheckedChanged += new System.EventHandler(this.uxCaseSensitive_CheckedChanged);
            // 
            // tabPageFromFile
            // 
            this.tabPageFromFile.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFromFile.Controls.Add(this.fileTextbox2);
            this.tabPageFromFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFromFile.Name = "tabPageFromFile";
            this.tabPageFromFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFromFile.Size = new System.Drawing.Size(793, 231);
            this.tabPageFromFile.TabIndex = 1;
            this.tabPageFromFile.Text = "From file";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fileTextboxOutput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileTextboxInput, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 641);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Replace";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 86);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(801, 552);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.scintillaFind, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.scintillaReplace, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(801, 291);
            this.tableLayoutPanel3.TabIndex = 43;
            // 
            // scintillaFind
            // 
            this.scintillaFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaFind.Location = new System.Drawing.Point(3, 3);
            this.scintillaFind.Name = "scintillaFind";
            this.scintillaFind.Size = new System.Drawing.Size(394, 285);
            this.scintillaFind.TabIndex = 0;
            this.scintillaFind.Text = "The quick brown fox jumps over the lazy dog.";
            this.scintillaFind.UseTabs = false;
            this.scintillaFind.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintillaFind_UpdateUI);
            // 
            // scintillaReplace
            // 
            this.scintillaReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaReplace.Location = new System.Drawing.Point(403, 3);
            this.scintillaReplace.Name = "scintillaReplace";
            this.scintillaReplace.Size = new System.Drawing.Size(395, 285);
            this.scintillaReplace.TabIndex = 1;
            this.scintillaReplace.UseTabs = false;
            this.scintillaReplace.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintillaReplace_UpdateUI);
            // 
            // fileTextboxOutput
            // 
            this.fileTextboxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTextboxOutput.AutoCompleteList = null;
            this.fileTextboxOutput.BasePath = null;
            this.fileTextboxOutput.DragDropFileFilter = null;
            this.fileTextboxOutput.DropDownList = ((System.Collections.Generic.List<string>)(resources.GetObject("fileTextboxOutput.DropDownList")));
            this.fileTextboxOutput.DropDownListString = "";
            this.fileTextboxOutput.Filter = "All files (*.*)|*.*";
            this.fileTextboxOutput.Label = "Output file:";
            this.fileTextboxOutput.Location = new System.Drawing.Point(3, 30);
            this.fileTextboxOutput.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.fileTextboxOutput.Name = "fileTextboxOutput";
            this.fileTextboxOutput.ShowRelativePath = false;
            this.fileTextboxOutput.Size = new System.Drawing.Size(784, 21);
            this.fileTextboxOutput.TabIndex = 0;
            // 
            // fileTextboxInput
            // 
            this.fileTextboxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTextboxInput.AutoCompleteList = null;
            this.fileTextboxInput.BasePath = null;
            this.fileTextboxInput.DragDropFileFilter = null;
            this.fileTextboxInput.DropDownList = ((System.Collections.Generic.List<string>)(resources.GetObject("fileTextboxInput.DropDownList")));
            this.fileTextboxInput.DropDownListString = "";
            this.fileTextboxInput.Filter = "All files (*.*)|*.*";
            this.fileTextboxInput.Label = "Input file:";
            this.fileTextboxInput.Location = new System.Drawing.Point(3, 3);
            this.fileTextboxInput.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.fileTextboxInput.Name = "fileTextboxInput";
            this.fileTextboxInput.ShowRelativePath = false;
            this.fileTextboxInput.Size = new System.Drawing.Size(784, 21);
            this.fileTextboxInput.TabIndex = 0;
            this.fileTextboxInput.FileChanged += new FileTextbox.FileChangedEventHandler(this.fileTextboxInput_FileChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Bulk Find and Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDirect.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutFind.ResumeLayout(false);
            this.tableLayoutFind.PerformLayout();
            this.tableLayoutReplace.ResumeLayout(false);
            this.tableLayoutReplace.PerformLayout();
            this.tabPageFromFile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FileTextbox fileTextbox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDirect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageFromFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ScintillaNET.Scintilla scintillaFind;
        private ScintillaNET.Scintilla scintillaReplace;
        private FileTextbox fileTextboxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox uxCaseSensitive;
        private ScintillaNET.Scintilla uxFindList;
        private ScintillaNET.Scintilla uxReplaceList;
        private FileTextbox fileTextboxOutput;
    }
}

