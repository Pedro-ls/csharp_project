using projectRoupas.lib;
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

        private Cloth cloth;

        private int id_actual;

        public Venda()
        {


            InitializeComponent();

            qtd = 0;

            lblDescricao.Text = StateGlobal.ClothActual.Description_product;
            lblFornecedor.Text = StateGlobal.ClothActual.Provider;
            lblMarca.Text = StateGlobal.ClothActual.Brand;
            lblPreco.Text = StateGlobal.ClothActual.Price.ToString();

            pnlImgProduto.BackgroundImage = Image.FromFile(StateGlobal.ClothActual.Photo);

            id_actual = StateGlobal.ClothActual.IdCloth;

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

        private bool verify()
        {
            foreach (Cloth item in StateGlobal.clothes)
            {
                if (StateGlobal.ClothActual.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            if (StateGlobal.clothes != null)
            {

                if (!verify())
                {
                    StateGlobal.clothes.Add(StateGlobal.ClothActual);
                }

            }
            else
            {
                StateGlobal.clothes.Add(StateGlobal.ClothActual);
            }
          
        }
    }
}
