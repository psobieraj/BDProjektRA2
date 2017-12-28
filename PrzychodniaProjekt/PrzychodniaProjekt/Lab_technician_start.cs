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
    public partial class Lab_technician_start : Form
    {
        public Lab_technician_start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lab_technician_start_Load(object sender, EventArgs e)
        {
            dataGridViewExaminations.DataSource = Bizz_technician.GetExams((kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status) => new { kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status });
        }
    }
}
