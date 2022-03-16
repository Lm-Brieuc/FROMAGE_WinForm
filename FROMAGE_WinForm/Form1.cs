using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FROMAGE_WinForm
{
    public partial class Form1 : Form
    {
        const string Json_File = "Fromages.json";

        static List<C_FROMAGE> listFromages;

        public Form1()
        {
                string Data_Json = File.ReadAllText(Json_File);
                List<C_FROMAGE> FROMAGES = new List<C_FROMAGE>();
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            FROMAGES = JsonSerializer.Deserialize<List<C_FROMAGE>>(Data_Json);
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
            listFromages = FROMAGES;
            //BackColor = Color.Cornsilk;

            InitializeComponent();
            foreach (C_FROMAGE un_Fromage in FROMAGES)
            {
                listBox_Fromages.Items.Add(un_Fromage.Nom_Fromage);

            }
            //incListBox_Filter();
            Manual_incListBox_Filter();

        }

        private void Manual_incListBox_Filter()
        {
            listBox_Filter.Items.Add("All");
            listBox_Filter.Items.Add("Cher");
            listBox_Filter.Items.Add("Corr\u00E8ze");
            listBox_Filter.Items.Add("Dr\u00F4me");
            listBox_Filter.Items.Add("Hautes-Alpes");
        }

        private void incListBox_Filter()
        {
            List<string> Departements = new List<string>();
            Departements.Add("Cher");
            foreach (C_FROMAGE un_Fromage in listFromages)
            {
                for (int i = 0; i < Departements.Count; i++)
                {
                    if (Departements[i] == un_Fromage.Departement) { return; }
                    else
                    {
                        listBox_Filter.Items.Add(un_Fromage.Departement);
                        Departements.Add(un_Fromage.Departement);
                    }
                }

            }
        }


        private void listBox_Fromages_SelectedIndexChanged(object sender, EventArgs e)
        {
                            
           
        }







        private void listBox_Fromages_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox_Lait.Text = listFromages[listBox_Fromages.SelectedIndex].Lait;
            textBox_Departement.Text = listFromages[listBox_Fromages.SelectedIndex].Departement;
            textBox_Wiki.Text = listFromages[listBox_Fromages.SelectedIndex].Page_Francaise;

        }

        private void listBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fromages.Items.Clear();
            foreach (C_FROMAGE un_Fromage in listFromages)
            {
                if(un_Fromage.Departement == listFromages[listBox_Filter.SelectedIndex].Departement || listBox_Filter.SelectedIndex == 0)
                {
                    listBox_Fromages.Items.Add(un_Fromage.Nom_Fromage);

                }
                
            }
        }










        private void Label_list_Fromage_Click(object sender, EventArgs e)
        {

        }

        private void label_Departement_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void couleurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1. BackColor = Color.Black;
        }
    }
}