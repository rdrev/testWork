using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

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
                
                update_task.Visible = false;
                update_employee.Visible = false;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void R_update_tasks()
        {
            listView1.Items.Clear();//очишаем таблицу 


            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса



            string comond = "SELECT " +
                "[tasks].[id] AS id_ta," +
                " [industry], " +
                "[tasks].[name] AS na_ta," +
                " [brigade].[name] AS na_br " +
                "FROM [tasks], [brigade]" +
                " WHERE  [tasks].[brigade] = [brigade].[id]";

            //string comond = "SELECT *" +
            //    "FROM [tasks]"; 
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
                            Convert.ToString(sqlRead["id_ta"]),
                              Convert.ToString(sqlRead["industry"]),
                              Convert.ToString(sqlRead["na_ta"]),
                              Convert.ToString(sqlRead["na_br"])
                             //Convert.ToString(sqlRead["id"]),
                             // Convert.ToString(sqlRead["industry"]),
                             // Convert.ToString(sqlRead["name"]),
                             // Convert.ToString(sqlRead["brigade"])

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


            //List<string> photo = new List<string>(),
            //     surname = new List<string>(),
            //      name = new List<string>(),
            //       patronymic = new List<string>(),
            //        specialtry = new List<string>();

            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса

            string comond = "SELECT  [surname], [employee].[name] AS name_em, [patronymic], [specialty], [employee].[id] AS id_em, [photo], [brigade].[name] AS name_br, [vin]" +
                "FROM [employee], [brigade]" +
                "WHERE [employee].[brigade] = [brigade].[id]";


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
                            Convert.ToString(sqlRead["name_em"]),
                              Convert.ToString(sqlRead["patronymic"]),
                              Convert.ToString(sqlRead["specialty"]),
                              Convert.ToString(sqlRead["id_em"]),
                              Convert.ToString(sqlRead["name_br"]),
                              Convert.ToString(sqlRead["vin"])
                      }));


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
            update_task.Enabled = listView1.SelectedItems.Count > 0;
            view_task.Enabled = listView1.SelectedItems.Count > 0;

        }
        private void CheckBtnActivity2()
        {
            ybrati2.Enabled = listView2.SelectedItems.Count > 0;
            update_employee.Enabled = listView2.SelectedItems.Count > 0;
            view_employee.Enabled = listView2.SelectedItems.Count > 0;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ybrati1_Click(object sender, EventArgs e)
        {
            SqlCommand comend = new SqlCommand("DELETE FROM [tasks] " +
                                                    "WHERE [id] = @id", sqlConn);//перемеена для хранение  запроса

            comend.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[0].Text);
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
                                                    "WHERE [id] = @id", sqlConn);//перемеена для хранение  запроса

            comend.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[0].Text);
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
            Form_view_tasks f = new Form_view_tasks(sqlConn,
                listView1.SelectedItems[0].SubItems[3].Text);

            f.Show();
        }

        private void view_employee_Click(object sender, EventArgs e)
        {
            Form_view_employee f = new Form_view_employee(sqlConn,
                listView2.SelectedItems[0].SubItems[5].Text);

            f.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void update_employee_Click(object sender, EventArgs e)
        {
            Form_update_employee f = new Form_update_employee(sqlConn,
                listView2.SelectedItems[0].SubItems[5].Text);

            f.Show();
        }

        private void update_task_Click(object sender, EventArgs e)
        {
            Form_update_task f = new Form_update_task(sqlConn,
                listView1.SelectedItems[0].SubItems[3].Text);

            f.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R_update_tasks();
            R_update_employee();
        }

        private void инфVINToolStripMenuItem_Click(object sender, EventArgs e)//вывод собщения о годе
        {
                 MessageBox.Show(VIN.rdrev.GET_year(listView2.SelectedItems[0].SubItems[7].Text, sqlConn),//текст из функции dll 
                                "year",//заголовок 
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);//тип поля
        }

        private void инфЗаводVINToolStripMenuItem_Click(object sender, EventArgs e)//вывод собщения о заводе
        {
            MessageBox.Show(VIN.rdrev.GET_factory(listView2.SelectedItems[0].SubItems[7].Text, sqlConn),//текст из функции dll 
                               "factory",//заголовок 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Question);//тип поля
        }
    }
}
