using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A2 RID: 418
	[Register("kotlin/jvm/internal/FunctionBase", DoNotGenerateAcw = true)]
	internal class IFunctionBaseInvoker : Java.Lang.Object, IFunctionBase, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x00042438 File Offset: 0x00040638
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunctionBaseInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0004245C File Offset: 0x0004065C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunctionBaseInvoker._members;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00042463 File Offset: 0x00040663
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0004246B File Offset: 0x0004066B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunctionBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00042477 File Offset: 0x00040677
		[NullableContext(2)]
		public static IFunctionBase GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunctionBase>(handle, transfer);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00042480 File Offset: 0x00040680
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunctionBaseInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.FunctionBase'.");
			}
			return handle;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x000424AB File Offset: 0x000406AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000424DC File Offset: 0x000406DC
		public IFunctionBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunctionBaseInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00042514 File Offset: 0x00040714
		[NullableContext(1)]
		private static Delegate GetGetArityHandler()
		{
			if (IFunctionBaseInvoker.cb_getArity == null)
			{
				IFunctionBaseInvoker.cb_getArity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IFunctionBaseInvoker.n_GetArity));
			}
			return IFunctionBaseInvoker.cb_getArity;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00042538 File Offset: 0x00040738
		private static int n_GetArity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFunctionBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arity;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00042547 File Offset: 0x00040747
		public int Arity
		{
			get
			{
				if (this.id_getArity == IntPtr.Zero)
				{
					this.id_getArity = JNIEnv.GetMethodID(this.class_ref, "getArity", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getArity);
			}
		}

		// Token: 0x040006AA RID: 1706
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/FunctionBase", typeof(IFunctionBaseInvoker));

		// Token: 0x040006AB RID: 1707
		private IntPtr class_ref;

		// Token: 0x040006AC RID: 1708
		[Nullable(2)]
		private static Delegate cb_getArity;

		// Token: 0x040006AD RID: 1709
		private IntPtr id_getArity;
	}
}
