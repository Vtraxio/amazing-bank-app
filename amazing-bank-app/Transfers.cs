using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using amazing_bank_app.Network;
using amazing_bank_app.Network.Dto.Response;

namespace amazing_bank_app
{
    public partial class Transfers : Form {
		public Transfers() {
			InitializeComponent();
		}

		private void Transfers_Load(object sender, EventArgs e) {
			Http.Get<TransfersList>("/transfer", out var data);

			bindingSource1.DataSource = data.sent;

			dataGridView1.AutoGenerateColumns = true;
			dataGridView1.DataSource          = bindingSource1;
        }
    }
}