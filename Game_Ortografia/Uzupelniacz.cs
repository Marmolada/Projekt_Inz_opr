using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Game_Ortografia
{
    class Uzupelniacz
    {
        private List<Instancja> lista = new List<Instancja>();

        public Uzupelniacz()
        {
        }

        public void Wypelnij()
        {

            string line;
            int licz = 0;

            Encoding enc = Encoding.GetEncoding("Windows-1250");           
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"D:\Studia\Obsluga_bazy_test\ConsoleApplication1\ConsoleApplication1\slowa-win.txt", enc);

            while ((line = file.ReadLine()) != null && licz <= 1000)
            {

                for (int i = 0; i < 6; i++)
                {
                    Instancja inst = new Instancja(line.ToUpper());

                    if(inst.Szukaj(i))
                    {
                        lista.Add(inst);
                    }
                }                                   
                licz++;

            }

        }

        public void Wypisz()
        {
            foreach(Instancja n in lista)
            {
                n.Wypisz();
            }
        }

        public void DodajDoBazy()
        {
            Ortografia_databaseDataSet myDataSet = new Ortografia_databaseDataSet();
            Ortografia_databaseDataSetTableAdapters.PrzykladTableAdapter CTA = new Ortografia_databaseDataSetTableAdapters.PrzykladTableAdapter();

            foreach(Instancja inst in lista)
            {
                inst.Dodaj_do_bazy(myDataSet,CTA);
            }
        }

    }
}
