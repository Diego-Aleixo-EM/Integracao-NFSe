using System.ComponentModel.DataAnnotations;

namespace APP;

public partial class Home : Form
{
	public enum Ambiente
	{
		[Display(GroupName = "Homologação")]
		Homologacao,
		[Display(GroupName = "Produção")]
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

	private void btnFechar_Click(object sender, EventArgs e) => Close();
}
