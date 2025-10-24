using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200006A RID: 106
	[Register("kotlin/Function", DoNotGenerateAcw = true)]
	internal class IFunctionInvoker : Java.Lang.Object, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000577C File Offset: 0x0000397C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000057A0 File Offset: 0x000039A0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunctionInvoker._members;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000057A7 File Offset: 0x000039A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000057AF File Offset: 0x000039AF
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000057BB File Offset: 0x000039BB
		[NullableContext(2)]
		public static IFunction GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction>(handle, transfer);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000057C4 File Offset: 0x000039C4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.Function'.");
			}
			return handle;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000057EF File Offset: 0x000039EF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00005820 File Offset: 0x00003A20
		public IFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000092 RID: 146
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Function", typeof(IFunctionInvoker));

		// Token: 0x04000093 RID: 147
		private IntPtr class_ref;
	}
}
