using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000CE RID: 206
	[Register("android/widget/Filterable", DoNotGenerateAcw = true)]
	internal class IFilterableInvoker : Java.Lang.Object, IFilterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00007D2C File Offset: 0x00005F2C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFilterableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00007D50 File Offset: 0x00005F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFilterableInvoker._members;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00007D57 File Offset: 0x00005F57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00007D5F File Offset: 0x00005F5F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFilterableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00007D6B File Offset: 0x00005F6B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFilterableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.Filterable'.");
			}
			return handle;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00007D96 File Offset: 0x00005F96
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00007DC8 File Offset: 0x00005FC8
		public IFilterableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFilterableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00007E00 File Offset: 0x00006000
		private static Delegate GetGetFilterHandler()
		{
			if (IFilterableInvoker.cb_getFilter == null)
			{
				IFilterableInvoker.cb_getFilter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFilterableInvoker.n_GetFilter));
			}
			return IFilterableInvoker.cb_getFilter;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00007E24 File Offset: 0x00006024
		private static IntPtr n_GetFilter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFilterable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Filter);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00007E38 File Offset: 0x00006038
		public Filter Filter
		{
			get
			{
				if (this.id_getFilter == IntPtr.Zero)
				{
					this.id_getFilter = JNIEnv.GetMethodID(this.class_ref, "getFilter", "()Landroid/widget/Filter;");
				}
				return Java.Lang.Object.GetObject<Filter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getFilter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040000CA RID: 202
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Filterable", typeof(IFilterableInvoker));

		// Token: 0x040000CB RID: 203
		private IntPtr class_ref;

		// Token: 0x040000CC RID: 204
		private static Delegate cb_getFilter;

		// Token: 0x040000CD RID: 205
		private IntPtr id_getFilter;
	}
}
