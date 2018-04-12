using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest.DI.Helpers
{
    public class PercentageCalculator
    {
        public static int CalcPercentageProcess<TT>(IEnumerable<TT> listDocs, TT currentDoc)
        {
            var list = listDocs.ToList();
            var rowNumber = list.IndexOf(currentDoc) + 1;
            var percent = rowNumber * 100 / list.Count;
            return percent;
        }

        public static int CalcPercentageProcess<TT>(IEnumerable<TT> listDocs, TT currentDoc, int qtdDocs)
        {
            var list = listDocs.ToList();
            var rowNumber = list.IndexOf(currentDoc) + 1;
            var percent = rowNumber * 100 / qtdDocs;
            return percent;
        }
    }
}
