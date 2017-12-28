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
    public partial class Exam_dictionary : Form
    {

        public static string currentChosenExamType = "";

        public Exam_dictionary()
        {
            InitializeComponent();
        }

        private void Exam_dictionary_Load_1(object sender, EventArgs e)
        {
            dataGridViewExamDictionaryList.DataSource = Bizz_examDictionary.GetExams(currentChosenExamType);
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewExamDictionaryList.CurrentCell.RowIndex;
            string code = dataGridViewExamDictionaryList.Rows[rowindex].Cells[0].Value.ToString();
            string name = dataGridViewExamDictionaryList.Rows[rowindex].Cells[2].Value.ToString();

            Form1.doctor_examination_psychical.fillForms(code, name);
            PatientLabExamList.doctor_examination_laboratory.fillForms(code, name);
            
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
