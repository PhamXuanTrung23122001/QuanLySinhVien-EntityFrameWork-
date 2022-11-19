using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapWinFormADO.NET
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            //đây là toàn bộ cái đống form
        }
        // đây là thằng đc gen để truyền account từ login về customer
        public Customer(string text)
        {
            //copy init ỏ trên xuống
            InitializeComponent();
            Text = "Hello "+ text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboID.Text = "";
            txtCusName.Text = "";
            txtBirthDate.Text = "";
            txtAddress.Text = "";
            RadioMale.Checked = false;
            radioFemale.Checked = false;
        }
        

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            //tắt tất cả
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //Để load 1 table vào datagidview ta làm như sau
            //b1: tạo 1 method có tên là loaddata()
            LoadData();
        }
        DataProvider data = new DataProvider();
        private void LoadData()
        {
            //b2:nhồi tất cả vào trycatch
            //b3:viết lệnh sql và thực thi nó bằng dataprovider
            //b4:nhồi dữ liệu nhận đc vô datasource của datagidview
            //b5:done
            try
            {
                string sql = "select * from Customers";
                DataTable dt = data.executeQuery(sql);
                //chèn dữ liệu của datatable vào datasource của datagridview
                dataGridView1.DataSource = dt;

                //chèn dữ liệu vô combobox
                //chèn dữ liệu của datatable vào datasource của comboboxCustomerID
                cboID.DataSource = dt;
                cboID.DisplayMember = "CustomerId";
                cboID.ValueMember = "CustomerId";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error" +ex.Message);
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //đây là cách binding dữ liệu từ datagridview lên các toolbox
            //xử lí vs combobox
            cboID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            //xử lí với textbox
            txtCusName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtBirthDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            //xử lí vs radio
            if(dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("True"))
            {
                RadioMale.Checked = true;   
            }
            else
            {
                radioFemale.Checked = true;    
            }
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                //check xem code có tồn tại trong database hay k
                //nếu không thì thông báo và return
                String checkcode = "Select * from Customers " +
                 "where CustomerId='" + cboID.Text + "'";
                DataTable dt = data.executeQuery(checkcode);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("This id is not existed!!!");
                }
                else
                {
                    String sql = "Delete from Customers " +
                    "where CustomerId= '" + cboID.Text + "'";
                    if (data.executeNonQuery(sql))
                    {
                        MessageBox.Show("Delete Successful");
                        //xóa xong thì loaddata lại để xem luôn
                        
                    }
                }
                LoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Delete error" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check xem code có tồn tại trong database hay k
            //nếu không thì add 
            //nếu có thì thông báo và return
            try
            {
                    //do thằng id tự tăng nên kcan phải insert vô
                    bool gender = true;
                    if(radioFemale.Checked)
                    {
                        gender = false;
                    }
                    String sql = "Insert into Customers(CustomerName,BirthDate,Gender,Address) "+
                        "values('"+txtCusName.Text+"','"+txtBirthDate.Text +"','"+gender+"','"+txtAddress.Text+"')";
                    if (data.executeNonQuery(sql))
                    {
                        MessageBox.Show("Insert Successful");
                        //add xong thì loaddata lại để xem luôn
                        
                    }
                
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Add error" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check xem code có tồn tại trong database hay k
            //nếu không thì thông báo và return
            //nếu có thì update
            try
            {
                String checkcode = "Select * from Customers " +
                 "where CustomerId='" + cboID.Text + "'";
                DataTable dt = data.executeQuery(checkcode);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("This id is not existed so cant update!!!");
                }
                //do thằng id tự tăng nên k thể update id vô
                else
                {
                    bool gender = true;
                    if (radioFemale.Checked)
                    {
                        gender = false;
                    }
                    
                    String sql = " UPDATE Customers\r\n   " +
                        "set [CustomerName] = '"+txtCusName.Text+"'\r\n      ," +
                        "[Birthdate] = '"+txtBirthDate.Text+"'\r\n      ," +
                        "[Gender] = '"+gender+"'\r\n      ," +
                        "[Address] = '"+txtAddress.Text +"'\r\n " +
                        "WHERE CustomerId = '"+cboID.Text +"'";



                    if (data.executeNonQuery(sql))
                    {
                        MessageBox.Show("Update Successful");
                        //update xong thì loaddata lại để xem luôn

                    }
                }
            
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Update error" + ex.Message);
            }
        }
        /*
        private bool checkcode(String text)
        {
            string checkcode = "Select * from Customers " +
                 "where CustomerId='" + text + "'";
           DataTable dt= data.executeQuery(checkcode);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        */
    }
}
