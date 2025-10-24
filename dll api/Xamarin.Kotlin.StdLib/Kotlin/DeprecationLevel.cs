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
	// Token: 0x0200004C RID: 76
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/DeprecationLevel", DoNotGenerateAcw = true)]
	public sealed class DeprecationLevel : Java.Lang.Enum
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002E44 File Offset: 0x00001044
		[Nullable(2)]
		[Register("ERROR")]
		public static DeprecationLevel Error
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<DeprecationLevel>(DeprecationLevel._members.StaticFields.GetObjectValue("ERROR.Lkotlin/DeprecationLevel;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00002E74 File Offset: 0x00001074
		[Nullable(2)]
		[Register("HIDDEN")]
		public static DeprecationLevel Hidden
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<DeprecationLevel>(DeprecationLevel._members.StaticFields.GetObjectValue("HIDDEN.Lkotlin/DeprecationLevel;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002EA4 File Offset: 0x000010A4
		[Nullable(2)]
		[Register("WARNING")]
		public static DeprecationLevel Warning
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<DeprecationLevel>(DeprecationLevel._members.StaticFields.GetObjectValue("WARNING.Lkotlin/DeprecationLevel;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002ED4 File Offset: 0x000010D4
		internal static IntPtr class_ref
		{
			get
			{
				return DeprecationLevel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002EF8 File Offset: 0x000010F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeprecationLevel._members;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002F00 File Offset: 0x00001100
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeprecationLevel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002F24 File Offset: 0x00001124
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeprecationLevel._members.ManagedPeerType;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002F30 File Offset: 0x00001130
		internal DeprecationLevel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00002F3C File Offset: 0x0000113C
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(DeprecationLevel._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002F70 File Offset: 0x00001170
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/DeprecationLevel;", "")]
		public unsafe static DeprecationLevel ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			DeprecationLevel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DeprecationLevel>(DeprecationLevel._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/DeprecationLevel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002FDC File Offset: 0x000011DC
		[Register("values", "()[Lkotlin/DeprecationLevel;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static DeprecationLevel[] Values()
		{
			return (DeprecationLevel[])JNIEnv.GetArray(DeprecationLevel._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/DeprecationLevel;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DeprecationLevel));
		}

		// Token: 0x0400001D RID: 29
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DeprecationLevel", typeof(DeprecationLevel));
	}
}
