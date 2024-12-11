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

namespace amazing_bank_app {
	public partial class Transfers : Form {
		public Transfers() {
			InitializeComponent();
		}

		private void Transfers_Load(object sender, EventArgs e) {
			typeCombo.SelectedIndex = 0;

			;
		}

		private void typeCombo_SelectedIndexChanged(object sender, EventArgs e) {
			Http.Get<TransfersList>("/transfer", out var data);
			transactionsList.Items.Clear();

			var items = new List<ListViewItem>();

			if (typeCombo.SelectedIndex == 0) {
				var list = data?.sent;

				items = list?.Select(x => {
					var item = new ListViewItem {
						Text = x.title
					};
                    item.SubItems.Add(x.targetName);
                    item.SubItems.Add(x.targetId.ToString());
                    item.SubItems.Add(x.amount.ToString());
                    item.SubItems.Add(DateTime.Parse(x.date).ToString());

                    return item;
				}).ToList();
            } else {
				var list = data?.received;

				items = list?.Select(x => {
					var item = new ListViewItem {
						Text = x.title
					};
					item.SubItems.Add(x.targetName);
					item.SubItems.Add(x.targetId.ToString());
					item.SubItems.Add(x.amount.ToString());
					item.SubItems.Add(DateTime.Parse(x.date).ToString());

					return item;
				}).ToList();
			}

			transactionsList.Items.AddRange(items.ToArray());
			transactionsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			transactionsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
	}
}