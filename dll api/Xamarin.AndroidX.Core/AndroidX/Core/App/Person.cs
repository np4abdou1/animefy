using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.Graphics.Drawable;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x0200007F RID: 127
	[Register("androidx/core/app/Person", DoNotGenerateAcw = true)]
	public class Person : Java.Lang.Object
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000157F0 File Offset: 0x000139F0
		internal static IntPtr class_ref
		{
			get
			{
				return Person._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00015814 File Offset: 0x00013A14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Person._members;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001581C File Offset: 0x00013A1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Person._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00015840 File Offset: 0x00013A40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Person._members.ManagedPeerType;
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00002384 File Offset: 0x00000584
		protected Person(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001584C File Offset: 0x00013A4C
		private static Delegate GetGetIconHandler()
		{
			if (Person.cb_getIcon == null)
			{
				Person.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_GetIcon));
			}
			return Person.cb_getIcon;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00015870 File Offset: 0x00013A70
		private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00015884 File Offset: 0x00013A84
		public virtual IconCompat Icon
		{
			[Register("getIcon", "()Landroidx/core/graphics/drawable/IconCompat;", "GetGetIconHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IconCompat>(Person._members.InstanceMethods.InvokeVirtualObjectMethod("getIcon.()Landroidx/core/graphics/drawable/IconCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000158B6 File Offset: 0x00013AB6
		private static Delegate GetIsBotHandler()
		{
			if (Person.cb_isBot == null)
			{
				Person.cb_isBot = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Person.n_IsBot));
			}
			return Person.cb_isBot;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000158DA File Offset: 0x00013ADA
		private static bool n_IsBot(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsBot;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000158E9 File Offset: 0x00013AE9
		public virtual bool IsBot
		{
			[Register("isBot", "()Z", "GetIsBotHandler")]
			get
			{
				return Person._members.InstanceMethods.InvokeVirtualBooleanMethod("isBot.()Z", this, null);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00015902 File Offset: 0x00013B02
		private static Delegate GetIsImportantHandler()
		{
			if (Person.cb_isImportant == null)
			{
				Person.cb_isImportant = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Person.n_IsImportant));
			}
			return Person.cb_isImportant;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00015926 File Offset: 0x00013B26
		private static bool n_IsImportant(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsImportant;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00015935 File Offset: 0x00013B35
		public virtual bool IsImportant
		{
			[Register("isImportant", "()Z", "GetIsImportantHandler")]
			get
			{
				return Person._members.InstanceMethods.InvokeVirtualBooleanMethod("isImportant.()Z", this, null);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001594E File Offset: 0x00013B4E
		private static Delegate GetGetKeyHandler()
		{
			if (Person.cb_getKey == null)
			{
				Person.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_GetKey));
			}
			return Person.cb_getKey;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00015972 File Offset: 0x00013B72
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00015988 File Offset: 0x00013B88
		public virtual string Key
		{
			[Register("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get
			{
				return JNIEnv.GetString(Person._members.InstanceMethods.InvokeVirtualObjectMethod("getKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000159BA File Offset: 0x00013BBA
		private static Delegate GetGetNameHandler()
		{
			if (Person.cb_getName == null)
			{
				Person.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_GetName));
			}
			return Person.cb_getName;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000159DE File Offset: 0x00013BDE
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NameFormatted);
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000159F4 File Offset: 0x00013BF4
		public virtual ICharSequence NameFormatted
		{
			[Register("getName", "()Ljava/lang/CharSequence;", "GetGetNameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(Person._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00015A26 File Offset: 0x00013C26
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

		// Token: 0x0600071B RID: 1819 RVA: 0x00015A3D File Offset: 0x00013C3D
		private static Delegate GetGetUriHandler()
		{
			if (Person.cb_getUri == null)
			{
				Person.cb_getUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_GetUri));
			}
			return Person.cb_getUri;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00015A61 File Offset: 0x00013C61
		private static IntPtr n_GetUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Uri);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00015A78 File Offset: 0x00013C78
		public virtual string Uri
		{
			[Register("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get
			{
				return JNIEnv.GetString(Person._members.InstanceMethods.InvokeVirtualObjectMethod("getUri.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00015AAC File Offset: 0x00013CAC
		[Register("fromAndroidPerson", "(Landroid/app/Person;)Landroidx/core/app/Person;", "")]
		public unsafe static Person FromAndroidPerson(Person person)
		{
			Person @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((person == null) ? IntPtr.Zero : person.Handle);
				@object = Java.Lang.Object.GetObject<Person>(Person._members.StaticMethods.InvokeObjectMethod("fromAndroidPerson.(Landroid/app/Person;)Landroidx/core/app/Person;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(person);
			}
			return @object;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00015B20 File Offset: 0x00013D20
		[Register("fromBundle", "(Landroid/os/Bundle;)Landroidx/core/app/Person;", "")]
		public unsafe static Person FromBundle(Bundle bundle)
		{
			Person @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				@object = Java.Lang.Object.GetObject<Person>(Person._members.StaticMethods.InvokeObjectMethod("fromBundle.(Landroid/os/Bundle;)Landroidx/core/app/Person;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bundle);
			}
			return @object;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00015B94 File Offset: 0x00013D94
		[Register("fromPersistableBundle", "(Landroid/os/PersistableBundle;)Landroidx/core/app/Person;", "")]
		public unsafe static Person FromPersistableBundle(PersistableBundle bundle)
		{
			Person @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				@object = Java.Lang.Object.GetObject<Person>(Person._members.StaticMethods.InvokeObjectMethod("fromPersistableBundle.(Landroid/os/PersistableBundle;)Landroidx/core/app/Person;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bundle);
			}
			return @object;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00015C08 File Offset: 0x00013E08
		private static Delegate GetResolveToLegacyUriHandler()
		{
			if (Person.cb_resolveToLegacyUri == null)
			{
				Person.cb_resolveToLegacyUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_ResolveToLegacyUri));
			}
			return Person.cb_resolveToLegacyUri;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00015C2C File Offset: 0x00013E2C
		private static IntPtr n_ResolveToLegacyUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResolveToLegacyUri());
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00015C40 File Offset: 0x00013E40
		[Register("resolveToLegacyUri", "()Ljava/lang/String;", "GetResolveToLegacyUriHandler")]
		public virtual string ResolveToLegacyUri()
		{
			return JNIEnv.GetString(Person._members.InstanceMethods.InvokeVirtualObjectMethod("resolveToLegacyUri.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00015C72 File Offset: 0x00013E72
		private static Delegate GetToAndroidPersonHandler()
		{
			if (Person.cb_toAndroidPerson == null)
			{
				Person.cb_toAndroidPerson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_ToAndroidPerson));
			}
			return Person.cb_toAndroidPerson;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00015C96 File Offset: 0x00013E96
		private static IntPtr n_ToAndroidPerson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToAndroidPerson());
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00015CAC File Offset: 0x00013EAC
		[Register("toAndroidPerson", "()Landroid/app/Person;", "GetToAndroidPersonHandler")]
		public virtual Person ToAndroidPerson()
		{
			return Java.Lang.Object.GetObject<Person>(Person._members.InstanceMethods.InvokeVirtualObjectMethod("toAndroidPerson.()Landroid/app/Person;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00015CDE File Offset: 0x00013EDE
		private static Delegate GetToBuilderHandler()
		{
			if (Person.cb_toBuilder == null)
			{
				Person.cb_toBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_ToBuilder));
			}
			return Person.cb_toBuilder;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00015D02 File Offset: 0x00013F02
		private static IntPtr n_ToBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBuilder());
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00015D18 File Offset: 0x00013F18
		[Register("toBuilder", "()Landroidx/core/app/Person$Builder;", "GetToBuilderHandler")]
		public virtual Person.Builder ToBuilder()
		{
			return Java.Lang.Object.GetObject<Person.Builder>(Person._members.InstanceMethods.InvokeVirtualObjectMethod("toBuilder.()Landroidx/core/app/Person$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00015D4A File Offset: 0x00013F4A
		private static Delegate GetToBundleHandler()
		{
			if (Person.cb_toBundle == null)
			{
				Person.cb_toBundle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_ToBundle));
			}
			return Person.cb_toBundle;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00015D6E File Offset: 0x00013F6E
		private static IntPtr n_ToBundle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBundle());
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00015D84 File Offset: 0x00013F84
		[Register("toBundle", "()Landroid/os/Bundle;", "GetToBundleHandler")]
		public virtual Bundle ToBundle()
		{
			return Java.Lang.Object.GetObject<Bundle>(Person._members.InstanceMethods.InvokeVirtualObjectMethod("toBundle.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00015DB6 File Offset: 0x00013FB6
		private static Delegate GetToPersistableBundleHandler()
		{
			if (Person.cb_toPersistableBundle == null)
			{
				Person.cb_toPersistableBundle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.n_ToPersistableBundle));
			}
			return Person.cb_toPersistableBundle;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00015DDA File Offset: 0x00013FDA
		private static IntPtr n_ToPersistableBundle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToPersistableBundle());
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00015DF0 File Offset: 0x00013FF0
		[Register("toPersistableBundle", "()Landroid/os/PersistableBundle;", "GetToPersistableBundleHandler")]
		public virtual PersistableBundle ToPersistableBundle()
		{
			return Java.Lang.Object.GetObject<PersistableBundle>(Person._members.InstanceMethods.InvokeVirtualObjectMethod("toPersistableBundle.()Landroid/os/PersistableBundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001D4 RID: 468
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/Person", typeof(Person));

		// Token: 0x040001D5 RID: 469
		private static Delegate cb_getIcon;

		// Token: 0x040001D6 RID: 470
		private static Delegate cb_isBot;

		// Token: 0x040001D7 RID: 471
		private static Delegate cb_isImportant;

		// Token: 0x040001D8 RID: 472
		private static Delegate cb_getKey;

		// Token: 0x040001D9 RID: 473
		private static Delegate cb_getName;

		// Token: 0x040001DA RID: 474
		private static Delegate cb_getUri;

		// Token: 0x040001DB RID: 475
		private static Delegate cb_resolveToLegacyUri;

		// Token: 0x040001DC RID: 476
		private static Delegate cb_toAndroidPerson;

		// Token: 0x040001DD RID: 477
		private static Delegate cb_toBuilder;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_toBundle;

		// Token: 0x040001DF RID: 479
		private static Delegate cb_toPersistableBundle;

		// Token: 0x02000080 RID: 128
		[Register("androidx/core/app/Person$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000731 RID: 1841 RVA: 0x00015E40 File Offset: 0x00014040
			internal static IntPtr class_ref
			{
				get
				{
					return Person.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000732 RID: 1842 RVA: 0x00015E64 File Offset: 0x00014064
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Person.Builder._members;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000733 RID: 1843 RVA: 0x00015E6C File Offset: 0x0001406C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Person.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000734 RID: 1844 RVA: 0x00015E90 File Offset: 0x00014090
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Person.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000735 RID: 1845 RVA: 0x00002384 File Offset: 0x00000584
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000736 RID: 1846 RVA: 0x00015E9C File Offset: 0x0001409C
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Person.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Person.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000737 RID: 1847 RVA: 0x00015F0A File Offset: 0x0001410A
			private static Delegate GetBuildHandler()
			{
				if (Person.Builder.cb_build == null)
				{
					Person.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Person.Builder.n_Build));
				}
				return Person.Builder.cb_build;
			}

			// Token: 0x06000738 RID: 1848 RVA: 0x00015F2E File Offset: 0x0001412E
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000739 RID: 1849 RVA: 0x00015F44 File Offset: 0x00014144
			[Register("build", "()Landroidx/core/app/Person;", "GetBuildHandler")]
			public virtual Person Build()
			{
				return Java.Lang.Object.GetObject<Person>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Landroidx/core/app/Person;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600073A RID: 1850 RVA: 0x00015F76 File Offset: 0x00014176
			private static Delegate GetSetBot_ZHandler()
			{
				if (Person.Builder.cb_setBot_Z == null)
				{
					Person.Builder.cb_setBot_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(Person.Builder.n_SetBot_Z));
				}
				return Person.Builder.cb_setBot_Z;
			}

			// Token: 0x0600073B RID: 1851 RVA: 0x00015F9A File Offset: 0x0001419A
			private static IntPtr n_SetBot_Z(IntPtr jnienv, IntPtr native__this, bool bot)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBot(bot));
			}

			// Token: 0x0600073C RID: 1852 RVA: 0x00015FB0 File Offset: 0x000141B0
			[Register("setBot", "(Z)Landroidx/core/app/Person$Builder;", "GetSetBot_ZHandler")]
			public unsafe virtual Person.Builder SetBot(bool bot)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(bot);
				return Java.Lang.Object.GetObject<Person.Builder>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setBot.(Z)Landroidx/core/app/Person$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600073D RID: 1853 RVA: 0x00015FF9 File Offset: 0x000141F9
			private static Delegate GetSetIcon_Landroidx_core_graphics_drawable_IconCompat_Handler()
			{
				if (Person.Builder.cb_setIcon_Landroidx_core_graphics_drawable_IconCompat_ == null)
				{
					Person.Builder.cb_setIcon_Landroidx_core_graphics_drawable_IconCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Person.Builder.n_SetIcon_Landroidx_core_graphics_drawable_IconCompat_));
				}
				return Person.Builder.cb_setIcon_Landroidx_core_graphics_drawable_IconCompat_;
			}

			// Token: 0x0600073E RID: 1854 RVA: 0x00016020 File Offset: 0x00014220
			private static IntPtr n_SetIcon_Landroidx_core_graphics_drawable_IconCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				Person.Builder @object = Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IconCompat object2 = Java.Lang.Object.GetObject<IconCompat>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x00016048 File Offset: 0x00014248
			[Register("setIcon", "(Landroidx/core/graphics/drawable/IconCompat;)Landroidx/core/app/Person$Builder;", "GetSetIcon_Landroidx_core_graphics_drawable_IconCompat_Handler")]
			public unsafe virtual Person.Builder SetIcon(IconCompat icon)
			{
				Person.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<Person.Builder>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(Landroidx/core/graphics/drawable/IconCompat;)Landroidx/core/app/Person$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x000160BC File Offset: 0x000142BC
			private static Delegate GetSetImportant_ZHandler()
			{
				if (Person.Builder.cb_setImportant_Z == null)
				{
					Person.Builder.cb_setImportant_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(Person.Builder.n_SetImportant_Z));
				}
				return Person.Builder.cb_setImportant_Z;
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x000160E0 File Offset: 0x000142E0
			private static IntPtr n_SetImportant_Z(IntPtr jnienv, IntPtr native__this, bool important)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetImportant(important));
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x000160F8 File Offset: 0x000142F8
			[Register("setImportant", "(Z)Landroidx/core/app/Person$Builder;", "GetSetImportant_ZHandler")]
			public unsafe virtual Person.Builder SetImportant(bool important)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(important);
				return Java.Lang.Object.GetObject<Person.Builder>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setImportant.(Z)Landroidx/core/app/Person$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000743 RID: 1859 RVA: 0x00016141 File Offset: 0x00014341
			private static Delegate GetSetKey_Ljava_lang_String_Handler()
			{
				if (Person.Builder.cb_setKey_Ljava_lang_String_ == null)
				{
					Person.Builder.cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Person.Builder.n_SetKey_Ljava_lang_String_));
				}
				return Person.Builder.cb_setKey_Ljava_lang_String_;
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x00016168 File Offset: 0x00014368
			private static IntPtr n_SetKey_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				Person.Builder @object = Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetKey(@string));
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x00016190 File Offset: 0x00014390
			[Register("setKey", "(Ljava/lang/String;)Landroidx/core/app/Person$Builder;", "GetSetKey_Ljava_lang_String_Handler")]
			public unsafe virtual Person.Builder SetKey(string key)
			{
				IntPtr intPtr = JNIEnv.NewString(key);
				Person.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Person.Builder>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setKey.(Ljava/lang/String;)Landroidx/core/app/Person$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x000161FC File Offset: 0x000143FC
			private static Delegate GetSetName_Ljava_lang_CharSequence_Handler()
			{
				if (Person.Builder.cb_setName_Ljava_lang_CharSequence_ == null)
				{
					Person.Builder.cb_setName_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Person.Builder.n_SetName_Ljava_lang_CharSequence_));
				}
				return Person.Builder.cb_setName_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000747 RID: 1863 RVA: 0x00016220 File Offset: 0x00014420
			private static IntPtr n_SetName_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				Person.Builder @object = Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_name, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetName(object2));
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x00016248 File Offset: 0x00014448
			[Register("setName", "(Ljava/lang/CharSequence;)Landroidx/core/app/Person$Builder;", "GetSetName_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual Person.Builder SetName(ICharSequence name)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(name);
				Person.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Person.Builder>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setName.(Ljava/lang/CharSequence;)Landroidx/core/app/Person$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(name);
				}
				return @object;
			}

			// Token: 0x06000749 RID: 1865 RVA: 0x000162BC File Offset: 0x000144BC
			public Person.Builder SetName(string name)
			{
				Java.Lang.String @string = (name == null) ? null : new Java.Lang.String(name);
				Person.Builder result = this.SetName(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x000162E6 File Offset: 0x000144E6
			private static Delegate GetSetUri_Ljava_lang_String_Handler()
			{
				if (Person.Builder.cb_setUri_Ljava_lang_String_ == null)
				{
					Person.Builder.cb_setUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Person.Builder.n_SetUri_Ljava_lang_String_));
				}
				return Person.Builder.cb_setUri_Ljava_lang_String_;
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x0001630C File Offset: 0x0001450C
			private static IntPtr n_SetUri_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
			{
				Person.Builder @object = Java.Lang.Object.GetObject<Person.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_uri, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetUri(@string));
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x00016334 File Offset: 0x00014534
			[Register("setUri", "(Ljava/lang/String;)Landroidx/core/app/Person$Builder;", "GetSetUri_Ljava_lang_String_Handler")]
			public unsafe virtual Person.Builder SetUri(string uri)
			{
				IntPtr intPtr = JNIEnv.NewString(uri);
				Person.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Person.Builder>(Person.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setUri.(Ljava/lang/String;)Landroidx/core/app/Person$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x040001E0 RID: 480
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/Person$Builder", typeof(Person.Builder));

			// Token: 0x040001E1 RID: 481
			private static Delegate cb_build;

			// Token: 0x040001E2 RID: 482
			private static Delegate cb_setBot_Z;

			// Token: 0x040001E3 RID: 483
			private static Delegate cb_setIcon_Landroidx_core_graphics_drawable_IconCompat_;

			// Token: 0x040001E4 RID: 484
			private static Delegate cb_setImportant_Z;

			// Token: 0x040001E5 RID: 485
			private static Delegate cb_setKey_Ljava_lang_String_;

			// Token: 0x040001E6 RID: 486
			private static Delegate cb_setName_Ljava_lang_CharSequence_;

			// Token: 0x040001E7 RID: 487
			private static Delegate cb_setUri_Ljava_lang_String_;
		}
	}
}
