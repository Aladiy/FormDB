using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        DB database = new DB();
        public Form2()
        {
            InitializeComponent();
        }
        private void CreateColumns1()
        {
            dataGridView1_user.Columns.Add("id", "id");
            dataGridView1_user.Columns.Add("AddressAutopark", "Адрес автопарка");
            dataGridView1_user.Columns.Add("NumPhone", "Телефон");
            dataGridView1_user.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns2()
        {
            dataGridView2_user.Columns.Add("StateNum", "Гос.номер");
            dataGridView2_user.Columns.Add("model", "Модель");
            dataGridView2_user.Columns.Add("color", "Цвет");
            dataGridView2_user.Columns.Add("year_of_issue", "Год выпуска");
            dataGridView2_user.Columns.Add("class", "Класс");
            dataGridView2_user.Columns.Add("mileage", "Пробег");
            dataGridView2_user.Columns.Add("statusCar", "Статус");
            dataGridView2_user.Columns.Add("rentalPrice", "Цена проката");
            dataGridView2_user.Columns.Add("insuranceCost", "Страховая стоимость");
            dataGridView2_user.Columns.Add("Autoparkid", "id автопарка");
            dataGridView2_user.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns3()
        {
            dataGridView3_user.Columns.Add("id_client", "id");
            dataGridView3_user.Columns.Add("client_name", "Имя");
            dataGridView3_user.Columns.Add("client_surname", "Фамилия");
            dataGridView3_user.Columns.Add("client_patronymic", "Отчество");
            dataGridView3_user.Columns.Add("Passport", "Паспорт");
            dataGridView3_user.Columns.Add("AddressClient", "Адрес");
            dataGridView3_user.Columns.Add("PhoneNumClient", "Телефон");
            dataGridView3_user.Columns.Add("carStateNum", "id автомобиля");
            dataGridView3_user.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns4()
        {
            dataGridView4_user.Columns.Add("RequestNum", "Номер заявки");
            dataGridView4_user.Columns.Add("DateOfIssue", "Дата проката");
            dataGridView4_user.Columns.Add("NumOfRentalDays", "Кол-во дней проката");
            dataGridView4_user.Columns.Add("Clientid", "id клиента");
            dataGridView4_user.Columns.Add("Carid", "id автомобиля");
            dataGridView4_user.Columns.Add("Workerid", "id работника");
            dataGridView4_user.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns5()
        {
            dataGridView5_user.Columns.Add("id_worker", "id");
            dataGridView5_user.Columns.Add("Worker_name", "Имя");
            dataGridView5_user.Columns.Add("Worker_surname", "Фамилия");
            dataGridView5_user.Columns.Add("Worker_patronymic", "Отчество");
            dataGridView5_user.Columns.Add("position", "Должность");
            dataGridView5_user.Columns.Add("contact", "Телефон");
            dataGridView5_user.Columns.Add("OperatingMode", "Режим работы");
            dataGridView5_user.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetString(6), record.GetDecimal(7), record.GetDecimal(8), record.GetInt32(9), RowState.ModifiedNew);
        }
        private void ReadSingleRow3(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetInt32(7), RowState.ModifiedNew);
        }
        private void ReadSingleRow4(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifiedNew);

        }
        private void ReadSingleRow5(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }
        private void RefreshDataGrid1(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString1 = $"select * from Autopark";

            var con = database.getConnection();

            SqlCommand command1 = new SqlCommand(queryString1, con);

            database.openConnection();

            SqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                ReadSingleRow1(dgw, reader1);
            }
            reader1.Close();
        }
        private void RefreshDataGrid2(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString2 = $"select * from Car";

            var con = database.getConnection();

            SqlCommand command2 = new SqlCommand(queryString2, con);

            database.openConnection();

            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                ReadSingleRow2(dgw, reader2);
            }
            reader2.Close();
        }
        private void RefreshDataGrid3(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString3 = $"select * from Client";

            var con = database.getConnection();

            SqlCommand command3 = new SqlCommand(queryString3, con);

            database.openConnection();

            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                ReadSingleRow3(dgw, reader3);
            }
            reader3.Close();
        }
        private void RefreshDataGrid4(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString4 = $"select * from Rental";

            var con = database.getConnection();

            SqlCommand command4 = new SqlCommand(queryString4, con);

            database.openConnection();

            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                ReadSingleRow4(dgw, reader4);
            }
            reader4.Close();
        }
        private void RefreshDataGrid5(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString5 = $"select * from Worker";

            var con = database.getConnection();

            SqlCommand command5 = new SqlCommand(queryString5, con);

            database.openConnection();

            SqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {
                ReadSingleRow5(dgw, reader5);
            }
            reader5.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns1();
            CreateColumns2();
            CreateColumns3();
            CreateColumns4();
            CreateColumns5();
            RefreshDataGrid1(dataGridView1_user);
            RefreshDataGrid2(dataGridView2_user);
            RefreshDataGrid3(dataGridView3_user);
            RefreshDataGrid4(dataGridView4_user);
            RefreshDataGrid5(dataGridView5_user);
        }

        private void UserSearchAutopark(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Autopark where concat(ID, AddressAutopark, NumPhone) like '%" + textBox_usersearchAutopark.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow1(dgw, read);
            }
            read.Close();
        }
        private void UserSearchCar(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Car where concat(StateNum, model, color, year_of_issue, class, mileage, statusCar, rentalPrice, insuranceCost, Autoparkid) like '%" + textBox_usersearchCar.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow2(dgw, read);
            }
            read.Close();
        }
        private void UserSearchClient(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Client where concat(id_client, client_name, client_surname, client_patronymic, Passport, AddressClient, PhoneNumClient, carStateNum) like '%" + textBox_usersearchClient.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow3(dgw, read);
            }
            read.Close();
        }
        private void UserSearchRental(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Rental where concat(RequestNum, DateOfIssue, NumOfRentalDays, Clientid, Carid, Workerid) like '%" + textBox_usersearchRental.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow4(dgw, read);
            }
            read.Close();
        }
        private void UserSearchWorker(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Worker where concat(id_worker, Worker_name, Worker_surname, Worker_patronymic, position, contact, OperatingMode) like '%" + textBox_usersearchWorker.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow5(dgw, read);
            }
            read.Close();

        }

        private void textBox_usersearchAutopark_TextChanged(object sender, EventArgs e)
        {
            UserSearchAutopark(dataGridView1_user);
        }

        private void textBox_usersearchCar_TextChanged(object sender, EventArgs e)
        {
            UserSearchCar(dataGridView2_user);
        }

        private void textBox_usersearchClient_TextChanged(object sender, EventArgs e)
        {
            UserSearchClient(dataGridView3_user);
        }

        private void textBox_usersearchRental_TextChanged(object sender, EventArgs e)
        {
            UserSearchRental(dataGridView4_user);
        }

        private void textBox_usersearchWorker_TextChanged(object sender, EventArgs e)
        {
            UserSearchWorker(dataGridView5_user);
        }
    }
}
