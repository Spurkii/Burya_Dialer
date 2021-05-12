using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Dialer
{
    public class Phone
    {
        protected string C_Name;
        protected string P_Number;
        protected string P_Type;

        public Phone(string Company_Name, string Phone_Number, string Phone_Type)
        {
            C_Name = Company_Name;
            P_Number = Phone_Number;
            P_Type = Phone_Type;

        }
        public virtual void Dial()
        {
            Console.WriteLine(C_Name + " is being dialed using " + P_Number + ". . .");
        }
    }
}
