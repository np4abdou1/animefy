using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace AndroidX.Core.OS
{
	// Token: 0x02000050 RID: 80
	[Register("androidx/core/os/LocaleListCompat", DoNotGenerateAcw = true)]
	public sealed class LocaleListCompat : Java.Lang.Object
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000027C8 File Offset: 0x000009C8
		internal static IntPtr class_ref
		{
			get
			{
				return LocaleListCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000027EC File Offset: 0x000009EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocaleListCompat._members;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000027F4 File Offset: 0x000009F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocaleListCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002818 File Offset: 0x00000A18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocaleListCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002384 File Offset: 0x00000584
		internal LocaleListCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002824 File Offset: 0x00000A24
		public static LocaleListCompat AdjustedDefault
		{
			[Register("getAdjustedDefault", "()Landroidx/core/os/LocaleListCompat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("getAdjustedDefault.()Landroidx/core/os/LocaleListCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002858 File Offset: 0x00000A58
		public static LocaleListCompat Default
		{
			[Register("getDefault", "()Landroidx/core/os/LocaleListCompat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("getDefault.()Landroidx/core/os/LocaleListCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000288C File Offset: 0x00000A8C
		public static LocaleListCompat EmptyLocaleList
		{
			[Register("getEmptyLocaleList", "()Landroidx/core/os/LocaleListCompat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("getEmptyLocaleList.()Landroidx/core/os/LocaleListCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000028BD File Offset: 0x00000ABD
		public bool IsEmpty
		{
			[Register("isEmpty", "()Z", "")]
			get
			{
				return LocaleListCompat._members.InstanceMethods.InvokeAbstractBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000028D8 File Offset: 0x00000AD8
		[Register("create", "([Ljava/util/Locale;)Landroidx/core/os/LocaleListCompat;", "")]
		public unsafe static LocaleListCompat Create(params Locale[] localeList)
		{
			IntPtr intPtr = JNIEnv.NewArray<Locale>(localeList);
			LocaleListCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("create.([Ljava/util/Locale;)Landroidx/core/os/LocaleListCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (localeList != null)
				{
					JNIEnv.CopyArray<Locale>(intPtr, localeList);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(localeList);
			}
			return @object;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002954 File Offset: 0x00000B54
		[Register("forLanguageTags", "(Ljava/lang/String;)Landroidx/core/os/LocaleListCompat;", "")]
		public unsafe static LocaleListCompat ForLanguageTags(string list)
		{
			IntPtr intPtr = JNIEnv.NewString(list);
			LocaleListCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("forLanguageTags.(Ljava/lang/String;)Landroidx/core/os/LocaleListCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000029C0 File Offset: 0x00000BC0
		[Register("get", "(I)Ljava/util/Locale;", "")]
		public unsafe Locale Get(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Locale>(LocaleListCompat._members.InstanceMethods.InvokeAbstractObjectMethod("get.(I)Ljava/util/Locale;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002A0C File Offset: 0x00000C0C
		[Register("getFirstMatch", "([Ljava/lang/String;)Ljava/util/Locale;", "")]
		public unsafe Locale GetFirstMatch(string[] supportedLocales)
		{
			IntPtr intPtr = JNIEnv.NewArray(supportedLocales);
			Locale @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Locale>(LocaleListCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getFirstMatch.([Ljava/lang/String;)Ljava/util/Locale;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (supportedLocales != null)
				{
					JNIEnv.CopyArray(intPtr, supportedLocales);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(supportedLocales);
			}
			return @object;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002A88 File Offset: 0x00000C88
		[Register("indexOf", "(Ljava/util/Locale;)I", "")]
		public unsafe int IndexOf(Locale locale)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((locale == null) ? IntPtr.Zero : locale.Handle);
				result = LocaleListCompat._members.InstanceMethods.InvokeAbstractInt32Method("indexOf.(Ljava/util/Locale;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(locale);
			}
			return result;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Register("matchesLanguageAndScript", "(Ljava/util/Locale;Ljava/util/Locale;)Z", "")]
		public unsafe static bool MatchesLanguageAndScript(Locale supported, Locale desired)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((supported == null) ? IntPtr.Zero : supported.Handle);
				ptr[1] = new JniArgumentValue((desired == null) ? IntPtr.Zero : desired.Handle);
				result = LocaleListCompat._members.StaticMethods.InvokeBooleanMethod("matchesLanguageAndScript.(Ljava/util/Locale;Ljava/util/Locale;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(supported);
				GC.KeepAlive(desired);
			}
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Register("size", "()I", "")]
		public int Size()
		{
			return LocaleListCompat._members.InstanceMethods.InvokeAbstractInt32Method("size.()I", this, null);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002B98 File Offset: 0x00000D98
		[Register("toLanguageTags", "()Ljava/lang/String;", "")]
		public string ToLanguageTags()
		{
			return JNIEnv.GetString(LocaleListCompat._members.InstanceMethods.InvokeAbstractObjectMethod("toLanguageTags.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002BCC File Offset: 0x00000DCC
		[Register("unwrap", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Unwrap()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(LocaleListCompat._members.InstanceMethods.InvokeAbstractObjectMethod("unwrap.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002C00 File Offset: 0x00000E00
		[Register("wrap", "(Landroid/os/LocaleList;)Landroidx/core/os/LocaleListCompat;", "")]
		public unsafe static LocaleListCompat Wrap(LocaleList localeList)
		{
			LocaleListCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((localeList == null) ? IntPtr.Zero : localeList.Handle);
				@object = Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("wrap.(Landroid/os/LocaleList;)Landroidx/core/os/LocaleListCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(localeList);
			}
			return @object;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002C74 File Offset: 0x00000E74
		[Register("wrap", "(Ljava/lang/Object;)Landroidx/core/os/LocaleListCompat;", "")]
		public unsafe static LocaleListCompat Wrap(Java.Lang.Object localeList)
		{
			LocaleListCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((localeList == null) ? IntPtr.Zero : localeList.Handle);
				@object = Java.Lang.Object.GetObject<LocaleListCompat>(LocaleListCompat._members.StaticMethods.InvokeObjectMethod("wrap.(Ljava/lang/Object;)Landroidx/core/os/LocaleListCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(localeList);
			}
			return @object;
		}

		// Token: 0x0400000F RID: 15
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/os/LocaleListCompat", typeof(LocaleListCompat));
	}
}
