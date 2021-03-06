﻿using System;
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
    public partial class Form_view_tasks : Form
    {
        SqlConnection sqlConn;
        string id;

        public Form_view_tasks(SqlConnection sqlConn, string id)
        {
            InitializeComponent();
            this.sqlConn = sqlConn;
            this.id = id;
        }

        private void Form_view_tasks_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlRead = null;//перемеена для хранение вывода  запроса

            SqlCommand comend = new SqlCommand();//перемеена для хранение  запроса

            idBox.Text = id;

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
                    industry.Text = Convert.ToString(sqlRead["industry"]);
                    name.Text = Convert.ToString(sqlRead["name"]);
                    brigade.Text = Convert.ToString(sqlRead["brigade"]);

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
    }
}
