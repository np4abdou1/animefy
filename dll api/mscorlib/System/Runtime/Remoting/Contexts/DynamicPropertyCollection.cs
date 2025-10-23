using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	// Token: 0x0200032D RID: 813
	internal class DynamicPropertyCollection
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00073A20 File Offset: 0x00071C20
		public bool HasProperties
		{
			get
			{
				return this._properties.Count > 0;
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00073A30 File Offset: 0x00071C30
		public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
		{
			ArrayList properties = this._properties;
			if (start)
			{
				using (IEnumerator enumerator = properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DynamicPropertyCollection.DynamicPropertyReg dynamicPropertyReg = (DynamicPropertyCollection.DynamicPropertyReg)obj;
						if (dynamicPropertyReg.Sink != null)
						{
							dynamicPropertyReg.Sink.ProcessMessageStart(msg, client_site, async);
						}
					}
					return;
				}
			}
			foreach (object obj2 in properties)
			{
				DynamicPropertyCollection.DynamicPropertyReg dynamicPropertyReg2 = (DynamicPropertyCollection.DynamicPropertyReg)obj2;
				if (dynamicPropertyReg2.Sink != null)
				{
					dynamicPropertyReg2.Sink.ProcessMessageFinish(msg, client_site, async);
				}
			}
		}

		// Token: 0x04000B23 RID: 2851
		private ArrayList _properties;

		// Token: 0x0200032E RID: 814
		private class DynamicPropertyReg
		{
			// Token: 0x04000B24 RID: 2852
			public IDynamicMessageSink Sink;
		}
	}
}
