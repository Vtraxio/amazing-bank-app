using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazing_bank_app.Network {
	public partial class PhpError : Form {
		private readonly string _text;

        public PhpError(string text) {
			InitializeComponent();
			this._text = text;
		}

		private void PhpError_Load(object sender, EventArgs e) {
			webView.EnsureCoreWebView2Async().ContinueWith(_ => {
				webView.NavigateToString($"<pre>{_text}</pre>");
            }, TaskScheduler.FromCurrentSynchronizationContext());
		}
	}
}