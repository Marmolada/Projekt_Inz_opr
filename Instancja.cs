using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Game_Ortografia
{
    class Instancja
    {
        String Przyklad;
        int id_wypadku;
        bool ktora_dobra;
        static String[] tab_wyp = new String[] { "RZ", "Ż", "CH", "H", "U", "Ó" };
        
        public Instancja(String a)
        {
            Przyklad = a;
        }

        public bool Szukaj(int ktore)
        {
            String b = tab_wyp[ktore];
            int licz = b.Count();

            for (int i = 0; i+licz < Przyklad.Count()+1; i++)
            {
                if (b.Equals(Przyklad.Substring(i, licz)))
                {
                    if (ktore == 3 && i != 0)                           //
                        if (Przyklad.Substring(i-1,2).Equals("CH"))    // pominie wypadek gdy znalazl 'H' który okazał się fragentem 'CH'
                            continue;                                 //

                    System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(Przyklad); // zamiana na typ dynamiczny - String jest tylko ReadOnly!

                    if (b.Count() == 1)
                        strBuilder[i] = '_';
                    else
                    {
                        strBuilder[i] = '_';
                        strBuilder.Remove(i + 1, 1);
                    }

                    Przyklad = strBuilder.ToString();                                               // oddanie typu na nowo pod String

                    //////////////////////////////////////////////////////////////////// uzupelnienie pozostalych parametrow klasy instancja
                    if (ktore % 2 == 0)
                        ktora_dobra = false;
                    else
                        ktora_dobra = true;

                    switch(ktore)
                    {
                        case 0: 
                        case 1:
                            id_wypadku = 0;
                            break;
                        case 2:
                        case 3:
                            id_wypadku = 1;
                            break;
                        case 4:
                        case 5:
                            id_wypadku = 2;
                            break;
                    }
                    /////////////////////////////////////////////////////////////////////
                    return true; // dostarczenie do klasy Uzupelniacz informacji że ta instacja ma wejsc do listy przykladow
                }

            }
            return false;
        }

        public void Wypisz()
        {
            Console.Write(Przyklad+" : "+id_wypadku+" : ");
            if (ktora_dobra)
                Console.Write("1 \n");
            else
                Console.Write("0 \n");
        }

        public void Dodaj_do_bazy(Ortografia_databaseDataSet myDataSet, Ortografia_databaseDataSetTableAdapters.PrzykladTableAdapter CTA)
        {
            try
            {
                CTA.Insert(Przyklad, ktora_dobra, id_wypadku);
                CTA.Fill(myDataSet.Przyklad);
                myDataSet.Przyklad.AcceptChanges();
                CTA.Update(myDataSet.Przyklad);  
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
