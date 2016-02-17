using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bulk_Find_and_Replace
{
    class ProgramSettings
    {
            public string FindItems="";
            public string ReplaceItems = "";
            public string FindText = "";
            public string ReplaceText = "";
            public string SelectedInputFile;
            public string SelectedOutputFile;
            public List<string> InputFilesDropdownList;
            public List<string> OutputFilesDropdownList;
    }
}
