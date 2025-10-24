using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Regex
{
	// Token: 0x02000329 RID: 809
	[Register("java/util/regex/MatchResult", DoNotGenerateAcw = true)]
	internal class IMatchResultInvoker : Java.Lang.Object, IMatchResult, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x000616A4 File Offset: 0x0005F8A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IMatchResultInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000616C8 File Offset: 0x0005F8C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMatchResultInvoker._members;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x000616CF File Offset: 0x0005F8CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000616D7 File Offset: 0x0005F8D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMatchResultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000616E3 File Offset: 0x0005F8E3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMatchResultInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.regex.MatchResult'.");
			}
			return handle;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x0006170E File Offset: 0x0005F90E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00061740 File Offset: 0x0005F940
		public IMatchResultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMatchResultInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00061778 File Offset: 0x0005F978
		private static Delegate GetEndHandler()
		{
			if (IMatchResultInvoker.cb_end == null)
			{
				IMatchResultInvoker.cb_end = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchResultInvoker.n_End));
			}
			return IMatchResultInvoker.cb_end;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0006179C File Offset: 0x0005F99C
		private static int n_End(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).End();
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000617AB File Offset: 0x0005F9AB
		public int End()
		{
			if (this.id_end == IntPtr.Zero)
			{
				this.id_end = JNIEnv.GetMethodID(this.class_ref, "end", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_end);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000617EB File Offset: 0x0005F9EB
		private static Delegate GetEnd_IHandler()
		{
			if (IMatchResultInvoker.cb_end_I == null)
			{
				IMatchResultInvoker.cb_end_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(IMatchResultInvoker.n_End_I));
			}
			return IMatchResultInvoker.cb_end_I;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0006180F File Offset: 0x0005FA0F
		private static int n_End_I(IntPtr jnienv, IntPtr native__this, int group)
		{
			return Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).End(group);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00061820 File Offset: 0x0005FA20
		public unsafe int End(int group)
		{
			if (this.id_end_I == IntPtr.Zero)
			{
				this.id_end_I = JNIEnv.GetMethodID(this.class_ref, "end", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(group);
			return JNIEnv.CallIntMethod(base.Handle, this.id_end_I, ptr);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00061884 File Offset: 0x0005FA84
		private static Delegate GetGroupHandler()
		{
			if (IMatchResultInvoker.cb_group == null)
			{
				IMatchResultInvoker.cb_group = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMatchResultInvoker.n_Group));
			}
			return IMatchResultInvoker.cb_group;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000618A8 File Offset: 0x0005FAA8
		private static IntPtr n_Group(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Group());
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000618BC File Offset: 0x0005FABC
		public string Group()
		{
			if (this.id_group == IntPtr.Zero)
			{
				this.id_group = JNIEnv.GetMethodID(this.class_ref, "group", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_group), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0006190D File Offset: 0x0005FB0D
		private static Delegate GetGroup_IHandler()
		{
			if (IMatchResultInvoker.cb_group_I == null)
			{
				IMatchResultInvoker.cb_group_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMatchResultInvoker.n_Group_I));
			}
			return IMatchResultInvoker.cb_group_I;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00061931 File Offset: 0x0005FB31
		private static IntPtr n_Group_I(IntPtr jnienv, IntPtr native__this, int group)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Group(group));
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00061948 File Offset: 0x0005FB48
		public unsafe string Group(int group)
		{
			if (this.id_group_I == IntPtr.Zero)
			{
				this.id_group_I = JNIEnv.GetMethodID(this.class_ref, "group", "(I)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(group);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_group_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000619B2 File Offset: 0x0005FBB2
		private static Delegate GetGroupCountHandler()
		{
			if (IMatchResultInvoker.cb_groupCount == null)
			{
				IMatchResultInvoker.cb_groupCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchResultInvoker.n_GroupCount));
			}
			return IMatchResultInvoker.cb_groupCount;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000619D6 File Offset: 0x0005FBD6
		private static int n_GroupCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GroupCount();
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000619E5 File Offset: 0x0005FBE5
		public int GroupCount()
		{
			if (this.id_groupCount == IntPtr.Zero)
			{
				this.id_groupCount = JNIEnv.GetMethodID(this.class_ref, "groupCount", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_groupCount);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00061A25 File Offset: 0x0005FC25
		private static Delegate GetStartHandler()
		{
			if (IMatchResultInvoker.cb_start == null)
			{
				IMatchResultInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMatchResultInvoker.n_Start));
			}
			return IMatchResultInvoker.cb_start;
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00061A49 File Offset: 0x0005FC49
		private static int n_Start(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00061A58 File Offset: 0x0005FC58
		public int Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00061A98 File Offset: 0x0005FC98
		private static Delegate GetStart_IHandler()
		{
			if (IMatchResultInvoker.cb_start_I == null)
			{
				IMatchResultInvoker.cb_start_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(IMatchResultInvoker.n_Start_I));
			}
			return IMatchResultInvoker.cb_start_I;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00061ABC File Offset: 0x0005FCBC
		private static int n_Start_I(IntPtr jnienv, IntPtr native__this, int group)
		{
			return Java.Lang.Object.GetObject<IMatchResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start(group);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00061ACC File Offset: 0x0005FCCC
		public unsafe int Start(int group)
		{
			if (this.id_start_I == IntPtr.Zero)
			{
				this.id_start_I = JNIEnv.GetMethodID(this.class_ref, "start", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(group);
			return JNIEnv.CallIntMethod(base.Handle, this.id_start_I, ptr);
		}

		// Token: 0x04000E3B RID: 3643
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/regex/MatchResult", typeof(IMatchResultInvoker));

		// Token: 0x04000E3C RID: 3644
		private IntPtr class_ref;

		// Token: 0x04000E3D RID: 3645
		private static Delegate cb_end;

		// Token: 0x04000E3E RID: 3646
		private IntPtr id_end;

		// Token: 0x04000E3F RID: 3647
		private static Delegate cb_end_I;

		// Token: 0x04000E40 RID: 3648
		private IntPtr id_end_I;

		// Token: 0x04000E41 RID: 3649
		private static Delegate cb_group;

		// Token: 0x04000E42 RID: 3650
		private IntPtr id_group;

		// Token: 0x04000E43 RID: 3651
		private static Delegate cb_group_I;

		// Token: 0x04000E44 RID: 3652
		private IntPtr id_group_I;

		// Token: 0x04000E45 RID: 3653
		private static Delegate cb_groupCount;

		// Token: 0x04000E46 RID: 3654
		private IntPtr id_groupCount;

		// Token: 0x04000E47 RID: 3655
		private static Delegate cb_start;

		// Token: 0x04000E48 RID: 3656
		private IntPtr id_start;

		// Token: 0x04000E49 RID: 3657
		private static Delegate cb_start_I;

		// Token: 0x04000E4A RID: 3658
		private IntPtr id_start_I;
	}
}
