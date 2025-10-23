using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.VersionedParcelable
{
	// Token: 0x02000007 RID: 7
	[Register("androidx/versionedparcelable/CustomVersionedParcelable", DoNotGenerateAcw = true)]
	public abstract class CustomVersionedParcelable : Java.Lang.Object, IVersionedParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return CustomVersionedParcelable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CustomVersionedParcelable._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CustomVersionedParcelable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CustomVersionedParcelable._members.ManagedPeerType;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020DC File Offset: 0x000002DC
		protected CustomVersionedParcelable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "()V", "")]
		public CustomVersionedParcelable() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CustomVersionedParcelable._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CustomVersionedParcelable._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002156 File Offset: 0x00000356
		private static Delegate GetOnPostParcelingHandler()
		{
			if (CustomVersionedParcelable.cb_onPostParceling == null)
			{
				CustomVersionedParcelable.cb_onPostParceling = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CustomVersionedParcelable.n_OnPostParceling));
			}
			return CustomVersionedParcelable.cb_onPostParceling;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000217A File Offset: 0x0000037A
		private static void n_OnPostParceling(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CustomVersionedParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPostParceling();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002189 File Offset: 0x00000389
		[Register("onPostParceling", "()V", "GetOnPostParcelingHandler")]
		public virtual void OnPostParceling()
		{
			CustomVersionedParcelable._members.InstanceMethods.InvokeVirtualVoidMethod("onPostParceling.()V", this, null);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021A2 File Offset: 0x000003A2
		private static Delegate GetOnPreParceling_ZHandler()
		{
			if (CustomVersionedParcelable.cb_onPreParceling_Z == null)
			{
				CustomVersionedParcelable.cb_onPreParceling_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CustomVersionedParcelable.n_OnPreParceling_Z));
			}
			return CustomVersionedParcelable.cb_onPreParceling_Z;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021C6 File Offset: 0x000003C6
		private static void n_OnPreParceling_Z(IntPtr jnienv, IntPtr native__this, bool isStream)
		{
			Java.Lang.Object.GetObject<CustomVersionedParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPreParceling(isStream);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021D8 File Offset: 0x000003D8
		[Register("onPreParceling", "(Z)V", "GetOnPreParceling_ZHandler")]
		public unsafe virtual void OnPreParceling(bool isStream)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isStream);
			CustomVersionedParcelable._members.InstanceMethods.InvokeVirtualVoidMethod("onPreParceling.(Z)V", this, ptr);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/versionedparcelable/CustomVersionedParcelable", typeof(CustomVersionedParcelable));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_onPostParceling;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_onPreParceling_Z;
	}
}
