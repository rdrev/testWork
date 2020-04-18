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
    public partial class Form_view_employee : Form
    {
        SqlConnection sqlConn;
        string id;

        public Form_view_employee(SqlConnection sqlConn, string id)
        {
            InitializeComponent();
            this.sqlConn = sqlConn;
            this.id = id;
        }

        private void Form_view_employee_Load(object sender, EventArgs e) {


           // await sqlConn.OpenAsync();

            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса

            idBox.Text = id;

            string comond = "SELECT  *" +
                "FROM [employee]" +
               "WHERE [id] = @id ";
            comend = new SqlCommand(comond, sqlConn);
            comend.Parameters.AddWithValue("@id", Convert.ToString(id));

            

            if (sqlRead != null)
                sqlRead.Close();//проверка на откратасть 

            try
            {
                sqlRead = comend.ExecuteReader();//создаем запрос

               

                List<ListViewItem> ListViewItem1 = new List<ListViewItem>();

                while (sqlRead.Read())
                {


                    surname.Text = Convert.ToString(sqlRead["surname"]);
                    name.Text = Convert.ToString(sqlRead["name"]);
                    patronymic.Text = Convert.ToString(sqlRead["patronymic"]);
                    specialty.Text = Convert.ToString(sqlRead["specialty"]);



                   pictureBox1.Image = new Bitmap(
                        Image.FromFile(Convert.ToString(sqlRead["photo"])));

                }
        }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlRead != null)
                    sqlRead.Close();//проверка на откратасть 

            }

            this.Hide();
        } 
    }
}
