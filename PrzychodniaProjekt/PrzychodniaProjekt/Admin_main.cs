using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace PrzychodniaProjekt
{
    public partial class Admin_main : Form
    {
        public Admin_main()
        {
            InitializeComponent();
        }

        private void Admin_main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przychodniaDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.przychodniaDataSet2.User);

        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            Admin_manage admin_manage = new Admin_manage();

            int rowindex = dataGridViewAccounts.CurrentCell.RowIndex;
            string login = dataGridViewAccounts.Rows[rowindex].Cells[3].Value.ToString();
            string rola = dataGridViewAccounts.Rows[rowindex].Cells[2].Value.ToString();
            dynamic data = dataGridViewAccounts.Rows[rowindex].Cells[4].Value;

            
            //if (dataGridViewAccounts.Rows[rowindex].Cells[4].Value != null)
            //{
            //    data = "";
            //};

            admin_manage.fillForms(login, rola);

            admin_manage.ShowDialog();


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            IQueryable<User> user = Bizz_admin.FilterUser(textBoxPattern.Text);
            dataGridViewAccounts.DataSource = user;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Admin_manage admin_add = new Admin_manage();

            admin_add.HideDatePicker(false);
            admin_add.ShowDialog();
            
            //admin_add.set

            //admin_add.textBoxLogin = dataGridViewAccounts.DataSource;
            // admin_add->te
            

        }
    }
}
