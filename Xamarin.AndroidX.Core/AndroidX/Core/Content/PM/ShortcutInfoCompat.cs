using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.Graphics.Drawable;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Content.PM
{
	// Token: 0x0200005D RID: 93
	[Register("androidx/core/content/pm/ShortcutInfoCompat", DoNotGenerateAcw = true)]
	public class ShortcutInfoCompat : Java.Lang.Object
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000093EC File Offset: 0x000075EC
		internal static IntPtr class_ref
		{
			get
			{
				return ShortcutInfoCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00009410 File Offset: 0x00007610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShortcutInfoCompat._members;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00009418 File Offset: 0x00007618
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShortcutInfoCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000943C File Offset: 0x0000763C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShortcutInfoCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002384 File Offset: 0x00000584
		protected ShortcutInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00009448 File Offset: 0x00007648
		private static Delegate GetGetActivityHandler()
		{
			if (ShortcutInfoCompat.cb_getActivity == null)
			{
				ShortcutInfoCompat.cb_getActivity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetActivity));
			}
			return ShortcutInfoCompat.cb_getActivity;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000946C File Offset: 0x0000766C
		private static IntPtr n_GetActivity(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Activity);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00009480 File Offset: 0x00007680
		public virtual ComponentName Activity
		{
			[Register("getActivity", "()Landroid/content/ComponentName;", "GetGetActivityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ComponentName>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getActivity.()Landroid/content/ComponentName;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000094B2 File Offset: 0x000076B2
		private static Delegate GetGetCategoriesHandler()
		{
			if (ShortcutInfoCompat.cb_getCategories == null)
			{
				ShortcutInfoCompat.cb_getCategories = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetCategories));
			}
			return ShortcutInfoCompat.cb_getCategories;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000094D6 File Offset: 0x000076D6
		private static IntPtr n_GetCategories(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Categories);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000094EC File Offset: 0x000076EC
		public virtual ICollection<string> Categories
		{
			[Register("getCategories", "()Ljava/util/Set;", "GetGetCategoriesHandler")]
			get
			{
				return JavaSet<string>.FromJniHandle(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getCategories.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000951E File Offset: 0x0000771E
		private static Delegate GetGetDisabledMessageHandler()
		{
			if (ShortcutInfoCompat.cb_getDisabledMessage == null)
			{
				ShortcutInfoCompat.cb_getDisabledMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetDisabledMessage));
			}
			return ShortcutInfoCompat.cb_getDisabledMessage;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00009542 File Offset: 0x00007742
		private static IntPtr n_GetDisabledMessage(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisabledMessageFormatted);
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00009558 File Offset: 0x00007758
		public virtual ICharSequence DisabledMessageFormatted
		{
			[Register("getDisabledMessage", "()Ljava/lang/CharSequence;", "GetGetDisabledMessageHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getDisabledMessage.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000958A File Offset: 0x0000778A
		public string DisabledMessage
		{
			get
			{
				if (this.DisabledMessageFormatted != null)
				{
					return this.DisabledMessageFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000095A1 File Offset: 0x000077A1
		private static Delegate GetGetDisabledReasonHandler()
		{
			if (ShortcutInfoCompat.cb_getDisabledReason == null)
			{
				ShortcutInfoCompat.cb_getDisabledReason = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ShortcutInfoCompat.n_GetDisabledReason));
			}
			return ShortcutInfoCompat.cb_getDisabledReason;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000095C5 File Offset: 0x000077C5
		private static int n_GetDisabledReason(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisabledReason;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000095D4 File Offset: 0x000077D4
		public virtual int DisabledReason
		{
			[Register("getDisabledReason", "()I", "GetGetDisabledReasonHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getDisabledReason.()I", this, null);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000095ED File Offset: 0x000077ED
		private static Delegate GetGetExcludedFromSurfacesHandler()
		{
			if (ShortcutInfoCompat.cb_getExcludedFromSurfaces == null)
			{
				ShortcutInfoCompat.cb_getExcludedFromSurfaces = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ShortcutInfoCompat.n_GetExcludedFromSurfaces));
			}
			return ShortcutInfoCompat.cb_getExcludedFromSurfaces;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00009611 File Offset: 0x00007811
		private static int n_GetExcludedFromSurfaces(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExcludedFromSurfaces;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00009620 File Offset: 0x00007820
		public virtual int ExcludedFromSurfaces
		{
			[Register("getExcludedFromSurfaces", "()I", "GetGetExcludedFromSurfacesHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getExcludedFromSurfaces.()I", this, null);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00009639 File Offset: 0x00007839
		private static Delegate GetGetExtrasHandler()
		{
			if (ShortcutInfoCompat.cb_getExtras == null)
			{
				ShortcutInfoCompat.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetExtras));
			}
			return ShortcutInfoCompat.cb_getExtras;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000965D File Offset: 0x0000785D
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extras);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00009674 File Offset: 0x00007874
		public virtual PersistableBundle Extras
		{
			[Register("getExtras", "()Landroid/os/PersistableBundle;", "GetGetExtrasHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PersistableBundle>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getExtras.()Landroid/os/PersistableBundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000096A6 File Offset: 0x000078A6
		private static Delegate GetHasKeyFieldsOnlyHandler()
		{
			if (ShortcutInfoCompat.cb_hasKeyFieldsOnly == null)
			{
				ShortcutInfoCompat.cb_hasKeyFieldsOnly = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_HasKeyFieldsOnly));
			}
			return ShortcutInfoCompat.cb_hasKeyFieldsOnly;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000096CA File Offset: 0x000078CA
		private static bool n_HasKeyFieldsOnly(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasKeyFieldsOnly;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000351 RID: 849 RVA: 0x000096D9 File Offset: 0x000078D9
		public virtual bool HasKeyFieldsOnly
		{
			[Register("hasKeyFieldsOnly", "()Z", "GetHasKeyFieldsOnlyHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("hasKeyFieldsOnly.()Z", this, null);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000096F2 File Offset: 0x000078F2
		private static Delegate GetGetIconHandler()
		{
			if (ShortcutInfoCompat.cb_getIcon == null)
			{
				ShortcutInfoCompat.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetIcon));
			}
			return ShortcutInfoCompat.cb_getIcon;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00009716 File Offset: 0x00007916
		private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000972C File Offset: 0x0000792C
		public virtual IconCompat Icon
		{
			[Register("getIcon", "()Landroidx/core/graphics/drawable/IconCompat;", "GetGetIconHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IconCompat>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getIcon.()Landroidx/core/graphics/drawable/IconCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000975E File Offset: 0x0000795E
		private static Delegate GetGetIdHandler()
		{
			if (ShortcutInfoCompat.cb_getId == null)
			{
				ShortcutInfoCompat.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetId));
			}
			return ShortcutInfoCompat.cb_getId;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00009782 File Offset: 0x00007982
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00009798 File Offset: 0x00007998
		public virtual string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000097CA File Offset: 0x000079CA
		private static Delegate GetGetIntentHandler()
		{
			if (ShortcutInfoCompat.cb_getIntent == null)
			{
				ShortcutInfoCompat.cb_getIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetIntent));
			}
			return ShortcutInfoCompat.cb_getIntent;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000097EE File Offset: 0x000079EE
		private static IntPtr n_GetIntent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Intent);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00009804 File Offset: 0x00007A04
		public virtual Intent Intent
		{
			[Register("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Intent>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getIntent.()Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00009836 File Offset: 0x00007A36
		private static Delegate GetIsCachedHandler()
		{
			if (ShortcutInfoCompat.cb_isCached == null)
			{
				ShortcutInfoCompat.cb_isCached = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_IsCached));
			}
			return ShortcutInfoCompat.cb_isCached;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000985A File Offset: 0x00007A5A
		private static bool n_IsCached(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCached;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00009869 File Offset: 0x00007A69
		public virtual bool IsCached
		{
			[Register("isCached", "()Z", "GetIsCachedHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isCached.()Z", this, null);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00009882 File Offset: 0x00007A82
		private static Delegate GetIsDeclaredInManifestHandler()
		{
			if (ShortcutInfoCompat.cb_isDeclaredInManifest == null)
			{
				ShortcutInfoCompat.cb_isDeclaredInManifest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_IsDeclaredInManifest));
			}
			return ShortcutInfoCompat.cb_isDeclaredInManifest;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000098A6 File Offset: 0x00007AA6
		private static bool n_IsDeclaredInManifest(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDeclaredInManifest;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000098B5 File Offset: 0x00007AB5
		public virtual bool IsDeclaredInManifest
		{
			[Register("isDeclaredInManifest", "()Z", "GetIsDeclaredInManifestHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isDeclaredInManifest.()Z", this, null);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000098CE File Offset: 0x00007ACE
		private static Delegate GetIsDynamicHandler()
		{
			if (ShortcutInfoCompat.cb_isDynamic == null)
			{
				ShortcutInfoCompat.cb_isDynamic = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_IsDynamic));
			}
			return ShortcutInfoCompat.cb_isDynamic;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000098F2 File Offset: 0x00007AF2
		private static bool n_IsDynamic(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDynamic;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00009901 File Offset: 0x00007B01
		public virtual bool IsDynamic
		{
			[Register("isDynamic", "()Z", "GetIsDynamicHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isDynamic.()Z", this, null);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000991A File Offset: 0x00007B1A
		private static Delegate GetIsEnabledHandler()
		{
			if (ShortcutInfoCompat.cb_isEnabled == null)
			{
				ShortcutInfoCompat.cb_isEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_IsEnabled));
			}
			return ShortcutInfoCompat.cb_isEnabled;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000993E File Offset: 0x00007B3E
		private static bool n_IsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEnabled;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000994D File Offset: 0x00007B4D
		public virtual bool IsEnabled
		{
			[Register("isEnabled", "()Z", "GetIsEnabledHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00009966 File Offset: 0x00007B66
		private static Delegate GetIsImmutableHandler()
		{
			if (ShortcutInfoCompat.cb_isImmutable == null)
			{
				ShortcutInfoCompat.cb_isImmutable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_IsImmutable));
			}
			return ShortcutInfoCompat.cb_isImmutable;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000998A File Offset: 0x00007B8A
		private static bool n_IsImmutable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsImmutable;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00009999 File Offset: 0x00007B99
		public virtual bool IsImmutable
		{
			[Register("isImmutable", "()Z", "GetIsImmutableHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isImmutable.()Z", this, null);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000099B2 File Offset: 0x00007BB2
		private static Delegate GetIsPinnedHandler()
		{
			if (ShortcutInfoCompat.cb_isPinned == null)
			{
				ShortcutInfoCompat.cb_isPinned = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortcutInfoCompat.n_IsPinned));
			}
			return ShortcutInfoCompat.cb_isPinned;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000099D6 File Offset: 0x00007BD6
		private static bool n_IsPinned(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPinned;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000099E5 File Offset: 0x00007BE5
		public virtual bool IsPinned
		{
			[Register("isPinned", "()Z", "GetIsPinnedHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isPinned.()Z", this, null);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000099FE File Offset: 0x00007BFE
		private static Delegate GetGetLastChangedTimestampHandler()
		{
			if (ShortcutInfoCompat.cb_getLastChangedTimestamp == null)
			{
				ShortcutInfoCompat.cb_getLastChangedTimestamp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ShortcutInfoCompat.n_GetLastChangedTimestamp));
			}
			return ShortcutInfoCompat.cb_getLastChangedTimestamp;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00009A22 File Offset: 0x00007C22
		private static long n_GetLastChangedTimestamp(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LastChangedTimestamp;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00009A31 File Offset: 0x00007C31
		public virtual long LastChangedTimestamp
		{
			[Register("getLastChangedTimestamp", "()J", "GetGetLastChangedTimestampHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualInt64Method("getLastChangedTimestamp.()J", this, null);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00009A4A File Offset: 0x00007C4A
		private static Delegate GetGetLocusIdHandler()
		{
			if (ShortcutInfoCompat.cb_getLocusId == null)
			{
				ShortcutInfoCompat.cb_getLocusId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetLocusId));
			}
			return ShortcutInfoCompat.cb_getLocusId;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00009A6E File Offset: 0x00007C6E
		private static IntPtr n_GetLocusId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocusId);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00009A84 File Offset: 0x00007C84
		public virtual LocusIdCompat LocusId
		{
			[Register("getLocusId", "()Landroidx/core/content/LocusIdCompat;", "GetGetLocusIdHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LocusIdCompat>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLocusId.()Landroidx/core/content/LocusIdCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00009AB6 File Offset: 0x00007CB6
		private static Delegate GetGetLongLabelHandler()
		{
			if (ShortcutInfoCompat.cb_getLongLabel == null)
			{
				ShortcutInfoCompat.cb_getLongLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetLongLabel));
			}
			return ShortcutInfoCompat.cb_getLongLabel;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00009ADA File Offset: 0x00007CDA
		private static IntPtr n_GetLongLabel(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LongLabelFormatted);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public virtual ICharSequence LongLabelFormatted
		{
			[Register("getLongLabel", "()Ljava/lang/CharSequence;", "GetGetLongLabelHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLongLabel.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00009B22 File Offset: 0x00007D22
		public string LongLabel
		{
			get
			{
				if (this.LongLabelFormatted != null)
				{
					return this.LongLabelFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00009B39 File Offset: 0x00007D39
		private static Delegate GetGetPackageHandler()
		{
			if (ShortcutInfoCompat.cb_getPackage == null)
			{
				ShortcutInfoCompat.cb_getPackage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetPackage));
			}
			return ShortcutInfoCompat.cb_getPackage;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00009B5D File Offset: 0x00007D5D
		private static IntPtr n_GetPackage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Package);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00009B74 File Offset: 0x00007D74
		public virtual string Package
		{
			[Register("getPackage", "()Ljava/lang/String;", "GetGetPackageHandler")]
			get
			{
				return JNIEnv.GetString(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getPackage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00009BA6 File Offset: 0x00007DA6
		private static Delegate GetGetRankHandler()
		{
			if (ShortcutInfoCompat.cb_getRank == null)
			{
				ShortcutInfoCompat.cb_getRank = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ShortcutInfoCompat.n_GetRank));
			}
			return ShortcutInfoCompat.cb_getRank;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00009BCA File Offset: 0x00007DCA
		private static int n_GetRank(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Rank;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00009BD9 File Offset: 0x00007DD9
		public virtual int Rank
		{
			[Register("getRank", "()I", "GetGetRankHandler")]
			get
			{
				return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getRank.()I", this, null);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00009BF2 File Offset: 0x00007DF2
		private static Delegate GetGetShortLabelHandler()
		{
			if (ShortcutInfoCompat.cb_getShortLabel == null)
			{
				ShortcutInfoCompat.cb_getShortLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetShortLabel));
			}
			return ShortcutInfoCompat.cb_getShortLabel;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00009C16 File Offset: 0x00007E16
		private static IntPtr n_GetShortLabel(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShortLabelFormatted);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00009C2C File Offset: 0x00007E2C
		public virtual ICharSequence ShortLabelFormatted
		{
			[Register("getShortLabel", "()Ljava/lang/CharSequence;", "GetGetShortLabelHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getShortLabel.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00009C5E File Offset: 0x00007E5E
		public string ShortLabel
		{
			get
			{
				if (this.ShortLabelFormatted != null)
				{
					return this.ShortLabelFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00009C75 File Offset: 0x00007E75
		private static Delegate GetGetTransientExtrasHandler()
		{
			if (ShortcutInfoCompat.cb_getTransientExtras == null)
			{
				ShortcutInfoCompat.cb_getTransientExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetTransientExtras));
			}
			return ShortcutInfoCompat.cb_getTransientExtras;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00009C99 File Offset: 0x00007E99
		private static IntPtr n_GetTransientExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TransientExtras);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00009CB0 File Offset: 0x00007EB0
		public virtual Bundle TransientExtras
		{
			[Register("getTransientExtras", "()Landroid/os/Bundle;", "GetGetTransientExtrasHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTransientExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00009CE2 File Offset: 0x00007EE2
		private static Delegate GetGetUserHandleHandler()
		{
			if (ShortcutInfoCompat.cb_getUserHandle == null)
			{
				ShortcutInfoCompat.cb_getUserHandle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetUserHandle));
			}
			return ShortcutInfoCompat.cb_getUserHandle;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00009D06 File Offset: 0x00007F06
		private static IntPtr n_GetUserHandle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserHandle);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00009D1C File Offset: 0x00007F1C
		public virtual UserHandle UserHandle
		{
			[Register("getUserHandle", "()Landroid/os/UserHandle;", "GetGetUserHandleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<UserHandle>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getUserHandle.()Landroid/os/UserHandle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00009D4E File Offset: 0x00007F4E
		private static Delegate GetGetIntentsHandler()
		{
			if (ShortcutInfoCompat.cb_getIntents == null)
			{
				ShortcutInfoCompat.cb_getIntents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_GetIntents));
			}
			return ShortcutInfoCompat.cb_getIntents;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00009D72 File Offset: 0x00007F72
		private static IntPtr n_GetIntents(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Intent>(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetIntents());
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00009D88 File Offset: 0x00007F88
		[Register("getIntents", "()[Landroid/content/Intent;", "GetGetIntentsHandler")]
		public virtual Intent[] GetIntents()
		{
			return (Intent[])JNIEnv.GetArray(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getIntents.()[Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Intent));
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00009DC9 File Offset: 0x00007FC9
		private static Delegate GetIsExcludedFromSurfaces_IHandler()
		{
			if (ShortcutInfoCompat.cb_isExcludedFromSurfaces_I == null)
			{
				ShortcutInfoCompat.cb_isExcludedFromSurfaces_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(ShortcutInfoCompat.n_IsExcludedFromSurfaces_I));
			}
			return ShortcutInfoCompat.cb_isExcludedFromSurfaces_I;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00009DED File Offset: 0x00007FED
		private static bool n_IsExcludedFromSurfaces_I(IntPtr jnienv, IntPtr native__this, int surface)
		{
			return Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExcludedFromSurfaces(surface);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00009E00 File Offset: 0x00008000
		[Register("isExcludedFromSurfaces", "(I)Z", "GetIsExcludedFromSurfaces_IHandler")]
		public unsafe virtual bool IsExcludedFromSurfaces(int surface)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(surface);
			return ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isExcludedFromSurfaces.(I)Z", this, ptr);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00009E3B File Offset: 0x0000803B
		private static Delegate GetToShortcutInfoHandler()
		{
			if (ShortcutInfoCompat.cb_toShortcutInfo == null)
			{
				ShortcutInfoCompat.cb_toShortcutInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShortcutInfoCompat.n_ToShortcutInfo));
			}
			return ShortcutInfoCompat.cb_toShortcutInfo;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00009E5F File Offset: 0x0000805F
		private static IntPtr n_ToShortcutInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShortcutInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToShortcutInfo());
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00009E74 File Offset: 0x00008074
		[Register("toShortcutInfo", "()Landroid/content/pm/ShortcutInfo;", "GetToShortcutInfoHandler")]
		public virtual ShortcutInfo ToShortcutInfo()
		{
			return Java.Lang.Object.GetObject<ShortcutInfo>(ShortcutInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toShortcutInfo.()Landroid/content/pm/ShortcutInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000D9 RID: 217
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/content/pm/ShortcutInfoCompat", typeof(ShortcutInfoCompat));

		// Token: 0x040000DA RID: 218
		private static Delegate cb_getActivity;

		// Token: 0x040000DB RID: 219
		private static Delegate cb_getCategories;

		// Token: 0x040000DC RID: 220
		private static Delegate cb_getDisabledMessage;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_getDisabledReason;

		// Token: 0x040000DE RID: 222
		private static Delegate cb_getExcludedFromSurfaces;

		// Token: 0x040000DF RID: 223
		private static Delegate cb_getExtras;

		// Token: 0x040000E0 RID: 224
		private static Delegate cb_hasKeyFieldsOnly;

		// Token: 0x040000E1 RID: 225
		private static Delegate cb_getIcon;

		// Token: 0x040000E2 RID: 226
		private static Delegate cb_getId;

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_getIntent;

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_isCached;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_isDeclaredInManifest;

		// Token: 0x040000E6 RID: 230
		private static Delegate cb_isDynamic;

		// Token: 0x040000E7 RID: 231
		private static Delegate cb_isEnabled;

		// Token: 0x040000E8 RID: 232
		private static Delegate cb_isImmutable;

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_isPinned;

		// Token: 0x040000EA RID: 234
		private static Delegate cb_getLastChangedTimestamp;

		// Token: 0x040000EB RID: 235
		private static Delegate cb_getLocusId;

		// Token: 0x040000EC RID: 236
		private static Delegate cb_getLongLabel;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_getPackage;

		// Token: 0x040000EE RID: 238
		private static Delegate cb_getRank;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_getShortLabel;

		// Token: 0x040000F0 RID: 240
		private static Delegate cb_getTransientExtras;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_getUserHandle;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_getIntents;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_isExcludedFromSurfaces_I;

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_toShortcutInfo;
	}
}
