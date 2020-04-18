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
    public partial class Form_add_employee : Form
    {

        SqlConnection sqlConn;
        string FileName = "";

        public Form_add_employee(SqlConnection sqlConn)
        {
            InitializeComponent();

            this.sqlConn = sqlConn;
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand comend = new SqlCommand("INSERT INTO[employee] (name, surname, patronymic, specialty, photo, login, password, dostoop)" +
                           "VALUES(@name, @surname, @specialty, @photo, @login, @password, @dostoop);", sqlConn);//перемеена для хранение  запроса
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
                comend.ExecuteReader();//создаем запрос

            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
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
    }
}
