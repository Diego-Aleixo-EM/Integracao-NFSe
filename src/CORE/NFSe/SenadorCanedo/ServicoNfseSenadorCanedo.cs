using CORE.Utilitarios;
using NFSeSenadorCanedo;
using System.ServiceModel;

namespace CORE.NFSe.SenadorCanedo;

public class ServicoNfseSenadorCanedo
{
	public object EnvieRps()
	{
		Task<gerarNfseResponse> requisicao = GereRequisicao();

		return requisicao.Result;
	}

	private async Task<gerarNfseResponse> GereRequisicao()
	{
		IssWebWSClient client = CrieClientWebService2();

		IssWebWS canal = client.ChannelFactory.CreateChannel();

		GerarNfseEnvio xml = UtilitarioXml.DesserializeXml<GerarNfseEnvio>("","");

		gerarNfse model = new(xml, "", "");

		return await canal.gerarNfseAsync(model).ConfigureAwait(false);
	}

	private IssWebWS CrieClientWebService()
	{
		BasicHttpBinding binding = new();
		binding.MaxBufferSize = int.MaxValue;
		binding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
		binding.MaxReceivedMessageSize = int.MaxValue;
		binding.AllowCookies = true;

		EndpointAddress endpoin = new("");

		IssWebWSClient cliente = new(binding, endpoin);

		return cliente;
	}

	private IssWebWSClient CrieClientWebService2()
	{
		BasicHttpBinding binding = new();
		binding.MaxBufferSize = int.MaxValue;
		binding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
		binding.MaxReceivedMessageSize = int.MaxValue;
		binding.AllowCookies = true;

		EndpointAddress endpoin = new("");

		IssWebWSClient cliente = new(binding, endpoin);

		return cliente;
	}
}
