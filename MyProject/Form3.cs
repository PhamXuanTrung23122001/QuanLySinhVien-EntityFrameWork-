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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        StudentManageMentSystemContext context = new StudentManageMentSystemContext();
        private void Form3_Load(object sender, EventArgs e)
        {
            var data = context.Students
                .Select(p => new
                {
                    MaSo = p.StudentId,
                    HoTen = p.StudentName,
                    NgaySinh = p.BirthDate,
                    GioiTinh = p.Gender ? "Nam" : "Nu",
                    DiaChi = p.Address,
                    DienThoai = p.PhoneNumber,
                    Lop = p.Class.ClassCode,
                    MaLop = p.Class.ClassId
                })
                .ToList();
            dataGridView1.DataSource = data;
            
            var data2 =context.Classes.ToList();
            cboID.DataSource = data2;
            cboID.DisplayMember = "ClassId";
            cboID.ValueMember = "ClassId";

            cboClassName.DataSource = data2;
            cboClassName.DisplayMember = "ClassCode";
            cboClassName.ValueMember = "ClassId";
            //biding du lieu

            cboID.DataBindings.Clear();
            cboID.DataBindings.Add("Text", data, "MaLop");

            cboClassName.DataBindings.Clear();
            cboClassName.DataBindings.Add("Text", data, "Lop");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 ok = new Form4();
            ok.Show();
        }
    }
}
