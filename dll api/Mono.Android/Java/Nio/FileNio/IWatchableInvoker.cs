using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000384 RID: 900
	[Register("java/nio/file/Watchable", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IWatchableInvoker : Java.Lang.Object, IWatchable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000716F0 File Offset: 0x0006F8F0
		private static IntPtr java_class_ref
		{
			get
			{
				return IWatchableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x00071714 File Offset: 0x0006F914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWatchableInvoker._members;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x0007171B File Offset: 0x0006F91B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x00071723 File Offset: 0x0006F923
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWatchableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0007172F File Offset: 0x0006F92F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWatchableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.Watchable'.");
			}
			return handle;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x0007175A File Offset: 0x0006F95A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0007178C File Offset: 0x0006F98C
		public IWatchableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWatchableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000717C4 File Offset: 0x0006F9C4
		private static Delegate GetRegister_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_Handler()
		{
			if (IWatchableInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ == null)
			{
				IWatchableInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IWatchableInvoker.n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_));
			}
			return IWatchableInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000717E8 File Offset: 0x0006F9E8
		private static IntPtr n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_(IntPtr jnienv, IntPtr native__this, IntPtr native_watcher, IntPtr native_events)
		{
			IWatchable @object = Java.Lang.Object.GetObject<IWatchable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWatchService object2 = Java.Lang.Object.GetObject<IWatchService>(native_watcher, JniHandleOwnership.DoNotTransfer);
			IWatchEventKind[] array = (IWatchEventKind[])JNIEnv.GetArray(native_events, JniHandleOwnership.DoNotTransfer, typeof(IWatchEventKind));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Register(object2, array));
			if (array != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(array, native_events);
			}
			return result;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00071834 File Offset: 0x0006FA34
		public unsafe IWatchKey Register(IWatchService watcher, params IWatchEventKind[] events)
		{
			if (this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ == IntPtr.Zero)
			{
				this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_ = JNIEnv.GetMethodID(this.class_ref, "register", "(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent$Kind;)Ljava/nio/file/WatchKey;");
			}
			IntPtr intPtr = JNIEnv.NewArray<IWatchEventKind>(events);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((watcher == null) ? IntPtr.Zero : ((Java.Lang.Object)watcher).Handle);
			ptr[1] = new JValue(intPtr);
			IWatchKey @object = Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_, ptr), JniHandleOwnership.TransferLocalRef);
			if (events != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(intPtr, events);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000718DC File Offset: 0x0006FADC
		private static Delegate GetRegister_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_Handler()
		{
			if (IWatchableInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ == null)
			{
				IWatchableInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IWatchableInvoker.n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_));
			}
			return IWatchableInvoker.cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00071900 File Offset: 0x0006FB00
		private static IntPtr n_Register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_(IntPtr jnienv, IntPtr native__this, IntPtr native_watcher, IntPtr native_events, IntPtr native_modifiers)
		{
			IWatchable @object = Java.Lang.Object.GetObject<IWatchable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWatchService object2 = Java.Lang.Object.GetObject<IWatchService>(native_watcher, JniHandleOwnership.DoNotTransfer);
			IWatchEventKind[] array = (IWatchEventKind[])JNIEnv.GetArray(native_events, JniHandleOwnership.DoNotTransfer, typeof(IWatchEventKind));
			IWatchEventModifier[] array2 = (IWatchEventModifier[])JNIEnv.GetArray(native_modifiers, JniHandleOwnership.DoNotTransfer, typeof(IWatchEventModifier));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Register(object2, array, array2));
			if (array != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(array, native_events);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray<IWatchEventModifier>(array2, native_modifiers);
			}
			return result;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00071970 File Offset: 0x0006FB70
		public unsafe IWatchKey Register(IWatchService watcher, IWatchEventKind[] events, params IWatchEventModifier[] modifiers)
		{
			if (this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ == IntPtr.Zero)
			{
				this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_ = JNIEnv.GetMethodID(this.class_ref, "register", "(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent$Kind;[Ljava/nio/file/WatchEvent$Modifier;)Ljava/nio/file/WatchKey;");
			}
			IntPtr intPtr = JNIEnv.NewArray<IWatchEventKind>(events);
			IntPtr intPtr2 = JNIEnv.NewArray<IWatchEventModifier>(modifiers);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((watcher == null) ? IntPtr.Zero : ((Java.Lang.Object)watcher).Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(intPtr2);
			IWatchKey @object = Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_, ptr), JniHandleOwnership.TransferLocalRef);
			if (events != null)
			{
				JNIEnv.CopyArray<IWatchEventKind>(intPtr, events);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (modifiers != null)
			{
				JNIEnv.CopyArray<IWatchEventModifier>(intPtr2, modifiers);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x04001069 RID: 4201
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/Watchable", typeof(IWatchableInvoker));

		// Token: 0x0400106A RID: 4202
		private IntPtr class_ref;

		// Token: 0x0400106B RID: 4203
		private static Delegate cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_;

		// Token: 0x0400106C RID: 4204
		private IntPtr id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_;

		// Token: 0x0400106D RID: 4205
		private static Delegate cb_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_;

		// Token: 0x0400106E RID: 4206
		private IntPtr id_register_Ljava_nio_file_WatchService_arrayLjava_nio_file_WatchEvent_Kind_arrayLjava_nio_file_WatchEvent_Modifier_;
	}
}
