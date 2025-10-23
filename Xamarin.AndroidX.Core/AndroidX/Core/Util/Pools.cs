using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Util
{
	// Token: 0x0200004D RID: 77
	[Register("androidx/core/util/Pools", DoNotGenerateAcw = true)]
	public sealed class Pools : Java.Lang.Object
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002514 File Offset: 0x00000714
		internal static IntPtr class_ref
		{
			get
			{
				return Pools._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002538 File Offset: 0x00000738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Pools._members;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002540 File Offset: 0x00000740
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Pools._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002564 File Offset: 0x00000764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Pools._members.ManagedPeerType;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002384 File Offset: 0x00000584
		internal Pools(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/util/Pools", typeof(Pools));

		// Token: 0x0200004E RID: 78
		[Register("androidx/core/util/Pools$Pool", "", "AndroidX.Core.Util.Pools/IPoolInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface IPool : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000137 RID: 311
			[Register("acquire", "()Ljava/lang/Object;", "GetAcquireHandler:AndroidX.Core.Util.Pools/IPoolInvoker, Xamarin.AndroidX.Core")]
			Java.Lang.Object Acquire();

			// Token: 0x06000138 RID: 312
			[Register("release", "(Ljava/lang/Object;)Z", "GetRelease_Ljava_lang_Object_Handler:AndroidX.Core.Util.Pools/IPoolInvoker, Xamarin.AndroidX.Core")]
			bool Release(Java.Lang.Object instance);
		}

		// Token: 0x0200004F RID: 79
		[Register("androidx/core/util/Pools$Pool", DoNotGenerateAcw = true)]
		internal class IPoolInvoker : Java.Lang.Object, Pools.IPool, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000139 RID: 313 RVA: 0x0000258C File Offset: 0x0000078C
			private static IntPtr java_class_ref
			{
				get
				{
					return Pools.IPoolInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600013A RID: 314 RVA: 0x000025B0 File Offset: 0x000007B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Pools.IPoolInvoker._members;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600013B RID: 315 RVA: 0x000025B7 File Offset: 0x000007B7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600013C RID: 316 RVA: 0x000025BF File Offset: 0x000007BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Pools.IPoolInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600013D RID: 317 RVA: 0x000025CB File Offset: 0x000007CB
			public static Pools.IPool GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Pools.IPool>(handle, transfer);
			}

			// Token: 0x0600013E RID: 318 RVA: 0x000025D4 File Offset: 0x000007D4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Pools.IPoolInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.util.Pools.Pool'.");
				}
				return handle;
			}

			// Token: 0x0600013F RID: 319 RVA: 0x000025FF File Offset: 0x000007FF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00002630 File Offset: 0x00000830
			public IPoolInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Pools.IPoolInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00002668 File Offset: 0x00000868
			private static Delegate GetAcquireHandler()
			{
				if (Pools.IPoolInvoker.cb_acquire == null)
				{
					Pools.IPoolInvoker.cb_acquire = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Pools.IPoolInvoker.n_Acquire));
				}
				return Pools.IPoolInvoker.cb_acquire;
			}

			// Token: 0x06000142 RID: 322 RVA: 0x0000268C File Offset: 0x0000088C
			private static IntPtr n_Acquire(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Pools.IPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Acquire());
			}

			// Token: 0x06000143 RID: 323 RVA: 0x000026A0 File Offset: 0x000008A0
			public Java.Lang.Object Acquire()
			{
				if (this.id_acquire == IntPtr.Zero)
				{
					this.id_acquire = JNIEnv.GetMethodID(this.class_ref, "acquire", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_acquire), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000144 RID: 324 RVA: 0x000026F1 File Offset: 0x000008F1
			private static Delegate GetRelease_Ljava_lang_Object_Handler()
			{
				if (Pools.IPoolInvoker.cb_release_Ljava_lang_Object_ == null)
				{
					Pools.IPoolInvoker.cb_release_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Pools.IPoolInvoker.n_Release_Ljava_lang_Object_));
				}
				return Pools.IPoolInvoker.cb_release_Ljava_lang_Object_;
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00002718 File Offset: 0x00000918
			private static bool n_Release_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_instance)
			{
				Pools.IPool @object = Java.Lang.Object.GetObject<Pools.IPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_instance, JniHandleOwnership.DoNotTransfer);
				return @object.Release(object2);
			}

			// Token: 0x06000146 RID: 326 RVA: 0x0000273C File Offset: 0x0000093C
			public unsafe bool Release(Java.Lang.Object instance)
			{
				if (this.id_release_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_release_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "release", "(Ljava/lang/Object;)Z");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(instance);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_release_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
				return result;
			}

			// Token: 0x04000009 RID: 9
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/util/Pools$Pool", typeof(Pools.IPoolInvoker));

			// Token: 0x0400000A RID: 10
			private IntPtr class_ref;

			// Token: 0x0400000B RID: 11
			private static Delegate cb_acquire;

			// Token: 0x0400000C RID: 12
			private IntPtr id_acquire;

			// Token: 0x0400000D RID: 13
			private static Delegate cb_release_Ljava_lang_Object_;

			// Token: 0x0400000E RID: 14
			private IntPtr id_release_Ljava_lang_Object_;
		}
	}
}
