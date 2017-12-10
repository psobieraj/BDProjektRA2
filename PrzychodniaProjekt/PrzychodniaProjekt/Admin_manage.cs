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

        public static bool dateExpired = false;

        public Admin_manage()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        public void fillForms(string login, string rola, string id, dynamic data)
        {
            textBoxLogin.Text = login.Replace(" ", string.Empty);
            //textBoxPassword.Text = haslo;
            comboBoxRole.Text = rola;
            textBoxId.Text = id;
            dateTimePickerExpired.Value = Convert.ToDateTime(data);





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
            //this.userTableAdapter.Fill(this.przychodniaDataSet2.User);
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (Admin_main.addOrManage == "add")
            {
                Bizz_admin.AddUser(textBoxPassword.Text, comboBoxRole.Text, textBoxLogin.Text);
            }
            if (Admin_main.addOrManage == "man")
            {

                Bizz_admin.UpdateUser(int.Parse(textBoxId.Text), textBoxPassword.Text, comboBoxRole.Text, textBoxLogin.Text, dateTimePickerExpired.Value, dateExpired);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.No;
            //textBoxLogin.Text = names;


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;         
        }

        private void checkBoxUserActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserActive.Checked == true)
            {
                dateTimePickerExpired.Enabled = true;
                dateExpired = true;
            }
            else
            {
                dateTimePickerExpired.Enabled = false;
                dateExpired = false;
            }
        }

        public void setCheckBoxUserActive(dynamic data)
        {
            if (data != null)
            {
                checkBoxUserActive.Checked = true;
            }
            else
            {
                checkBoxUserActive.Checked = false;
            };
        }
    }
}
