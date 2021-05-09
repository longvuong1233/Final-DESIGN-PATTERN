using System;
using System.Collections.Generic;
using System.Text;
using DAL_ELECTRIC;
using System.Data;
using DTO_ELECTRIC;

namespace BUS_ELECTRIC
{
    public class BUS_Electric_Company
    {
        private DAL_Electric_Company dalElectricCompany = DAL_Electric_Company.getElectricCompanyObserver();
        public DTO_Electric_Company getCustomer()
        {
            return DAL_Electric_Company.getEletricCompany();
        }

        public bool editNameElectricCompany(String nameElectric)
        {
            return dalElectricCompany.editNameElectricCompany(nameElectric);
        }
        public bool editCostElectricCompany(float costElectric)
        {
            return dalElectricCompany.editCostElectricCompany(costElectric);
        }
    }
}
