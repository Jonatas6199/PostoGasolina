using PostoGasolina.Enumeradores;
using PostoGasolina.Utilidades;

namespace PostoGasolina.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarFormasPagamento();
            CarregarCombustiveis();
            CarregarPureza();
            EsconderOuExibirParcelas(false);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show
                ("Deseja realmente fechar?", "Encerrar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void lblParcelas_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            CombustivelEnum combustivel = (CombustivelEnum)cbxCombustíveis.SelectedIndex;
            PurezaEnum pureza = (PurezaEnum)cbxNivelPureza.SelectedIndex;
            PagamentosEnum pagamentos = (PagamentosEnum)cbxFormaPagamento.SelectedIndex;
            double litros = (double)npdLitros.Value;
            //TODO: Passar parcelas
            OperacoesPosto.RealizarCompra(combustivel, pureza, pagamentos, litros);
        }
        private void EsconderOuExibirParcelas(bool exibir)
        {
            if (exibir)
            {
                cbxParcelas.Visible = lblParcelas.Visible = true;
            }
            else
            {
                cbxParcelas.Visible = lblParcelas.Visible = false;
            }
        }
        private void CarregarFormasPagamento()
        {
            cbxFormaPagamento.DataSource = Enum.GetValues(typeof(PagamentosEnum));
        }
        private void CarregarCombustiveis()
        {
            cbxCombustíveis.DataSource = Enum.GetValues(typeof(CombustivelEnum));

        }
        private void CarregarPureza()
        {
            cbxNivelPureza.DataSource = Enum.GetValues(typeof(PurezaEnum));
        }

        private void cbxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFormaPagamento.SelectedIndex == 1) 
            { 
                EsconderOuExibirParcelas(true);
            }
            else
            {
                EsconderOuExibirParcelas(false);
            }
        }
    }
}
