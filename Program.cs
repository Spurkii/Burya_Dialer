using System;
using System.Security.Cryptography.X509Certificates;

// Mark Burya
// IT112
// NOTES: Everything works as it should, However reading through the key requirements, there may be some things
// that could of been done wrong. 
// BEHAVIORS NOT IMPLIMENTED AND WHY:
namespace Burya_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] Phones = new Phone[10];
            Phones[0] = new HomePhone("CompuTest", "(303) 985 - 5060", "1");
            Phones[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123", "2");
            Phones[2] = new HomePhone("Data Functions", "(800) 876-2524", "1");
            Phones[3] = new HomePhone("Donnay Repair", "(708) 397-3330", "1");
            Phones[4] = new HomePhone("ErgoNomic Inc", "(360) 434-3894", "1");
            Phones[5] = new HomePhone("ErgoSource", "(800) 969-4374", "1");
            Phones[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527", "2");
            Phones[7] = new CellPhone("Glare-Guard", "(800) 545-6254", "2");
            Phones[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641", "2");
            Phones[9] = new CellPhone("Komfort Support", "(714) 472-4409", "2");

            for (int i = 0; i < Phones.Length; i++)
            {
                Phones[i].Dial();
            }
        }
    }
}
