using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000BF RID: 191
	[Register("com/unity3d/services/core/request/metrics/Metric", DoNotGenerateAcw = true)]
	public class Metric : Java.Lang.Object
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00014084 File Offset: 0x00012284
		internal static IntPtr class_ref
		{
			get
			{
				return Metric._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000140A8 File Offset: 0x000122A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Metric._members;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x000140B0 File Offset: 0x000122B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Metric._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x000140D4 File Offset: 0x000122D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Metric._members.ManagedPeerType;
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Metric(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000140E0 File Offset: 0x000122E0
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Object;Ljava/util/Map;)V", "")]
		public unsafe Metric(string name, Java.Lang.Object value, IDictionary<string, string> tags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				base.SetHandle(Metric._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Object;Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Metric._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Object;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(tags);
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000141D8 File Offset: 0x000123D8
		private static Delegate GetGetNameHandler()
		{
			if (Metric.cb_getName == null)
			{
				Metric.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Metric.n_GetName));
			}
			return Metric.cb_getName;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000141FC File Offset: 0x000123FC
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Metric>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00014210 File Offset: 0x00012410
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(Metric._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00014242 File Offset: 0x00012442
		private static Delegate GetGetTagsHandler()
		{
			if (Metric.cb_getTags == null)
			{
				Metric.cb_getTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Metric.n_GetTags));
			}
			return Metric.cb_getTags;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00014266 File Offset: 0x00012466
		private static IntPtr n_GetTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<Metric>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Tags);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0001427C File Offset: 0x0001247C
		public virtual IDictionary<string, string> Tags
		{
			[Register("getTags", "()Ljava/util/Map;", "GetGetTagsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(Metric._members.InstanceMethods.InvokeVirtualObjectMethod("getTags.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000142AE File Offset: 0x000124AE
		private static Delegate GetGetValueHandler()
		{
			if (Metric.cb_getValue == null)
			{
				Metric.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Metric.n_GetValue));
			}
			return Metric.cb_getValue;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000142D2 File Offset: 0x000124D2
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Metric>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x000142E8 File Offset: 0x000124E8
		public virtual Java.Lang.Object Value
		{
			[Register("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Metric._members.InstanceMethods.InvokeVirtualObjectMethod("getValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040001B9 RID: 441
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/Metric", typeof(Metric));

		// Token: 0x040001BA RID: 442
		private static Delegate cb_getName;

		// Token: 0x040001BB RID: 443
		private static Delegate cb_getTags;

		// Token: 0x040001BC RID: 444
		private static Delegate cb_getValue;
	}
}
