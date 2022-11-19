using Microsoft.EntityFrameworkCore.Diagnostics;
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
using System.IO;




namespace MyProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        StudentManageMentSystemContext context = new StudentManageMentSystemContext();


        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data4 = context.Students
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
            dataGridView1.DataSource = data4;
            var data = context.Students.ToList();
            var data2 = context.Subjects.ToList();
            var data3 = context.Results.ToList();

            cboID.DataSource = data;
            cboID.DisplayMember = "StudentId";
            cboID.ValueMember = "StudentId";


            cboName.DataSource = data;
            cboName.DisplayMember = "StudentName";
            cboName.ValueMember = "StudentId";

            CboSubID.DataSource = data2;
            CboSubID.DisplayMember = "SubjectId";
            CboSubID.ValueMember = "SubjectId";

            cboSubName.DataSource = data2;
            cboSubName.DisplayMember = "SubjectName";
            cboSubName.ValueMember = "SubjectId";

            //liên quan đến 2 bảng subject và result

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Result p = new Result
                {
                    StudentId = (int)cboID.SelectedValue,
                    SubjectId = (int)CboSubID.SelectedValue,
                    Mark = Convert.ToDouble(txtMark.Text),
                };
                context.Results.Add(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Nhập điểm thành công!!");
                    LoadData();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Nhập điểm không thành công vì điểm này đã được chấm, nếu muốn sửa vui lòng ấn vô nút cập nhật!!");

            }
        }

        private void btnViewMark_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Result p = context.Results.
                 FirstOrDefault(p => p.SubjectId == (int)CboSubID.SelectedValue && p.StudentId == (int)cboID.SelectedValue);
                if (p != null)
                {
                    //tức là có tìm thấy
                    p.Mark = Convert.ToDouble(txtMark.Text);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Cập nhật điểm thành công!!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật điểm không thành công!!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cập Nhật điểm không thành công" + ex.Message);
            }
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Bạn có chắc là muốn xóa điểm ông này không??", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Result p = context.Results.
                        FirstOrDefault(p => p.SubjectId == (int)CboSubID.SelectedValue && p.StudentId == (int)cboID.SelectedValue);
                        if (p != null)
                        {
                            context.Results.Remove(p);
                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Xóa điểm thành công!!");
                            }
                            else
                            {
                                MessageBox.Show("Xoá điểm không thành công!!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Delete error" + ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }


        }

       
       

        
        
       



    }
    }

