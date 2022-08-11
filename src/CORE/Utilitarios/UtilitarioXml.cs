using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CORE.Utilitarios;

public class UtilitarioXml
{

	public static T ConvertaXmlEmObjeto<T>(string arquivo, string namespaceXml)
		where T : new()
	{
		XmlRootAttribute root = new()
		{
			ElementName = typeof(T).Name,
			Namespace = namespaceXml
		};

		using XmlReader reader = XmlReader.Create(new StringReader(arquivo));

		XmlSerializer serializer = new(typeof(T), root);

		return (T)serializer.Deserialize(reader)!;
	}

	public static bool TenteConverterEmXml(string resposta, out XmlDocument xml)
	{
		xml = new XmlDocument();

		if (string.IsNullOrEmpty(resposta))
		{
			return false;
		}

		xml.LoadXml(resposta);

		return true;
	}

	public static string ConvertaObjetoEmXml(object notaFiscal, string namespaceXML)
	{
		using MemoryStream ms = new();
		using XmlTextWriter textWriter = new(ms, Encoding.UTF8);

		XmlSerializer serializer = new(notaFiscal.GetType());
		XmlSerializerNamespaces ns = new();
		ns.Add("", namespaceXML);
		serializer.Serialize(textWriter, notaFiscal, ns);

		//Substring elimina o comentário do xml colocado pelo serializador, pois, neste caso não é um documento completo e sim um elemento.
		return Encoding.UTF8.GetString(ms.ToArray())
							.Substring(39);
	}
}
