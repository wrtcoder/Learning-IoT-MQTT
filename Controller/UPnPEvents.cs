using System;
using Clayster.Library.Internet.UPnP;

namespace Controller
{
	public class Subscription
	{
		private string sid;
		private string udn;
		private IUPnPService service;

		public Subscription (string Udn, string Sid, IUPnPService Service)
		{
			this.sid = Sid;
			this.service = Service;
		}

		public string UDN
		{
			get{return this.udn;}
		}

		public string SID
		{
			get{return this.sid;}
		}

		public IUPnPService Service
		{
			get{return this.service;}
		}

	}
}

