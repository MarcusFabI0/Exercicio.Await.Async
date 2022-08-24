namespace Exercício.Await.Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime cronometro = new();
        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            cronometro = new();
             Calculo();
        }

        private async Task Calculo()
        {
            timer1.Start();
            btnCalcular.Enabled = false;
            lblAviso.ForeColor = Color.Red;
            lblAviso.Text = "Cálculo sendo efetuado, por favor aguarde...";

            txbFolha.Text = await FolhaPagamento();
            txbImpostos.Text = await Impostos();
            txbReceitas.Text = await Receitas();
            txbDespesa.Text = await Despesas();

            await Task.Delay(TimeSpan.FromSeconds(5));

            lblAviso.Text = "Cálculos efetuados!";
            lblAviso.ForeColor = Color.Green;
            btnCalcular.Enabled = true;
            timer1.Stop();

        }

        private async Task<string> FolhaPagamento()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return "R$ 3890,00";
        }

        private async Task<string> Impostos()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return "R$ 370,00";
        }

        private async Task<string> Receitas()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return "R$ 2398,00";
        }

        private async Task<string> Despesas()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
            return "R$ 1739,00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cronometro = cronometro.AddSeconds(1);
            lblTimer.Text = $"Tempo gasto na operação: {cronometro.Second}s";
        }
    }
}