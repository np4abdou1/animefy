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
	// Token: 0x02000287 RID: 647
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/annotation/AnnotationTarget", DoNotGenerateAcw = true)]
	public sealed class AnnotationTarget : Java.Lang.Enum
	{
		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000616F0 File Offset: 0x0005F8F0
		[Register("ANNOTATION_CLASS")]
		public static AnnotationTarget AnnotationClass
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("ANNOTATION_CLASS.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00061720 File Offset: 0x0005F920
		[Register("CLASS")]
		public static AnnotationTarget Klass
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("CLASS.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00061750 File Offset: 0x0005F950
		[Register("CONSTRUCTOR")]
		public static AnnotationTarget Constructor
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("CONSTRUCTOR.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00061780 File Offset: 0x0005F980
		[Register("EXPRESSION")]
		public static AnnotationTarget Expression
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("EXPRESSION.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000617B0 File Offset: 0x0005F9B0
		[Register("FIELD")]
		public static AnnotationTarget Field
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("FIELD.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x000617E0 File Offset: 0x0005F9E0
		[Register("FILE")]
		public static AnnotationTarget File
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("FILE.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00061810 File Offset: 0x0005FA10
		[Register("FUNCTION")]
		public static AnnotationTarget Function
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("FUNCTION.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x00061840 File Offset: 0x0005FA40
		[Register("LOCAL_VARIABLE")]
		public static AnnotationTarget LocalVariable
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("LOCAL_VARIABLE.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00061870 File Offset: 0x0005FA70
		[Register("PROPERTY")]
		public static AnnotationTarget Property
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("PROPERTY.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x000618A0 File Offset: 0x0005FAA0
		[Register("PROPERTY_GETTER")]
		public static AnnotationTarget PropertyGetter
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("PROPERTY_GETTER.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x000618D0 File Offset: 0x0005FAD0
		[Register("PROPERTY_SETTER")]
		public static AnnotationTarget PropertySetter
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("PROPERTY_SETTER.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00061900 File Offset: 0x0005FB00
		[Register("TYPE")]
		public static AnnotationTarget Type
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("TYPE.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00061930 File Offset: 0x0005FB30
		[Register("TYPEALIAS")]
		public static AnnotationTarget Typealias
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("TYPEALIAS.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00061960 File Offset: 0x0005FB60
		[Register("TYPE_PARAMETER")]
		public static AnnotationTarget TypeParameter
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("TYPE_PARAMETER.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00061990 File Offset: 0x0005FB90
		[Register("VALUE_PARAMETER")]
		public static AnnotationTarget ValueParameter
		{
			get
			{
				return Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticFields.GetObjectValue("VALUE_PARAMETER.Lkotlin/annotation/AnnotationTarget;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000619C0 File Offset: 0x0005FBC0
		internal static IntPtr class_ref
		{
			get
			{
				return AnnotationTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x000619E4 File Offset: 0x0005FBE4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AnnotationTarget._members;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x000619EC File Offset: 0x0005FBEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnnotationTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00061A10 File Offset: 0x0005FC10
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AnnotationTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00061A1C File Offset: 0x0005FC1C
		internal AnnotationTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00061A28 File Offset: 0x0005FC28
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(AnnotationTarget._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00061A5C File Offset: 0x0005FC5C
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/annotation/AnnotationTarget;", "")]
		public unsafe static AnnotationTarget ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			AnnotationTarget @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AnnotationTarget>(AnnotationTarget._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/annotation/AnnotationTarget;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00061AC8 File Offset: 0x0005FCC8
		[Register("values", "()[Lkotlin/annotation/AnnotationTarget;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static AnnotationTarget[] Values()
		{
			return (AnnotationTarget[])JNIEnv.GetArray(AnnotationTarget._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/annotation/AnnotationTarget;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AnnotationTarget));
		}

		// Token: 0x040008E3 RID: 2275
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/annotation/AnnotationTarget", typeof(AnnotationTarget));
	}
}
