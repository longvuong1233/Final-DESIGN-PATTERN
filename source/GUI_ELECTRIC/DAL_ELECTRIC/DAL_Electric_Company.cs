using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_ELECTRIC;
using System.Collections;
namespace DAL_ELECTRIC
{
   public class DAL_Electric_Company : DBConnect, Subject
    {
        private ArrayList observers;
        private float cost ;
        private string unit;
        private static DAL_Electric_Company myCompany = new DAL_Electric_Company();

        private DAL_Electric_Company()
        {
            this.observers = new ArrayList();
            this.cost = DTO_Electric_Company.getElectricCompany().ELECTRIC_COST;
           
        }
        public static DAL_Electric_Company getElectricCompanyObserver()
        {
            return myCompany;
        }

        public static DTO_Electric_Company getEletricCompany()
        {
            
            return DTO_Electric_Company.getElectricCompany();
        }

        public bool editNameElectricCompany(String nameCompany)
        {
            if (nameCompany.Trim() != "")
            {
                DTO_Electric_Company.getElectricCompany().COMPANY_NAME = nameCompany;
                return true;
            }
            return false;
        }
        public bool editCostElectricCompany(float costElectric)
        {
            if (costElectric>0)
            {
                DTO_Electric_Company.getElectricCompany().ELECTRIC_COST= costElectric;
                return true;
            }
            return false;
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
           int i = observers.IndexOf(o);
            if (i != -1)
            {
                observers.RemoveAt(i);
            }
        }

        public void notifyObservers()
        {
            DAL_Customer dalCustomer = new DAL_Customer();
            for (int i = 0; i < observers.Count; ++i)
            {
                Observer observer = (Observer)observers[i];
               
                DTO_Customer customer =  dalCustomer.findCustomer(observer.IdCustomer);
                CalCostMethod calCost = CalCostFactory.getCalCostMethod(customer.CUSTOMER_KIND, customer.CUSTOMER_ID, this.cost,this.unit);
               
                observer.update(this.cost,this.unit, calCost.execute());
            }
            
        }
        public void setData(float cost,string unit)
        {
          
            this.cost = cost;
            this.unit = unit;

            dataChanged();
        }
        public void dataChanged()
        {
            
            notifyObservers();
        }


    }
}
