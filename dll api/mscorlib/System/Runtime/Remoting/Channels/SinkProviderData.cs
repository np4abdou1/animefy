using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Stores sink provider data for sink providers.</summary>
	// Token: 0x0200034C RID: 844
	[ComVisible(true)]
	public class SinkProviderData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" /> class.</summary>
		/// <param name="name">The name of the sink provider that the data in the current <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" /> object is associated with. </param>
		// Token: 0x06001AF1 RID: 6897 RVA: 0x00074E91 File Offset: 0x00073091
		public SinkProviderData(string name)
		{
			this.sinkName = name;
			this.children = new ArrayList();
			this.properties = new Hashtable();
		}

		/// <summary>Gets a list of the child <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" /> nodes.</summary>
		/// <returns>A <see cref="T:System.Collections.IList" /> of the child <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" /> nodes.</returns>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00074EB6 File Offset: 0x000730B6
		public IList Children
		{
			get
			{
				return this.children;
			}
		}

		/// <summary>Gets a dictionary through which properties on the sink provider can be accessed.</summary>
		/// <returns>A dictionary through which properties on the sink provider can be accessed.</returns>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00074EBE File Offset: 0x000730BE
		public IDictionary Properties
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x04000B45 RID: 2885
		private string sinkName;

		// Token: 0x04000B46 RID: 2886
		private ArrayList children;

		// Token: 0x04000B47 RID: 2887
		private Hashtable properties;
	}
}
