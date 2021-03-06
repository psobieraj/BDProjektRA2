﻿using System;
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
            comboBoxRole.Text = rola;
            textBoxId.Text = id;
            dateTimePickerExpired.Value = Convert.ToDateTime(data);
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
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (Admin_main.addOrManage == "add")
            {
                IQueryable<User> user = Bizz_admin.checkLogin(textBoxLogin.Text);

                if (user.Any())
                {
                    MessageBox.Show("jest już taki użytkownik");
                } else
                {
                    if (textBoxPassword.Text != "" && comboBoxRole.Text != "" && textBoxLogin.Text != "")
                    {
                        Bizz_admin.AddUser(textBoxPassword.Text, comboBoxRole.Text, textBoxLogin.Text);
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                    else
                        MessageBox.Show("Wypelnij wszystkie pola.");
                }
            }

            if (Admin_main.addOrManage == "man")
            {
                IQueryable<User> user = Bizz_admin.checkLogin(textBoxLogin.Text);

                if (user.Any() && (user.Single().Id_user).ToString() != textBoxId.Text)
                {
                    MessageBox.Show("jest już taki użytkownik");
                }
                else
                {
                    if (textBoxPassword.Text != "" && comboBoxRole.Text != "" && textBoxLogin.Text != "")
                    {
                        Bizz_admin.UpdateUser(int.Parse(textBoxId.Text), textBoxPassword.Text,
                        comboBoxRole.Text, textBoxLogin.Text, dateTimePickerExpired.Value, dateExpired);
                        this.DialogResult = System.Windows.Forms.DialogResult.No;
                    }
                    else
                    {
                        MessageBox.Show("Wypelnij wszystkie pola.");
                    }

                    
                }
            }
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

        private void Only_Number_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
