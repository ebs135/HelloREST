using System.ServiceModel;
using System.ServiceModel.Web;

namespace HelloREST.Server
{
	[ServiceContract(Namespace = "http://ebs135.my.id/HelloRest")]
	public interface IHelloWorld
	{
		[OperationContract]
		[WebGet(UriTemplate = "prm?nama={nama}",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		string HaloDunia(string nama);
	}
}