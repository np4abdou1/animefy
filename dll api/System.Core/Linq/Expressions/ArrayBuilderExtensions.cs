using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	// Token: 0x0200007C RID: 124
	internal static class ArrayBuilderExtensions
	{
		// Token: 0x0600036D RID: 877 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		public static ReadOnlyCollection<T> ToReadOnly<T>(this ArrayBuilder<T> builder)
		{
			return new TrueReadOnlyCollection<T>(builder.ToArray());
		}
	}
}
