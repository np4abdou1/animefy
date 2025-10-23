using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003D4 RID: 980
	[Register("java/lang/Cloneable", DoNotGenerateAcw = true)]
	internal class ICloneableInvoker : Object, ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x00078388 File Offset: 0x00076588
		private static IntPtr java_class_ref
		{
			get
			{
				return ICloneableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000783AC File Offset: 0x000765AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICloneableInvoker._members;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000783B3 File Offset: 0x000765B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000783BB File Offset: 0x000765BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICloneableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000783C7 File Offset: 0x000765C7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICloneableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Cloneable'.");
			}
			return handle;
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000783F2 File Offset: 0x000765F2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00078424 File Offset: 0x00076624
		public ICloneableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICloneableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04001158 RID: 4440
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Cloneable", typeof(ICloneableInvoker));

		// Token: 0x04001159 RID: 4441
		private IntPtr class_ref;
	}
}
