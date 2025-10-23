using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x0200003C RID: 60
	[Register("com/bumptech/glide/GlideExperiments", DoNotGenerateAcw = true)]
	public class GlideExperiments : Java.Lang.Object
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00006A94 File Offset: 0x00004C94
		internal static IntPtr class_ref
		{
			get
			{
				return GlideExperiments._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00006AB8 File Offset: 0x00004CB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideExperiments._members;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00006AC0 File Offset: 0x00004CC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideExperiments._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00006AE4 File Offset: 0x00004CE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideExperiments._members.ManagedPeerType;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00006AF0 File Offset: 0x00004CF0
		protected GlideExperiments(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006AFA File Offset: 0x00004CFA
		private static Delegate GetIsEnabled_Ljava_lang_Class_Handler()
		{
			if (GlideExperiments.cb_isEnabled_Ljava_lang_Class_ == null)
			{
				GlideExperiments.cb_isEnabled_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GlideExperiments.n_IsEnabled_Ljava_lang_Class_));
			}
			return GlideExperiments.cb_isEnabled_Ljava_lang_Class_;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00006B20 File Offset: 0x00004D20
		private static bool n_IsEnabled_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			GlideExperiments @object = Java.Lang.Object.GetObject<GlideExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_clazz, JniHandleOwnership.DoNotTransfer);
			return @object.IsEnabled(object2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006B44 File Offset: 0x00004D44
		[Register("isEnabled", "(Ljava/lang/Class;)Z", "GetIsEnabled_Ljava_lang_Class_Handler")]
		public unsafe virtual bool IsEnabled(Class clazz)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				result = GlideExperiments._members.InstanceMethods.InvokeVirtualBooleanMethod("isEnabled.(Ljava/lang/Class;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(clazz);
			}
			return result;
		}

		// Token: 0x04000059 RID: 89
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GlideExperiments", typeof(GlideExperiments));

		// Token: 0x0400005A RID: 90
		private static Delegate cb_isEnabled_Ljava_lang_Class_;
	}
}
