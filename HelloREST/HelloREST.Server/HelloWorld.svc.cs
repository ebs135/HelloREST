namespace HelloREST.Server
{
	public class HelloWorld : IHelloWorld
	{
		public string HaloDunia(string nama)
		{
			nama = "Halo dunia, namaku " + nama.ToUpper() + " !!!";

			return nama;
		}
	}
}