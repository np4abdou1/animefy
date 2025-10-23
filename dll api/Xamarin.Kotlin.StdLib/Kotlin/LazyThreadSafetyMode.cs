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
	// Token: 0x0200008B RID: 139
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/LazyThreadSafetyMode", DoNotGenerateAcw = true)]
	public sealed class LazyThreadSafetyMode : Java.Lang.Enum
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00009514 File Offset: 0x00007714
		[Nullable(2)]
		[Register("NONE")]
		public static LazyThreadSafetyMode None
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<LazyThreadSafetyMode>(LazyThreadSafetyMode._members.StaticFields.GetObjectValue("NONE.Lkotlin/LazyThreadSafetyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00009544 File Offset: 0x00007744
		[Nullable(2)]
		[Register("PUBLICATION")]
		public static LazyThreadSafetyMode Publication
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<LazyThreadSafetyMode>(LazyThreadSafetyMode._members.StaticFields.GetObjectValue("PUBLICATION.Lkotlin/LazyThreadSafetyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00009574 File Offset: 0x00007774
		[Nullable(2)]
		[Register("SYNCHRONIZED")]
		public static LazyThreadSafetyMode Synchronized
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<LazyThreadSafetyMode>(LazyThreadSafetyMode._members.StaticFields.GetObjectValue("SYNCHRONIZED.Lkotlin/LazyThreadSafetyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000095A4 File Offset: 0x000077A4
		internal static IntPtr class_ref
		{
			get
			{
				return LazyThreadSafetyMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000095C8 File Offset: 0x000077C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LazyThreadSafetyMode._members;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000095D0 File Offset: 0x000077D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LazyThreadSafetyMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000095F4 File Offset: 0x000077F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LazyThreadSafetyMode._members.ManagedPeerType;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00009600 File Offset: 0x00007800
		internal LazyThreadSafetyMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000960C File Offset: 0x0000780C
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(LazyThreadSafetyMode._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00009640 File Offset: 0x00007840
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/LazyThreadSafetyMode;", "")]
		public unsafe static LazyThreadSafetyMode ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			LazyThreadSafetyMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LazyThreadSafetyMode>(LazyThreadSafetyMode._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/LazyThreadSafetyMode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000096AC File Offset: 0x000078AC
		[Register("values", "()[Lkotlin/LazyThreadSafetyMode;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static LazyThreadSafetyMode[] Values()
		{
			return (LazyThreadSafetyMode[])JNIEnv.GetArray(LazyThreadSafetyMode._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/LazyThreadSafetyMode;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(LazyThreadSafetyMode));
		}

		// Token: 0x0400013B RID: 315
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/LazyThreadSafetyMode", typeof(LazyThreadSafetyMode));
	}
}
