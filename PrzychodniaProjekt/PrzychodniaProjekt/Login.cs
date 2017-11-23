using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void linkLabelSupervisor_lab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Application.Run(new Supervisor_lab());            /// smieci
            //Form.ShowDialog(new Supervisor_lab());

            this.Hide();    /// ukrywamy formularz logowania

            Supervisor_lab supervisor_lab = new Supervisor_lab();
            supervisor_lab.ShowDialog();

            
            this.Close();   /// po wylaczeniu formularza kierownika wylaczamy aplikacje
        }
    }
}
