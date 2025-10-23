using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200002B RID: 43
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DebugStringsKt", DoNotGenerateAcw = true)]
	public sealed class DebugStringsKt : Java.Lang.Object
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000046EC File Offset: 0x000028EC
		internal static IntPtr class_ref
		{
			get
			{
				return DebugStringsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00004710 File Offset: 0x00002910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DebugStringsKt._members;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004718 File Offset: 0x00002918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DebugStringsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000473C File Offset: 0x0000293C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DebugStringsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004748 File Offset: 0x00002948
		internal DebugStringsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004754 File Offset: 0x00002954
		[Register("getClassSimpleName", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe static string GetClassSimpleName(Java.Lang.Object obj)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@string = JNIEnv.GetString(DebugStringsKt._members.StaticMethods.InvokeObjectMethod("getClassSimpleName.(Ljava/lang/Object;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @string;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000047C8 File Offset: 0x000029C8
		[Register("getHexAddress", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe static string GetHexAddress(Java.Lang.Object obj)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@string = JNIEnv.GetString(DebugStringsKt._members.StaticMethods.InvokeObjectMethod("getHexAddress.(Ljava/lang/Object;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @string;
		}

		// Token: 0x04000021 RID: 33
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DebugStringsKt", typeof(DebugStringsKt));
	}
}
