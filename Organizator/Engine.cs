using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizator
{
    public static class Engine
    {
        public static List<Adrese> Adrese = new List<Adrese>();
        public static void Init_Demo()
        {
            Adrese.Add(new Sadress("Ion","077300348"));
            Adrese.Add(new Sadress("Mihaela", "0348112113"));
            Adrese.Add(new Madress(Category.Family, "Raul", "0771300314"));
            Adrese.Add(new Madress(Category.Office, "Daniel", "044300348"));
         Adrese t = new Eadress(Category.Office,"Alex","0771300345");
            (t as Eadress).NrTelefon2 = "0771300352";
            (t as Eadress).Adresa = "str. Berzei nr 2";
            Adrese.Add(t);
        }
        public static List<string> ViewAdrese()
        {
            List<string> text = new List<string>();
            foreach(Adrese adresa in Adrese)
            {
                text.Add(adresa.Info());
            }
            return text;
        }
    }
   
}
