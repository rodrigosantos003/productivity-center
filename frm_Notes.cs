using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProductivityCenter
{
    public partial class frm_Notes : Form
    {
        int Id = 0;

        public frm_Notes()
        {
            InitializeComponent();
        }

        private void frm_Notes_Load(object sender, EventArgs e)
        {
            showNotes();
        }

        private void frm_Notes_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frm_MainScreen().Show();
        }

        private void showNotes()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\MyProjects\ProductivityCenter\DB_Storage.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Notes", sqlcon);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\MyProjects\ProductivityCenter\DB_Storage.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("DELETE tbl_Notes WHERE Id=@Id", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Note deleted!");

                showNotes();
            }
        }
    }
}
