using iRh.Windows.Cadastros.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosOsEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
           
        }
        private void CarregarDocumentos()
        {
            var documento = new DocumentoDeIdentificacao();
            var listaDeDocumentos = documento.ObterTodosOsDocumentos();
            var documentosAz = listaDeDocumentos.OrderBy(x => x.Descricao).ToList();
            cmbDocumento.Items.Clear();
            cmbDocumento.DataSource = documentosAz;
            cmbDocumento.DisplayMember = "Descricao";
            cmbDocumento.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            var cepDigitado = txtCep.Text;
            if(cepDigitado.Length < 9)
            {
                MessageBox.Show("INFORME UM CEP VALIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                txtCep.Clear();
                return;
            }
            var endereco = new Endereco();
            
            var enderecoCompleto = endereco.obterPorCep(cepDigitado);
            if (enderecoCompleto == null)
            {
                MessageBox.Show("INFORME UM CEP VALIDO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
                txtCep.Clear();
                return;
                
            }
            else
            {
                txtLougradouro.Text = enderecoCompleto.Logradouro;
                txtBairro.Text = enderecoCompleto.Bairro;
                txtCidade.Text = enderecoCompleto.Localidade;
                txtDdd.Text = enderecoCompleto.Ddd;
                cmbEstados.SelectedValue = enderecoCompleto.Uf;
              

                if(txtLougradouro == null)
                {
                    txtLougradouro.Enabled = false;
                }
                if (txtBairro == null)
                {
                    txtBairro.Enabled = false;
                }
                if (txtCidade != null)
                {
                    txtCidade.Enabled = false;
                }
                if (txtDdd != null)
                {
                    txtDdd.Enabled = false;
                }
                if (cmbEstados != null)
                {
                    cmbEstados.Enabled = false;
                }

            }
        }

        private void lblChamarNoZap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=5527995203567&text=SOU%20FODA");
        }
    }
}
