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
	// Token: 0x0200013B RID: 315
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/reflect/KVisibility", DoNotGenerateAcw = true)]
	public sealed class KVisibility : Java.Lang.Enum
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00037B28 File Offset: 0x00035D28
		[Register("INTERNAL")]
		public static KVisibility Internal
		{
			get
			{
				return Java.Lang.Object.GetObject<KVisibility>(KVisibility._members.StaticFields.GetObjectValue("INTERNAL.Lkotlin/reflect/KVisibility;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00037B58 File Offset: 0x00035D58
		[Register("PRIVATE")]
		public static KVisibility Private
		{
			get
			{
				return Java.Lang.Object.GetObject<KVisibility>(KVisibility._members.StaticFields.GetObjectValue("PRIVATE.Lkotlin/reflect/KVisibility;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00037B88 File Offset: 0x00035D88
		[Register("PROTECTED")]
		public static KVisibility Protected
		{
			get
			{
				return Java.Lang.Object.GetObject<KVisibility>(KVisibility._members.StaticFields.GetObjectValue("PROTECTED.Lkotlin/reflect/KVisibility;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00037BB8 File Offset: 0x00035DB8
		[Register("PUBLIC")]
		public static KVisibility Public
		{
			get
			{
				return Java.Lang.Object.GetObject<KVisibility>(KVisibility._members.StaticFields.GetObjectValue("PUBLIC.Lkotlin/reflect/KVisibility;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00037BE8 File Offset: 0x00035DE8
		internal static IntPtr class_ref
		{
			get
			{
				return KVisibility._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00037C0C File Offset: 0x00035E0C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return KVisibility._members;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00037C14 File Offset: 0x00035E14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KVisibility._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00037C38 File Offset: 0x00035E38
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return KVisibility._members.ManagedPeerType;
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00037C44 File Offset: 0x00035E44
		internal KVisibility(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00037C50 File Offset: 0x00035E50
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(KVisibility._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00037C84 File Offset: 0x00035E84
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/reflect/KVisibility;", "")]
		public unsafe static KVisibility ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			KVisibility @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<KVisibility>(KVisibility._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/reflect/KVisibility;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00037CF0 File Offset: 0x00035EF0
		[Register("values", "()[Lkotlin/reflect/KVisibility;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static KVisibility[] Values()
		{
			return (KVisibility[])JNIEnv.GetArray(KVisibility._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/reflect/KVisibility;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(KVisibility));
		}

		// Token: 0x0400056F RID: 1391
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KVisibility", typeof(KVisibility));
	}
}
