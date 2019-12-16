using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizator
{
    public abstract class Adrese
    {
        public string Nume;
        public string NrTelefon;
        public Adrese(string Nume,string NrTelefon)
        {
            this.Nume = Nume;
            this.NrTelefon = NrTelefon;
        }
        public virtual string Info()
        {
            return Nume + " " + NrTelefon;
        }
    }
   public  class Sadress : Adrese
    {
        public Sadress(string Nume, string NrTelefon)
            :base(Nume,NrTelefon)
        {

        }
        public override string Info()
        {
            return base.Info();
        }
    }
    public enum Category
    {
        Home, Office, Friends, Family, Others
    }
   public  class Madress : Adrese
    {
        public string NrTelefon2;
        public string Email;
        public Category Type;
        public Madress(Category Type,string Nume, string NrTelefon)
            :base(Nume,NrTelefon)
        {
            this.Type = Type;
        }
        public override string Info()
        {
            return base.Info() + " " + Type + " " + "(" + NrTelefon2 + ")" + " " + Email;
        }

    }
    public  class Eadress:Madress{
        public string Adresa;
        public Eadress(Category Type,string Nume,string NrTelefon)
            :base(Type,Nume,NrTelefon)
        {

        }
        public override string Info()
        {
            return base.Info() + " " + Adresa;
        }
    }
}
