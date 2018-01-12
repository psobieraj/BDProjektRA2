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
            dataGridViewExaminations.DataSource = Bizz_technician.GetExams((kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab) 
                => new { kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab });
        }

        private void buttonServe_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewExaminations.CurrentCell.RowIndex;
            int id_bad = int.Parse(dataGridViewExaminations.Rows[rowindex].Cells[8].Value.ToString());

            Lab_technician_serve_examination lab_technician_serve_examination = 
                new Lab_technician_serve_examination(id_bad);
            

            
            string kod = dataGridViewExaminations.Rows[rowindex].Cells[0].Value.ToString();
            string wynik = dataGridViewExaminations.Rows[rowindex].Cells[5].Value == null ? "":
                dataGridViewExaminations.Rows[rowindex].Cells[5].Value.ToString();
            string uwagi_lek = dataGridViewExaminations.Rows[rowindex].Cells[4].Value == null ? "":
                dataGridViewExaminations.Rows[rowindex].Cells[4].Value.ToString();

            lab_technician_serve_examination.FillForms(kod, uwagi_lek);

            lab_technician_serve_examination.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //if (dropdownChooseStatusStatus.Text != "")
            //{
                bool check = dateTimePicker.Checked;

                dataGridViewExaminations.DataSource = Bizz_technician.FilterExams(dateTimePicker.Value, dropdownChooseStatusStatus.Text, check,
                    (kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab)
                    => new { kod, data_zlec, data_wyk_anul, data_zatw_anul, uwagi_lek, wynik, uwagi_kier, status, id_bad_lab });
            //}
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
