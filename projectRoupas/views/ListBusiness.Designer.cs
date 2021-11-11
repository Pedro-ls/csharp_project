namespace projectRoupas.views
{
    partial class ListBusiness
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
            this.listBusinessUserProduct = new System.Windows.Forms.DataGridView();
            this.status_buy = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.imageProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButtonBusiness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listBusinessUserProduct)).BeginInit();
            this.imageProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBusinessUserProduct
            // 
            this.listBusinessUserProduct.AllowUserToAddRows = false;
            this.listBusinessUserProduct.AllowUserToDeleteRows = false;
            this.listBusinessUserProduct.AllowUserToOrderColumns = true;
            this.listBusinessUserProduct.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBusinessUserProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBusinessUserProduct.Location = new System.Drawing.Point(237, 28);
            this.listBusinessUserProduct.Name = "listBusinessUserProduct";
            this.listBusinessUserProduct.ReadOnly = true;
            this.listBusinessUserProduct.Size = new System.Drawing.Size(507, 349);
            this.listBusinessUserProduct.TabIndex = 0;
            // 
            // status_buy
            // 
            this.status_buy.AutoSize = true;
            this.status_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_buy.ForeColor = System.Drawing.Color.White;
            this.status_buy.Location = new System.Drawing.Point(12, 21);
            this.status_buy.Name = "status_buy";
            this.status_buy.Size = new System.Drawing.Size(115, 20);
            this.status_buy.TabIndex = 1;
            this.status_buy.Text = "status de pago";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(29, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "pago";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.onRadioBuyTrue);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(29, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "pendente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.onRadioBuyFalse);
            // 
            // imageProduct
            // 
            this.imageProduct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imageProduct.Controls.Add(this.label1);
            this.imageProduct.Location = new System.Drawing.Point(16, 119);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.Size = new System.Drawing.Size(200, 258);
            this.imageProduct.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "aqui vai uma imagem do produto";
            // 
            // deleteButtonBusiness
            // 
            this.deleteButtonBusiness.BackColor = System.Drawing.Color.Red;
            this.deleteButtonBusiness.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButtonBusiness.ForeColor = System.Drawing.Color.White;
            this.deleteButtonBusiness.Location = new System.Drawing.Point(602, 383);
            this.deleteButtonBusiness.Name = "deleteButtonBusiness";
            this.deleteButtonBusiness.Size = new System.Drawing.Size(142, 45);
            this.deleteButtonBusiness.TabIndex = 5;
            this.deleteButtonBusiness.Text = "Apagar";
            this.deleteButtonBusiness.UseVisualStyleBackColor = false;
            this.deleteButtonBusiness.Click += new System.EventHandler(this.deleteClick);
            // 
            // ListBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(779, 440);
            this.Controls.Add(this.deleteButtonBusiness);
            this.Controls.Add(this.imageProduct);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.status_buy);
            this.Controls.Add(this.listBusinessUserProduct);
            this.Name = "ListBusiness";
            this.Text = "Venda produtos comprados por usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.listBusinessUserProduct)).EndInit();
            this.imageProduct.ResumeLayout(false);
            this.imageProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listBusinessUserProduct;
        private System.Windows.Forms.Label status_buy;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel imageProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButtonBusiness;
    }
}