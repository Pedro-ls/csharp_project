using projectRoupas.lib;
using projectRoupas.models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace projectRoupas.views
{
    public partial class Users : Form
    {

        private string pass;
        private string radioSelectedType;
        private int idSelected;
        private int indexSelect;

        public Users()
        {
            InitializeComponent();

            listTableUsers.AutoGenerateColumns = false;

            listTableUsers.ColumnCount = 7;

            listTableUsers.Columns[0].HeaderText = "id";
            listTableUsers.Columns[0].DataPropertyName = "id";

            listTableUsers.Columns[1].HeaderText = "nome";
            listTableUsers.Columns[1].DataPropertyName = "name";

            listTableUsers.Columns[2].HeaderText = "username";
            listTableUsers.Columns[2].DataPropertyName = "username";

            listTableUsers.Columns[3].HeaderText = "cpf";
            listTableUsers.Columns[3].DataPropertyName = "cpf";

            listTableUsers.Columns[4].HeaderText = "data de aniversario";
            listTableUsers.Columns[4].DataPropertyName = "date_birthday";

            listTableUsers.Columns[5].HeaderText = "cartão de credito";
            listTableUsers.Columns[5].DataPropertyName = "creditCard";

            listTableUsers.Columns[6].HeaderText = "tipo de usuario";
            listTableUsers.Columns[6].DataPropertyName = "typeUser";

            updateTable();
            disableButtons();

            
        }

        private void updateTable()
        {
            listTableUsers.DataSource = (new UserModel()).all();

            int value = 1;

            foreach(DataGridViewRow i in listTableUsers.Rows)
            {
                if(value == 1)
                {
                    i.DefaultCellStyle.BackColor = Color.Gray;

                    value--;

                }
                else if(value == 0)
                {
                    i.DefaultCellStyle.BackColor = Color.LightGray;
                    value++;
                }
            }
        }

        private void cleanFields()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCredit.Text = "";
            txtCpf.Text = "";
            txtDate.Text = "";
            radioSelectedType = "";

            radioAdm.Checked = false;
            radioCli.Checked = false;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (radioSelectedType == "CLI")
            {
                user.Name = txtName.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.CreditCard = txtCredit.Text;
                user.Cpf = txtCpf.Text;
                user.Date_birth = DateTime.Parse(txtDate.Text);
                user.TypeUser = "CLI";
            }
            else
            {
                user.Name = txtName.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.CreditCard = txtCredit.Text;
                user.Cpf = txtCpf.Text;
                user.Date_birth = DateTime.Parse(txtDate.Text);
                user.TypeUser = "ADM";

            }

            UserModel model = new UserModel();

            if (model.insert(user))
            {
                MessageBox.Show("Usuario Criado!!!");
                updateTable();
                cleanFields();
                disableButtons();
            }
            else
            {
                MessageBox.Show("Algun erro aconteceu na persistencia!!!");
            }
            
        }

        private void disableButtons()
        {
            btnUpdateUsers.Enabled = false;
            btnDeleteUsers.Enabled = false;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (radioSelectedType == "CLI")
            {
                user.Name = txtName.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.CreditCard = txtCredit.Text;
                user.Cpf = txtCpf.Text;
                user.Date_birth = DateTime.Parse(txtDate.Text);
                user.TypeUser = "CLI";
            }
            else
            {
                user.Name = txtName.Text;
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.CreditCard = txtCredit.Text;
                user.Cpf = txtCpf.Text;
                user.Date_birth = DateTime.Parse(txtDate.Text);
                user.TypeUser = "ADM";
            }

            UserModel model = new UserModel();

            if (model.update(this.indexSelect, user))
            {
                MessageBox.Show("Usuario Alterado!!!");
                updateTable();
                cleanFields();
                disableButtons();
               
            }
            else
            {
                MessageBox.Show("Algum erro aconteceu na persistencia!!!");
            }
        }

        private void clickedCliRadioMethod(object sender, EventArgs e)
        {
            radioCli.Checked = true;
            radioAdm.Checked = false;

            radioSelectedType = "CLI";
        }

        private void clickedAdmRadioMethod(object sender, EventArgs e)
        {
            radioCli.Checked = false;
            radioAdm.Checked = true;

            radioSelectedType = "ADM";
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();

            model.delete(indexSelect);

            updateTable();
            cleanFields();
            disableButtons();
        }

        private void listTableCell_method(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = (DataGridView) sender;

            this.idSelected = data.CurrentRow.Index;

            this.indexSelect = int.Parse(data.Rows[idSelected].Cells[0].Value.ToString());

            txtName.Text = data.Rows[idSelected].Cells[1].Value.ToString();
            txtUsername.Text = data.Rows[idSelected].Cells[2].Value.ToString();
            txtCpf.Text = data.Rows[idSelected].Cells[3].Value.ToString();
            txtDate.Text = data.Rows[idSelected].Cells[4].Value.ToString();
            txtCredit.Text = data.Rows[idSelected].Cells[5].Value.ToString();
            var type = data.Rows[idSelected].Cells[6].Value.ToString();

            if (type == "CLI")
            {
                radioCli.Checked = true;
                radioAdm.Checked = false;

                radioSelectedType = "CLI";
            }
            else if(type == "ADM")
            {
                radioCli.Checked = false;
                radioAdm.Checked = true;

                radioSelectedType = "ADM";
            }

            btnUpdateUsers.Enabled = true;
            btnDeleteUsers.Enabled = true;

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
