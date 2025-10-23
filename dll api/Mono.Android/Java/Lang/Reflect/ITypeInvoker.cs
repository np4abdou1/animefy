using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000408 RID: 1032
	[Register("java/lang/reflect/Type", DoNotGenerateAcw = true)]
	internal class ITypeInvoker : Object, IType, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x0007CF40 File Offset: 0x0007B140
		private static IntPtr java_class_ref
		{
			get
			{
				return ITypeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x0007CF64 File Offset: 0x0007B164
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITypeInvoker._members;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x0007CF6B File Offset: 0x0007B16B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x0007CF73 File Offset: 0x0007B173
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITypeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x0007CF7F File Offset: 0x0007B17F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITypeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.reflect.Type'.");
			}
			return handle;
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x0007CFAA File Offset: 0x0007B1AA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x0007CFDC File Offset: 0x0007B1DC
		public ITypeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITypeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040011EA RID: 4586
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Type", typeof(ITypeInvoker));

		// Token: 0x040011EB RID: 4587
		private IntPtr class_ref;
	}
}
