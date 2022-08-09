using System.Xml;
using System.Xml.Serialization;

namespace CORE.Utilitarios;

public class UtilitarioXml
{

	public static T DesserializeXml<T>(string arquivo, string namespaceXml)
		where T : new()
	{
		XmlRootAttribute root = new()
		{
			ElementName = typeof(T).Name,
			Namespace = namespaceXml
		};

		using XmlReader reader = XmlReader.Create(new StringReader(arquivo));

		XmlSerializer serializer = new(typeof(T), root);

		return (T)serializer.Deserialize(reader);
	}
}
