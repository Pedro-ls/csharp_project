namespace projectRoupas.views
{
    partial class Users
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.radioCli = new System.Windows.Forms.RadioButton();
            this.radioAdm = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.listTableUsers = new System.Windows.Forms.DataGridView();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.btnCreateUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listTableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(31, 45);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 35);
            this.txtName.TabIndex = 4;
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(31, 206);
            this.txtCredit.Multiline = true;
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(274, 35);
            this.txtCredit.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(31, 153);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(274, 35);
            this.txtCpf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cartâo de crédito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(31, 99);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(274, 34);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(31, 260);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 35);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // radioCli
            // 
            this.radioCli.AutoSize = true;
            this.radioCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCli.ForeColor = System.Drawing.Color.White;
            this.radioCli.Location = new System.Drawing.Point(31, 347);
            this.radioCli.Name = "radioCli";
            this.radioCli.Size = new System.Drawing.Size(76, 24);
            this.radioCli.TabIndex = 21;
            this.radioCli.TabStop = true;
            this.radioCli.Text = "Cliente";
            this.radioCli.UseVisualStyleBackColor = true;
            this.radioCli.Click += new System.EventHandler(this.clickedCliRadioMethod);
            // 
            // radioAdm
            // 
            this.radioAdm.AutoSize = true;
            this.radioAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdm.ForeColor = System.Drawing.Color.White;
            this.radioAdm.Location = new System.Drawing.Point(31, 371);
            this.radioAdm.Name = "radioAdm";
            this.radioAdm.Size = new System.Drawing.Size(125, 24);
            this.radioAdm.TabIndex = 22;
            this.radioAdm.TabStop = true;
            this.radioAdm.Text = "Administrador";
            this.radioAdm.UseVisualStyleBackColor = true;
            this.radioAdm.Click += new System.EventHandler(this.clickedAdmRadioMethod);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "birth date";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(31, 312);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(274, 26);
            this.txtDate.TabIndex = 30;
            // 
            // listTableUsers
            // 
            this.listTableUsers.AllowUserToAddRows = false;
            this.listTableUsers.AllowUserToDeleteRows = false;
            this.listTableUsers.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listTableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTableUsers.GridColor = System.Drawing.Color.DarkSlateGray;
            this.listTableUsers.Location = new System.Drawing.Point(326, 41);
            this.listTableUsers.Name = "listTableUsers";
            this.listTableUsers.ReadOnly = true;
            this.listTableUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listTableUsers.Size = new System.Drawing.Size(548, 289);
            this.listTableUsers.TabIndex = 32;
            this.listTableUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTableCell_method);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUsers.Location = new System.Drawing.Point(572, 345);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(128, 37);
            this.btnDeleteUsers.TabIndex = 41;
            this.btnDeleteUsers.Text = "Apagar";
            this.btnDeleteUsers.UseVisualStyleBackColor = false;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUsers.Location = new System.Drawing.Point(450, 345);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(114, 37);
            this.btnUpdateUsers.TabIndex = 40;
            this.btnUpdateUsers.Text = "Atualizar";
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnCreateUsers
            // 
            this.btnCreateUsers.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreateUsers.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUsers.ForeColor = System.Drawing.Color.White;
            this.btnCreateUsers.Location = new System.Drawing.Point(328, 345);
            this.btnCreateUsers.Name = "btnCreateUsers";
            this.btnCreateUsers.Size = new System.Drawing.Size(114, 37);
            this.btnCreateUsers.TabIndex = 39;
            this.btnCreateUsers.Text = "Cadastrar";
            this.btnCreateUsers.UseVisualStyleBackColor = false;
            this.btnCreateUsers.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(901, 407);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnUpdateUsers);
            this.Controls.Add(this.btnCreateUsers);
            this.Controls.Add(this.listTableUsers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.radioAdm);
            this.Controls.Add(this.radioCli);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtName);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton radioCli;
        private System.Windows.Forms.RadioButton radioAdm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DataGridView listTableUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Button btnCreateUsers;
    }
}