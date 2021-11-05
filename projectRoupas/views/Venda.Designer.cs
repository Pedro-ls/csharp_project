namespace projectRoupas.views
{
    partial class Venda
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.pnlImgProduto = new System.Windows.Forms.Panel();
            this.lblQtd = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.TextBox();
            this.lblTotBuy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(455, 390);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(257, 55);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // pnlImgProduto
            // 
            this.pnlImgProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlImgProduto.Location = new System.Drawing.Point(455, 43);
            this.pnlImgProduto.Name = "pnlImgProduto";
            this.pnlImgProduto.Size = new System.Drawing.Size(257, 307);
            this.pnlImgProduto.TabIndex = 1;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(132, 372);
            this.lblQtd.Multiline = true;
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(88, 47);
            this.lblQtd.TabIndex = 2;
            this.lblQtd.Text = "0";
            this.lblQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.DarkRed;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(61, 372);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 47);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(226, 372);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 47);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Custo Total: ";
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDescricao.Location = new System.Drawing.Point(19, 43);
            this.lblDescricao.Multiline = true;
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.ReadOnly = true;
            this.lblDescricao.Size = new System.Drawing.Size(375, 107);
            this.lblDescricao.TabIndex = 10;
            // 
            // lblPreco
            // 
            this.lblPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPreco.Location = new System.Drawing.Point(19, 187);
            this.lblPreco.Multiline = true;
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.ReadOnly = true;
            this.lblPreco.Size = new System.Drawing.Size(375, 31);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "200.50";
            // 
            // lblMarca
            // 
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMarca.Location = new System.Drawing.Point(19, 251);
            this.lblMarca.Multiline = true;
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.ReadOnly = true;
            this.lblMarca.Size = new System.Drawing.Size(375, 31);
            this.lblMarca.TabIndex = 12;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFornecedor.Location = new System.Drawing.Point(19, 319);
            this.lblFornecedor.Multiline = true;
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.ReadOnly = true;
            this.lblFornecedor.Size = new System.Drawing.Size(375, 31);
            this.lblFornecedor.TabIndex = 13;
            // 
            // lblTotBuy
            // 
            this.lblTotBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotBuy.Location = new System.Drawing.Point(196, 434);
            this.lblTotBuy.Multiline = true;
            this.lblTotBuy.Name = "lblTotBuy";
            this.lblTotBuy.ReadOnly = true;
            this.lblTotBuy.Size = new System.Drawing.Size(110, 33);
            this.lblTotBuy.TabIndex = 14;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(737, 479);
            this.Controls.Add(this.lblTotBuy);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.pnlImgProduto);
            this.Controls.Add(this.btnBuy);
            this.Name = "Venda";
            this.Text = "Venda de Roupa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel pnlImgProduto;
        private System.Windows.Forms.TextBox lblQtd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblDescricao;
        private System.Windows.Forms.TextBox lblPreco;
        private System.Windows.Forms.TextBox lblMarca;
        private System.Windows.Forms.TextBox lblFornecedor;
        private System.Windows.Forms.TextBox lblTotBuy;
    }
}

