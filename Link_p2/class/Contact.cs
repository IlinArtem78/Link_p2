using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_p2
{
    public class Contact
    {
        public string Name;
        public System.Int64 Phone;
        public string Email;

        public Contact(string Name, System.Int64 Phone, string Email)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }


    }
}
