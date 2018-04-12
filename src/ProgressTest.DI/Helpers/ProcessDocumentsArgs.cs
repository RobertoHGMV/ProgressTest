using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest.DI.Helpers
{
    public delegate void OnProcessDocumentsHandle(object sender, ProcessDocumentsArgs args);

    public class ProcessDocumentsArgs
    {
        public ProcessDocumentsArgs(int percent, string description, bool showProgressBar)
        {
            Percent = percent;
            Description = description;
            ShowPressBar = showProgressBar;
        }

        public int Percent { get; set; }

        public string Description { get; set; }

        public bool ShowPressBar { get; set; }
    }
}
