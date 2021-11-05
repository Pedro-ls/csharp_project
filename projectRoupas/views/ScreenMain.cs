using projectRoupas.lib;
using System;
using System.Windows.Forms;

namespace projectRoupas.views
{
    public partial class ScreenMain : Form
    {



        public ScreenMain()
        {

            InitializeComponent();

            MessageBox.Show(StateGlobal.user.Name);

            privateAdm();
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
            (new Venda()).Show();
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

        }
    }
}
