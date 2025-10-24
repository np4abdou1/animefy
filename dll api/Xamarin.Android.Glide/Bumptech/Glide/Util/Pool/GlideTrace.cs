using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util.Pool
{
	// Token: 0x02000057 RID: 87
	[Register("com/bumptech/glide/util/pool/GlideTrace", DoNotGenerateAcw = true)]
	public sealed class GlideTrace : Java.Lang.Object
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		internal static IntPtr class_ref
		{
			get
			{
				return GlideTrace._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideTrace._members;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideTrace._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideTrace._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000D808 File Offset: 0x0000BA08
		internal GlideTrace(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000D814 File Offset: 0x0000BA14
		[Register("beginSection", "(Ljava/lang/String;)V", "")]
		public unsafe static void BeginSection(string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				GlideTrace._members.StaticMethods.InvokeVoidMethod("beginSection.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000D870 File Offset: 0x0000BA70
		[Register("beginSectionAsync", "(Ljava/lang/String;)I", "")]
		public unsafe static int BeginSectionAsync(string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = GlideTrace._members.StaticMethods.InvokeInt32Method("beginSectionAsync.(Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000D8CC File Offset: 0x0000BACC
		[Register("beginSectionFormat", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe static void BeginSectionFormat(string format, Java.Lang.Object arg1)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				GlideTrace._members.StaticMethods.InvokeVoidMethod("beginSectionFormat.(Ljava/lang/String;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(arg1);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000D950 File Offset: 0x0000BB50
		[Register("beginSectionFormat", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe static void BeginSectionFormat(string format, Java.Lang.Object arg1, Java.Lang.Object arg2)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				ptr[2] = new JniArgumentValue((arg2 == null) ? IntPtr.Zero : arg2.Handle);
				GlideTrace._members.StaticMethods.InvokeVoidMethod("beginSectionFormat.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(arg1);
				GC.KeepAlive(arg2);
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000DA00 File Offset: 0x0000BC00
		[Register("beginSectionFormat", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe static void BeginSectionFormat(string format, Java.Lang.Object arg1, Java.Lang.Object arg2, Java.Lang.Object arg3)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				ptr[2] = new JniArgumentValue((arg2 == null) ? IntPtr.Zero : arg2.Handle);
				ptr[3] = new JniArgumentValue((arg3 == null) ? IntPtr.Zero : arg3.Handle);
				GlideTrace._members.StaticMethods.InvokeVoidMethod("beginSectionFormat.(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(arg1);
				GC.KeepAlive(arg2);
				GC.KeepAlive(arg3);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		[Register("endSection", "()V", "")]
		public static void EndSection()
		{
			GlideTrace._members.StaticMethods.InvokeVoidMethod("endSection.()V", null);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
		[Register("endSectionAsync", "(Ljava/lang/String;I)V", "")]
		public unsafe static void EndSectionAsync(string tag, int cookie)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(cookie);
				GlideTrace._members.StaticMethods.InvokeVoidMethod("endSectionAsync.(Ljava/lang/String;I)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040000D3 RID: 211
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/GlideTrace", typeof(GlideTrace));
	}
}
