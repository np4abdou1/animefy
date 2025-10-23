using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000E0 RID: 224
	[Register("com/unity3d/services/core/misc/JsonFlattenerRules", DoNotGenerateAcw = true)]
	public class JsonFlattenerRules : Java.Lang.Object
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000194B8 File Offset: 0x000176B8
		internal static IntPtr class_ref
		{
			get
			{
				return JsonFlattenerRules._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x000194DC File Offset: 0x000176DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JsonFlattenerRules._members;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000194E4 File Offset: 0x000176E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JsonFlattenerRules._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00019508 File Offset: 0x00017708
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JsonFlattenerRules._members.ManagedPeerType;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000021E8 File Offset: 0x000003E8
		protected JsonFlattenerRules(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00019514 File Offset: 0x00017714
		[Register(".ctor", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe JsonFlattenerRules(IList<string> topLevelToInclude, IList<string> reduceKeys, IList<string> skipKeys) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(topLevelToInclude);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(reduceKeys);
			IntPtr intPtr3 = JavaList<string>.ToLocalJniHandle(skipKeys);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				base.SetHandle(JsonFlattenerRules._members.InstanceMethods.StartCreateInstance("(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				JsonFlattenerRules._members.InstanceMethods.FinishCreateInstance("(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(topLevelToInclude);
				GC.KeepAlive(reduceKeys);
				GC.KeepAlive(skipKeys);
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00019610 File Offset: 0x00017810
		private static Delegate GetGetReduceKeysHandler()
		{
			if (JsonFlattenerRules.cb_getReduceKeys == null)
			{
				JsonFlattenerRules.cb_getReduceKeys = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JsonFlattenerRules.n_GetReduceKeys));
			}
			return JsonFlattenerRules.cb_getReduceKeys;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00019634 File Offset: 0x00017834
		private static IntPtr n_GetReduceKeys(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<JsonFlattenerRules>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReduceKeys);
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00019648 File Offset: 0x00017848
		public virtual IList<string> ReduceKeys
		{
			[Register("getReduceKeys", "()Ljava/util/List;", "GetGetReduceKeysHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(JsonFlattenerRules._members.InstanceMethods.InvokeVirtualObjectMethod("getReduceKeys.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0001967A File Offset: 0x0001787A
		private static Delegate GetGetSkipKeysHandler()
		{
			if (JsonFlattenerRules.cb_getSkipKeys == null)
			{
				JsonFlattenerRules.cb_getSkipKeys = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JsonFlattenerRules.n_GetSkipKeys));
			}
			return JsonFlattenerRules.cb_getSkipKeys;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001969E File Offset: 0x0001789E
		private static IntPtr n_GetSkipKeys(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<JsonFlattenerRules>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SkipKeys);
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x000196B4 File Offset: 0x000178B4
		public virtual IList<string> SkipKeys
		{
			[Register("getSkipKeys", "()Ljava/util/List;", "GetGetSkipKeysHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(JsonFlattenerRules._members.InstanceMethods.InvokeVirtualObjectMethod("getSkipKeys.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000196E6 File Offset: 0x000178E6
		private static Delegate GetGetTopLevelToIncludeHandler()
		{
			if (JsonFlattenerRules.cb_getTopLevelToInclude == null)
			{
				JsonFlattenerRules.cb_getTopLevelToInclude = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JsonFlattenerRules.n_GetTopLevelToInclude));
			}
			return JsonFlattenerRules.cb_getTopLevelToInclude;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0001970A File Offset: 0x0001790A
		private static IntPtr n_GetTopLevelToInclude(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<JsonFlattenerRules>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopLevelToInclude);
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00019720 File Offset: 0x00017920
		public virtual IList<string> TopLevelToInclude
		{
			[Register("getTopLevelToInclude", "()Ljava/util/List;", "GetGetTopLevelToIncludeHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(JsonFlattenerRules._members.InstanceMethods.InvokeVirtualObjectMethod("getTopLevelToInclude.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000211 RID: 529
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/JsonFlattenerRules", typeof(JsonFlattenerRules));

		// Token: 0x04000212 RID: 530
		private static Delegate cb_getReduceKeys;

		// Token: 0x04000213 RID: 531
		private static Delegate cb_getSkipKeys;

		// Token: 0x04000214 RID: 532
		private static Delegate cb_getTopLevelToInclude;
	}
}
