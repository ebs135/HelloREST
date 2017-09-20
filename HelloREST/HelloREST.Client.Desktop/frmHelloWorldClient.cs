using System;
using System.Net;
using System.Windows.Forms;

namespace HelloREST.Client.Desktop
{
	public partial class frmHelloWorldClient : Form
	{
		private WebClient client;
		const string Uri = "http://localhost/HelloREST/HelloWorld.svc/prm?nama=";

		public frmHelloWorldClient()
		{
			InitializeComponent();
		}

		private void frmHelloWorldClient_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.FixedSingle;
			lblRetVal.Text = "Return value tampil di sini..";
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			client = new WebClient();

			string response = client.DownloadString(Uri + txtNama.Text);
			response = response.Substring(1, response.Length - 2);

			lblRetVal.Text = response;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lblRetVal.Text = "Return value tampil di sini..";
			txtNama.Text = string.Empty;
			txtNama.Focus();
		}
	}
}
