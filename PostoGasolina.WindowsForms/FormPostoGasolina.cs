using PostoGasolina.Entidades;
using PostoGasolina.Enumeradores;
using PostoGasolina.Utilidades;
using System.ComponentModel;

namespace PostoGasolina.WindowsForms
{
    public partial class FormPostoGasolina : Form
    {
        private static BindingList<Compra> compras;
        public FormPostoGasolina()
        {
            InitializeComponent();
            CarregarFormasPagamento();
            CarregarParcelas(); 
            CarregarCombustiveis();
            CarregarPureza();
            EsconderOuExibirParcelas(false);
            compras = new BindingList<Compra>();
            dgvExtrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExtrato.DataSource = compras;
            dgvExtrato.AllowUserToAddRows = false;
            dgvExtrato.RowHeadersVisible = false;
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

        private void btnComprar_Click(object sender, EventArgs e)
        {
            CombustivelEnum combustivel = (CombustivelEnum)cbxCombustíveis.SelectedIndex;
            PurezaEnum pureza = (PurezaEnum)cbxNivelPureza.SelectedIndex;
            PagamentosEnum pagamentos = (PagamentosEnum)cbxFormaPagamento.SelectedIndex;
            double litros = (double)npdLitros.Value;
            int parcelas = cbxParcelas.SelectedIndex +1;
            Compra compra = OperacoesPosto.RealizarCompra(combustivel, pureza, pagamentos, litros, parcelas);
            compras.Add(compra);
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
                cbxParcelas.SelectedIndex = -1;
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
        private void CarregarParcelas()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbxParcelas.Items.Add(i.ToString());
            }
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
