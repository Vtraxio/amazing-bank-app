using System;
using System.Collections.Generic;
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
			outData = res.Content.ReadFromJsonAsync<T>().Result;
            return res;
		}

		public static HttpResponseMessage Post<T>(string path, T data) {
			return HttpClient.PostAsJsonAsync(path, data).Result;
		}

		public static HttpResponseMessage Post<T, TU>(string path, T data, out TU? outData) {
			var res = HttpClient.PostAsJsonAsync(path, data).Result;
			outData = res.Content.ReadFromJsonAsync<TU>().Result;
			return res;
		}
	}
}