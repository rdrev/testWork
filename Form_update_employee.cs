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
    public partial class Form_update_employee : Form
    {
        SqlConnection sqlConn;
        string FileName = "",
            id = "";

        public Form_update_employee(SqlConnection sqlConn, string id)
        {
            InitializeComponent();

            this.sqlConn = sqlConn;
            this.id = id;
        }

        private void Form_update_employee_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса


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



           

            while (sqlRead.Read())
            {


                surname.Text = Convert.ToString(sqlRead["surname"]);
                name.Text = Convert.ToString(sqlRead["name"]);
                patronymic.Text = Convert.ToString(sqlRead["patronymic"]);
                specialty.Text = Convert.ToString(sqlRead["specialty"]);
                login.Text = Convert.ToString(sqlRead["login"]);
                password.Text = Convert.ToString(sqlRead["password"]);
                dostoop.Text = Convert.ToString(sqlRead["dostoop"]);



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
        }

        private void button_photo_Click(object sender, EventArgs e)
        {
            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    FileName = ofd.FileName;
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand comend = new SqlCommand("UPDATE [employee] " +
                                                "SET name = @name, surname = @surname, patronymic = @patronymic, specialty = @specialty, photo = @photo, login = @login, password = @password, dostoop = @dostoop " +
                                                "WHERE id = @id; ", sqlConn);//перемеена для хранение  запроса
            comend.Parameters.AddWithValue("@id", id);
            comend.Parameters.AddWithValue("@name", name.Text);
            comend.Parameters.AddWithValue("@surname", surname.Text);
            comend.Parameters.AddWithValue("@patronymic", patronymic.Text);
            comend.Parameters.AddWithValue("@specialty", specialty.Text);
            comend.Parameters.AddWithValue("@photo", FileName);
            comend.Parameters.AddWithValue("@login", login.Text);
            comend.Parameters.AddWithValue("@password", password.Text);
            comend.Parameters.AddWithValue("@dostoop", Convert.ToInt32(dostoop.Text));



            try
            {
                SqlDataReader sqlRead =  comend.ExecuteReader();//создаем запрос
                sqlRead.Close();

            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            this.Hide();
        }
    }
}
