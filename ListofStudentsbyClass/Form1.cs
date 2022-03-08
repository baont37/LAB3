using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ListofStudentsbyClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.CLASS);
        }

        string conn = global::ListofStudentsbyClass.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter = null;
        string str;
        private void btnView_Click(object sender, EventArgs e)
        {
            str = $"select * from student where classID = '{cboClassID.Text}'";
            adapter = new SqlDataAdapter(str, conn);
            ds = new DataSet();
            adapter.Fill(ds);

            sTUDENTDataGridView.DataSource = ds.Tables[0];
        }
    }
}
