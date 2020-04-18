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
        string s_name,
             s_surname,
             s_patronymic,
             s_specialty;

        public Form_view_employee(SqlConnection sqlConn,
            string name,
            string surname, 
            string patronymic,
            string specialty)
        {
            InitializeComponent();
            this.sqlConn = sqlConn;
            this.name.Text = name; s_name = name;
            this.surname.Text = surname; s_surname = surname;
            this.patronymic.Text = patronymic; s_patronymic = patronymic;
            this.specialty.Text = specialty; s_specialty = specialty;

        }

        private async void Form_view_employee_Load(object sender, EventArgs e) {


           // await sqlConn.OpenAsync();

            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса

            string comond = "SELECT  [photo]" +
                "FROM [employee]" +
               "WHERE [name] = @name AND [surname] = @surname AND [patronymic] = @patronymic AND [specialty] = @specialty";
            comend = new SqlCommand(comond, sqlConn);
            comend.Parameters.AddWithValue("@name", s_name);
            comend.Parameters.AddWithValue("@surname", s_surname);
            comend.Parameters.AddWithValue("@patronymic", s_patronymic);
            comend.Parameters.AddWithValue("@specialty", s_specialty);

            

            if (sqlRead != null)
                sqlRead.Close();//проверка на откратасть 
            


                this.Hide();
        } 
    }
}
