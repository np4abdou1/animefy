using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin
{
	// Token: 0x0200007C RID: 124
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/RequiresOptIn$Level", DoNotGenerateAcw = true)]
	public sealed class RequiresOptInLevel : Java.Lang.Enum
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00007834 File Offset: 0x00005A34
		[Nullable(2)]
		[Register("ERROR")]
		public static RequiresOptInLevel Error
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<RequiresOptInLevel>(RequiresOptInLevel._members.StaticFields.GetObjectValue("ERROR.Lkotlin/RequiresOptIn$Level;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00007864 File Offset: 0x00005A64
		[Nullable(2)]
		[Register("WARNING")]
		public static RequiresOptInLevel Warning
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<RequiresOptInLevel>(RequiresOptInLevel._members.StaticFields.GetObjectValue("WARNING.Lkotlin/RequiresOptIn$Level;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00007894 File Offset: 0x00005A94
		internal static IntPtr class_ref
		{
			get
			{
				return RequiresOptInLevel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000078B8 File Offset: 0x00005AB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequiresOptInLevel._members;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000333 RID: 819 RVA: 0x000078C0 File Offset: 0x00005AC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequiresOptInLevel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000078E4 File Offset: 0x00005AE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequiresOptInLevel._members.ManagedPeerType;
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000078F0 File Offset: 0x00005AF0
		internal RequiresOptInLevel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000336 RID: 822 RVA: 0x000078FC File Offset: 0x00005AFC
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(RequiresOptInLevel._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00007930 File Offset: 0x00005B30
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/RequiresOptIn$Level;", "")]
		public unsafe static RequiresOptInLevel ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			RequiresOptInLevel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequiresOptInLevel>(RequiresOptInLevel._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/RequiresOptIn$Level;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000799C File Offset: 0x00005B9C
		[Register("values", "()[Lkotlin/RequiresOptIn$Level;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static RequiresOptInLevel[] Values()
		{
			return (RequiresOptInLevel[])JNIEnv.GetArray(RequiresOptInLevel._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/RequiresOptIn$Level;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(RequiresOptInLevel));
		}

		// Token: 0x040000F9 RID: 249
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/RequiresOptIn$Level", typeof(RequiresOptInLevel));
	}
}
