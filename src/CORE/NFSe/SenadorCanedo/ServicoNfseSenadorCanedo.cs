using CORE.DTO;
using CORE.Utilitarios;
using NFSeSenadorCanedo;
using System.ServiceModel;
using System.Xml;

namespace CORE.NFSe.SenadorCanedo;

public class ServicoNfseSenadorCanedo
{
	public static void ProcesseRps(DTODadosNotaFiscal dadosNotaFiscal)
	{
		try
		{
			object resposta = EnvieRps(dadosNotaFiscal);

			if (UtilitarioXml.TenteConverterEmXml(resposta?.ToString()!, out XmlDocument xml))
			{
				dadosNotaFiscal.XmlResposta = xml.OuterXml;
			}
			else
			{
				dadosNotaFiscal.Inconsistencias.Add("Resposta de xml em formato inválido.");
			}
		}
		catch (Exception ex)
		{
			dadosNotaFiscal.Inconsistencias.Add(ex.Message);
		}
	}

	private static object EnvieRps(DTODadosNotaFiscal dadosNotaFiscal)
	{
		const string UsuarioHomologacao = "01001001000113";
		const string SenhaHomologacao = "123456";
		const string EndpointHomologacao = "http://fi1.fiorilli.com.br:5663/IssWeb-ejb/IssWebWS/IssWebWS?wsdl";
		const string EndpointProducao = "http://45.65.223.34:5661/IssWeb-ejb/IssWebWS/IssWebWS?wsdl";

		GerarNfseEnvio xml =
			UtilitarioXml.ConvertaXmlEmObjeto<GerarNfseEnvio>(dadosNotaFiscal.XmlEnvio, "http://www.abrasf.org.br/nfse.xsd");

		gerarNfse model = dadosNotaFiscal.EhEnvioProducao ?
			new(xml, dadosNotaFiscal.Usuario, dadosNotaFiscal.Senha) :
			new(xml, UsuarioHomologacao, SenhaHomologacao);

		string endereco = dadosNotaFiscal.EhEnvioProducao ? EndpointProducao : EndpointHomologacao;

		Task <gerarNfseResponse> requisicao = GereRequisicao(endereco, model);

		return ObtenhaResposta(requisicao);
	}

	private static async Task<gerarNfseResponse> GereRequisicao(string enderecoEndpoint, gerarNfse model) =>
		await CrieClientWebService(enderecoEndpoint).gerarNfseAsync(model).ConfigureAwait(false);

	private static IssWebWS CrieClientWebService(string enderecoEndpoint)
	{
		BasicHttpBinding binding = new();
		binding.MaxBufferSize = int.MaxValue;
		binding.ReaderQuotas = XmlDictionaryReaderQuotas.Max;
		binding.MaxReceivedMessageSize = int.MaxValue;
		binding.AllowCookies = true;

		EndpointAddress endpoint = new(enderecoEndpoint);

		IssWebWSClient cliente = new(binding, endpoint);

		return cliente;
	}

	private static object ObtenhaResposta(Task<gerarNfseResponse> requisicao)
	{
		while (!requisicao.IsCompleted)
		{
			Thread.Sleep(1000);
		}

		GerarNfseResposta? resposta = requisicao.Result?.GerarNfseResposta;

		if (resposta is not null)
		{
			return UtilitarioXml.ConvertaObjetoEmXml(resposta, "http://www.abrasf.org.br/nfse.xsd");
		}

		throw new Exception("Falha ao obter resposta.");
	}
}
