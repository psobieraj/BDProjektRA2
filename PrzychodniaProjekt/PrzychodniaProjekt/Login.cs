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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

 
        private void CheckUser()
        {
            string role;

            IQueryable<User> user = Bizz_Clinic.SearchUser(textLogin.Text, textPassword.Text);
                
            if (user.Any())
            {
                role = user.Single().Rola;
                this.Hide();
                switch (role)
                {
                    case "rec ":
                        Registry_main registry_main = new Registry_main();
                        registry_main.ShowDialog();
                        break;
                    case "doc ":
                        Doctor_main doctor_main = new Doctor_main();
                        doctor_main.ShowDialog();
                        break;
                    case "lab ":
                        Lab_technician_start lab_technician_start = new Lab_technician_start();
                        lab_technician_start.ShowDialog();
                        break;
                    case "klab":
                        Supervisor_lab supervisor_lab = new Supervisor_lab();
                        supervisor_lab.ShowDialog();
                        break;
                    case "adm ":
                        Admin_main admin_main = new Admin_main();
                        admin_main.ShowDialog();
                        break;
                }
                this.Close();
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CheckUser();

        }
    }
}
