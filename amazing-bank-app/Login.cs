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
using amazing_bank_app.Network;
using amazing_bank_app.Network.Dto.Request;
using amazing_bank_app.Network.Dto.Response;

namespace amazing_bank_app
{
    public partial class Login : Form {
		public     Token  token;

		public Login() {
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e) {
			var login    = emailTextBox.Text;
			var password = passwordTextBox.Text;

			Http.Post("/login/", new LoginJson { login = login, password = password }, out token);
			
			DialogResult = DialogResult.OK;
			Close();
		}

		private void QuitButton_Click(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}