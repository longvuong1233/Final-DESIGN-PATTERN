using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DTO_ELECTRIC
{
    class InterVal
    {
        public System.Timers.Timer interval(Action action, int millis)
        {

            var timer = new System.Timers.Timer(millis);
            timer.Elapsed += (s, e) => {
                timer.Enabled = false;
                action();
                timer.Enabled = true;
            };
            timer.Enabled = true;
            return timer;
        }
        public void clearInterval(System.Timers.Timer timer)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
    }
}
