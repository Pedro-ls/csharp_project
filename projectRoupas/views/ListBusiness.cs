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
    public partial class ListBusiness : Form
    {

        private int statusBuy;
        public ListBusiness()
        {
            InitializeComponent();

            this.statusBuy = 0;

            listBusinessUserProduct.AutoGenerateColumns = false;

            listBusinessUserProduct.ColumnCount = 6;

            listBusinessUserProduct.Columns[0].HeaderText = "id";
            listBusinessUserProduct.Columns[0].DataPropertyName = "id";

            listBusinessUserProduct.Columns[1].HeaderText = "usuario";
            listBusinessUserProduct.Columns[1].DataPropertyName = "user";

            listBusinessUserProduct.Columns[2].HeaderText = "descrição do produto";
            listBusinessUserProduct.Columns[2].DataPropertyName = "desc";

            listBusinessUserProduct.Columns[3].HeaderText = "cpf";
            listBusinessUserProduct.Columns[3].DataPropertyName = "cpf";

            listBusinessUserProduct.Columns[4].HeaderText = "preço";
            listBusinessUserProduct.Columns[4].DataPropertyName = "price";

            listBusinessUserProduct.Columns[5].HeaderText = "quantidade";
            listBusinessUserProduct.Columns[5].DataPropertyName = "qtd";


            deleteButtonBusiness.Enabled = false;
        }

        private void onRadioBuyTrue(object sender, EventArgs e)
        {
            this.statusBuy = 1;
            this.radioButton1.Checked = true;
            this.radioButton2.Checked = false;
        }
        private void onRadioBuyFalse(object sender, EventArgs e)
        {
            this.statusBuy = 0;
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = true;
        }

        private void deleteClick(object sender, EventArgs e)
        {

        }
    }
}
