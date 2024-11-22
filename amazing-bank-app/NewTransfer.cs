﻿using System;
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
using amazing_bank_app.Network;

namespace amazing_bank_app {
	public partial class NewTransfer : Form {
		public NewTransfer() {
            InitializeComponent();
		}

		private void transferBtn_Click(object sender, EventArgs e) {
            var transfer = new Transfer {
				amount = (int)amountNum.Value,
				target = int.Parse(targetTxt.Text) * 100,
			};

			var res = Http.Post("/transfer", transfer);

			MessageBox.Show(res.StatusCode.ToString());
		}
	}
}