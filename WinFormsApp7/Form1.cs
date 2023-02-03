using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mhd\\source\\repos\\WinFormsApp7\\WinFormsApp7\\MyInfoDb.mdf;Integrated Security=True");
         cn.Open();
            getInfo();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblMyInfo (id, name, age) VALUES(@id, @name, @age)";
            cmd= new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@age",Int32.Parse(age.Text));
            cmd.ExecuteNonQuery(); 
            getInfo();
        }

        public void getInfo()
        {
            cmd = new SqlCommand("select * from tblMyInfo", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}