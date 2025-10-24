using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000153 RID: 339
	[Register("com/bumptech/glide/load/engine/GlideException", DoNotGenerateAcw = true)]
	public sealed class GlideException : Java.Lang.Exception
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000378C0 File Offset: 0x00035AC0
		internal static IntPtr class_ref
		{
			get
			{
				return GlideException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x000378E4 File Offset: 0x00035AE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideException._members;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x000378EC File Offset: 0x00035AEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00037910 File Offset: 0x00035B10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideException._members.ManagedPeerType;
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0003791C File Offset: 0x00035B1C
		internal GlideException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00037928 File Offset: 0x00035B28
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GlideException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(GlideException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000379CC File Offset: 0x00035BCC
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe GlideException(string detailMessage, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(detailMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(GlideException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00037A98 File Offset: 0x00035C98
		[Register(".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe GlideException(string detailMessage, IList<Throwable> causes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(detailMessage);
			IntPtr intPtr2 = JavaList<Throwable>.ToLocalJniHandle(causes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(GlideException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/util/List;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(causes);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00037B64 File Offset: 0x00035D64
		public IList<Throwable> Causes
		{
			[Register("getCauses", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<Throwable>.FromJniHandle(GlideException._members.InstanceMethods.InvokeAbstractObjectMethod("getCauses.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00037B98 File Offset: 0x00035D98
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x00037BCC File Offset: 0x00035DCC
		public unsafe Java.Lang.Exception Origin
		{
			[Register("getOrigin", "()Ljava/lang/Exception;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Exception>(GlideException._members.InstanceMethods.InvokeAbstractObjectMethod("getOrigin.()Ljava/lang/Exception;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setOrigin", "(Ljava/lang/Exception;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					GlideException._members.InstanceMethods.InvokeAbstractVoidMethod("setOrigin.(Ljava/lang/Exception;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00037C30 File Offset: 0x00035E30
		public IList<Throwable> RootCauses
		{
			[Register("getRootCauses", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<Throwable>.FromJniHandle(GlideException._members.InstanceMethods.InvokeAbstractObjectMethod("getRootCauses.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00037C64 File Offset: 0x00035E64
		[Register("logRootCauses", "(Ljava/lang/String;)V", "")]
		public unsafe void LogRootCauses(string tag)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				GlideException._members.InstanceMethods.InvokeAbstractVoidMethod("logRootCauses.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040003EF RID: 1007
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/GlideException", typeof(GlideException));
	}
}
