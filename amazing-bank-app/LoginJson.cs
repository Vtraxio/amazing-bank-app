using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazing_bank_app {
	record class LoginJson {
		public string login    { get; set; }
		public string password { get; set; }
	}
}