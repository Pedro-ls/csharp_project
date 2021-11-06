using projectRoupas.lib;

namespace projectRoupas.views
{
    partial class ScreenMain
    {

        private User user;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.enterUser = new System.Windows.Forms.ToolStripButton();
            this.enterVenda = new System.Windows.Forms.ToolStripButton();
            this.enterCloth = new System.Windows.Forms.ToolStripButton();
            this.enterLittleCar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTypeUser = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterUser,
            this.enterVenda,
            this.enterCloth,
            this.enterLittleCar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(769, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // enterUser
            // 
            this.enterUser.BackColor = System.Drawing.Color.Transparent;
            this.enterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUser.ForeColor = System.Drawing.Color.White;
            this.enterUser.Image = global::projectRoupas.Properties.Resources.user;
            this.enterUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterUser.Name = "enterUser";
            this.enterUser.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.enterUser.RightToLeftAutoMirrorImage = true;
            this.enterUser.Size = new System.Drawing.Size(102, 37);
            this.enterUser.Text = "Usuário";
            this.enterUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enterUser.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // enterVenda
            // 
            this.enterVenda.BackColor = System.Drawing.Color.Transparent;
            this.enterVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterVenda.ForeColor = System.Drawing.Color.White;
            this.enterVenda.Image = global::projectRoupas.Properties.Resources.carrinho;
            this.enterVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterVenda.Name = "enterVenda";
            this.enterVenda.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.enterVenda.RightToLeftAutoMirrorImage = true;
            this.enterVenda.Size = new System.Drawing.Size(94, 37);
            this.enterVenda.Text = "Venda";
            this.enterVenda.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // enterCloth
            // 
            this.enterCloth.BackColor = System.Drawing.Color.Transparent;
            this.enterCloth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCloth.ForeColor = System.Drawing.Color.White;
            this.enterCloth.Image = global::projectRoupas.Properties.Resources.roupa;
            this.enterCloth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterCloth.Name = "enterCloth";
            this.enterCloth.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.enterCloth.RightToLeftAutoMirrorImage = true;
            this.enterCloth.Size = new System.Drawing.Size(94, 37);
            this.enterCloth.Text = "Roupa";
            this.enterCloth.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // enterLittleCar
            // 
            this.enterLittleCar.BackColor = System.Drawing.Color.SeaGreen;
            this.enterLittleCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enterLittleCar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLittleCar.ForeColor = System.Drawing.Color.White;
            this.enterLittleCar.Image = ((System.Drawing.Image)(resources.GetObject("enterLittleCar.Image")));
            this.enterLittleCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterLittleCar.Name = "enterLittleCar";
            this.enterLittleCar.Padding = new System.Windows.Forms.Padding(4);
            this.enterLittleCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enterLittleCar.Size = new System.Drawing.Size(98, 37);
            this.enterLittleCar.Text = "Carrinho";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblTypeUser);
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Location = new System.Drawing.Point(16, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 194);
            this.panel1.TabIndex = 1;
            // 
            // lblTypeUser
            // 
            this.lblTypeUser.AutoSize = true;
            this.lblTypeUser.ForeColor = System.Drawing.Color.White;
            this.lblTypeUser.Location = new System.Drawing.Point(12, 47);
            this.lblTypeUser.Name = "lblTypeUser";
            this.lblTypeUser.Size = new System.Drawing.Size(45, 24);
            this.lblTypeUser.TabIndex = 1;
            this.lblTypeUser.Text = "type";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.ForeColor = System.Drawing.Color.White;
            this.lblNameUser.Location = new System.Drawing.Point(12, 12);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(49, 24);
            this.lblNameUser.TabIndex = 0;
            this.lblNameUser.Text = "User";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.lblBrand);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnLeft);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnRight);
            this.panel3.Controls.Add(this.panelImage);
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 361);
            this.panel3.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrand.Location = new System.Drawing.Point(103, 205);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 24);
            this.lblBrand.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(103, 166);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 24);
            this.lblPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "preço";
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLeft.Location = new System.Drawing.Point(381, 40);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 269);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(381, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 325);
            this.panel4.TabIndex = 6;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRight.Location = new System.Drawing.Point(682, 40);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 269);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.BlueViolet;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.Location = new System.Drawing.Point(424, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(252, 325);
            this.panelImage.TabIndex = 3;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Crimson;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(16, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(232, 36);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Finalizar Compra";
            this.btnFinish.UseMnemonic = false;
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(682, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 325);
            this.panel5.TabIndex = 7;
            // 
            // ScreenMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ScreenMain";
            this.Text = "ScreenMain";
            this.Load += new System.EventHandler(this.ScreenMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton enterUser;
        private System.Windows.Forms.ToolStripButton enterVenda;
        private System.Windows.Forms.ToolStripButton enterCloth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTypeUser;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.ToolStripButton enterLittleCar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}