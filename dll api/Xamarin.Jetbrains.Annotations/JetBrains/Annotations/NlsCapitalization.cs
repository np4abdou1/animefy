using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace JetBrains.Annotations
{
	// Token: 0x0200001D RID: 29
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Nls$Capitalization", DoNotGenerateAcw = true)]
	public sealed class NlsCapitalization : Java.Lang.Enum
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003438 File Offset: 0x00001638
		[Register("NotSpecified")]
		public static NlsCapitalization NotSpecified
		{
			get
			{
				return Java.Lang.Object.GetObject<NlsCapitalization>(NlsCapitalization._members.StaticFields.GetObjectValue("NotSpecified.Lorg/jetbrains/annotations/Nls$Capitalization;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003468 File Offset: 0x00001668
		[Register("Sentence")]
		public static NlsCapitalization Sentence
		{
			get
			{
				return Java.Lang.Object.GetObject<NlsCapitalization>(NlsCapitalization._members.StaticFields.GetObjectValue("Sentence.Lorg/jetbrains/annotations/Nls$Capitalization;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003498 File Offset: 0x00001698
		[Register("Title")]
		public static NlsCapitalization Title
		{
			get
			{
				return Java.Lang.Object.GetObject<NlsCapitalization>(NlsCapitalization._members.StaticFields.GetObjectValue("Title.Lorg/jetbrains/annotations/Nls$Capitalization;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000034C8 File Offset: 0x000016C8
		internal static IntPtr class_ref
		{
			get
			{
				return NlsCapitalization._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000034EC File Offset: 0x000016EC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return NlsCapitalization._members;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000034F4 File Offset: 0x000016F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NlsCapitalization._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003518 File Offset: 0x00001718
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return NlsCapitalization._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003524 File Offset: 0x00001724
		internal NlsCapitalization(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003530 File Offset: 0x00001730
		[Register("valueOf", "(Ljava/lang/String;)Lorg/jetbrains/annotations/Nls$Capitalization;", "")]
		public unsafe static NlsCapitalization ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			NlsCapitalization @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<NlsCapitalization>(NlsCapitalization._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lorg/jetbrains/annotations/Nls$Capitalization;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000359C File Offset: 0x0000179C
		[Register("values", "()[Lorg/jetbrains/annotations/Nls$Capitalization;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static NlsCapitalization[] Values()
		{
			return (NlsCapitalization[])JNIEnv.GetArray(NlsCapitalization._members.StaticMethods.InvokeObjectMethod("values.()[Lorg/jetbrains/annotations/Nls$Capitalization;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(NlsCapitalization));
		}

		// Token: 0x04000042 RID: 66
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Nls$Capitalization", typeof(NlsCapitalization));
	}
}
