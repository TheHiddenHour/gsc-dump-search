using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsc_dump_search {
    static class StringExtensions {
        public static bool Contains(ref string comparatorStr, string comparisonStr, StringComparison compareCulture = StringComparison.CurrentCulture) {
            return comparatorStr.IndexOf(comparisonStr, compareCulture) >= 0;
        }
    }
}