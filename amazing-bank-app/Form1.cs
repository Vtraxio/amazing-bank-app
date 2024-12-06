using System.Net.Http.Headers;
using System.Net.Http.Json;
using amazing_bank_app.Network;
using amazing_bank_app.Network.Dto.Response;

namespace amazing_bank_app {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			Login loginForm = new();
			if (loginForm.ShowDialog() == DialogResult.OK) {
				Show();
				Http.SetToken(loginForm.token.token);

				GetData();
			} else {
				Application.Exit();
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			var transferWindow = new NewTransfer();
			transferWindow.Transfer += (_, _) => GetData();

			transferWindow.ShowDialog();
		}

		private void GetData() {
			Http.Get<Account>("/account/details", out var data);

			number.Text = data?.accountNo.ToString();
			amount.Text = data?.amount.ToString();
			name.Text   = data?.name;
		}

		private void button2_Click(object sender, EventArgs e) {
			var tranfers = new Transfers();

			tranfers.ShowDialog();
		}
	}
}