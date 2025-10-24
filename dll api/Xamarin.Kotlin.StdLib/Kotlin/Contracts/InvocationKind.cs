using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.Contracts
{
	// Token: 0x02000279 RID: 633
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/contracts/InvocationKind", DoNotGenerateAcw = true)]
	public sealed class InvocationKind : Java.Lang.Enum
	{
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0005EF5C File Offset: 0x0005D15C
		[Register("AT_LEAST_ONCE")]
		public static InvocationKind AtLeastOnce
		{
			get
			{
				return Java.Lang.Object.GetObject<InvocationKind>(InvocationKind._members.StaticFields.GetObjectValue("AT_LEAST_ONCE.Lkotlin/contracts/InvocationKind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0005EF8C File Offset: 0x0005D18C
		[Register("AT_MOST_ONCE")]
		public static InvocationKind AtMostOnce
		{
			get
			{
				return Java.Lang.Object.GetObject<InvocationKind>(InvocationKind._members.StaticFields.GetObjectValue("AT_MOST_ONCE.Lkotlin/contracts/InvocationKind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0005EFBC File Offset: 0x0005D1BC
		[Register("EXACTLY_ONCE")]
		public static InvocationKind ExactlyOnce
		{
			get
			{
				return Java.Lang.Object.GetObject<InvocationKind>(InvocationKind._members.StaticFields.GetObjectValue("EXACTLY_ONCE.Lkotlin/contracts/InvocationKind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0005EFEC File Offset: 0x0005D1EC
		[Register("UNKNOWN")]
		public static InvocationKind Unknown
		{
			get
			{
				return Java.Lang.Object.GetObject<InvocationKind>(InvocationKind._members.StaticFields.GetObjectValue("UNKNOWN.Lkotlin/contracts/InvocationKind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0005F01C File Offset: 0x0005D21C
		internal static IntPtr class_ref
		{
			get
			{
				return InvocationKind._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0005F040 File Offset: 0x0005D240
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return InvocationKind._members;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0005F048 File Offset: 0x0005D248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InvocationKind._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0005F06C File Offset: 0x0005D26C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return InvocationKind._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0005F078 File Offset: 0x0005D278
		internal InvocationKind(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0005F084 File Offset: 0x0005D284
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(InvocationKind._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0005F0B8 File Offset: 0x0005D2B8
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/contracts/InvocationKind;", "")]
		public unsafe static InvocationKind ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			InvocationKind @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<InvocationKind>(InvocationKind._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/contracts/InvocationKind;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0005F124 File Offset: 0x0005D324
		[Register("values", "()[Lkotlin/contracts/InvocationKind;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static InvocationKind[] Values()
		{
			return (InvocationKind[])JNIEnv.GetArray(InvocationKind._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/contracts/InvocationKind;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(InvocationKind));
		}

		// Token: 0x040008CF RID: 2255
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/InvocationKind", typeof(InvocationKind));
	}
}
