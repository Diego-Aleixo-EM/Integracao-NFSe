namespace CORE.DTO;

public class DTODadosNotaFiscal
{
	public string Usuario { get; set; } = string.Empty;
	public string Senha { get; set; } = string.Empty;
	public string XmlEnvio { get; set; } = string.Empty;
	public string XmlResposta { get; set; } = string.Empty;
	public bool EhEnvioProducao { get; set; }
	public List<string> Inconsistencias { get; } = new();
}
