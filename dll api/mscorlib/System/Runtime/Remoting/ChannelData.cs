using System;
using System.Collections;

namespace System.Runtime.Remoting
{
	// Token: 0x0200030C RID: 780
	internal class ChannelData
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x00070529 File Offset: 0x0006E729
		internal ArrayList ServerProviders
		{
			get
			{
				if (this._serverProviders == null)
				{
					this._serverProviders = new ArrayList();
				}
				return this._serverProviders;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x00070544 File Offset: 0x0006E744
		public ArrayList ClientProviders
		{
			get
			{
				if (this._clientProviders == null)
				{
					this._clientProviders = new ArrayList();
				}
				return this._clientProviders;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x0007055F File Offset: 0x0006E75F
		public Hashtable CustomProperties
		{
			get
			{
				if (this._customProperties == null)
				{
					this._customProperties = new Hashtable();
				}
				return this._customProperties;
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0007057C File Offset: 0x0006E77C
		public void CopyFrom(ChannelData other)
		{
			if (this.Ref == null)
			{
				this.Ref = other.Ref;
			}
			if (this.Id == null)
			{
				this.Id = other.Id;
			}
			if (this.Type == null)
			{
				this.Type = other.Type;
			}
			if (this.DelayLoadAsClientChannel == null)
			{
				this.DelayLoadAsClientChannel = other.DelayLoadAsClientChannel;
			}
			if (other._customProperties != null)
			{
				foreach (object obj in other._customProperties)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (!this.CustomProperties.ContainsKey(dictionaryEntry.Key))
					{
						this.CustomProperties[dictionaryEntry.Key] = dictionaryEntry.Value;
					}
				}
			}
			if (this._serverProviders == null && other._serverProviders != null)
			{
				foreach (object obj2 in other._serverProviders)
				{
					ProviderData other2 = (ProviderData)obj2;
					ProviderData providerData = new ProviderData();
					providerData.CopyFrom(other2);
					this.ServerProviders.Add(providerData);
				}
			}
			if (this._clientProviders == null && other._clientProviders != null)
			{
				foreach (object obj3 in other._clientProviders)
				{
					ProviderData other3 = (ProviderData)obj3;
					ProviderData providerData2 = new ProviderData();
					providerData2.CopyFrom(other3);
					this.ClientProviders.Add(providerData2);
				}
			}
		}

		// Token: 0x04000ABA RID: 2746
		internal string Ref;

		// Token: 0x04000ABB RID: 2747
		internal string Type;

		// Token: 0x04000ABC RID: 2748
		internal string Id;

		// Token: 0x04000ABD RID: 2749
		internal string DelayLoadAsClientChannel;

		// Token: 0x04000ABE RID: 2750
		private ArrayList _serverProviders = new ArrayList();

		// Token: 0x04000ABF RID: 2751
		private ArrayList _clientProviders = new ArrayList();

		// Token: 0x04000AC0 RID: 2752
		private Hashtable _customProperties = new Hashtable();
	}
}
