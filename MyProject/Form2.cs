using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProject.Models;
namespace MyProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        StudentManageMentSystemContext context = new StudentManageMentSystemContext();  
        private void btnView_Click(object sender, EventArgs e)
        {
            int keyword = Convert.ToInt32(cboCode.Text);
            dataGridView1.DataSource = context.Results.Where(p => p.StudentId.Equals(keyword))
                .Select(a=> new
                {
                    TênMônHọc=a.Subject.SubjectName,
                    Điểm = a.Mark
                })
                .ToList();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = context.Students
                 .Select(p => new
                 {
                     StudentId = p.StudentId,
                     StudentName=p.StudentName,
                     ClassName=p.Class.ClassCode
                 })
                 .ToList();
                
           cboCode.DataSource = data;
           cboCode.DisplayMember = "StudentId";
           cboCode.ValueMember = "StudentId";

           cboName.DataSource = data;
           cboName.DisplayMember = "StudentName";
           cboName.ValueMember = "StudentId";
           
           txtClass.DataBindings.Clear();
           txtClass.DataBindings.Add("Text", data, "ClassName");

            
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
