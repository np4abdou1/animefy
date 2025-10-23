using System;
using System.Collections;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting
{
	// Token: 0x0200030D RID: 781
	internal class ProviderData
	{
		// Token: 0x060019B6 RID: 6582 RVA: 0x00070760 File Offset: 0x0006E960
		public void CopyFrom(ProviderData other)
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
			foreach (object obj in other.CustomProperties)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if (!this.CustomProperties.ContainsKey(dictionaryEntry.Key))
				{
					this.CustomProperties[dictionaryEntry.Key] = dictionaryEntry.Value;
				}
			}
			if (other.CustomData != null)
			{
				if (this.CustomData == null)
				{
					this.CustomData = new ArrayList();
				}
				foreach (object obj2 in other.CustomData)
				{
					SinkProviderData value = (SinkProviderData)obj2;
					this.CustomData.Add(value);
				}
			}
		}

		// Token: 0x04000AC1 RID: 2753
		internal string Ref;

		// Token: 0x04000AC2 RID: 2754
		internal string Type;

		// Token: 0x04000AC3 RID: 2755
		internal string Id;

		// Token: 0x04000AC4 RID: 2756
		internal Hashtable CustomProperties = new Hashtable();

		// Token: 0x04000AC5 RID: 2757
		internal IList CustomData;
	}
}
