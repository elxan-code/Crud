using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface icontacktadress
    {
        ContactAdress New(ContactAdress c1);
        bool Delete(int id);
        ContactAdress Uptade(int id,ContactAdress c1);
        ContactAdress Find(int id);




    }
}
