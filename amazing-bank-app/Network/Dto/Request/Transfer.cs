﻿namespace amazing_bank_app.Network.Dto.Request;

internal class Transfer {
	public int    target { get; set; }
	public int    amount { get; set; }
	public string title  { get; set; }
}