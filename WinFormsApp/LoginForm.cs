using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
            DB database = new DB();
    
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 55);
        }

        internal static void Restart()
        {
            string[] arguments = Environment.GetCommandLineArgs();
            Debug.Assert(arguments != null && arguments.Length > 0);
            StringBuilder sb = new StringBuilder((arguments.Length - 1) * 16);
            for (int argumentIndex = 1; argumentIndex < arguments.Length - 1; argumentIndex++)
            {
                sb.Append('"');
                sb.Append(arguments[argumentIndex]);
                sb.Append("\" ");
            }
            if (arguments.Length > 1)
            {
                sb.Append('"');
                sb.Append(arguments[arguments.Length - 1]);
                sb.Append('"');
            }
            ProcessStartInfo currentStartInfo = new ProcessStartInfo();
            currentStartInfo.FileName = Path.ChangeExtension(Application.ExecutablePath, "exe");
            if (sb.Length > 0)
            {
                currentStartInfo.Arguments = sb.ToString();
            }
            Application.Exit();
            Process.Start(currentStartInfo);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var loginUser = loginField.Text;
            var passUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '(loginUser)' and password_user = '(passUser)'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(loginUser == "admin")
            {
                MessageBox.Show("Выполнен вход. Успешно!","Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                frm1.Show();
            }
            else if (loginUser == "user")
            {
                MessageBox.Show("Выполнен вход. Успешно!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                frm2.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!","Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            database.closeConnection();
        }
    }
}
