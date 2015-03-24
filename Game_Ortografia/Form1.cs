using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Game_Ortografia
{
    public partial class Form1 : Form
    {
        Zestaw etap;
        Przyklad podetap;
        int traf;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sprawdz_i_dodaj()
        {
            label2.Text = "Trafione: " + traf;

            if(etap.Is_empty() != true)
            {
                Thread.Sleep(3000);
                Fill();
            }
            else
            {
                // jakis tam koniec gry
            }
        }

        private void Fill()
        {
            podetap = etap.Podaj();

            podetap.fill_przyklad(button1, button2, label1);
            
            button1.Enabled = true;
            button2.Enabled = true;
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(wybor_trybu_1.Checked)
            {
                etap = new Zestaw(0);
            }
            else
            {
                if (wybor_przypadku1.Checked)
                {
                    etap = new Zestaw(1);
                }
                else if (wybor_przypadku2.Checked)
                {
                    etap = new Zestaw(2);
                }
                else if (wybor_przypadku3.Checked)
                {
                    etap = new Zestaw(3);
                }
            }

            panel_etapu.Visible = false;
            panel_wypadkow.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;

            label2.Text = "Trafione: " + traf;
            label2.Visible = true;

            Fill();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            button3.Visible = true;
            label1.Visible = true;
            label1.Text = "Wybierz tryb";
            panel_etapu.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(podetap.Is_valid(1))
            {
                button1.BackColor = System.Drawing.Color.Green;
                traf++;            
            }
            else
            {
                button1.BackColor = System.Drawing.Color.Red;
            }

            Sprawdz_i_dodaj();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (podetap.Is_valid(2))
            {
                button2.BackColor = System.Drawing.Color.Green;
                traf++;
            }
            else
            {
                button2.BackColor = System.Drawing.Color.Red;
            }

            Sprawdz_i_dodaj();
        }

        private void wybor_trybu_1_CheckedChanged(object sender, EventArgs e)
        {
            panel_wypadkow.Visible = false;
        }

        private void wybor_trybu_2_CheckedChanged(object sender, EventArgs e)
        {
            panel_wypadkow.Visible = true;
        }

    }
}
