using System;
using DAL_ELECTRIC;
using System.Data;
using DTO_ELECTRIC;


namespace BUS_ELECTRIC

{
    public class BUS_Customer
    {
        private DAL_Customer dalCustomer = new DAL_Customer();

        public DataTable getCustomer()
        {
            return dalCustomer.getCustomer();
        }

        public bool addCustomer(DTO_Customer customer)
        {
            return dalCustomer.addCustomer(customer);
        }

        public bool deleteCustomer(int customerID)
        {
            return dalCustomer.deleteCustomer(customerID);
        }
        public bool editCustomer(DTO_Customer customer)
        {
            return dalCustomer.editCustomer(customer);
        }
        public bool hasCustomer(String customerPhone)
        {
            return dalCustomer.hasCustomer(customerPhone);
        }

        public DTO_Customer findCustomer(int idCustomer)
        {
            return dalCustomer.findCustomer(idCustomer);
        }
        public DTO_Customer findByPhone(String phone)
        {
            return dalCustomer.findByPhone(phone);
        }
    
    }
}
