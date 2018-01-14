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
        public static string addOrManage = "";

        public Admin_main()
        {
            InitializeComponent();
        }

        private void Admin_main_Load(object sender, EventArgs e)
        {
            dataGridViewAccounts.DataSource = Bizz_admin.GetUsers();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            IQueryable<User> user = Bizz_admin.FilterUser(textBoxPattern.Text);
            dataGridViewAccounts.DataSource = user;
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            Admin_manage admin_manage = new Admin_manage();

            int rowindex = dataGridViewAccounts.CurrentCell.RowIndex;
            string login = dataGridViewAccounts.Rows[rowindex].Cells[3].Value.ToString();
            string rola = dataGridViewAccounts.Rows[rowindex].Cells[2].Value.ToString();
           
            string id = dataGridViewAccounts.Rows[rowindex].Cells[0].Value.ToString();

            dynamic data = dataGridViewAccounts.Rows[rowindex].Cells[4].Value;

            if(data!=null)
            {
                data=data.ToString();
            } else
            {
                data = DateTime.Now;
            };

            admin_manage.fillForms(login, rola, id, data);
            admin_manage.setCheckBoxUserActive(dataGridViewAccounts.Rows[rowindex].Cells[4].Value);
            addOrManage = "man";
            admin_manage.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Admin_manage admin_add = new Admin_manage();

            admin_add.HideDatePicker(false);
            addOrManage = "add";
            admin_add.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
