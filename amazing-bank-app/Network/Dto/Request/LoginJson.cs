using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazing_bank_app.Network.Dto.Request {
	record class LoginJson {
		public string login    { get; set; }
		public string password { get; set; }
	}
}