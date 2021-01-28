using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickNoodle.Utils
{
    class Gradient
    {
        public Gradient(dynamic startValue, dynamic endValue, int notes)
        {

        }

        // USE THIS ONE ONLY FOR COLORS OR ELSE YOU HAVE AUTISM
        public int interpolate(int pBegin, int pEnd, int pStep, int pMax)
        {
            if (pBegin < pEnd) {
                return ((pEnd - pBegin) *(pStep / pMax)) + pBegin;
            } else {
                return ((pBegin - pEnd) *(1 - (pStep / pMax))) + pEnd;
            }
        }
    }
}
