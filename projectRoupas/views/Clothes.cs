using projectRoupas.lib;
using projectRoupas.models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projectRoupas.views
{
    public partial class Clothes : Form
    {
        // variaveis do upload
        private string fileName = "";
        private string source = "";
        private string dest = "";
        private string newDirectory = "";
        private int idSelected;
        private int indexSelect;
        private string string_photo = "";

        public Clothes()
        {
            InitializeComponent();

            listTableClothes.AutoGenerateColumns = false;

            listTableClothes.ColumnCount = 8;

            listTableClothes.Columns[0].HeaderText = "id";
            listTableClothes.Columns[0].DataPropertyName = "id";

            listTableClothes.Columns[1].HeaderText = "descrição";
            listTableClothes.Columns[1].DataPropertyName = "description_product";

            listTableClothes.Columns[2].HeaderText = "preço";
            listTableClothes.Columns[2].DataPropertyName = "price";

            listTableClothes.Columns[3].HeaderText = "marca";
            listTableClothes.Columns[3].DataPropertyName = "brand";

            listTableClothes.Columns[4].HeaderText = "imagem";
            listTableClothes.Columns[4].DataPropertyName = "photo";

            listTableClothes.Columns[5].HeaderText = "fornecedor";
            listTableClothes.Columns[5].DataPropertyName = "provider";

            listTableClothes.Columns[6].HeaderText = "data de postagem";
            listTableClothes.Columns[6].DataPropertyName = "datePost";

            listTableClothes.Columns[7].HeaderText = "quantidade em estoque";
            listTableClothes.Columns[7].DataPropertyName = "qtdInventory";
            listTableClothes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listTableClothes.MultiSelect = false;

            updateTable();

            btnUpdateClothes.Enabled = false;
        }

        private void updateTable()
        {
            listTableClothes.DataSource = null;

            DataTable datatable = (new ClothModel()).all();

            listTableClothes.DataSource = datatable;
        }

        private void findTable(int id)
        {
            listTableClothes.DataSource = null;

            DataTable datatable = (new ClothModel()).get(id);

            listTableClothes.DataSource = datatable;
        }

        private void btnCreateClothes_Click(object sender, EventArgs e)
        {
            //verifica se a foto foi selecionada
            if (this.source != "" && this.dest != "" && this.newDirectory != "" && this.fileName != "")
            {
                try
                {

                    // atribui campos as variaveis
                    string description = txtDescription.Text;
                    string price = txtPrice.Text == "" ? "0" : txtPrice.Text;
                    string provider = txtProvider.Text;
                    string brand = txtBrand.Text;
                    string qtdInventary = txtQtdInventary.Text == "" ? "0" : txtQtdInventary.Text;

                    //preenche campos da classe Cloth
                    Cloth cloth = new Cloth();

                    cloth.Description_product = description;
                    cloth.Price = double.Parse(price);
                    cloth.Provider = provider;
                    cloth.Brand = brand;
                    cloth.QtdInventory = int.Parse(qtdInventary);
                    cloth.DatePost = DateTime.Now;

                    if (Directory.Exists(this.newDirectory)) // verifica se arquivo existe
                    {
                        File.Copy(this.source, this.dest); // copia arquivo para pasta do projeto
                    }
                    else
                    {

                        Directory.CreateDirectory(this.newDirectory);// cria diretorio inexistente
                        File.Copy(this.source, this.dest);// copia arquivo para pasta do projeto recem criada
                    }

                    cloth.Photo = dest;

                    ClothModel model = new ClothModel();

                    if (model.insert(cloth))
                    {
                        MessageBox.Show("Roupa cadastrada com sucesso!!!");

                        // limpa caixas de texto
                        txtDescription.Text = "";
                        txtPrice.Text = "";
                        txtProvider.Text = "";
                        txtBrand.Text = "";
                        txtQtdInventary.Text = "";

                        //limpa atributos do upload
                        this.fileName = "";
                        this.source = "";
                        this.dest = "";
                        this.newDirectory = "";

                        //limpa campo imagem
                        this.panelPhotoCloth.BackgroundImage = null;

                        btnUpdateClothes.Enabled = false;

                        this.string_photo = "";
                        updateTable();


                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro!!!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString()); // retorna todas as exceções
                }
            }
            else
            {
                MessageBox.Show("Você não selecionou o arquivo");
            }


        }

        private void btnUpdateClothes_Click(object sender, EventArgs e)
        {
            //verifica se a foto foi selecionada
            if (this.source != "" && this.dest != "" && this.newDirectory != "" && this.fileName != "")
            {
                try
                {

                    // atribui campos as variaveis
                    string description = txtDescription.Text;
                    string price = txtPrice.Text == "" ? "0" : txtPrice.Text;


                    string provider = txtProvider.Text;
                    string brand = txtBrand.Text;
                    string qtdInventary = txtQtdInventary.Text == "" ? "0" : txtQtdInventary.Text;

                    //preenche campos da classe Cloth
                    Cloth cloth = new Cloth();

                    cloth.Description_product = description;
                    cloth.Price = double.Parse(price);
                    cloth.Provider = provider;
                    cloth.Brand = brand;
                    cloth.QtdInventory = int.Parse(qtdInventary);
                    cloth.DatePost = DateTime.Now;


                    if (Directory.Exists(this.newDirectory)) // verifica se arquivo existe
                    {
                        File.Copy(this.source, this.dest); // copia arquivo para pasta do projeto
                    }
                    else
                    {

                        Directory.CreateDirectory(this.newDirectory);// cria diretorio inexistente
                        File.Copy(this.source, this.dest);// copia arquivo para pasta do projeto recem criada
                    }
                    cloth.Photo = this.dest;



                    ClothModel model = new ClothModel();

                    if (model.update(this.indexSelect, cloth))
                    {
                        MessageBox.Show("Roupa atualizada com sucesso!!!");

                        // limpa caixas de texto
                        txtDescription.Text = "";
                        txtPrice.Text = "";
                        txtProvider.Text = "";
                        txtBrand.Text = "";
                        txtQtdInventary.Text = "";

                        //limpa atributos do upload
                        this.fileName = "";
                        this.source = "";
                        this.dest = "";
                        this.newDirectory = "";

                        this.string_photo = "";

                        btnUpdateClothes.Enabled = false;

                        //limpa campo imagem
                        this.panelPhotoCloth.BackgroundImage = null;

                        updateTable();

                    }
                    else
                    {
                        MessageBox.Show("Erro na atualização!!!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString()); // retorna todas as exceções
                }
            }
            else if (this.source == "" && this.dest != "" && this.newDirectory == "" && this.fileName == "")
            {
                try
                {

                    // atribui campos as variaveis
                    string description = txtDescription.Text;
                    string price = txtPrice.Text == "" ? "0" : txtPrice.Text;


                    string provider = txtProvider.Text;
                    string brand = txtBrand.Text;
                    string qtdInventary = txtQtdInventary.Text == "" ? "0" : txtQtdInventary.Text;

                    //preenche campos da classe Cloth
                    Cloth cloth = new Cloth();

                    cloth.Description_product = description;
                    cloth.Price = double.Parse(price);
                    cloth.Provider = provider;
                    cloth.Brand = brand;
                    cloth.QtdInventory = int.Parse(qtdInventary);
                    cloth.DatePost = DateTime.Now;

                    cloth.Photo = this.dest;

                    ClothModel model = new ClothModel();

                    if (model.update(this.indexSelect, cloth))
                    {
                        MessageBox.Show("Roupa atualizada com sucesso!!!");

                        // limpa caixas de texto
                        txtDescription.Text = "";
                        txtPrice.Text = "";
                        txtProvider.Text = "";
                        txtBrand.Text = "";
                        txtQtdInventary.Text = "";

                        //limpa atributos do upload
                        this.fileName = "";
                        this.source = "";
                        this.dest = "";
                        this.newDirectory = "";

                        this.string_photo = "";

                        //limpa campo imagem
                        this.panelPhotoCloth.BackgroundImage = null;

                        updateTable();

                        btnUpdateClothes.Enabled = false;


                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro!!!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString()); // retorna todas as exceções
                }
            }
        }

        private void UploadClick_method(object sender, EventArgs e)
        {
            String image = "";


            OpenFileDialog uploadFile = new OpenFileDialog(); // abre caixa de dialogo para upload

            uploadFile.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*"; //filtra campos que podem ser selecionados

            if (uploadFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                try {

                    //guarda dados do arquivo selecionado
                    this.fileName = uploadFile.FileName;
                    this.source = fileName;
                    this.dest = Directory.GetCurrentDirectory().ToString() + @"\upload\" + "file" + (new Random()).NextDouble() + (new Random()).NextDouble() + uploadFile.SafeFileName.ToString();
                    this.newDirectory = Directory.GetCurrentDirectory().ToString() + @"\upload\";

                    this.panelPhotoCloth.BackgroundImage = Image.FromFile(this.source);

                }
                catch
                {
                    MessageBox.Show("Erro na seleção do Arquivo");
                }
          
            }
        }

        private void select_clothes_method(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            MessageBox.Show("teszte");
        }

        private void Clicked_table_cell_method(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                idSelected = listTableClothes.CurrentRow.Index;

                this.indexSelect = int.Parse(listTableClothes.Rows[idSelected].Cells[0].Value.ToString());

                txtDescription.Text = listTableClothes.Rows[idSelected].Cells[1].Value.ToString();
                txtPrice.Text = listTableClothes.Rows[idSelected].Cells[2].Value.ToString();
                txtBrand.Text = listTableClothes.Rows[idSelected].Cells[3].Value.ToString();
                this.dest = listTableClothes.Rows[idSelected].Cells[4].Value.ToString();
                this.panelPhotoCloth.BackgroundImage = Image.FromFile(this.dest);
                txtProvider.Text = listTableClothes.Rows[idSelected].Cells[5].Value.ToString();
                var qtd = listTableClothes.Rows[idSelected].Cells[7].Value;
                var valor = qtd.ToString();
                txtQtdInventary.Text = valor;

                btnUpdateClothes.Enabled = true;

            }
            catch
            {
                MessageBox.Show("deve haver algum prblema com os registros");
            }

        }

        private void listTableClothes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
                  
                
            
           
        }

        private void btnDeleteClick_method(object sender, EventArgs e)
        {
            (new ClothModel()).delete(this.indexSelect);
            updateTable();
            MessageBox.Show("Apagado com sucesso!!");
        }


        private void updateBorder(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.WhiteSmoke;
        }

        private void updateBorderDown(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.White;
        }

        private void updateBorder(object sender, DragEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.LightSkyBlue;
        }

        private void updateBorder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.WhiteSmoke;
        }

        private void btnSerachUserId_Click(object sender, EventArgs e)
        {
            listTableClothes.DataSource = (new ClothModel()).get(int.Parse(txtSeachTextId.Text));
           
        }

        private void txtSeachTextId_TextChanged(object sender, EventArgs e)
        {
            if(txtSeachTextId.Text == "")
            {
                updateTable();
            }
        }

        private void Clothes_Load(object sender, EventArgs e)
        {

        }
    }
}
