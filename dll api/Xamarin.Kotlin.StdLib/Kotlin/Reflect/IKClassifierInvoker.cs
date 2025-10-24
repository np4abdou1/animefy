using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000105 RID: 261
	[Register("kotlin/reflect/KClassifier", DoNotGenerateAcw = true)]
	internal class IKClassifierInvoker : Java.Lang.Object, IKClassifier, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0002A488 File Offset: 0x00028688
		private static IntPtr java_class_ref
		{
			get
			{
				return IKClassifierInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0002A4AC File Offset: 0x000286AC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKClassifierInvoker._members;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x0002A4B3 File Offset: 0x000286B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0002A4BB File Offset: 0x000286BB
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKClassifierInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0002A4C7 File Offset: 0x000286C7
		[NullableContext(2)]
		public static IKClassifier GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKClassifier>(handle, transfer);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0002A4D0 File Offset: 0x000286D0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKClassifierInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KClassifier'.");
			}
			return handle;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0002A4FB File Offset: 0x000286FB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0002A52C File Offset: 0x0002872C
		public IKClassifierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKClassifierInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040002B8 RID: 696
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KClassifier", typeof(IKClassifierInvoker));

		// Token: 0x040002B9 RID: 697
		private IntPtr class_ref;
	}
}
