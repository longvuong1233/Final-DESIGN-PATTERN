using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ELECTRIC
{
    class ConvertAdapter : VietNamDongTarget
    {
        private DoLaAdaptee adaptee;
        public ConvertAdapter(DoLaAdaptee adap)
        {
            this.adaptee = adap;
        }
        public float convert(float money)
        {
            float dola = this.adaptee.convertVNDToDoLa(money);
            return dola;
        }
    }
}
