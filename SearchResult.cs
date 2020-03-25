using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsc_dump_search {
    public class SearchResult {
        public string Text { get; set; }
        public string Path { get; set; }
        public int Line { get; set; }

        public override string ToString() {
            string outStr = "Text: " + Text + "\n";
            outStr += "Path: " + Path + "\n";
            outStr += "Line: " + Line.ToString();

            return outStr;
        }
    }
}
