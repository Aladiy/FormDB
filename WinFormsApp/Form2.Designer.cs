
namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_usersearchAutopark = new System.Windows.Forms.TextBox();
            this.dataGridView1_user = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_usersearchCar = new System.Windows.Forms.TextBox();
            this.dataGridView2_user = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_usersearchClient = new System.Windows.Forms.TextBox();
            this.dataGridView3_user = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_usersearchRental = new System.Windows.Forms.TextBox();
            this.dataGridView4_user = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_usersearchWorker = new System.Windows.Forms.TextBox();
            this.dataGridView5_user = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_user)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_user)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_user)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4_user)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5_user)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(21, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1102, 542);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_usersearchAutopark);
            this.tabPage1.Controls.Add(this.dataGridView1_user);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1094, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автопарк";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(685, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Поиск по таблице Автопарк:";
            // 
            // textBox_usersearchAutopark
            // 
            this.textBox_usersearchAutopark.Location = new System.Drawing.Point(685, 101);
            this.textBox_usersearchAutopark.Name = "textBox_usersearchAutopark";
            this.textBox_usersearchAutopark.Size = new System.Drawing.Size(283, 27);
            this.textBox_usersearchAutopark.TabIndex = 8;
            this.textBox_usersearchAutopark.TextChanged += new System.EventHandler(this.textBox_usersearchAutopark_TextChanged);
            // 
            // dataGridView1_user
            // 
            this.dataGridView1_user.AllowUserToAddRows = false;
            this.dataGridView1_user.AllowUserToDeleteRows = false;
            this.dataGridView1_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_user.Location = new System.Drawing.Point(6, 2);
            this.dataGridView1_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1_user.Name = "dataGridView1_user";
            this.dataGridView1_user.ReadOnly = true;
            this.dataGridView1_user.RowHeadersWidth = 51;
            this.dataGridView1_user.RowTemplate.Height = 29;
            this.dataGridView1_user.Size = new System.Drawing.Size(555, 259);
            this.dataGridView1_user.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox_usersearchCar);
            this.tabPage2.Controls.Add(this.dataGridView2_user);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1094, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автомобиль";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WinFormsApp1.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(395, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск по таблице Автомобиль:";
            // 
            // textBox_usersearchCar
            // 
            this.textBox_usersearchCar.Location = new System.Drawing.Point(395, 372);
            this.textBox_usersearchCar.Name = "textBox_usersearchCar";
            this.textBox_usersearchCar.Size = new System.Drawing.Size(283, 27);
            this.textBox_usersearchCar.TabIndex = 8;
            this.textBox_usersearchCar.TextChanged += new System.EventHandler(this.textBox_usersearchCar_TextChanged);
            // 
            // dataGridView2_user
            // 
            this.dataGridView2_user.AllowUserToAddRows = false;
            this.dataGridView2_user.AllowUserToDeleteRows = false;
            this.dataGridView2_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_user.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2_user.Name = "dataGridView2_user";
            this.dataGridView2_user.ReadOnly = true;
            this.dataGridView2_user.RowHeadersWidth = 51;
            this.dataGridView2_user.RowTemplate.Height = 29;
            this.dataGridView2_user.Size = new System.Drawing.Size(1060, 259);
            this.dataGridView2_user.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox_usersearchClient);
            this.tabPage3.Controls.Add(this.dataGridView3_user);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1094, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиент";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WinFormsApp1.Properties.Resources.search;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(404, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поиск по таблице Клиент:";
            // 
            // textBox_usersearchClient
            // 
            this.textBox_usersearchClient.Location = new System.Drawing.Point(404, 385);
            this.textBox_usersearchClient.Name = "textBox_usersearchClient";
            this.textBox_usersearchClient.Size = new System.Drawing.Size(283, 27);
            this.textBox_usersearchClient.TabIndex = 8;
            this.textBox_usersearchClient.TextChanged += new System.EventHandler(this.textBox_usersearchClient_TextChanged);
            // 
            // dataGridView3_user
            // 
            this.dataGridView3_user.AllowUserToAddRows = false;
            this.dataGridView3_user.AllowUserToDeleteRows = false;
            this.dataGridView3_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3_user.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3_user.Name = "dataGridView3_user";
            this.dataGridView3_user.ReadOnly = true;
            this.dataGridView3_user.RowHeadersWidth = 51;
            this.dataGridView3_user.RowTemplate.Height = 29;
            this.dataGridView3_user.Size = new System.Drawing.Size(1060, 259);
            this.dataGridView3_user.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox_usersearchRental);
            this.tabPage4.Controls.Add(this.dataGridView4_user);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1094, 509);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Прокат";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WinFormsApp1.Properties.Resources.search;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(392, 336);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 36);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Поиск по таблице Прокат:";
            // 
            // textBox_usersearchRental
            // 
            this.textBox_usersearchRental.Location = new System.Drawing.Point(406, 380);
            this.textBox_usersearchRental.Name = "textBox_usersearchRental";
            this.textBox_usersearchRental.Size = new System.Drawing.Size(283, 27);
            this.textBox_usersearchRental.TabIndex = 8;
            this.textBox_usersearchRental.TextChanged += new System.EventHandler(this.textBox_usersearchRental_TextChanged);
            // 
            // dataGridView4_user
            // 
            this.dataGridView4_user.AllowUserToAddRows = false;
            this.dataGridView4_user.AllowUserToDeleteRows = false;
            this.dataGridView4_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4_user.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4_user.Name = "dataGridView4_user";
            this.dataGridView4_user.ReadOnly = true;
            this.dataGridView4_user.RowHeadersWidth = 51;
            this.dataGridView4_user.RowTemplate.Height = 29;
            this.dataGridView4_user.Size = new System.Drawing.Size(912, 259);
            this.dataGridView4_user.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage5.Controls.Add(this.pictureBox5);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBox_usersearchWorker);
            this.tabPage5.Controls.Add(this.dataGridView5_user);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(1094, 509);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Работник";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WinFormsApp1.Properties.Resources.search;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(407, 338);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поиск по таблице Работник:";
            // 
            // textBox_usersearchWorker
            // 
            this.textBox_usersearchWorker.Location = new System.Drawing.Point(407, 380);
            this.textBox_usersearchWorker.Name = "textBox_usersearchWorker";
            this.textBox_usersearchWorker.Size = new System.Drawing.Size(283, 27);
            this.textBox_usersearchWorker.TabIndex = 8;
            this.textBox_usersearchWorker.TextChanged += new System.EventHandler(this.textBox_usersearchWorker_TextChanged);
            // 
            // dataGridView5_user
            // 
            this.dataGridView5_user.AllowUserToAddRows = false;
            this.dataGridView5_user.AllowUserToDeleteRows = false;
            this.dataGridView5_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5_user.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView5_user.Name = "dataGridView5_user";
            this.dataGridView5_user.ReadOnly = true;
            this.dataGridView5_user.RowHeadersWidth = 51;
            this.dataGridView5_user.RowTemplate.Height = 29;
            this.dataGridView5_user.Size = new System.Drawing.Size(985, 259);
            this.dataGridView5_user.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 586);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_user)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_user)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_user)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4_user)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1_user;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2_user;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3_user;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4_user;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_usersearchAutopark;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usersearchCar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_usersearchClient;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_usersearchRental;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_usersearchWorker;
    }
}