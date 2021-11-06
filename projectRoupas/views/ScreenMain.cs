using projectRoupas.lib;
using projectRoupas.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace projectRoupas.views
{
    public partial class ScreenMain : Form
    {


        private List<Cloth> clothsLocals;

        private int numState;
        private int qtdCloths;


        public ScreenMain()
        {

            numState = 0;

            InitializeComponent();

            lblNameUser.Text = StateGlobal.user.Name;

            if (StateGlobal.user.TypeUser == "CLI")
            {
                privateClient();
                lblTypeUser.Text = "Cliente";
            }
            else
            {
                privateAdm();
                lblTypeUser.Text = "Administrador";
            }


            List<Cloth> list = new List<Cloth>();



            ClothModel model = new ClothModel();

            DataTable table =  model.all();
            Cloth cloth = null;
            foreach(DataRow row in table.Rows)
            {
                cloth = new Cloth();
                cloth.IdCloth = int.Parse(row.ItemArray.GetValue(0).ToString());
                cloth.Description_product = row.ItemArray.GetValue(1).ToString();
                cloth.Price = double.Parse(row.ItemArray.GetValue(2).ToString());
                cloth.Provider = row.ItemArray.GetValue(5).ToString();
                cloth.Photo = row.ItemArray.GetValue(4).ToString();
                cloth.Brand = row.ItemArray.GetValue(3).ToString();
                cloth.QtdInventory = int.Parse(row.ItemArray.GetValue(7).ToString());
                cloth.DatePost = DateTime.Parse(row.ItemArray.GetValue(6).ToString());

                list.Add(cloth);
                cloth = null;
            }

            clothsLocals = list;

            qtdCloths = clothsLocals.Count;

            accessCloth();
        }


        private void privateClient()
        {
            this.enterUser.Enabled = false;
            this.enterCloth.Enabled = false;

            this.enterLittleCar.Enabled = true;
            this.enterVenda.Enabled = true;
        }

        private void privateAdm()
        {
            this.enterUser.Enabled = true;
            this.enterCloth.Enabled = true;

            this.enterLittleCar.Enabled = false;
            this.enterVenda.Enabled = false;

            this.btnFinish.Enabled = false;
            this.btnLeft.Enabled = false;
            this.btnRight.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void ScreenMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StateGlobal.ClothActual = clothsLocals[numState];
            Venda screen = (new Venda());
                
            screen.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            (new Users()).Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

           
            (new Clothes()).Show();


        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            VendaModel model = new VendaModel();
            Business business;
            foreach (Cloth cl in StateGlobal.clothes)
            {
                business = new Business();
                business.User = StateGlobal.user;
                business.Cloth = cl;
                business.Date = DateTime.Now;
                business.Qtd = cl.QtdInventory;
                

                model.insert(business);
                business = null;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(numState > 0)
            {
                numState--;
            }
            accessCloth();

        }

        private void accessCloth()
        {
            this.lblPrice.Text = (clothsLocals[numState].Price).ToString();
            this.panelImage.BackgroundImage = Image.FromFile(clothsLocals[numState].Photo);
            this.lblBrand.Text = clothsLocals[numState].Brand;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (numState < qtdCloths-1)
            {
                numState++;
            }
            accessCloth();

        }
    }
}
