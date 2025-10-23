using System;

namespace System.Xml.Serialization
{
	/// <summary>Provides data for the known, but unreferenced, object found in an encoded SOAP XML stream during deserialization.</summary>
	// Token: 0x020001CF RID: 463
	public class UnreferencedObjectEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.UnreferencedObjectEventArgs" /> class.</summary>
		/// <param name="o">The unreferenced object. </param>
		/// <param name="id">A unique string used to identify the unreferenced object. </param>
		// Token: 0x06000F92 RID: 3986 RVA: 0x00062C4B File Offset: 0x00060E4B
		public UnreferencedObjectEventArgs(object o, string id)
		{
			this.o = o;
			this.id = id;
		}

		// Token: 0x04000B1E RID: 2846
		private object o;

		// Token: 0x04000B1F RID: 2847
		private string id;
	}
}
