using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Database;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data.Mediastore
{
	// Token: 0x0200019E RID: 414
	[Register("com/bumptech/glide/load/data/mediastore/ThumbnailQuery", DoNotGenerateAcw = true)]
	internal class IThumbnailQueryInvoker : Java.Lang.Object, IThumbnailQuery, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00042230 File Offset: 0x00040430
		private static IntPtr java_class_ref
		{
			get
			{
				return IThumbnailQueryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00042254 File Offset: 0x00040454
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IThumbnailQueryInvoker._members;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0004225B File Offset: 0x0004045B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00042263 File Offset: 0x00040463
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IThumbnailQueryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0004226F File Offset: 0x0004046F
		public static IThumbnailQuery GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IThumbnailQuery>(handle, transfer);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00042278 File Offset: 0x00040478
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IThumbnailQueryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.data.mediastore.ThumbnailQuery'.");
			}
			return handle;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000422A3 File Offset: 0x000404A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000422D4 File Offset: 0x000404D4
		public IThumbnailQueryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IThumbnailQueryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0004230C File Offset: 0x0004050C
		private static Delegate GetQuery_Landroid_net_Uri_Handler()
		{
			if (IThumbnailQueryInvoker.cb_query_Landroid_net_Uri_ == null)
			{
				IThumbnailQueryInvoker.cb_query_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IThumbnailQueryInvoker.n_Query_Landroid_net_Uri_));
			}
			return IThumbnailQueryInvoker.cb_query_Landroid_net_Uri_;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00042330 File Offset: 0x00040530
		private static IntPtr n_Query_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IThumbnailQuery @object = Java.Lang.Object.GetObject<IThumbnailQuery>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Query(object2));
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00042358 File Offset: 0x00040558
		public unsafe ICursor Query(Android.Net.Uri p0)
		{
			if (this.id_query_Landroid_net_Uri_ == IntPtr.Zero)
			{
				this.id_query_Landroid_net_Uri_ = JNIEnv.GetMethodID(this.class_ref, "query", "(Landroid/net/Uri;)Landroid/database/Cursor;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<ICursor>(JNIEnv.CallObjectMethod(base.Handle, this.id_query_Landroid_net_Uri_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040004F3 RID: 1267
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/mediastore/ThumbnailQuery", typeof(IThumbnailQueryInvoker));

		// Token: 0x040004F4 RID: 1268
		private IntPtr class_ref;

		// Token: 0x040004F5 RID: 1269
		private static Delegate cb_query_Landroid_net_Uri_;

		// Token: 0x040004F6 RID: 1270
		private IntPtr id_query_Landroid_net_Uri_;
	}
}
