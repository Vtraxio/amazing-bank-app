using System.Net.Http.Headers;
using System.Net.Http.Json;
using amazing_bank_app.Network;

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

			transferWindow.ShowDialog();

			transferWindow.Transfer += (_, _) => GetData();
		}

		private void GetData() {
			Http.Get<Account>("/account/details", out var data);

			number.Text = data?.accountNo.ToString();
			amount.Text = data?.amount.ToString();
			name.Text   = data?.name;
		}
	}
}