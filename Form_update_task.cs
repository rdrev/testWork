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
    public partial class Form_update_task : Form
    {
        SqlConnection sqlConn;
        string FileName = "",
            id = "";

        public Form_update_task(SqlConnection sqlConn, string id)
        {
            InitializeComponent();

            this.sqlConn = sqlConn;
            this.id = id;
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand comend = new SqlCommand("UPDATE [tasks] " +
                            "SET industry = @industry, name = @name, brigade = @brigade);" +
                                                "WHERE id = @id; ", sqlConn);//перемеена для хранение  запроса
            comend.Parameters.AddWithValue("@industry", industry.Text);
            comend.Parameters.AddWithValue("@name", name.Text);
            comend.Parameters.AddWithValue("@brigade", Convert.ToInt32((brigade.Text)));



            try
            {
                SqlDataReader sqlRead = comend.ExecuteReader();//создаем запрос
                sqlRead.Close();

            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private void Form_update_task_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса


            string comond = "SELECT DISTINCT *" +
                "FROM [tasks]" +
               "WHERE [id] = @id ";
            comend = new SqlCommand(comond, sqlConn);
            comend.Parameters.AddWithValue("@id", Convert.ToString(id));



            if (sqlRead != null)
                sqlRead.Close();//проверка на откратасть 

            try
            {
                sqlRead = comend.ExecuteReader();//создаем запрос



                while (sqlRead.Read())
                {


                    industry.Text = Convert.ToString(sqlRead["industry"]);
                    name.Text = Convert.ToString(sqlRead["name"]);
                    brigade.Text = Convert.ToString(sqlRead["brigade"]);

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
        }
    }
}
