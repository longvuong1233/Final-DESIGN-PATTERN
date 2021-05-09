using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ELECTRIC
{
    class DoLaAdaptee
    {
        public float convertVNDToDoLa(float vnd)
        {
            return vnd /23;
        }
    }
}
