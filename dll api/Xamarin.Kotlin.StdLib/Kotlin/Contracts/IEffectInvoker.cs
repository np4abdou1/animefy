using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x02000276 RID: 630
	[Register("kotlin/contracts/Effect", DoNotGenerateAcw = true)]
	internal class IEffectInvoker : Java.Lang.Object, IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0005EB28 File Offset: 0x0005CD28
		private static IntPtr java_class_ref
		{
			get
			{
				return IEffectInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0005EB4C File Offset: 0x0005CD4C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IEffectInvoker._members;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x0005EB53 File Offset: 0x0005CD53
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0005EB5B File Offset: 0x0005CD5B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IEffectInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0005EB67 File Offset: 0x0005CD67
		[NullableContext(2)]
		public static IEffect GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEffect>(handle, transfer);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0005EB70 File Offset: 0x0005CD70
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEffectInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.Effect'.");
			}
			return handle;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0005EB9B File Offset: 0x0005CD9B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0005EBCC File Offset: 0x0005CDCC
		public IEffectInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEffectInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040008C3 RID: 2243
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/Effect", typeof(IEffectInvoker));

		// Token: 0x040008C4 RID: 2244
		private IntPtr class_ref;
	}
}
