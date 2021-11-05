namespace projectRoupas.views
{
    partial class Clothes
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
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdInventary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panelPhotoCloth = new System.Windows.Forms.Panel();
            this.btnUpdateClothes = new System.Windows.Forms.Button();
            this.btnCreateClothes = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.listTableClothes = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSeachTextId = new System.Windows.Forms.TextBox();
            this.btnSerachUserId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listTableClothes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProvider
            // 
            this.txtProvider.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtProvider.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvider.Location = new System.Drawing.Point(30, 268);
            this.txtProvider.Multiline = true;
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(265, 35);
            this.txtProvider.TabIndex = 27;
            this.txtProvider.UseSystemPasswordChar = true;
            this.txtProvider.DragOver += new System.Windows.Forms.DragEventHandler(this.updateBorder);
            this.txtProvider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateBorderDown);
            this.txtProvider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateBorder);
            this.txtProvider.Move += new System.EventHandler(this.updateBorder);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "provider";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBrand.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(30, 152);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(265, 34);
            this.txtBrand.TabIndex = 26;
            this.txtBrand.DragOver += new System.Windows.Forms.DragEventHandler(this.updateBorder);
            this.txtBrand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateBorderDown);
            this.txtBrand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateBorder);
            this.txtBrand.Move += new System.EventHandler(this.updateBorder);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "quantity inventary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "description";
            // 
            // txtQtdInventary
            // 
            this.txtQtdInventary.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtQtdInventary.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdInventary.Location = new System.Drawing.Point(30, 209);
            this.txtQtdInventary.Multiline = true;
            this.txtQtdInventary.Name = "txtQtdInventary";
            this.txtQtdInventary.Size = new System.Drawing.Size(265, 35);
            this.txtQtdInventary.TabIndex = 20;
            this.txtQtdInventary.DragOver += new System.Windows.Forms.DragEventHandler(this.updateBorder);
            this.txtQtdInventary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateBorderDown);
            this.txtQtdInventary.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateBorder);
            this.txtQtdInventary.Move += new System.EventHandler(this.updateBorder);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrice.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(30, 328);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(265, 35);
            this.txtPrice.TabIndex = 30;
            this.txtPrice.DragOver += new System.Windows.Forms.DragEventHandler(this.updateBorder);
            this.txtPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateBorderDown);
            this.txtPrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateBorder);
            this.txtPrice.Move += new System.EventHandler(this.updateBorder);
            // 
            // panelPhotoCloth
            // 
            this.panelPhotoCloth.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPhotoCloth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPhotoCloth.ForeColor = System.Drawing.Color.Coral;
            this.panelPhotoCloth.Location = new System.Drawing.Point(335, 39);
            this.panelPhotoCloth.Name = "panelPhotoCloth";
            this.panelPhotoCloth.Size = new System.Drawing.Size(215, 307);
            this.panelPhotoCloth.TabIndex = 32;
            this.panelPhotoCloth.Click += new System.EventHandler(this.UploadClick_method);
            // 
            // btnUpdateClothes
            // 
            this.btnUpdateClothes.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateClothes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClothes.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClothes.Location = new System.Drawing.Point(575, 361);
            this.btnUpdateClothes.Name = "btnUpdateClothes";
            this.btnUpdateClothes.Size = new System.Drawing.Size(114, 37);
            this.btnUpdateClothes.TabIndex = 35;
            this.btnUpdateClothes.Text = "Atualizar";
            this.btnUpdateClothes.UseVisualStyleBackColor = false;
            this.btnUpdateClothes.Click += new System.EventHandler(this.btnUpdateClothes_Click);
            // 
            // btnCreateClothes
            // 
            this.btnCreateClothes.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreateClothes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClothes.ForeColor = System.Drawing.Color.White;
            this.btnCreateClothes.Location = new System.Drawing.Point(453, 361);
            this.btnCreateClothes.Name = "btnCreateClothes";
            this.btnCreateClothes.Size = new System.Drawing.Size(114, 37);
            this.btnCreateClothes.TabIndex = 34;
            this.btnCreateClothes.Text = "Cadastrar";
            this.btnCreateClothes.UseVisualStyleBackColor = false;
            this.btnCreateClothes.Click += new System.EventHandler(this.btnCreateClothes_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescription.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(30, 39);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 89);
            this.txtDescription.TabIndex = 36;
            this.txtDescription.DragOver += new System.Windows.Forms.DragEventHandler(this.updateBorder);
            this.txtDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateBorderDown);
            this.txtDescription.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateBorder);
            this.txtDescription.Move += new System.EventHandler(this.updateBorder);
            // 
            // listTableClothes
            // 
            this.listTableClothes.AllowUserToAddRows = false;
            this.listTableClothes.AllowUserToDeleteRows = false;
            this.listTableClothes.AllowUserToOrderColumns = true;
            this.listTableClothes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listTableClothes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTableClothes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listTableClothes.Location = new System.Drawing.Point(587, 85);
            this.listTableClothes.Name = "listTableClothes";
            this.listTableClothes.ReadOnly = true;
            this.listTableClothes.Size = new System.Drawing.Size(459, 261);
            this.listTableClothes.TabIndex = 37;
            this.listTableClothes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clicked_table_cell_method);
            this.listTableClothes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTableClothes_CellContentClick);
            this.listTableClothes.RowDividerDoubleClick += new System.Windows.Forms.DataGridViewRowDividerDoubleClickEventHandler(this.select_clothes_method);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(697, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 37);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Apagar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClick_method);
            // 
            // txtSeachTextId
            // 
            this.txtSeachTextId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSeachTextId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeachTextId.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachTextId.Location = new System.Drawing.Point(587, 39);
            this.txtSeachTextId.Multiline = true;
            this.txtSeachTextId.Name = "txtSeachTextId";
            this.txtSeachTextId.Size = new System.Drawing.Size(388, 29);
            this.txtSeachTextId.TabIndex = 39;
            this.txtSeachTextId.TextChanged += new System.EventHandler(this.txtSeachTextId_TextChanged);
            this.txtSeachTextId.DragOver += new System.Windows.Forms.DragEventHandler(this.updateBorder);
            this.txtSeachTextId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.updateBorderDown);
            this.txtSeachTextId.MouseUp += new System.Windows.Forms.MouseEventHandler(this.updateBorder);
            this.txtSeachTextId.Move += new System.EventHandler(this.updateBorder);
            // 
            // btnSerachUserId
            // 
            this.btnSerachUserId.BackColor = System.Drawing.Color.Blue;
            this.btnSerachUserId.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerachUserId.ForeColor = System.Drawing.Color.White;
            this.btnSerachUserId.Location = new System.Drawing.Point(965, 39);
            this.btnSerachUserId.Name = "btnSerachUserId";
            this.btnSerachUserId.Size = new System.Drawing.Size(92, 29);
            this.btnSerachUserId.TabIndex = 40;
            this.btnSerachUserId.Text = "Consultar";
            this.btnSerachUserId.UseVisualStyleBackColor = false;
            this.btnSerachUserId.Click += new System.EventHandler(this.btnSerachUserId_Click);
            // 
            // Clothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1058, 491);
            this.Controls.Add(this.btnSerachUserId);
            this.Controls.Add(this.txtSeachTextId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listTableClothes);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnUpdateClothes);
            this.Controls.Add(this.btnCreateClothes);
            this.Controls.Add(this.panelPhotoCloth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdInventary);
            this.Name = "Clothes";
            this.Text = "Clothes";
            this.Load += new System.EventHandler(this.Clothes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTableClothes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdInventary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panelPhotoCloth;
        private System.Windows.Forms.Button btnUpdateClothes;
        private System.Windows.Forms.Button btnCreateClothes;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView listTableClothes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSeachTextId;
        private System.Windows.Forms.Button btnSerachUserId;
    }
}