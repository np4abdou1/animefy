using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x0200026F RID: 623
	[Register("kotlin/contracts/CallsInPlace", DoNotGenerateAcw = true)]
	internal class ICallsInPlaceInvoker : Java.Lang.Object, ICallsInPlace, IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
		private static IntPtr java_class_ref
		{
			get
			{
				return ICallsInPlaceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0005E50C File Offset: 0x0005C70C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ICallsInPlaceInvoker._members;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0005E513 File Offset: 0x0005C713
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0005E51B File Offset: 0x0005C71B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ICallsInPlaceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0005E527 File Offset: 0x0005C727
		[NullableContext(2)]
		public static ICallsInPlace GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICallsInPlace>(handle, transfer);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0005E530 File Offset: 0x0005C730
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICallsInPlaceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.CallsInPlace'.");
			}
			return handle;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0005E55B File Offset: 0x0005C75B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0005E58C File Offset: 0x0005C78C
		public ICallsInPlaceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICallsInPlaceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040008B4 RID: 2228
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/CallsInPlace", typeof(ICallsInPlaceInvoker));

		// Token: 0x040008B5 RID: 2229
		private IntPtr class_ref;
	}
}
