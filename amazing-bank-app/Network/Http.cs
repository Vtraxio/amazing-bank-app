using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace amazing_bank_app.Network {
	internal class Http {
		public static HttpClient HttpClient = new() {
			BaseAddress = new Uri("http://localhost:80"),
		};

		public static string? UserToken { get; private set; }

		public static void SetToken(string token) {
			HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
			UserToken                                      = token;
		}

		public static void ResetToken() {
			HttpClient.DefaultRequestHeaders.Authorization = null;
			UserToken                                      = null;
		}

		public static HttpResponseMessage Get<T>(string path, out T? outData) {
			var res = HttpClient.GetAsync(path).Result;

			if (!res.IsSuccessStatusCode) {
				MessageBox.Show(res.Content.ReadAsStringAsync().Result, @"PHP Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

				outData = default;
				return res;
			}

			outData = res.Content.ReadFromJsonAsync<T>().Result;

			return res;
		}

		public static HttpResponseMessage Post<T>(string path, T data) {
			var res = HttpClient.PostAsJsonAsync(path, data).Result;

			if (!res.IsSuccessStatusCode) {
				MessageBox.Show(res.Content.ReadAsStringAsync().Result, @"PHP Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return res;
		}

		public static HttpResponseMessage Post<T, TU>(string path, T data, out TU? outData) {
			var res = HttpClient.PostAsJsonAsync(path, data).Result;

			if (!res.IsSuccessStatusCode) {
				MessageBox.Show(res.Content.ReadAsStringAsync().Result, @"PHP Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

				outData = default;
				return res;
			}

			outData = res.Content.ReadFromJsonAsync<TU>().Result;
			return res;
		}
	}
}