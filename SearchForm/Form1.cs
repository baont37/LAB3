using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SearchForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);
        }
        string connString = "database=STUDENT_MANAGEMENT;Server=DESKTOP-D0QGKOB\\SQLEXPRESS;User id=sa; password=123456";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"Select * from student where name like '%{txtStudentName.Text}%'", connString);
            ds = new DataSet();
            adapter.Fill(ds);
            sTUDENTDataGridView.DataSource = ds.Tables[0];
        }
    }
}
