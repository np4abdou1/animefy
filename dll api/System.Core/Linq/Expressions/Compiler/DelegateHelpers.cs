using System;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000DF RID: 223
	internal static class DelegateHelpers
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x00016218 File Offset: 0x00014418
		internal static Type GetFuncType(Type[] types)
		{
			switch (types.Length)
			{
			case 1:
				return typeof(Func<>).MakeGenericType(types);
			case 2:
				return typeof(Func<, >).MakeGenericType(types);
			case 3:
				return typeof(Func<, , >).MakeGenericType(types);
			case 4:
				return typeof(Func<, , , >).MakeGenericType(types);
			case 5:
				return typeof(Func<, , , , >).MakeGenericType(types);
			case 6:
				return typeof(Func<, , , , , >).MakeGenericType(types);
			case 7:
				return typeof(Func<, , , , , , >).MakeGenericType(types);
			case 8:
				return typeof(Func<, , , , , , , >).MakeGenericType(types);
			case 9:
				return typeof(Func<, , , , , , , , >).MakeGenericType(types);
			case 10:
				return typeof(Func<, , , , , , , , , >).MakeGenericType(types);
			case 11:
				return typeof(Func<, , , , , , , , , , >).MakeGenericType(types);
			case 12:
				return typeof(Func<, , , , , , , , , , , >).MakeGenericType(types);
			case 13:
				return typeof(Func<, , , , , , , , , , , , >).MakeGenericType(types);
			case 14:
				return typeof(Func<, , , , , , , , , , , , , >).MakeGenericType(types);
			case 15:
				return typeof(Func<, , , , , , , , , , , , , , >).MakeGenericType(types);
			case 16:
				return typeof(Func<, , , , , , , , , , , , , , , >).MakeGenericType(types);
			case 17:
				return typeof(Func<, , , , , , , , , , , , , , , , >).MakeGenericType(types);
			default:
				return null;
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001639C File Offset: 0x0001459C
		internal static Type GetActionType(Type[] types)
		{
			switch (types.Length)
			{
			case 0:
				return typeof(Action);
			case 1:
				return typeof(Action<>).MakeGenericType(types);
			case 2:
				return typeof(Action<, >).MakeGenericType(types);
			case 3:
				return typeof(Action<, , >).MakeGenericType(types);
			case 4:
				return typeof(Action<, , , >).MakeGenericType(types);
			case 5:
				return typeof(Action<, , , , >).MakeGenericType(types);
			case 6:
				return typeof(Action<, , , , , >).MakeGenericType(types);
			case 7:
				return typeof(Action<, , , , , , >).MakeGenericType(types);
			case 8:
				return typeof(Action<, , , , , , , >).MakeGenericType(types);
			case 9:
				return typeof(Action<, , , , , , , , >).MakeGenericType(types);
			case 10:
				return typeof(Action<, , , , , , , , , >).MakeGenericType(types);
			case 11:
				return typeof(Action<, , , , , , , , , , >).MakeGenericType(types);
			case 12:
				return typeof(Action<, , , , , , , , , , , >).MakeGenericType(types);
			case 13:
				return typeof(Action<, , , , , , , , , , , , >).MakeGenericType(types);
			case 14:
				return typeof(Action<, , , , , , , , , , , , , >).MakeGenericType(types);
			case 15:
				return typeof(Action<, , , , , , , , , , , , , , >).MakeGenericType(types);
			case 16:
				return typeof(Action<, , , , , , , , , , , , , , , >).MakeGenericType(types);
			default:
				return null;
			}
		}
	}
}
