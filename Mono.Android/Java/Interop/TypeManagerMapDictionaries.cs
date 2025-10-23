using System;
using System.Collections.Generic;

namespace Java.Interop
{
	// Token: 0x0200043C RID: 1084
	internal static class TypeManagerMapDictionaries
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x0008361C File Offset: 0x0008181C
		public static Dictionary<string, Type> JniToManaged
		{
			get
			{
				if (TypeManagerMapDictionaries._jniToManaged == null)
				{
					TypeManagerMapDictionaries._jniToManaged = new Dictionary<string, Type>(StringComparer.Ordinal);
				}
				return TypeManagerMapDictionaries._jniToManaged;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x00083639 File Offset: 0x00081839
		public static Dictionary<Type, string> ManagedToJni
		{
			get
			{
				if (TypeManagerMapDictionaries._managedToJni == null)
				{
					TypeManagerMapDictionaries._managedToJni = new Dictionary<Type, string>();
				}
				return TypeManagerMapDictionaries._managedToJni;
			}
		}

		// Token: 0x040012C2 RID: 4802
		private static Dictionary<string, Type> _jniToManaged;

		// Token: 0x040012C3 RID: 4803
		private static Dictionary<Type, string> _managedToJni;

		// Token: 0x040012C4 RID: 4804
		public static readonly object AccessLock = new object();
	}
}
