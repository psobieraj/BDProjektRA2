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
    public partial class Admin_manage : Form
    {
        public Admin_manage()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        public void fillForms(string login, string rola)
        {
            textBoxLogin.Text = login.Replace(" ", string.Empty);
            //textBoxPassword.Text = haslo;
            comboBoxRole.Text = rola;

            //dateTimePickerExpired = data;
            //System.Nullable<DateTime> SelectedDate;
            //data = dateTimePickerExpired.SelectedDate;
            //dateTimePickerExpired.SelectedDate = DateTime.Parse(data);


            //dateTimePickerExpired = data;
            //if (data == "")
            //{
            //    checkBoxUserActive.Checked = true;
            //}

            



        }

        public void HideDatePicker(bool someSelector)
        {
            dateTimePickerExpired.Visible = someSelector;
            checkBoxUserActive.Visible = someSelector;
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void Admin_manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.przychodniaDataSet2.User);

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            Bizz_admin.AddUser(textBoxLogin.Text, textBoxPassword.Text, comboBoxRole.Text, dateTimePickerExpired.Value);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;         
        }
    }
}
