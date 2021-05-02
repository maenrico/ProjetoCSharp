using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using DAL;
using Modelos;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Inserir(new Celular(txtMarca.Text, txtModelo.Text, txtQualidade.Text, int.Parse(txtTamanho.Text)));
                ListarCelular();
                MessageBox.Show($"Celular da Marca {txtMarca.Text} inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarCelular();
        }

        private void ListarCelular()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                gridClientes.DataSource = null;
                gridClientes.DataSource = rep.Listar();
                gridClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }
    }
}
