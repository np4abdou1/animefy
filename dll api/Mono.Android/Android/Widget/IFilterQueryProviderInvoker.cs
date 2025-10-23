using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Database;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000D0 RID: 208
	[Register("android/widget/FilterQueryProvider", DoNotGenerateAcw = true)]
	internal class IFilterQueryProviderInvoker : Java.Lang.Object, IFilterQueryProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00007EA4 File Offset: 0x000060A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IFilterQueryProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00007EC8 File Offset: 0x000060C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFilterQueryProviderInvoker._members;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00007ECF File Offset: 0x000060CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00007ED7 File Offset: 0x000060D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFilterQueryProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00007EE3 File Offset: 0x000060E3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFilterQueryProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.FilterQueryProvider'.");
			}
			return handle;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00007F0E File Offset: 0x0000610E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00007F40 File Offset: 0x00006140
		public IFilterQueryProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFilterQueryProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00007F78 File Offset: 0x00006178
		private static Delegate GetRunQuery_Ljava_lang_CharSequence_Handler()
		{
			if (IFilterQueryProviderInvoker.cb_runQuery_Ljava_lang_CharSequence_ == null)
			{
				IFilterQueryProviderInvoker.cb_runQuery_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFilterQueryProviderInvoker.n_RunQuery_Ljava_lang_CharSequence_));
			}
			return IFilterQueryProviderInvoker.cb_runQuery_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00007F9C File Offset: 0x0000619C
		private static IntPtr n_RunQuery_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_constraint)
		{
			IFilterQueryProvider @object = Java.Lang.Object.GetObject<IFilterQueryProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_constraint, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunQuery(object2));
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00007FC4 File Offset: 0x000061C4
		public unsafe ICursor RunQuery(ICharSequence constraint)
		{
			if (this.id_runQuery_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_runQuery_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(constraint);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ICursor @object = Java.Lang.Object.GetObject<ICursor>(JNIEnv.CallObjectMethod(base.Handle, this.id_runQuery_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x040000CE RID: 206
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/FilterQueryProvider", typeof(IFilterQueryProviderInvoker));

		// Token: 0x040000CF RID: 207
		private IntPtr class_ref;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_runQuery_Ljava_lang_CharSequence_;

		// Token: 0x040000D1 RID: 209
		private IntPtr id_runQuery_Ljava_lang_CharSequence_;
	}
}
