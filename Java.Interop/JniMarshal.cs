using System;
using System.Collections;

namespace Java.Interop
{
	// Token: 0x02000068 RID: 104
	public static class JniMarshal
	{
		// Token: 0x0600038B RID: 907 RVA: 0x0000DA44 File Offset: 0x0000BC44
		public static bool RecursiveEquals(object objA, object objB)
		{
			if (object.Equals(objA, objB))
			{
				return true;
			}
			IEnumerable enumerable = objA as IEnumerable;
			IEnumerable enumerable2 = objB as IEnumerable;
			if (enumerable != null && enumerable2 != null)
			{
				IEnumerator enumerator = enumerable.GetEnumerator();
				IEnumerator enumerator2 = enumerable2.GetEnumerator();
				try
				{
					bool flag;
					bool flag2;
					do
					{
						flag = enumerator.MoveNext();
						flag2 = enumerator2.MoveNext();
						if (!flag || !flag2)
						{
							goto IL_5C;
						}
					}
					while (JniMarshal.RecursiveEquals(enumerator.Current, enumerator2.Current));
					return false;
					IL_5C:
					return flag == flag2;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					IDisposable disposable2 = enumerator2 as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
					if (disposable2 != null)
					{
						disposable2.Dispose();
					}
				}
				return false;
			}
			return false;
		}
	}
}
