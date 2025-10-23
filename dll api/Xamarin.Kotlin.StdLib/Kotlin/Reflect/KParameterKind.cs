using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.Reflect
{
	// Token: 0x0200011C RID: 284
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KParameter$Kind", DoNotGenerateAcw = true)]
	public sealed class KParameterKind : Java.Lang.Enum
	{
		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00030CE4 File Offset: 0x0002EEE4
		[Nullable(2)]
		[Register("EXTENSION_RECEIVER")]
		public static KParameterKind ExtensionReceiver
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<KParameterKind>(KParameterKind._members.StaticFields.GetObjectValue("EXTENSION_RECEIVER.Lkotlin/reflect/KParameter$Kind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00030D14 File Offset: 0x0002EF14
		[Nullable(2)]
		[Register("INSTANCE")]
		public static KParameterKind Instance
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<KParameterKind>(KParameterKind._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/reflect/KParameter$Kind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00030D44 File Offset: 0x0002EF44
		[Nullable(2)]
		[Register("VALUE")]
		public static KParameterKind Value
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<KParameterKind>(KParameterKind._members.StaticFields.GetObjectValue("VALUE.Lkotlin/reflect/KParameter$Kind;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00030D74 File Offset: 0x0002EF74
		internal static IntPtr class_ref
		{
			get
			{
				return KParameterKind._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00030D98 File Offset: 0x0002EF98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KParameterKind._members;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KParameterKind._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00030DC4 File Offset: 0x0002EFC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KParameterKind._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00030DD0 File Offset: 0x0002EFD0
		internal KParameterKind(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00030DDC File Offset: 0x0002EFDC
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(KParameterKind._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00030E10 File Offset: 0x0002F010
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/reflect/KParameter$Kind;", "")]
		public unsafe static KParameterKind ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			KParameterKind @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<KParameterKind>(KParameterKind._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/reflect/KParameter$Kind;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00030E7C File Offset: 0x0002F07C
		[Register("values", "()[Lkotlin/reflect/KParameter$Kind;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static KParameterKind[] Values()
		{
			return (KParameterKind[])JNIEnv.GetArray(KParameterKind._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/reflect/KParameter$Kind;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(KParameterKind));
		}

		// Token: 0x04000418 RID: 1048
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KParameter$Kind", typeof(KParameterKind));
	}
}
