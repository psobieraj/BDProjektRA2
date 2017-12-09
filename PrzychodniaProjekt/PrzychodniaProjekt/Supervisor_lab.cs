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
    public partial class Supervisor_lab : Form
    {
        public Supervisor_lab()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
           Supervisor_lab_manage supervisor_lab_manage = new Supervisor_lab_manage();
            supervisor_lab_manage.ShowDialog();
        }
    }
}
