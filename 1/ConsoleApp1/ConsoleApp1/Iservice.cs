using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Iservice : icontacktadress

    {
        private ContactAdress[] c2 = new ContactAdress[0];
        public bool Delete(int id)
        {
          c2= Array.FindAll(c2, e => e.Id != id);
            return true;
        }

        public ContactAdress Find(int id)
        {
            ContactAdress foundcontactAdress= Array.Find(c2, e => e.Id == id);
            return foundcontactAdress;
        }

        public ContactAdress New(ContactAdress c1)
        {
            Array.Resize(ref c2, c2.Length + 1);
            c2[c2.Length - 1] = c1;
            return c1;
        }

        public ContactAdress Uptade(int id, ContactAdress c1)
        {
            ContactAdress uptadeadress = Array.Find(c2, e => e.Id == id);
            uptadeadress = c1;
            return uptadeadress;

        }
    }
}
