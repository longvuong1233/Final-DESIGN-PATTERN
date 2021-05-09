using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_ELECTRIC
{
    public interface Subject
    {
         void registerObserver(Observer o);
         void removeObserver(Observer o);
         void notifyObservers();
    }

    public abstract class Observer
    {
        private int idCustomer;

        protected Observer(int idCustomer)
        {
            this.idCustomer = idCustomer;
        }

        public int IdCustomer { get => idCustomer; set => idCustomer = value; }

        public   abstract void update(float cost, string unit, float costPay);
    }

    public interface DisplayElement
    {
         void display();
    }
}
