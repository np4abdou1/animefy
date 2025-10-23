using System;

namespace System.Linq
{
	// Token: 0x02000016 RID: 22
	internal static class Error
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00003EF0 File Offset: 0x000020F0
		internal static Exception ArgumentNull(string s)
		{
			return new ArgumentNullException(s);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003EF8 File Offset: 0x000020F8
		internal static Exception ArgumentOutOfRange(string s)
		{
			return new ArgumentOutOfRangeException(s);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003F00 File Offset: 0x00002100
		internal static Exception MoreThanOneElement()
		{
			return new InvalidOperationException("Sequence contains more than one element");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003F0C File Offset: 0x0000210C
		internal static Exception MoreThanOneMatch()
		{
			return new InvalidOperationException("Sequence contains more than one matching element");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003F18 File Offset: 0x00002118
		internal static Exception NoElements()
		{
			return new InvalidOperationException("Sequence contains no elements");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003F24 File Offset: 0x00002124
		internal static Exception NoMatch()
		{
			return new InvalidOperationException("Sequence contains no matching element");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003F30 File Offset: 0x00002130
		internal static Exception NotSupported()
		{
			return new NotSupportedException();
		}
	}
}
