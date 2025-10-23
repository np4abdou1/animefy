using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x0200003C RID: 60
	[Register("com/google/android/gms/ads/initialization/InitializationStatus", DoNotGenerateAcw = true)]
	internal class IInitializationStatusInvoker : Java.Lang.Object, IInitializationStatus, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00007484 File Offset: 0x00005684
		private static IntPtr java_class_ref
		{
			get
			{
				return IInitializationStatusInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000074A8 File Offset: 0x000056A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInitializationStatusInvoker._members;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000074AF File Offset: 0x000056AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600025A RID: 602 RVA: 0x000074B7 File Offset: 0x000056B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInitializationStatusInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000074C3 File Offset: 0x000056C3
		public static IInitializationStatus GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInitializationStatus>(handle, transfer);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000074CC File Offset: 0x000056CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInitializationStatusInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.initialization.InitializationStatus'.");
			}
			return handle;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000074F7 File Offset: 0x000056F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007528 File Offset: 0x00005728
		public IInitializationStatusInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInitializationStatusInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00007560 File Offset: 0x00005760
		private static Delegate GetGetAdapterStatusMapHandler()
		{
			if (IInitializationStatusInvoker.cb_getAdapterStatusMap == null)
			{
				IInitializationStatusInvoker.cb_getAdapterStatusMap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializationStatusInvoker.n_GetAdapterStatusMap));
			}
			return IInitializationStatusInvoker.cb_getAdapterStatusMap;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00007584 File Offset: 0x00005784
		private static IntPtr n_GetAdapterStatusMap(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, IAdapterStatus>.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializationStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterStatusMap);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00007598 File Offset: 0x00005798
		public IDictionary<string, IAdapterStatus> AdapterStatusMap
		{
			get
			{
				if (this.id_getAdapterStatusMap == IntPtr.Zero)
				{
					this.id_getAdapterStatusMap = JNIEnv.GetMethodID(this.class_ref, "getAdapterStatusMap", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, IAdapterStatus>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdapterStatusMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/initialization/InitializationStatus", typeof(IInitializationStatusInvoker));

		// Token: 0x04000091 RID: 145
		private IntPtr class_ref;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_getAdapterStatusMap;

		// Token: 0x04000093 RID: 147
		private IntPtr id_getAdapterStatusMap;
	}
}
