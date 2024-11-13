using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazing_bank_app {
	public partial class Login : Form {
		public     Token  token;

		public Login() {
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e) {
			var login    = emailTextBox.Text;
			var password = passwordTextBox.Text;

			HttpClient http = new() {
				BaseAddress = new Uri("http://localhost:/")
			};


			var res     = http.PostAsJsonAsync("/login/", new LoginJson { login = login, password = password }).Result;
			
			var account = res.Content.ReadFromJsonAsync<Token>().Result;
			token        = account;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void QuitButton_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}