using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testWork
{
    public partial class Form_add_tasks : Form
    {
        SqlConnection sqlConn;

        public Form_add_tasks(SqlConnection sqlConn1)
        {
            InitializeComponent();

            sqlConn = sqlConn1;
        }

        private void add_Click(object sender, EventArgs e)
        {
            

             SqlCommand comend = new SqlCommand("INSERT INTO[tasks] (industry, name, brigade)" +
                            "VALUES(@industry, @name, @brigade);", sqlConn);//перемеена для хранение  запроса
            comend.Parameters.AddWithValue("@industry", industry.Text);
            comend.Parameters.AddWithValue("@name", name.Text);
            comend.Parameters.AddWithValue("@brigade", Convert.ToInt32((brigade.Text)));


           
            try
            {
                comend.ExecuteReader();//создаем запрос

            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

       
    }
}
