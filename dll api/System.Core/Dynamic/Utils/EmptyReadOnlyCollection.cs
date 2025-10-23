using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Dynamic.Utils
{
	// Token: 0x02000139 RID: 313
	internal static class EmptyReadOnlyCollection<T>
	{
		// Token: 0x040002FD RID: 765
		public static readonly ReadOnlyCollection<T> Instance = new TrueReadOnlyCollection<T>(Array.Empty<T>());
	}
}
