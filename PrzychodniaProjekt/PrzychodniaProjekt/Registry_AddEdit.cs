using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace PrzychodniaProjekt
{
    public partial class Registry_AddEdit : Form
    {
        string addOrEdit =  "";
        public Registry_AddEdit(string addOrE)
        {
            InitializeComponent();
            addOrEdit = addOrE;
            if(addOrEdit == "add")
            {
                buttonModify.Enabled = false;
            }

            if (addOrEdit == "mod")
            {
                buttonAdd.Enabled = false;
            }
        }

        public void fillForms(string id_pac, string Imie, string Nazwisko, string PESEL, string id_adresu,string Miejscowosc, string Ulica, string Nr_domu, string Nr_lokalu)
        {
            textIDpat.Text = id_pac;
            textName.Text = Imie;
            textSurname.Text = Nazwisko;
            textPesel.Text = PESEL;
            textIDadr.Text = id_adresu;
            textCity.Text = Miejscowosc;
            textStreet.Text = Ulica;
            textHouse.Text = Nr_domu;
            textApartment.Text = Nr_lokalu;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Bizz_registry.EditPatient(int.Parse(textIDpat.Text), textName.Text,textSurname.Text,textPesel.Text, int.Parse(textIDadr.Text), textCity.Text,textStreet.Text,textHouse.Text,textApartment.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Bizz_registry.AddPatient(textName.Text, textSurname.Text, textPesel.Text, textCity.Text, textStreet.Text, textHouse.Text, textApartment.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
