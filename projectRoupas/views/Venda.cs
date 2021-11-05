using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectRoupas.views
{
    public partial class Venda : Form
    {

        private int qtd;
        public Venda()
        {
            qtd = 0;
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(this.qtd > 0)
            {
                this.qtd--;
            }
            lblQtd.Text = ""+this.qtd+"";
            updateBuy();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.qtd++;
            lblQtd.Text = "" + this.qtd + "";
            updateBuy();
        }
        private void updateBuy()
        {

            string total = "" + int.Parse(lblQtd.Text) * double.Parse(this.lblPreco.Text) +"";            

            lblTotBuy.Text = String.Format("{0:.2f}", total);
        }
    }
}
