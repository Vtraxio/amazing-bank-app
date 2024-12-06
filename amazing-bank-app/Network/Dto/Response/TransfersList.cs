using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazing_bank_app.Network.Dto.Response {
	public class Received {
		public string targetName { get; set; }
		public int    targetId   { get; set; }
		public int    amount     { get; set; }
		public string title      { get; set; }
		public string date       { get; set; }
	}

	public class TransfersList {
		public List<Sent>     sent     { get; set; }
		public List<Received> received { get; set; }
	}

	public class Sent {
		public string targetName { get; set; }
		public int    targetId   { get; set; }
		public int    amount     { get; set; }
		public string title      { get; set; }
		public string date       { get; set; }
	}
}