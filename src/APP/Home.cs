using CORE.DTO;
using CORE.NFSe.SenadorCanedo;

namespace APP;

public partial class Home : Form
{
	public enum Ambiente
	{
		Homologacao,
		Producao
	}

	public Home()
	{
		InitializeComponent();

		cboOpcaoAmbiente.DataSource = new[]
		{
			Ambiente.Homologacao,
			Ambiente.Producao
		};
	}

	private void Enviar()
	{
		if (string.IsNullOrEmpty(txtUsuario.Text) ||
			string.IsNullOrEmpty(txtSenha.Text) ||
			string.IsNullOrEmpty(txtRConteudoXml.Text))
		{
			MessageBox.Show(this, "Preecha os campos obrigatórios (Usuário, Senha, XmlEnvio)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		DTODadosNotaFiscal dadosNotaFiscal = new()
		{
			Usuario = txtUsuario.Text,
			Senha = txtSenha.Text,
			XmlEnvio = txtRConteudoXml.Text,
			EhEnvioProducao = (Ambiente)cboOpcaoAmbiente.SelectedItem == Ambiente.Producao
		};

		ServicoNfseSenadorCanedo.ProcesseRps(dadosNotaFiscal);

		if (dadosNotaFiscal.Inconsistencias.Any())
		{
			MessageBox.Show(this, string.Join(", ", dadosNotaFiscal.Inconsistencias), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		MessageBox.Show(this, "Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
		txtRResposta.Text = dadosNotaFiscal.XmlResposta;
	}

	private void btnEnviar_Click(object sender, EventArgs e) => Enviar();

	private void btnFechar_Click(object sender, EventArgs e) => Close();
}
