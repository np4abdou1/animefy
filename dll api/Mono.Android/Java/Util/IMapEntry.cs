using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000312 RID: 786
	[Register("java/util/Map$Entry", "", "Java.Util.IMapEntryInvoker")]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public interface IMapEntry : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600205B RID: 8283
		Java.Lang.Object Key { get; }

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600205C RID: 8284
		Java.Lang.Object Value { get; }

		// Token: 0x0600205D RID: 8285
		bool Equals(Java.Lang.Object o);

		// Token: 0x0600205E RID: 8286
		int GetHashCode();

		// Token: 0x0600205F RID: 8287
		Java.Lang.Object SetValue(Java.Lang.Object value);

		// Token: 0x06002060 RID: 8288 RVA: 0x00058E08 File Offset: 0x00057008
		[JavaTypeParameters(new string[]
		{
			"K extends java.lang.Comparable<? super K>",
			"V"
		})]
		public static IComparator ComparingByKey()
		{
			return Java.Lang.Object.GetObject<IComparator>(IMapEntry._members.StaticMethods.InvokeObjectMethod("comparingByKey.()Ljava/util/Comparator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00058E3C File Offset: 0x0005703C
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IComparator ComparingByKey(IComparator cmp)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cmp == null) ? IntPtr.Zero : ((Java.Lang.Object)cmp).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IMapEntry._members.StaticMethods.InvokeObjectMethod("comparingByKey.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(cmp);
			}
			return @object;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00058EB4 File Offset: 0x000570B4
		[JavaTypeParameters(new string[]
		{
			"K",
			"V extends java.lang.Comparable<? super V>"
		})]
		public static IComparator ComparingByValue()
		{
			return Java.Lang.Object.GetObject<IComparator>(IMapEntry._members.StaticMethods.InvokeObjectMethod("comparingByValue.()Ljava/util/Comparator;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00058EE8 File Offset: 0x000570E8
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static IComparator ComparingByValue(IComparator cmp)
		{
			IComparator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cmp == null) ? IntPtr.Zero : ((Java.Lang.Object)cmp).Handle);
				@object = Java.Lang.Object.GetObject<IComparator>(IMapEntry._members.StaticMethods.InvokeObjectMethod("comparingByValue.(Ljava/util/Comparator;)Ljava/util/Comparator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(cmp);
			}
			return @object;
		}

		// Token: 0x04000D43 RID: 3395
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Map$Entry", typeof(IMapEntry), true);
	}
}
