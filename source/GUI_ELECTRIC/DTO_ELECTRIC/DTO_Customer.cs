using System;

namespace DTO_ELECTRIC
{
    public class DTO_Customer
    {
        private int _CUSTOMER_ID;
        private String _CUSTOMER_NAME;
        private String _CUSTOMER_PHONE;
        private String _CUSTOMER_ADDRESS;
        private int _METER_ID;
        private String _CUSTOMER_KIND;

        public DTO_Customer()
        {
        }

        public DTO_Customer( String cUSTOMER_NAME, String cUSTOMER_PHONE, String cUSTOMER_ADDRESS, String customer_KIND)
        {
          
            _CUSTOMER_NAME = cUSTOMER_NAME;
            _CUSTOMER_PHONE = cUSTOMER_PHONE;
            _CUSTOMER_ADDRESS = cUSTOMER_ADDRESS;
            CUSTOMER_KIND = customer_KIND;
        }

        public DTO_Customer(int cUSTOMER_ID, string cUSTOMER_NAME, string cUSTOMER_PHONE, string cUSTOMER_ADDRESS, String customer_KIND)
        {
            _CUSTOMER_ID = cUSTOMER_ID;
            _CUSTOMER_NAME = cUSTOMER_NAME;
            _CUSTOMER_PHONE = cUSTOMER_PHONE;
            _CUSTOMER_ADDRESS = cUSTOMER_ADDRESS;
            CUSTOMER_KIND = customer_KIND;
        }

        public DTO_Customer(int cUSTOMER_ID, string cUSTOMER_NAME, string cUSTOMER_PHONE, string cUSTOMER_ADDRESS, int mETER_ID, string cUSTOMER_KIND)
        {
            _CUSTOMER_ID = cUSTOMER_ID;
            _CUSTOMER_NAME = cUSTOMER_NAME;
            _CUSTOMER_PHONE = cUSTOMER_PHONE;
            _CUSTOMER_ADDRESS = cUSTOMER_ADDRESS;
            _METER_ID = mETER_ID;
            _CUSTOMER_KIND = cUSTOMER_KIND;
        }

        public int CUSTOMER_ID { get => _CUSTOMER_ID; set => _CUSTOMER_ID = value; }
        public String CUSTOMER_NAME { get => _CUSTOMER_NAME; set => _CUSTOMER_NAME = value; }
        public String CUSTOMER_PHONE { get => _CUSTOMER_PHONE; set => _CUSTOMER_PHONE = value; }
        public String CUSTOMER_ADDRESS { get => _CUSTOMER_ADDRESS; set => _CUSTOMER_ADDRESS = value; }
        public int METER_ID { get => _METER_ID; set => _METER_ID = value; }
        public string CUSTOMER_KIND { get => _CUSTOMER_KIND; set => _CUSTOMER_KIND = value; }
    }
}
