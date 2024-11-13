using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazing_bank_app {
	public partial class NewTransfer : Form {
		private string token;

		public NewTransfer(string token) {
			this.token = token;
            InitializeComponent();
		}

		private void transferBtn_Click(object sender, EventArgs e) {
			var http = new HttpClient {
				BaseAddress = new Uri("http://localhost:80"),
			};
			http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

            var transfer = new Transfer {
				amount = (int)amountNum.Value,
				target = int.Parse(targetTxt.Text) * 100,
			};

			var res = http.PostAsJsonAsync("/transfer", transfer).Result;

			MessageBox.Show(res.StatusCode.ToString());
		}
	}
}