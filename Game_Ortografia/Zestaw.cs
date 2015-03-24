using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Game_Ortografia
{
    class Zestaw
    {
        private List<Przyklad> arr = new List<Przyklad>();
        DataTable table_SQ;

        public Zestaw(int a)
        {
            Ortografia_databaseDataSet myDataSet = new Ortografia_databaseDataSet();

            if (a == 1)
            {

                Ortografia_databaseDataSetTableAdapters.Przypadek_1TableAdapter CTA = new Ortografia_databaseDataSetTableAdapters.Przypadek_1TableAdapter();
                CTA.Fill(myDataSet.Przypadek_1);
                table_SQ = myDataSet.Przypadek_1;
            }
            else if(a == 2)
            {

                Ortografia_databaseDataSetTableAdapters.Przypadek_2TableAdapter CTA = new Ortografia_databaseDataSetTableAdapters.Przypadek_2TableAdapter();
                CTA.Fill(myDataSet.Przypadek_2);
                table_SQ = myDataSet.Przypadek_2;

            }
            else if(a == 3)
            {

                Ortografia_databaseDataSetTableAdapters.Przypadek_3TableAdapter CTA = new Ortografia_databaseDataSetTableAdapters.Przypadek_3TableAdapter();
                CTA.Fill(myDataSet.Przypadek_3);
                table_SQ = myDataSet.Przypadek_3;

            }
            else if(a == 0)
            {

                Ortografia_databaseDataSetTableAdapters.SelectQueryTableAdapter CTA = new Ortografia_databaseDataSetTableAdapters.SelectQueryTableAdapter();
                CTA.Fill(myDataSet.SelectQuery);
                table_SQ = myDataSet.SelectQuery;
            }

            Wrzuc(a);

        }

        public void Wrzuc(int a)
        {
            String W_1 = "";
            String W_2 = "";

            if (a != 0)
            {
                if (a == 1)
                {
                    W_1 = "RZ";
                    W_2 = "Ż";
                }
                else if(a == 2)
                {
                    W_1 = "CH";
                    W_2 = "H";
                }
                else if (a == 3)
                {
                    W_1 = "Ó";
                    W_2 = "U";
                }
            }

            foreach (DataRow dr in table_SQ.Rows)
            {
                int b;

                if(a == 0)
                {
                    W_1 = dr["W_1"].ToString();
                    W_2 = dr["W_2"].ToString();
                }

                if ((bool)dr["Odpowiedz"])
                    b = 2;
                else
                    b = 1;

                Przyklad pom = new Przyklad(dr["Slowo"].ToString(),
                                            W_1,
                                            W_2,
                                            b);
                arr.Add(pom);
            }
        }

        public Przyklad Podaj()
        {
            Random r = new Random();
            int n = r.Next(arr.Count());

            Przyklad pom = arr[n];
            arr.RemoveAt(n);

            return pom;
        }

        public bool Is_empty()
        {
            if (arr.Count() == 0)
                return true;
            return false;
        }

    }
}
