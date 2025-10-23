using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Text
{
	// Token: 0x02000275 RID: 629
	internal static class EncodingHelper
	{
		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0005AEA4 File Offset: 0x000590A4
		internal static Encoding UTF8Unmarked
		{
			get
			{
				if (EncodingHelper.utf8EncodingWithoutMarkers == null)
				{
					object obj = EncodingHelper.lockobj;
					lock (obj)
					{
						if (EncodingHelper.utf8EncodingWithoutMarkers == null)
						{
							EncodingHelper.utf8EncodingWithoutMarkers = new UTF8Encoding(false, false);
							EncodingHelper.utf8EncodingWithoutMarkers.setReadOnly(true);
						}
					}
				}
				return EncodingHelper.utf8EncodingWithoutMarkers;
			}
		}

		// Token: 0x06001631 RID: 5681
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string InternalCodePage(ref int code_page);

		// Token: 0x06001632 RID: 5682 RVA: 0x0005AF14 File Offset: 0x00059114
		internal static Encoding GetDefaultEncoding()
		{
			Encoding result = null;
			int num = 1;
			string name = EncodingHelper.InternalCodePage(ref num);
			try
			{
				if (num == -1)
				{
					result = Encoding.GetEncoding(name);
				}
				else
				{
					num &= 268435455;
					switch (num)
					{
					case 1:
						num = 20127;
						break;
					case 2:
						num = 65007;
						break;
					case 3:
						num = 65001;
						break;
					case 4:
						num = 1200;
						break;
					case 5:
						num = 1201;
						break;
					case 6:
						num = 1252;
						break;
					}
					result = Encoding.GetEncoding(num);
				}
			}
			catch (NotSupportedException)
			{
				result = EncodingHelper.UTF8Unmarked;
			}
			catch (ArgumentException)
			{
				result = EncodingHelper.UTF8Unmarked;
			}
			return result;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0005AFCC File Offset: 0x000591CC
		internal static object InvokeI18N(string name, params object[] args)
		{
			object obj = EncodingHelper.lockobj;
			object result;
			lock (obj)
			{
				if (EncodingHelper.i18nDisabled)
				{
					result = null;
				}
				else
				{
					if (EncodingHelper.i18nAssembly == null)
					{
						try
						{
							try
							{
								EncodingHelper.i18nAssembly = Assembly.Load("I18N, Version=2.0.5.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756");
							}
							catch (NotImplementedException)
							{
								EncodingHelper.i18nDisabled = true;
								return null;
							}
							if (EncodingHelper.i18nAssembly == null)
							{
								return null;
							}
						}
						catch (SystemException)
						{
							return null;
						}
					}
					Type type;
					try
					{
						type = EncodingHelper.i18nAssembly.GetType("I18N.Common.Manager");
					}
					catch (NotImplementedException)
					{
						EncodingHelper.i18nDisabled = true;
						return null;
					}
					if (type == null)
					{
						result = null;
					}
					else
					{
						object obj2;
						try
						{
							obj2 = type.InvokeMember("PrimaryManager", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty, null, null, null, null, null, null);
							if (obj2 == null)
							{
								return null;
							}
						}
						catch (MissingMethodException)
						{
							return null;
						}
						catch (SecurityException)
						{
							return null;
						}
						catch (NotImplementedException)
						{
							EncodingHelper.i18nDisabled = true;
							return null;
						}
						try
						{
							result = type.InvokeMember(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, obj2, args, null, null, null);
						}
						catch (MissingMethodException)
						{
							result = null;
						}
						catch (SecurityException)
						{
							result = null;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x040008A9 RID: 2217
		private static volatile Encoding utf8EncodingWithoutMarkers;

		// Token: 0x040008AA RID: 2218
		private static readonly object lockobj = new object();

		// Token: 0x040008AB RID: 2219
		private static Assembly i18nAssembly;

		// Token: 0x040008AC RID: 2220
		private static bool i18nDisabled;
	}
}
