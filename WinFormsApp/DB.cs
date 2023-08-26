using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=JUPITER;Initial Catalog=Autopark2;Integrated Security=True");
        
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try { 
                    sqlConnection.Open();
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения с БД!");
                    LoginForm.Restart();
                }
             
            }
        }
  
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
    
}