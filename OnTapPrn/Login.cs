using System.Data;

using OnTapWinFormADO.NET;
namespace OnTapWinFormADO.NET
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           // dataProvider = new DataProvider();
        }
        //B1: Tạo đối tượng DataProvider
        DataProvider dataProvider = new DataProvider();


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kiểm tra xem trong database có tìm đc thằng object nào có
            // account và pass thỏa k
            //b1:nhồi tất cả vào trycatch
            //b2:viết câu lệnh sql
            //b3:khởi tạo datatable và thực thực câu lệnh sql thông qua dataprovider kèm đó
            //là nhồi vào datatable
            //b4:check xem số hàng trong datatable có > 0 không ?
            //lớn hơn 0 tức là có dữ liệu đc tìm thấy
            //else thì nc lại
            try
            {
                
                String sql = "select * from Users " +
                    "where Account = '" + txtAccount.Text + "' and " +
                    "Password = '" + txtPassword.Text + "'";
                
                DataTable dt = dataProvider.executeQuery(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success!!!!");
                    //sau khi đăng nhập thành công tôi muốn hiện form customer, ta làm như sau
                    Customer cus = new Customer(txtAccount.Text);
                    //ở đây tôi muốn truyền thêm cả account về trang customer
                    //gen 1 contructor
                    this.Hide();
                    cus.Show();
                }
                else
                {
                    MessageBox.Show("Login Fail!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error because " + ex.Message);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //thoát toàn bộ
        }
    }
}