using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO.Encoding
{
	// Token: 0x0200023B RID: 571
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/encoding/StreamEncodingKt", DoNotGenerateAcw = true)]
	public sealed class StreamEncodingKt : Java.Lang.Object
	{
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00058EB8 File Offset: 0x000570B8
		internal static IntPtr class_ref
		{
			get
			{
				return StreamEncodingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00058EDC File Offset: 0x000570DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamEncodingKt._members;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00058EE4 File Offset: 0x000570E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamEncodingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00058F08 File Offset: 0x00057108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamEncodingKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00058F14 File Offset: 0x00057114
		internal StreamEncodingKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00058F20 File Offset: 0x00057120
		[Register("decodingWith", "(Ljava/io/InputStream;Lkotlin/io/encoding/Base64;)Ljava/io/InputStream;", "")]
		public unsafe static Stream DecodingWith(Stream _this_decodingWith, Base64 base64)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(_this_decodingWith);
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((base64 == null) ? IntPtr.Zero : base64.Handle);
				result = InputStreamInvoker.FromJniHandle(StreamEncodingKt._members.StaticMethods.InvokeObjectMethod("decodingWith.(Ljava/io/InputStream;Lkotlin/io/encoding/Base64;)Ljava/io/InputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_decodingWith);
				GC.KeepAlive(base64);
			}
			return result;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00058FB8 File Offset: 0x000571B8
		[Register("encodingWith", "(Ljava/io/OutputStream;Lkotlin/io/encoding/Base64;)Ljava/io/OutputStream;", "")]
		public unsafe static Stream EncodingWith(Stream _this_encodingWith, Base64 base64)
		{
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(_this_encodingWith);
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((base64 == null) ? IntPtr.Zero : base64.Handle);
				result = OutputStreamInvoker.FromJniHandle(StreamEncodingKt._members.StaticMethods.InvokeObjectMethod("encodingWith.(Ljava/io/OutputStream;Lkotlin/io/encoding/Base64;)Ljava/io/OutputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_encodingWith);
				GC.KeepAlive(base64);
			}
			return result;
		}

		// Token: 0x04000808 RID: 2056
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/encoding/StreamEncodingKt", typeof(StreamEncodingKt));
	}
}
