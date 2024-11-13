using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace amazing_bank_app {
    public partial class Form1 : Form
    {
        private readonly HttpClient _http;
        private string token;

        public Form1()
        {
            InitializeComponent();
            _http = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:80"),
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login loginForm = new();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Show();
                token = loginForm.token.token;
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

                var res = _http.GetAsync("/account/details").Result;
                var data = res.Content.ReadFromJsonAsync<Account>().Result;

                number.Text = data?.accountNo.ToString();
                amount.Text = data?.amount.ToString();
                name.Text = data?.name;
            }
            else
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
			var transferWindow = new NewTransfer(token);

            transferWindow.ShowDialog();
        }
    }
}