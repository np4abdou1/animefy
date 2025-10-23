using System;
using System.Collections.ObjectModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200010D RID: 269
	internal sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T>
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x00022CF9 File Offset: 0x00020EF9
		public TrueReadOnlyCollection(params T[] list) : base(list)
		{
		}
	}
}
