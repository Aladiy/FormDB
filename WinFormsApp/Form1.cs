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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        DB database = new DB();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateColumns1()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("AddressAutopark", "Адрес автопарка");
            dataGridView1.Columns.Add("NumPhone", "Телефон");
            dataGridView1.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns2()
        {
            dataGridView2.Columns.Add("StateNum", "Гос.номер");
            dataGridView2.Columns.Add("model", "Модель");
            dataGridView2.Columns.Add("color", "Цвет");
            dataGridView2.Columns.Add("year_of_issue", "Год выпуска");
            dataGridView2.Columns.Add("class", "Класс");
            dataGridView2.Columns.Add("mileage", "Пробег");
            dataGridView2.Columns.Add("statusCar", "Статус");
            dataGridView2.Columns.Add("rentalPrice", "Цена проката");
            dataGridView2.Columns.Add("insuranceCost", "Страховая стоимость");
            dataGridView2.Columns.Add("Autoparkid", "id автопарка");
            dataGridView2.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns3()
        {
            dataGridView3.Columns.Add("id_client", "id");
            dataGridView3.Columns.Add("client_name", "Имя");
            dataGridView3.Columns.Add("client_surname", "Фамилия");
            dataGridView3.Columns.Add("client_patronymic", "Отчество");
            dataGridView3.Columns.Add("Passport", "Паспорт");
            dataGridView3.Columns.Add("AddressClient", "Адрес");
            dataGridView3.Columns.Add("PhoneNumClient", "Телефон");
            dataGridView3.Columns.Add("carStateNum", "id автомобиля");
            dataGridView3.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns4()
        {
            dataGridView4.Columns.Add("RequestNum", "Номер заявки");
            dataGridView4.Columns.Add("DateOfIssue", "Дата проката");
            dataGridView4.Columns.Add("NumOfRentalDays", "Кол-во дней проката");
            dataGridView4.Columns.Add("Clientid", "id клиента");
            dataGridView4.Columns.Add("Carid", "id автомобиля");
            dataGridView4.Columns.Add("Workerid", "id работника");
            dataGridView4.Columns.Add("isNew", String.Empty);
        }
        private void CreateColumns5()
        {
            dataGridView5.Columns.Add("id_worker", "id");
            dataGridView5.Columns.Add("Worker_name", "Имя");
            dataGridView5.Columns.Add("Worker_surname", "Фамилия");
            dataGridView5.Columns.Add("Worker_patronymic", "Отчество");
            dataGridView5.Columns.Add("position", "Должность");
            dataGridView5.Columns.Add("contact", "Телефон");
            dataGridView5.Columns.Add("OperatingMode", "Режим работы");
            dataGridView5.Columns.Add("isNew", String.Empty);
        }
        private void ReadSingleRow1(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetString(6), record.GetInt32(7), record.GetInt32(8), record.GetInt32(9), RowState.ModifiedNew);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns1();
            CreateColumns2();
            CreateColumns3();
            CreateColumns4();
            CreateColumns5();
  
            RefreshDataGrid1(dataGridView1);
            RefreshDataGrid2(dataGridView2);
            RefreshDataGrid3(dataGridView3);
            RefreshDataGrid4(dataGridView4);
            RefreshDataGrid5(dataGridView5);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_address.Text = row.Cells[1].Value.ToString();
                textBox_phone.Text = row.Cells[2].Value.ToString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox_statenum.Text = row.Cells[0].Value.ToString();
                textBox_model.Text = row.Cells[1].Value.ToString();
                textBox_color.Text = row.Cells[2].Value.ToString();
                textBox_year.Text = row.Cells[3].Value.ToString();
                textBox_class.Text = row.Cells[4].Value.ToString();
                textBox_mileage.Text = row.Cells[5].Value.ToString();
                textBox_status.Text = row.Cells[6].Value.ToString();
                textBox_rental.Text = row.Cells[7].Value.ToString();
                textBox_incost.Text = row.Cells[8].Value.ToString();
            }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                textBox_idclient.Text = row.Cells[0].Value.ToString();
                textBox_nameclient.Text = row.Cells[1].Value.ToString();
                textBox_surclient.Text = row.Cells[2].Value.ToString();
                textBox_patclient.Text = row.Cells[3].Value.ToString();
                textBox_passport.Text = row.Cells[4].Value.ToString();
                textBox_addressclient.Text = row.Cells[5].Value.ToString();
                textBox_phoneclient.Text = row.Cells[6].Value.ToString();
                textBox_numcar.Text = row.Cells[7].Value.ToString();
            }
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];

                textBox_request.Text = row.Cells[0].Value.ToString();
                textBox_date.Text = row.Cells[1].Value.ToString();
                textBox_days.Text = row.Cells[2].Value.ToString();
                textBox_clientid.Text = row.Cells[3].Value.ToString();
                textBox_carid.Text = row.Cells[4].Value.ToString();
                textBox_workerid.Text = row.Cells[5].Value.ToString();

            }
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView5.Rows[selectedRow];

                textBox_idworker.Text = row.Cells[0].Value.ToString();
                textBox_nameworker.Text = row.Cells[1].Value.ToString();
                textBox_surworker.Text = row.Cells[2].Value.ToString();
                textBox_patworker.Text = row.Cells[3].Value.ToString();
                textBox_position.Text = row.Cells[4].Value.ToString();
                textBox_phoneworker.Text = row.Cells[5].Value.ToString();
                textBox_opermode.Text = row.Cells[6].Value.ToString();
            }
        }
        private void button_Autopark_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var address = textBox_address.Text;
            int phone;
            
            if (int.TryParse(textBox_phone.Text, out phone))
            {
                var addQuery = $"insert into Autopark (AddressAutopark, NumPhone) values ('{address}', '{phone}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Не получилось создать запись :с", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
        }

 //ПОИСК ЗАПИСЕЙ

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshDataGrid1(dataGridView1); 
        }

        private void SearchAutopark(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Autopark where concat(ID, AddressAutopark, NumPhone) like '%" + textBox_searchAutopark.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow1(dgw, read);
            }
            read.Close();
        }
        private void SearchCar(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Car where concat(StateNum, model, color, year_of_issue, class, mileage, statusCar, rentalPrice, insuranceCost, Autoparkid) like '%" + textBox_searchCar.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow2(dgw, read);
            }
            read.Close();
        }
        private void SearchClient(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Client where concat(id_client, client_name, client_surname, client_patronymic, Passport, AddressClient, PhoneNumClient, carStateNum) like '%" + textBox_searchClient.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow3(dgw, read);
            }
            read.Close();
        }
        private void SearchRental(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Rental where concat(RequestNum, DateOfIssue, NumOfRentalDays, Clientid, Carid, Workerid) like '%" + textBox_searchRental.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow4(dgw, read);
            }
            read.Close();
        }
        private void SearchWorker(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Worker where concat(id_worker, Worker_name, Worker_surname, Worker_patronymic, position, contact, OperatingMode) like '%" + textBox_searchWorker.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());
            database.openConnection();

            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow5(dgw, read);
            }
            read.Close();
        }
        private void textBox_searchAutopark_TextChanged(object sender, EventArgs e)
        {
            SearchAutopark(dataGridView1);
        }
        private void textBox_searchCar_TextChanged(object sender, EventArgs e)
        {
            SearchCar(dataGridView2);
        }

        private void textBox_searchClient_TextChanged(object sender, EventArgs e)
        {
            SearchClient(dataGridView3);
        }

        private void textBox_searchRental_TextChanged(object sender, EventArgs e)
        {
            SearchRental(dataGridView4);
        }

        private void textBox_searchWorker_TextChanged(object sender, EventArgs e)
        {
            SearchWorker(dataGridView5);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RefreshDataGrid3(dataGridView3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RefreshDataGrid4(dataGridView4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RefreshDataGrid5(dataGridView5);
        }

        private void button_Car_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var model = textBox_model.Text;
            var color = textBox_color.Text;
            var year = textBox_year.Text;
            var classCar = textBox_class.Text;
            var mileage = textBox_mileage.Text;
            var status = textBox_status.Text;
            var rental = textBox_rental.Text;
            var autoparkid = textBox_autoparkid.Text;
            int incost;

            if (int.TryParse(textBox_incost.Text, out incost))
            {
                var addQuery = $"insert into Car (model, color, year_of_issue, class, mileage, statusCar, rentalPrice, insuranceCost, Autoparkid) values ('{model}', '{color}', '{year}', '{classCar}', '{mileage}', '{status}', '{rental}', '{incost}', '{autoparkid}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не получилось создать запись :с", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var nameclient = textBox_nameclient.Text;
            var surclient = textBox_surclient.Text;
            var patclient = textBox_patclient.Text;
            var passport = textBox_passport.Text;
            var addressclient = textBox_addressclient.Text;
            var phoneclient = textBox_phoneclient.Text;
            int numcar;

            if (int.TryParse(textBox_numcar.Text, out numcar))
            {
                var addQuery = $"insert into Client (client_name, client_surname, client_patronymic, Passport, AddressClient, PhoneNumClient, carStateNum) values ('{nameclient}', '{surclient}', '{patclient}', '{passport}', '{addressclient}', '{phoneclient}', '{numcar}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не получилось создать запись :с", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
        }

        private void button_Rental_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var dateofissue = textBox_date.Text;
            var numofrentaldays = textBox_days.Text;
            var idclient = textBox_clientid.Text;
            var idcar = textBox_carid.Text;
            int idworker;

            if (int.TryParse(textBox_workerid.Text, out idworker))
            {
                var addQuery = $"insert into Rental (DateOfIssue, NumOfRentalDays, Clientid, Carid, Workerid) values ('{dateofissue}', '{numofrentaldays}', '{idclient}', '{idcar}', '{idworker}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не получилось создать запись :с", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
        }

        private void button_Worker_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var nameworker = textBox_nameworker.Text;
            var surworker = textBox_surworker.Text;
            var patworker = textBox_patworker.Text;
            var position = textBox_position.Text;
            var opermode = textBox_opermode.Text;
            int phoneworker;

            if (int.TryParse(textBox_phoneworker.Text, out phoneworker))
            {
                var addQuery = $"insert into Worker (Worker_name, Worker_surname, Worker_patronymic, position, contact, OperatingMode) values ('{nameworker}', '{surworker}', '{patworker}', '{position}', '{phoneworker}', '{opermode}')";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не получилось создать запись :с", "Провал!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
        }
        private void deleteRow1()
        {
            database.openConnection();
            int index = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex);
            dataGridView1.Rows[index].Visible = false;
            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from Autopark where id = {id}";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
        }
        private void Update1()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                RowState rowState = (RowState)dataGridView1.Rows[index].Cells[2].Value;
                
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Autopark where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var address = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update Autopark set AddressAutopark = '{address}', NumPhone = '{phone}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }
        
        private void button1_delete_Click(object sender, EventArgs e)
        {
            deleteRow1();
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            Update1();
        }
        private void deleteRow2()
        {
            database.openConnection();
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[index].Visible = false;
            var statenum = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from Car where StateNum = {statenum}";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();
            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            database.closeConnection();
        }
        private void Update2()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var statenum = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Car where StateNum = {statenum}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var statenum = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var model = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var color = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var year = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var classCar = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var mileage = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var status = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    var rental = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    var incost = dataGridView2.Rows[index].Cells[7].Value.ToString();
                    var idautopark = dataGridView2.Rows[index].Cells[8].Value.ToString();

                    var changeQuery = $"update Car set model = '{model}', color = '{color}', year_of_issue = '{year}', class = '{classCar}', mileage = '{mileage}', statusCar = '{status}', rentalPrice = '{rental}', insuranceCost = '{incost}', Autoparkid = '{idautopark}' where StateNum = '{statenum}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void button2_delete_Click(object sender, EventArgs e)
        {
            deleteRow2();
        }

        private void button2_save_Click(object sender, EventArgs e)
        {
            Update2();
        }
        private void deleteRow3()
        {
            database.openConnection();
            int index = dataGridView3.CurrentCell.RowIndex;
            dataGridView3.Rows[index].Visible = false;
            var idclient = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from Client where id_client = {idclient}";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();
            if (dataGridView3.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView3.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            database.closeConnection();
        }
        private void Update3()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView3.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var idclient = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Client where id_client = {idclient}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var idclient = dataGridView3.Rows[index].Cells[0].Value.ToString();
                    var nameclient = dataGridView3.Rows[index].Cells[1].Value.ToString();
                    var surclient = dataGridView3.Rows[index].Cells[2].Value.ToString();
                    var patclient = dataGridView3.Rows[index].Cells[3].Value.ToString();
                    var passport = dataGridView3.Rows[index].Cells[4].Value.ToString();
                    var addressclient = dataGridView3.Rows[index].Cells[5].Value.ToString();
                    var phoneclient = dataGridView3.Rows[index].Cells[6].Value.ToString();
                    var numcar = dataGridView3.Rows[index].Cells[7].Value.ToString();

                    var changeQuery = $"update Client set client_name = '{nameclient}', client_surname = '{surclient}', client_patronymic = '{patclient}', Passport = '{passport}', AddressClient = '{addressclient}', PhoneNumClient = '{phoneclient}', carStateNum = '{numcar}' where id_client = '{idclient}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void button3_delete_Click(object sender, EventArgs e)
        {
            deleteRow3();
        }

        private void button3_save_Click(object sender, EventArgs e)
        {
            Update3();
        }
        private void deleteRow4()
        {
            database.openConnection();
            int index = dataGridView4.CurrentCell.RowIndex;
            dataGridView4.Rows[index].Visible = false;
            var requestnum = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from Rental where RequestNum = {requestnum}";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();

            if (dataGridView4.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView4.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            database.closeConnection();
        }
        private void Update4()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView4.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView4.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var requestnum = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Rental where StateNum = {requestnum}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RowState.Modified)
                {
                    var requestnum = dataGridView4.Rows[index].Cells[0].Value.ToString();
                    var date = dataGridView4.Rows[index].Cells[1].Value.ToString();
                    var days = dataGridView4.Rows[index].Cells[2].Value.ToString();
                    var idClient = dataGridView4.Rows[index].Cells[3].Value.ToString();
                    var idCar = dataGridView4.Rows[index].Cells[4].Value.ToString();
                    var idWorker = dataGridView4.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update Rental set DateOfIssue = '{date}', NumOfRentalDays = '{days}', Clientid = '{idClient}', Carid = '{idCar}', Workerid = '{idWorker}' where RequestNum = '{requestnum}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void button4_delete_Click(object sender, EventArgs e)
        {
            deleteRow4();
        }

        private void button4_save_Click(object sender, EventArgs e)
        {
            Update4();
        }
        private void deleteRow5()
        {
            database.openConnection();
            int index = dataGridView5.CurrentCell.RowIndex;
            dataGridView5.Rows[index].Visible = false;
            var idworker = Convert.ToInt32(dataGridView5.Rows[index].Cells[0].Value);
            var deleteQuery = $"delete from Worker where id_worker = {idworker}";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();
            if (dataGridView5.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView5.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            database.closeConnection();
        }
        private void Update5()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView5.Rows.Count; index++)
            {
                var rowState5 = (RowState)dataGridView5.Rows[index].Cells[6].Value;

                if (rowState5 == RowState.Existed)
                    continue;
                if (rowState5 == RowState.Deleted)
                {
                    var idworker = Convert.ToInt32(dataGridView5.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Worker where id_worker = {idworker}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState5 == RowState.Modified)
                {
                    var idworker = dataGridView5.Rows[index].Cells[0].Value.ToString();
                    var nameworker = dataGridView5.Rows[index].Cells[1].Value.ToString();
                    var surworker = dataGridView5.Rows[index].Cells[2].Value.ToString();
                    var patworker = dataGridView5.Rows[index].Cells[3].Value.ToString();
                    var position = dataGridView5.Rows[index].Cells[4].Value.ToString();
                    var contact = dataGridView5.Rows[index].Cells[5].Value.ToString();
                    var opermode = dataGridView5.Rows[index].Cells[6].Value.ToString();
                   
                    var changeQuery = $"update Worker set Worker_name= '{nameworker}', Worker_surname = '{surworker}', Worker_patronymic = '{patworker}', position = '{position}', contact = '{contact}', OperatingMode = '{opermode}' where id_worker = '{idworker}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();        
                }
            }
            database.closeConnection();
        }

        private void button5_delete_Click(object sender, EventArgs e)
        {
            deleteRow5();
        }

        private void button5_save_Click(object sender, EventArgs e)
        {
            Update5();
        }
        private void Change1()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var address = textBox_address.Text;
            int phone;

            if(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_phone.Text, out phone))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, address, phone);
                    dataGridView1.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
                    var changeQuery = $"update Autopark set AddressAutopark = '{address}', NumPhone = '{phone}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }
        private void button1_change_Click(object sender, EventArgs e)
        {
            Change1();
        }
        private void Change2()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var statenum = textBox_statenum.Text;
            var model = textBox_model.Text;
            var color = textBox_color.Text;
            var year = textBox_year.Text;
            var classCar = textBox_class.Text;
            var mileage = textBox_mileage.Text;
            var status = textBox_status.Text;
            var rental = textBox_rental.Text;
            var incost = textBox_incost.Text;
            int autoparkid;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_autoparkid.Text, out autoparkid))
                {
                    dataGridView2.Rows[selectedRowIndex].SetValues(statenum, model, color, year, classCar, mileage, status, rental, incost, autoparkid);
                    dataGridView2.Rows[selectedRowIndex].Cells[9].Value = RowState.Modified;
                    var changeQuery = $"update Car set model = '{model}', color = '{color}', year_of_issue = '{year}', class = '{classCar}', mileage = '{mileage}', statusCar = '{status}', rentalPrice = '{rental}', insuranceCost = '{incost}', Autoparkid = '{autoparkid}' where StateNum = '{statenum}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }
        private void button2_change_Click(object sender, EventArgs e)
        {
            Change2();
        }
        private void Change3()
        {
            var selectedRowIndex = dataGridView3.CurrentCell.RowIndex;
            var idclient = textBox_idclient.Text;
            var nameclient = textBox_nameclient.Text;
            var surclient = textBox_surclient.Text;
            var patclient = textBox_patclient.Text;
            var passport = textBox_passport.Text;
            var addressclient = textBox_addressclient.Text;
            var phoneclient = textBox_phoneclient.Text;
            int numcar;

            if (dataGridView3.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_numcar.Text, out numcar))
                {
                    dataGridView3.Rows[selectedRowIndex].SetValues(idclient, nameclient, surclient, patclient, passport, addressclient, phoneclient, numcar);
                    dataGridView3.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                    var changeQuery = $"update Client set client_name = '{nameclient}', client_surname = '{surclient}', client_patronymic = '{patclient}', Passport = '{passport}', AddressClient = '{addressclient}', PhoneNumClient = '{phoneclient}', carStateNum = '{numcar}' where id_client = '{idclient}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }
        private void button3_change_Click(object sender, EventArgs e)
        {
            Change3();
        }
        private void Change4()
        {
            var selectedRowIndex = dataGridView4.CurrentCell.RowIndex;
            var requestnum = textBox_request.Text;
            var date = textBox_date.Text;
            var days = textBox_days.Text;
            var idClient = textBox_clientid.Text;
            var idCar = textBox_carid.Text;
            int idWorker;

            if (dataGridView4.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_idworker.Text, out idWorker))
                {
                    dataGridView4.Rows[selectedRowIndex].SetValues(requestnum, date, days, idClient, idCar, idWorker);
                    dataGridView4.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;

                    var changeQuery = $"update Rental set DateOfIssue = '{date}', NumOfRentalDays = '{days}', Clientid = '{idClient}', Carid = '{idCar}', Workerid = '{idWorker}' where RequestNum = '{requestnum}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }
        private void button4_change_Click(object sender, EventArgs e)
        {
            Change4();
        }
        private void Change5()
        {
            var selectedRowIndex = dataGridView5.CurrentCell.RowIndex;
            var idworker = textBox_idworker.Text;
            var nameworker = textBox_nameworker.Text;
            var surworker = textBox_surworker.Text;
            var patworker = textBox_patworker.Text;
            var position = textBox_position.Text;
            var opermode = textBox_opermode.Text;
            var contact = textBox_phoneworker.Text;
           
            if (dataGridView5.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView5.Rows[selectedRowIndex].SetValues(idworker, nameworker, surworker, patworker, position, contact, opermode);
                dataGridView5.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                var changeQuery = $"update Worker set Worker_name= '{nameworker}', Worker_surname = '{surworker}', Worker_patronymic = '{patworker}', position = '{position}', contact = '{contact}', OperatingMode = '{opermode}' where id_worker = '{idworker}'";
                var command = new SqlCommand(changeQuery, database.getConnection());
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }
        private void button5_change_Click(object sender, EventArgs e)
        {
            Change5();
        }
        private void ClearFields()
        {

        }
    }
}