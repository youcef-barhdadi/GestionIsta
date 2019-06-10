namespace GestionIsta
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ServerNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataBaseName = new System.Windows.Forms.TextBox();
            this.btnSqlServer = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btntext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfiles = new System.Windows.Forms.TextBox();
            this.radioButtontextFile = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBosqlfile = new System.Windows.Forms.GroupBox();
            this.groupBoxsql = new System.Windows.Forms.GroupBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.groupBosqlfile.SuspendLayout();
            this.groupBoxsql.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SQL Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ServerNameTxt
            // 
            this.ServerNameTxt.Location = new System.Drawing.Point(30, 52);
            this.ServerNameTxt.Name = "ServerNameTxt";
            this.ServerNameTxt.Size = new System.Drawing.Size(167, 20);
            this.ServerNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DataBase Name";
            // 
            // DataBaseName
            // 
            this.DataBaseName.Location = new System.Drawing.Point(217, 52);
            this.DataBaseName.Name = "DataBaseName";
            this.DataBaseName.Size = new System.Drawing.Size(167, 20);
            this.DataBaseName.TabIndex = 3;
            // 
            // btnSqlServer
            // 
            this.btnSqlServer.Location = new System.Drawing.Point(400, 50);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Size = new System.Drawing.Size(60, 23);
            this.btnSqlServer.TabIndex = 5;
            this.btnSqlServer.Text = "Test Connection";
            this.btnSqlServer.UseVisualStyleBackColor = true;
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SQL File";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DataBase Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Path";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(17, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btntext
            // 
            this.btntext.Location = new System.Drawing.Point(434, 48);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(82, 23);
            this.btntext.TabIndex = 17;
            this.btntext.Text = "Test Connection";
            this.btntext.UseVisualStyleBackColor = true;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Creatre Files";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Path";
            // 
            // txtfiles
            // 
            this.txtfiles.Location = new System.Drawing.Point(17, 54);
            this.txtfiles.Name = "txtfiles";
            this.txtfiles.Size = new System.Drawing.Size(167, 20);
            this.txtfiles.TabIndex = 13;
            // 
            // radioButtontextFile
            // 
            this.radioButtontextFile.AutoSize = true;
            this.radioButtontextFile.Location = new System.Drawing.Point(42, 245);
            this.radioButtontextFile.Name = "radioButtontextFile";
            this.radioButtontextFile.Size = new System.Drawing.Size(65, 17);
            this.radioButtontextFile.TabIndex = 12;
            this.radioButtontextFile.TabStop = true;
            this.radioButtontextFile.Text = "Text File";
            this.radioButtontextFile.UseVisualStyleBackColor = true;
            this.radioButtontextFile.CheckedChanged += new System.EventHandler(this.radioButtontextFile_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Create ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(176, 306);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(325, 46);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Value = 5;
            // 
            // groupBosqlfile
            // 
            this.groupBosqlfile.Controls.Add(this.textBox4);
            this.groupBosqlfile.Controls.Add(this.label4);
            this.groupBosqlfile.Controls.Add(this.textBox3);
            this.groupBosqlfile.Controls.Add(this.label3);
            this.groupBosqlfile.Controls.Add(this.button1);
            this.groupBosqlfile.Location = new System.Drawing.Point(176, 108);
            this.groupBosqlfile.Name = "groupBosqlfile";
            this.groupBosqlfile.Size = new System.Drawing.Size(516, 90);
            this.groupBosqlfile.TabIndex = 20;
            this.groupBosqlfile.TabStop = false;
            this.groupBosqlfile.Text = "Sql File";
            // 
            // groupBoxsql
            // 
            this.groupBoxsql.Controls.Add(this.ServerNameTxt);
            this.groupBoxsql.Controls.Add(this.label1);
            this.groupBoxsql.Controls.Add(this.DataBaseName);
            this.groupBoxsql.Controls.Add(this.label2);
            this.groupBoxsql.Controls.Add(this.btnSqlServer);
            this.groupBoxsql.Location = new System.Drawing.Point(176, 12);
            this.groupBoxsql.Name = "groupBoxsql";
            this.groupBoxsql.Size = new System.Drawing.Size(516, 90);
            this.groupBoxsql.TabIndex = 21;
            this.groupBoxsql.TabStop = false;
            this.groupBoxsql.Text = "Sql server";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.label6);
            this.groupBoxFile.Controls.Add(this.txtfiles);
            this.groupBoxFile.Controls.Add(this.label5);
            this.groupBoxFile.Controls.Add(this.checkBox1);
            this.groupBoxFile.Controls.Add(this.btntext);
            this.groupBoxFile.Location = new System.Drawing.Point(170, 197);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(516, 90);
            this.groupBoxFile.TabIndex = 6;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Text Files ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 364);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxsql);
            this.Controls.Add(this.groupBosqlfile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioButtontextFile);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBosqlfile.ResumeLayout(false);
            this.groupBosqlfile.PerformLayout();
            this.groupBoxsql.ResumeLayout(false);
            this.groupBoxsql.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox ServerNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataBaseName;
        private System.Windows.Forms.Button btnSqlServer;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btntext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfiles;
        private System.Windows.Forms.RadioButton radioButtontextFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBosqlfile;
        private System.Windows.Forms.GroupBox groupBoxsql;
        private System.Windows.Forms.GroupBox groupBoxFile;
    }
}