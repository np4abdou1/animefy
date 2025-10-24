using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x02000271 RID: 625
	[Register("kotlin/contracts/ConditionalEffect", DoNotGenerateAcw = true)]
	internal class IConditionalEffectInvoker : Java.Lang.Object, IConditionalEffect, IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0005E5E0 File Offset: 0x0005C7E0
		private static IntPtr java_class_ref
		{
			get
			{
				return IConditionalEffectInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0005E604 File Offset: 0x0005C804
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IConditionalEffectInvoker._members;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0005E60B File Offset: 0x0005C80B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0005E613 File Offset: 0x0005C813
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IConditionalEffectInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0005E61F File Offset: 0x0005C81F
		[NullableContext(2)]
		public static IConditionalEffect GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConditionalEffect>(handle, transfer);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0005E628 File Offset: 0x0005C828
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConditionalEffectInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.ConditionalEffect'.");
			}
			return handle;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0005E653 File Offset: 0x0005C853
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0005E684 File Offset: 0x0005C884
		public IConditionalEffectInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConditionalEffectInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040008B6 RID: 2230
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/ConditionalEffect", typeof(IConditionalEffectInvoker));

		// Token: 0x040008B7 RID: 2231
		private IntPtr class_ref;
	}
}
