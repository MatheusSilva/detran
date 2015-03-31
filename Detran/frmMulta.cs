using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Detran
{
    /// <summary>classe frmMulta da camada controle/visão</summary>
	public partial class frmMulta : Form
	{

        /// <summary>metodo construtor da classe</summary>
		public frmMulta()
		{
			InitializeComponent();
		}

        /// <summary>Carrega todos as multas do banco</summary>
        private void carregarRegistros()
        {
            DaoMulta MultaPersistencia = new DaoMulta();
            MultaPersistencia.criaBdTabelas();
            dgMulta.DataSource = MultaPersistencia.retornaRegistros();
        }

        /// <summary>Este metodo e execudado sempre quando aplicação inicia</summary>
        private void frmMulta_Load(object sender, EventArgs e)
        {
            carregarRegistros();
        }

        /// <summary>limpa todos os campos</summary>
        private void limpar()
        {
            txtcodMulta.Text   = string.Empty;
            txtinfracao.Text   = string.Empty;
            txtPontos.Text     = string.Empty;
            txtpenalidade.Text = string.Empty;
            txtvalor.Text      = string.Empty;
        }

        /// <summary>Ao clicar no botao Salvar chama este metodo que executa todos os procedimentos necessarios</summary>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Multa multa  = new Multa();
            multa.Codigo = 0;
            multa.Pontos = -1;
            multa.Valor  = -1;

            int codigo;
            int pontos;
            double valor;

            if (txtcodMulta.Text.Length != 0 && int.TryParse(txtcodMulta.Text, out codigo)) {
                multa.Codigo = codigo;
            }

            if (txtPontos.Text.Length != 0 && int.TryParse(txtPontos.Text, out pontos)) {
                multa.Pontos = pontos;
            }

            if (txtvalor.Text.Length != 0 && double.TryParse(txtvalor.Text, out valor)) {
                multa.Valor = valor;
            }

            multa.Penalidade           = txtpenalidade.Text;
            multa.Infracao             = txtinfracao.Text;
            
            DaoMulta MultaPersistencia = new DaoMulta();

            if (MultaPersistencia.validaGravacao(multa) && MultaPersistencia.gravar(multa)) {
                limpar();
                carregarRegistros();
            }
        }

        /// <summary>Ao clicar no botao Excluir chama este metodo que executa todos os procedimentos necessarios</summary>
        private void btnExcluir_Click(object sender, EventArgs e)
		{
            Multa multa  = new Multa();
            multa.Codigo = 0;

            int codigo;

            if (txtcodMulta.Text.Length != 0 && int.TryParse(txtcodMulta.Text, out codigo)) {
                multa.Codigo = codigo;
            }

            DaoMulta MultaPersistencia = new DaoMulta();

            if (MultaPersistencia.validaExclusao(multa) == true 
            && dgMulta.CurrentRow != null 
            && MultaPersistencia.excluir(dgMulta.CurrentRow.Cells[0].Value)) {
                limpar();
                carregarRegistros();
            }	
		}

        /// <summary>Ao clicar no botao Atualizar chama este metodo que executa todos os procedimentos necessarios</summary>
        private void btnAtualizar_Click(object sender, EventArgs e)
		{
            if (dgMulta.CurrentRow != null) {
                Multa multa  = new Multa();
                multa.Codigo = 0;
                multa.Pontos = -1;
                multa.Valor = -1;

                int codigo;
                int pontos;
                double valor;

                if (txtcodMulta.Text.Length != 0 && int.TryParse(txtcodMulta.Text, out codigo)) {
                    multa.Codigo = codigo;
                }

                if (txtPontos.Text.Length != 0 && int.TryParse(txtPontos.Text, out pontos)) {
                    multa.Pontos = pontos;
                }

                if (txtvalor.Text.Length != 0 && double.TryParse(txtvalor.Text, out valor)) {
                    multa.Valor = valor;
                }

                multa.Penalidade           = txtpenalidade.Text;
                multa.Infracao             = txtinfracao.Text;
                DaoMulta MultaPersistencia = new DaoMulta();

                if (MultaPersistencia.validaAlteracao(multa) && MultaPersistencia.atualizar(multa)) {
                    carregarRegistros();
                }

            }
		}

        /// <summary>Ao clicar no botao Sair chama este metodo que executa todos os procedimentos necessarios</summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>Ao clicar no botao Carregar chama este metodo que executa todos os procedimentos necessarios</summary>
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (dgMulta.CurrentRow != null) { 
                txtcodMulta.Text   = Convert.ToString(dgMulta.CurrentRow.Cells[0].Value);
                txtinfracao.Text   = Convert.ToString(dgMulta.CurrentRow.Cells[1].Value);
                txtPontos.Text     = Convert.ToString(dgMulta.CurrentRow.Cells[2].Value);
                txtpenalidade.Text = Convert.ToString(dgMulta.CurrentRow.Cells[3].Value);
                txtvalor.Text      = Convert.ToString(dgMulta.CurrentRow.Cells[4].Value);
            }

        }
			 
	}
}
