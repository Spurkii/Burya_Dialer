using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burya_Dialer
{
    public class CellPhone : Phone
    {
        public CellPhone(string Company_Name, string Phone_Number, string Phone_Type) : base(Company_Name, Phone_Number, Phone_Type)
        {
        }
        public override void Dial()
        { 
            Console.WriteLine(C_Name + " is being dialed using 1+" + P_Number + ". . .");
        }
    }
}
