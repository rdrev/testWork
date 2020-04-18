using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace testWork
{
    public partial class Menu_men : Form
    {
        SqlConnection sqlConn;
        bool dostoop = false;
        public Menu_men(bool dostoop)
        {
            InitializeComponent();

            this.dostoop = dostoop;
        }
        private async void Menu_men_Load_1(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source = NIKITA\SQLEXPRESS; Initial Catalog = testWord; Integrated Security = True;";//строка подключения 

            sqlConn = new SqlConnection(ConnStr);

            await sqlConn.OpenAsync();

            R_update_tasks();
            R_update_employee();

            CheckBtnActivity1();
            CheckBtnActivity2();

            if (!dostoop)//скрытие элементов для обычных сотрудников 
            {
                add_task.Visible = false;
                add_employee.Visible = false;
                ybrati1.Visible = false;
                ybrati2.Visible = false;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void R_update_tasks()
        {
            listView1.Items.Clear();//очишаем таблицу 


            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса



            string comond = "SELECT DISTINCT *" +
                "FROM [tasks]";


            comend = new SqlCommand(comond, sqlConn);

            if (sqlRead != null)
                sqlRead.Close();//проверка на откратасть 

            try
            {
                sqlRead = comend.ExecuteReader();//создаем запрос


                while (sqlRead.Read())
                {
                    listView1.Items.Add
                      (new ListViewItem(new string[]
                          {
                            Convert.ToString(sqlRead["industry"]),
                              Convert.ToString(sqlRead["name"]),
                              Convert.ToString(sqlRead["brigade"])

                          })//водим результат в таблицу 
                      );

                }

                if (sqlRead != null)
                    sqlRead.Close();//проверка на откратасть 
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

        private void R_update_employee()
        {
            listView2.Items.Clear();//очишаем таблицу 


            List<string> photo = new List<string>(),
                 surname = new List<string>(),
                  name = new List<string>(),
                   patronymic = new List<string>(),
                    specialtry = new List<string>();

            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса

            string comond = "SELECT  *" +
                "FROM [employee]";


            comend = new SqlCommand(comond, sqlConn);

            if (sqlRead != null)
                sqlRead.Close();//проверка на откратасть 
            string str = "";
            try
            {
                sqlRead = comend.ExecuteReader();//создаем запрос

                int c = 0;
                ImageList ImageList1 = new ImageList();
                ImageList1.ImageSize = new Size(50, 50);

                List<ListViewItem> ListViewItem1 = new List<ListViewItem>();

                while (sqlRead.Read())
                {

                    ListViewItem1.Add(new ListViewItem(new string[]
                          {
                              "",
                            Convert.ToString(sqlRead["surname"]),
                              Convert.ToString(sqlRead["name"]),
                              Convert.ToString(sqlRead["patronymic"]),
                              Convert.ToString(sqlRead["specialty"])
                          }));

                    str = Convert.ToString(sqlRead["surname"]);

                    ImageList1.Images.Add
                    (new Bitmap(
                        Image.FromFile(Convert.ToString(sqlRead["photo"]))));

                    c++;
                }

                listView2.SmallImageList = ImageList1;

                for (int i = 0; i < c; i++)
                {
                    ListViewItem1[i].ImageIndex = i;

                    listView2.Items.Add(ListViewItem1[i]);
                }
                if (sqlRead != null)
                    sqlRead.Close();//проверка на откратасть 
            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString() + str, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlRead != null)
                    sqlRead.Close();//проверка на откратасть 

            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBtnActivity1();
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBtnActivity2();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CheckBtnActivity1()
        {
            ybrati1.Enabled = listView1.SelectedItems.Count > 0;

        }
        private void CheckBtnActivity2()
        {
            ybrati2.Enabled = listView2.SelectedItems.Count > 0;

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ybrati1_Click(object sender, EventArgs e)
        {
            SqlCommand comend = new SqlCommand("DELETE FROM [tasks] " +
                                                    "WHERE [industry] = @industry, [name] = @name, [brigade] = @brigade", sqlConn);//перемеена для хранение  запроса

            comend.Parameters.AddWithValue("@brigade", listView1.SelectedItems[0].SubItems[0].Text);
            comend.Parameters.AddWithValue("@name", listView1.SelectedItems[0].SubItems[1].Text);
            comend.Parameters.AddWithValue("@brigade", listView1.SelectedItems[0].SubItems[2].Text);
            try
            {
                comend.ExecuteReader();//создаем запрос

            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ybrati2_Click(object sender, EventArgs e)
        {
            SqlCommand comend = new SqlCommand("DELETE FROM [employee] " +
                                                    "WHERE [name] = @name, [surname] = @surname,[patronymic] = @patronymic, [specialty] = @specialty", sqlConn);//перемеена для хранение  запроса

            comend.Parameters.AddWithValue("@name", listView1.SelectedItems[0].SubItems[1].Text);
            comend.Parameters.AddWithValue("@surname", listView1.SelectedItems[0].SubItems[2].Text);
            comend.Parameters.AddWithValue("@patronymic", listView1.SelectedItems[0].SubItems[3].Text);
            comend.Parameters.AddWithValue("@specialty", listView1.SelectedItems[0].SubItems[4].Text);
            try
            {
                comend.ExecuteReader();//создаем запрос

            }
            catch (Exception ex)//обработка исключений
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void add_task_Click(object sender, EventArgs e)
        {
            Form_add_tasks f = new Form_add_tasks(sqlConn);

            f.Show();
        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            Form_add_employee f = new Form_add_employee(sqlConn);

            f.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void view_task_Click(object sender, EventArgs e)
        {
            Form_view_tasks f = new Form_view_tasks(
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[2].Text);

            f.Show();
        }

        private void view_employee_Click(object sender, EventArgs e)
        {
            Form_view_employee f = new Form_view_employee(sqlConn,
                listView2.SelectedItems[0].SubItems[1].Text,
                listView2.SelectedItems[0].SubItems[2].Text,
                listView2.SelectedItems[0].SubItems[3].Text,
                listView2.SelectedItems[0].SubItems[4].Text);

            f.Show();
        }
    }
}
