using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test009
{
   public class Samochod
    {

         string marka;
         string model;
         int pojsilnika;
         double iloscpaliwa;


        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int PojSilnika
        {
            get { return pojsilnika; }
            set { pojsilnika = value; }
        }

        public int Iloscpaliwa
        {
            get { return iloscpaliwa; }
            set { iloscpaliwa = value; }



        public Samochod(string marka, string model, int pojsilnika, double iloscpaliwa)
        {
            this.marka = marka;
            this.model = model;
            this.pojsilnika = pojsilnika;
            this.iloscpaliwa = iloscpaliwa;

        }

       

    }
    samochod01 = new Samochod(marka, model, pojsilnika, iloscpaliwa);

}
