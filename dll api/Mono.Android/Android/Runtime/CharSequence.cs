using System;
using System.Collections.Generic;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002C5 RID: 709
	public static class CharSequence
	{
		// Token: 0x06001AEC RID: 6892 RVA: 0x0004651C File Offset: 0x0004471C
		public static ICharSequence[] ArrayFromStringArray(string[] val)
		{
			if (val == null)
			{
				return null;
			}
			ICharSequence[] array = new ICharSequence[val.Length];
			for (int i = 0; i < val.Length; i++)
			{
				array[i] = new Java.Lang.String(val[i]);
			}
			return array;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00046554 File Offset: 0x00044754
		public static string[] ArrayToStringArray(ICharSequence[] val)
		{
			if (val == null)
			{
				return null;
			}
			string[] array = new string[val.Length];
			for (int i = 0; i < val.Length; i++)
			{
				array[i] = val[i].ToString();
			}
			return array;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00046589 File Offset: 0x00044789
		public static IntPtr ToLocalJniHandle(string value)
		{
			return JNIEnv.NewString(value);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00046591 File Offset: 0x00044791
		public static IntPtr ToLocalJniHandle(ICharSequence value)
		{
			if (value != null)
			{
				return JNIEnv.ToLocalJniHandle(value);
			}
			return IntPtr.Zero;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000465A4 File Offset: 0x000447A4
		public static IntPtr ToLocalJniHandle(IEnumerable<char> value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			string text = value as string;
			if (text != null)
			{
				return JNIEnv.NewString(text);
			}
			if (value is ICharSequence)
			{
				return JNIEnv.ToLocalJniHandle((ICharSequence)value);
			}
			return CharSequence.ToLocalJniHandle(string.Concat<char>(value));
		}
	}
}
