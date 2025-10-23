using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.Utils
{
	// Token: 0x0200013B RID: 315
	[Register("com/applovin/impl/sdk/utils/StringUtils", DoNotGenerateAcw = true)]
	public class StringUtils : Java.Lang.Object
	{
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0002A8D4 File Offset: 0x00028AD4
		internal static IntPtr class_ref
		{
			get
			{
				return StringUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0002A8F8 File Offset: 0x00028AF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StringUtils._members;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0002A900 File Offset: 0x00028B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StringUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0002A924 File Offset: 0x00028B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StringUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000021F0 File Offset: 0x000003F0
		protected StringUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0002A930 File Offset: 0x00028B30
		[Register(".ctor", "()V", "")]
		public StringUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(StringUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			StringUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		[Register("appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string AppendQueryParameter(string p0, string p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JNIEnv.NewString(p2);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("appendQueryParameter.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0002AA50 File Offset: 0x00028C50
		[Register("appendQueryParameters", "(Ljava/lang/String;Ljava/util/Map;Z)Ljava/lang/String;", "")]
		public unsafe static string AppendQueryParameters(string p0, IDictionary<string, string> p1, bool p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(p2);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("appendQueryParameters.(Ljava/lang/String;Ljava/util/Map;Z)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return @string;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		[Register("containsIgnoreCase", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe static bool ContainsIgnoreCase(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = StringUtils._members.StaticMethods.InvokeBooleanMethod("containsIgnoreCase.(Ljava/lang/String;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0002AB74 File Offset: 0x00028D74
		[Register("createListItemDetailSpannedString", "(Ljava/lang/String;I)Landroid/text/SpannedString;", "")]
		public unsafe static SpannedString CreateListItemDetailSpannedString(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			SpannedString @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				@object = Java.Lang.Object.GetObject<SpannedString>(StringUtils._members.StaticMethods.InvokeObjectMethod("createListItemDetailSpannedString.(Ljava/lang/String;I)Landroid/text/SpannedString;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0002ABF4 File Offset: 0x00028DF4
		[Register("createListItemDetailSubSpannedString", "(Ljava/lang/String;I)Landroid/text/SpannedString;", "")]
		public unsafe static SpannedString CreateListItemDetailSubSpannedString(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			SpannedString @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				@object = Java.Lang.Object.GetObject<SpannedString>(StringUtils._members.StaticMethods.InvokeObjectMethod("createListItemDetailSubSpannedString.(Ljava/lang/String;I)Landroid/text/SpannedString;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0002AC74 File Offset: 0x00028E74
		[Register("createSpannedString", "(Ljava/lang/String;II)Landroid/text/SpannedString;", "")]
		public unsafe static SpannedString CreateSpannedString(string p0, int p1, int p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			SpannedString @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue(p2);
				@object = Java.Lang.Object.GetObject<SpannedString>(StringUtils._members.StaticMethods.InvokeObjectMethod("createSpannedString.(Ljava/lang/String;II)Landroid/text/SpannedString;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0002AD08 File Offset: 0x00028F08
		[Register("createSpannedString", "(Ljava/lang/String;III)Landroid/text/SpannedString;", "")]
		public unsafe static SpannedString CreateSpannedString(string p0, int p1, int p2, int p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			SpannedString @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue(p2);
				ptr[3] = new JniArgumentValue(p3);
				@object = Java.Lang.Object.GetObject<SpannedString>(StringUtils._members.StaticMethods.InvokeObjectMethod("createSpannedString.(Ljava/lang/String;III)Landroid/text/SpannedString;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0002ADB4 File Offset: 0x00028FB4
		[Register("emptyIfNull", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string EmptyIfNull(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("emptyIfNull.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0002AE20 File Offset: 0x00029020
		[Register("endsWith", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/Boolean;", "")]
		public unsafe static Java.Lang.Boolean EndsWith(string p0, IList<string> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(p1);
			Java.Lang.Boolean @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Boolean>(StringUtils._members.StaticMethods.InvokeObjectMethod("endsWith.(Ljava/lang/String;Ljava/util/List;)Ljava/lang/Boolean;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0002AEB4 File Offset: 0x000290B4
		[Register("getHostAndPath", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string GetHostAndPath(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("getHostAndPath.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0002AF20 File Offset: 0x00029120
		[Register("isAlphaNumeric", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool IsAlphaNumeric(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringUtils._members.StaticMethods.InvokeBooleanMethod("isAlphaNumeric.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0002AF7C File Offset: 0x0002917C
		[Register("isNumeric", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool IsNumeric(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringUtils._members.StaticMethods.InvokeBooleanMethod("isNumeric.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0002AFD8 File Offset: 0x000291D8
		[Register("isValidString", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool IsValidString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringUtils._members.StaticMethods.InvokeBooleanMethod("isValidString.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0002B034 File Offset: 0x00029234
		[Register("parseInt", "(Ljava/lang/String;)I", "")]
		public unsafe static int ParseInt(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringUtils._members.StaticMethods.InvokeInt32Method("parseInt.(Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0002B090 File Offset: 0x00029290
		[Register("parseInt", "(Ljava/lang/String;I)I", "")]
		public unsafe static int ParseInt(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = StringUtils._members.StaticMethods.InvokeInt32Method("parseInt.(Ljava/lang/String;I)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0002B100 File Offset: 0x00029300
		[Register("prefixToIndex", "(ILjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string PrefixToIndex(int p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("prefixToIndex.(ILjava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0002B180 File Offset: 0x00029380
		[Register("replace", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string Replace(string p0, string p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JNIEnv.NewString(p2);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("replace.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @string;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0002B230 File Offset: 0x00029430
		[Register("replace", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public unsafe static string Replace(string p0, IDictionary<string, string> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("replace.(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return @string;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0002B2C4 File Offset: 0x000294C4
		[Register("toDigitsOnlyVersionString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ToDigitsOnlyVersionString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("toDigitsOnlyVersionString.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002B330 File Offset: 0x00029530
		[Register("toFullSHA1Hash", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ToFullSHA1Hash(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("toFullSHA1Hash.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0002B39C File Offset: 0x0002959C
		[Register("toHexString", "([B)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(byte[] p0)
		{
			IntPtr intPtr = JNIEnv.NewArray(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("toHexString.([B)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (p0 != null)
				{
					JNIEnv.CopyArray(intPtr, p0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0002B418 File Offset: 0x00029618
		[Register("toHumanReadableString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ToHumanReadableString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("toHumanReadableString.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0002B484 File Offset: 0x00029684
		[Register("toShortSHA1Hash", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ToShortSHA1Hash(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(StringUtils._members.StaticMethods.InvokeObjectMethod("toShortSHA1Hash.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x040004F0 RID: 1264
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/StringUtils", typeof(StringUtils));
	}
}
