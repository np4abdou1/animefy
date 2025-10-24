using System;
using System.Collections;

namespace System.Runtime.InteropServices
{
	/// <summary>Enables customization of managed objects that extend from unmanaged objects during creation.</summary>
	// Token: 0x0200041C RID: 1052
	[ComVisible(true)]
	public sealed class ExtensibleClassFactory
	{
		// Token: 0x06001F67 RID: 8039 RVA: 0x00086B48 File Offset: 0x00084D48
		internal static ObjectCreationDelegate GetObjectCreationCallback(Type t)
		{
			return ExtensibleClassFactory.hashtable[t] as ObjectCreationDelegate;
		}

		// Token: 0x04000F11 RID: 3857
		private static readonly Hashtable hashtable = new Hashtable();
	}
}
