using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.Annotation
{
	// Token: 0x02000286 RID: 646
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/annotation/AnnotationRetention", DoNotGenerateAcw = true)]
	public sealed class AnnotationRetention : Java.Lang.Enum
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000614FC File Offset: 0x0005F6FC
		[Nullable(2)]
		[Register("BINARY")]
		public static AnnotationRetention Binary
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<AnnotationRetention>(AnnotationRetention._members.StaticFields.GetObjectValue("BINARY.Lkotlin/annotation/AnnotationRetention;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x0006152C File Offset: 0x0005F72C
		[Nullable(2)]
		[Register("RUNTIME")]
		public static AnnotationRetention Runtime
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<AnnotationRetention>(AnnotationRetention._members.StaticFields.GetObjectValue("RUNTIME.Lkotlin/annotation/AnnotationRetention;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0006155C File Offset: 0x0005F75C
		[Nullable(2)]
		[Register("SOURCE")]
		public static AnnotationRetention Source
		{
			[NullableContext(2)]
			get
			{
				return Java.Lang.Object.GetObject<AnnotationRetention>(AnnotationRetention._members.StaticFields.GetObjectValue("SOURCE.Lkotlin/annotation/AnnotationRetention;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0006158C File Offset: 0x0005F78C
		internal static IntPtr class_ref
		{
			get
			{
				return AnnotationRetention._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000615B0 File Offset: 0x0005F7B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnnotationRetention._members;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000615B8 File Offset: 0x0005F7B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnnotationRetention._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000615DC File Offset: 0x0005F7DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnnotationRetention._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000615E8 File Offset: 0x0005F7E8
		internal AnnotationRetention(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000615F4 File Offset: 0x0005F7F4
		public static IEnumEntries Entries
		{
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(AnnotationRetention._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00061628 File Offset: 0x0005F828
		[NullableContext(2)]
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/annotation/AnnotationRetention;", "")]
		public unsafe static AnnotationRetention ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			AnnotationRetention @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AnnotationRetention>(AnnotationRetention._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/annotation/AnnotationRetention;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00061694 File Offset: 0x0005F894
		[Register("values", "()[Lkotlin/annotation/AnnotationRetention;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static AnnotationRetention[] Values()
		{
			return (AnnotationRetention[])JNIEnv.GetArray(AnnotationRetention._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/annotation/AnnotationRetention;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AnnotationRetention));
		}

		// Token: 0x040008E2 RID: 2274
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/annotation/AnnotationRetention", typeof(AnnotationRetention));
	}
}
