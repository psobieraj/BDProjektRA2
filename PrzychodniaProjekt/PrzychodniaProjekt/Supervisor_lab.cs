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
    public partial class Supervisor_lab : Form
    {
        public Supervisor_lab()
        {
            InitializeComponent();
        }

        private void Supervisor_lab_Load(object sender, EventArgs e)
        {
            dgvExaminations.DataSource = Bizz_technician.GetExams((kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab)
                => new { kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab });
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonManage_Click(object sender, EventArgs e)
        { 
            int rowindex = dgvExaminations.CurrentCell.RowIndex;
            int id_bad = int.Parse(dgvExaminations.Rows[rowindex].Cells[8].Value.ToString());

            Supervisor_lab_manage supervisor_lab_manage = new Supervisor_lab_manage(id_bad);


            string kod = dgvExaminations.Rows[rowindex].Cells[0].Value.ToString();
            string wynik = dgvExaminations.Rows[rowindex].Cells[5].Value == null ? "" :
                dgvExaminations.Rows[rowindex].Cells[5].Value.ToString();
            string uwagi_lek = dgvExaminations.Rows[rowindex].Cells[4].Value == null ? "" :
                dgvExaminations.Rows[rowindex].Cells[4].Value.ToString();

            supervisor_lab_manage.FillForms(kod, uwagi_lek);

            supervisor_lab_manage.ShowDialog();
        }

        private void buttonShowExams_Click(object sender, EventArgs e)
        {
            bool check = dtpDone.Checked;

            dgvExaminations.DataSource = Bizz_technician.FilterExamsSupervisor(dtpDone.Value, comboBoxState.Text, check,
                (kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab)
                => new { kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab });
        }
    }
}
