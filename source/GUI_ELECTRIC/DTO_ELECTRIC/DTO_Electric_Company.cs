using System;
using System.Collections.Generic;
using System.Text;


namespace DTO_ELECTRIC
{
    public class DTO_Electric_Company
    {
   
        private String _COMPANY_NAME;
        private float _ELECTRIC_COST=3000;
      
        private static DTO_Electric_Company myElectricCompany;

        private DTO_Electric_Company() { }

        public static DTO_Electric_Company getElectricCompany()
        {
            if (myElectricCompany == null)
            {
                myElectricCompany= new DTO_Electric_Company();
            }
            return myElectricCompany;
        }

       
        public string COMPANY_NAME { get => _COMPANY_NAME; set => _COMPANY_NAME = value; }
        public float ELECTRIC_COST { get => _ELECTRIC_COST; set => _ELECTRIC_COST = value; }
  
    }
}
