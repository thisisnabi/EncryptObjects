namespace EncryptObjects
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFunctions = new System.Windows.Forms.CheckBox();
            this.chkProcedures = new System.Windows.Forms.CheckBox();
            this.chkViews = new System.Windows.Forms.CheckBox();
            this.btnCheckConnecition = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(116, 339);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(96, 35);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catalog :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password :";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(112, 35);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(304, 31);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "192.168.8.55\\MSSQLSERVER2019";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(112, 85);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(304, 31);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.Text = "Bargh0623";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(304, 31);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(304, 31);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "nk@2089tt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "BEFORE YOU DO THIS, TAKE A BACKUP!!!!!!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Database Connection ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFunctions);
            this.groupBox2.Controls.Add(this.chkProcedures);
            this.groupBox2.Controls.Add(this.chkViews);
            this.groupBox2.Location = new System.Drawing.Point(469, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 243);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Objects ";
            // 
            // chkFunctions
            // 
            this.chkFunctions.AutoSize = true;
            this.chkFunctions.Location = new System.Drawing.Point(20, 116);
            this.chkFunctions.Name = "chkFunctions";
            this.chkFunctions.Size = new System.Drawing.Size(107, 29);
            this.chkFunctions.TabIndex = 0;
            this.chkFunctions.Text = "Functions";
            this.chkFunctions.UseVisualStyleBackColor = true;
            // 
            // chkProcedures
            // 
            this.chkProcedures.AutoSize = true;
            this.chkProcedures.Location = new System.Drawing.Point(20, 81);
            this.chkProcedures.Name = "chkProcedures";
            this.chkProcedures.Size = new System.Drawing.Size(119, 29);
            this.chkProcedures.TabIndex = 0;
            this.chkProcedures.Text = "Procedures";
            this.chkProcedures.UseVisualStyleBackColor = true;
            // 
            // chkViews
            // 
            this.chkViews.AutoSize = true;
            this.chkViews.Location = new System.Drawing.Point(20, 46);
            this.chkViews.Name = "chkViews";
            this.chkViews.Size = new System.Drawing.Size(76, 29);
            this.chkViews.TabIndex = 0;
            this.chkViews.Text = "Views";
            this.chkViews.UseVisualStyleBackColor = true;
            // 
            // btnCheckConnecition
            // 
            this.btnCheckConnecition.Location = new System.Drawing.Point(12, 339);
            this.btnCheckConnecition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckConnecition.Name = "btnCheckConnecition";
            this.btnCheckConnecition.Size = new System.Drawing.Size(96, 35);
            this.btnCheckConnecition.TabIndex = 0;
            this.btnCheckConnecition.Text = "Check";
            this.btnCheckConnecition.UseVisualStyleBackColor = true;
            this.btnCheckConnecition.Click += new System.EventHandler(this.btnCheckConnecition_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(220, 339);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(96, 35);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 671);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCheckConnecition);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt Sql Server Database Objects";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEncrypt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtDatabase;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkFunctions;
        private CheckBox chkProcedures;
        private CheckBox chkViews;
        private Button btnCheckConnecition;
        private Button btnDecrypt;
    }
}