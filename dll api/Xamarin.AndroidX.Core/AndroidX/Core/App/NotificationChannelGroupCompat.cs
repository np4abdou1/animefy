using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000072 RID: 114
	[Register("androidx/core/app/NotificationChannelGroupCompat", DoNotGenerateAcw = true)]
	public class NotificationChannelGroupCompat : Java.Lang.Object
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		internal static IntPtr class_ref
		{
			get
			{
				return NotificationChannelGroupCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000D808 File Offset: 0x0000BA08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationChannelGroupCompat._members;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000D810 File Offset: 0x0000BA10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationChannelGroupCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000D834 File Offset: 0x0000BA34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationChannelGroupCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002384 File Offset: 0x00000584
		protected NotificationChannelGroupCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000D840 File Offset: 0x0000BA40
		private static Delegate GetGetChannelsHandler()
		{
			if (NotificationChannelGroupCompat.cb_getChannels == null)
			{
				NotificationChannelGroupCompat.cb_getChannels = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelGroupCompat.n_GetChannels));
			}
			return NotificationChannelGroupCompat.cb_getChannels;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000D864 File Offset: 0x0000BA64
		private static IntPtr n_GetChannels(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<NotificationChannelCompat>.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Channels);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0000D878 File Offset: 0x0000BA78
		public virtual IList<NotificationChannelCompat> Channels
		{
			[Register("getChannels", "()Ljava/util/List;", "GetGetChannelsHandler")]
			get
			{
				return JavaList<NotificationChannelCompat>.FromJniHandle(NotificationChannelGroupCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getChannels.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000D8AA File Offset: 0x0000BAAA
		private static Delegate GetGetDescriptionHandler()
		{
			if (NotificationChannelGroupCompat.cb_getDescription == null)
			{
				NotificationChannelGroupCompat.cb_getDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelGroupCompat.n_GetDescription));
			}
			return NotificationChannelGroupCompat.cb_getDescription;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000D8CE File Offset: 0x0000BACE
		private static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Description);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		public virtual string Description
		{
			[Register("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelGroupCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getDescription.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000D916 File Offset: 0x0000BB16
		private static Delegate GetGetIdHandler()
		{
			if (NotificationChannelGroupCompat.cb_getId == null)
			{
				NotificationChannelGroupCompat.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelGroupCompat.n_GetId));
			}
			return NotificationChannelGroupCompat.cb_getId;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000D93A File Offset: 0x0000BB3A
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000D950 File Offset: 0x0000BB50
		public virtual string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelGroupCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000D982 File Offset: 0x0000BB82
		private static Delegate GetIsBlockedHandler()
		{
			if (NotificationChannelGroupCompat.cb_isBlocked == null)
			{
				NotificationChannelGroupCompat.cb_isBlocked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelGroupCompat.n_IsBlocked));
			}
			return NotificationChannelGroupCompat.cb_isBlocked;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000D9A6 File Offset: 0x0000BBA6
		private static bool n_IsBlocked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsBlocked;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000D9B5 File Offset: 0x0000BBB5
		public virtual bool IsBlocked
		{
			[Register("isBlocked", "()Z", "GetIsBlockedHandler")]
			get
			{
				return NotificationChannelGroupCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isBlocked.()Z", this, null);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000D9CE File Offset: 0x0000BBCE
		private static Delegate GetGetNameHandler()
		{
			if (NotificationChannelGroupCompat.cb_getName == null)
			{
				NotificationChannelGroupCompat.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelGroupCompat.n_GetName));
			}
			return NotificationChannelGroupCompat.cb_getName;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000D9F2 File Offset: 0x0000BBF2
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NameFormatted);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000DA08 File Offset: 0x0000BC08
		public virtual ICharSequence NameFormatted
		{
			[Register("getName", "()Ljava/lang/CharSequence;", "GetGetNameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(NotificationChannelGroupCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0000DA3A File Offset: 0x0000BC3A
		public string Name
		{
			get
			{
				if (this.NameFormatted != null)
				{
					return this.NameFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000DA51 File Offset: 0x0000BC51
		private static Delegate GetToBuilderHandler()
		{
			if (NotificationChannelGroupCompat.cb_toBuilder == null)
			{
				NotificationChannelGroupCompat.cb_toBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelGroupCompat.n_ToBuilder));
			}
			return NotificationChannelGroupCompat.cb_toBuilder;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000DA75 File Offset: 0x0000BC75
		private static IntPtr n_ToBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBuilder());
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000DA8C File Offset: 0x0000BC8C
		[Register("toBuilder", "()Landroidx/core/app/NotificationChannelGroupCompat$Builder;", "GetToBuilderHandler")]
		public virtual NotificationChannelGroupCompat.Builder ToBuilder()
		{
			return Java.Lang.Object.GetObject<NotificationChannelGroupCompat.Builder>(NotificationChannelGroupCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toBuilder.()Landroidx/core/app/NotificationChannelGroupCompat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000147 RID: 327
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationChannelGroupCompat", typeof(NotificationChannelGroupCompat));

		// Token: 0x04000148 RID: 328
		private static Delegate cb_getChannels;

		// Token: 0x04000149 RID: 329
		private static Delegate cb_getDescription;

		// Token: 0x0400014A RID: 330
		private static Delegate cb_getId;

		// Token: 0x0400014B RID: 331
		private static Delegate cb_isBlocked;

		// Token: 0x0400014C RID: 332
		private static Delegate cb_getName;

		// Token: 0x0400014D RID: 333
		private static Delegate cb_toBuilder;

		// Token: 0x02000073 RID: 115
		[Register("androidx/core/app/NotificationChannelGroupCompat$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000DADC File Offset: 0x0000BCDC
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationChannelGroupCompat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000DB00 File Offset: 0x0000BD00
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationChannelGroupCompat.Builder._members;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000DB08 File Offset: 0x0000BD08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationChannelGroupCompat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000DB2C File Offset: 0x0000BD2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationChannelGroupCompat.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x00002384 File Offset: 0x00000584
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x0000DB38 File Offset: 0x0000BD38
			[Register(".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder(string id) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.NewString(id);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					base.SetHandle(NotificationChannelGroupCompat.Builder._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationChannelGroupCompat.Builder._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x0000DBDC File Offset: 0x0000BDDC
			private static Delegate GetBuildHandler()
			{
				if (NotificationChannelGroupCompat.Builder.cb_build == null)
				{
					NotificationChannelGroupCompat.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelGroupCompat.Builder.n_Build));
				}
				return NotificationChannelGroupCompat.Builder.cb_build;
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x0000DC00 File Offset: 0x0000BE00
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelGroupCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060004DC RID: 1244 RVA: 0x0000DC14 File Offset: 0x0000BE14
			[Register("build", "()Landroidx/core/app/NotificationChannelGroupCompat;", "GetBuildHandler")]
			public virtual NotificationChannelGroupCompat Build()
			{
				return Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(NotificationChannelGroupCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Landroidx/core/app/NotificationChannelGroupCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x0000DC46 File Offset: 0x0000BE46
			private static Delegate GetSetDescription_Ljava_lang_String_Handler()
			{
				if (NotificationChannelGroupCompat.Builder.cb_setDescription_Ljava_lang_String_ == null)
				{
					NotificationChannelGroupCompat.Builder.cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationChannelGroupCompat.Builder.n_SetDescription_Ljava_lang_String_));
				}
				return NotificationChannelGroupCompat.Builder.cb_setDescription_Ljava_lang_String_;
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x0000DC6C File Offset: 0x0000BE6C
			private static IntPtr n_SetDescription_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
			{
				NotificationChannelGroupCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelGroupCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_description, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetDescription(@string));
			}

			// Token: 0x060004DF RID: 1247 RVA: 0x0000DC94 File Offset: 0x0000BE94
			[Register("setDescription", "(Ljava/lang/String;)Landroidx/core/app/NotificationChannelGroupCompat$Builder;", "GetSetDescription_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationChannelGroupCompat.Builder SetDescription(string description)
			{
				IntPtr intPtr = JNIEnv.NewString(description);
				NotificationChannelGroupCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationChannelGroupCompat.Builder>(NotificationChannelGroupCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setDescription.(Ljava/lang/String;)Landroidx/core/app/NotificationChannelGroupCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x0000DD00 File Offset: 0x0000BF00
			private static Delegate GetSetName_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationChannelGroupCompat.Builder.cb_setName_Ljava_lang_CharSequence_ == null)
				{
					NotificationChannelGroupCompat.Builder.cb_setName_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationChannelGroupCompat.Builder.n_SetName_Ljava_lang_CharSequence_));
				}
				return NotificationChannelGroupCompat.Builder.cb_setName_Ljava_lang_CharSequence_;
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x0000DD24 File Offset: 0x0000BF24
			private static IntPtr n_SetName_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				NotificationChannelGroupCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelGroupCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_name, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetName(object2));
			}

			// Token: 0x060004E2 RID: 1250 RVA: 0x0000DD4C File Offset: 0x0000BF4C
			[Register("setName", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationChannelGroupCompat$Builder;", "GetSetName_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationChannelGroupCompat.Builder SetName(ICharSequence name)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(name);
				NotificationChannelGroupCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationChannelGroupCompat.Builder>(NotificationChannelGroupCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setName.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationChannelGroupCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(name);
				}
				return @object;
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
			public NotificationChannelGroupCompat.Builder SetName(string name)
			{
				Java.Lang.String @string = (name == null) ? null : new Java.Lang.String(name);
				NotificationChannelGroupCompat.Builder result = this.SetName(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0400014E RID: 334
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationChannelGroupCompat$Builder", typeof(NotificationChannelGroupCompat.Builder));

			// Token: 0x0400014F RID: 335
			private static Delegate cb_build;

			// Token: 0x04000150 RID: 336
			private static Delegate cb_setDescription_Ljava_lang_String_;

			// Token: 0x04000151 RID: 337
			private static Delegate cb_setName_Ljava_lang_CharSequence_;
		}
	}
}
