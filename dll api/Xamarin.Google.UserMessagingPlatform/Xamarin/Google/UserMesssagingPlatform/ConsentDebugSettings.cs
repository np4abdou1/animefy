using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200000E RID: 14
	[Register("com/google/android/ump/ConsentDebugSettings", DoNotGenerateAcw = true)]
	public class ConsentDebugSettings : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002058 File Offset: 0x00000258
		internal static IntPtr class_ref
		{
			get
			{
				return ConsentDebugSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000207C File Offset: 0x0000027C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConsentDebugSettings._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002084 File Offset: 0x00000284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConsentDebugSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000020A8 File Offset: 0x000002A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConsentDebugSettings._members.ManagedPeerType;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020B4 File Offset: 0x000002B4
		protected ConsentDebugSettings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020BE File Offset: 0x000002BE
		private static Delegate GetIsTestDeviceHandler()
		{
			if (ConsentDebugSettings.cb_isTestDevice == null)
			{
				ConsentDebugSettings.cb_isTestDevice = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ConsentDebugSettings.n_IsTestDevice));
			}
			return ConsentDebugSettings.cb_isTestDevice;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020E2 File Offset: 0x000002E2
		private static bool n_IsTestDevice(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ConsentDebugSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTestDevice;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000020F1 File Offset: 0x000002F1
		public virtual bool IsTestDevice
		{
			[Register("isTestDevice", "()Z", "GetIsTestDeviceHandler")]
			get
			{
				return ConsentDebugSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isTestDevice.()Z", this, null);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000210A File Offset: 0x0000030A
		private static Delegate GetDebugGeographyDataHandler()
		{
			if (ConsentDebugSettings.cb_getDebugGeography == null)
			{
				ConsentDebugSettings.cb_getDebugGeography = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ConsentDebugSettings.n_DebugGeographyData));
			}
			return ConsentDebugSettings.cb_getDebugGeography;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000212E File Offset: 0x0000032E
		private static int n_DebugGeographyData(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ConsentDebugSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DebugGeographyData();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000213D File Offset: 0x0000033D
		[Register("getDebugGeography", "()I", "GetDebugGeographyDataHandler")]
		public virtual int DebugGeographyData()
		{
			return ConsentDebugSettings._members.InstanceMethods.InvokeVirtualInt32Method("getDebugGeography.()I", this, null);
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentDebugSettings", typeof(ConsentDebugSettings));

		// Token: 0x04000002 RID: 2
		private static Delegate cb_isTestDevice;

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getDebugGeography;

		// Token: 0x0200000F RID: 15
		[Register("com/google/android/ump/ConsentDebugSettings$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002174 File Offset: 0x00000374
			internal static IntPtr class_ref
			{
				get
				{
					return ConsentDebugSettings.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003B RID: 59 RVA: 0x00002198 File Offset: 0x00000398
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ConsentDebugSettings.Builder._members;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600003C RID: 60 RVA: 0x000021A0 File Offset: 0x000003A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ConsentDebugSettings.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600003D RID: 61 RVA: 0x000021C4 File Offset: 0x000003C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ConsentDebugSettings.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600003E RID: 62 RVA: 0x000020B4 File Offset: 0x000002B4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600003F RID: 63 RVA: 0x000021D0 File Offset: 0x000003D0
			[Register(".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(ConsentDebugSettings.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ConsentDebugSettings.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00002280 File Offset: 0x00000480
			private static Delegate GetAddTestDeviceHashedId_Ljava_lang_String_Handler()
			{
				if (ConsentDebugSettings.Builder.cb_addTestDeviceHashedId_Ljava_lang_String_ == null)
				{
					ConsentDebugSettings.Builder.cb_addTestDeviceHashedId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ConsentDebugSettings.Builder.n_AddTestDeviceHashedId_Ljava_lang_String_));
				}
				return ConsentDebugSettings.Builder.cb_addTestDeviceHashedId_Ljava_lang_String_;
			}

			// Token: 0x06000041 RID: 65 RVA: 0x000022A4 File Offset: 0x000004A4
			private static IntPtr n_AddTestDeviceHashedId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_hashedId)
			{
				ConsentDebugSettings.Builder @object = Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_hashedId, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddTestDeviceHashedId(@string));
			}

			// Token: 0x06000042 RID: 66 RVA: 0x000022CC File Offset: 0x000004CC
			[Register("addTestDeviceHashedId", "(Ljava/lang/String;)Lcom/google/android/ump/ConsentDebugSettings$Builder;", "GetAddTestDeviceHashedId_Ljava_lang_String_Handler")]
			public unsafe virtual ConsentDebugSettings.Builder AddTestDeviceHashedId(string hashedId)
			{
				IntPtr intPtr = JNIEnv.NewString(hashedId);
				ConsentDebugSettings.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(ConsentDebugSettings.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addTestDeviceHashedId.(Ljava/lang/String;)Lcom/google/android/ump/ConsentDebugSettings$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00002338 File Offset: 0x00000538
			private static Delegate GetBuildHandler()
			{
				if (ConsentDebugSettings.Builder.cb_build == null)
				{
					ConsentDebugSettings.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConsentDebugSettings.Builder.n_Build));
				}
				return ConsentDebugSettings.Builder.cb_build;
			}

			// Token: 0x06000044 RID: 68 RVA: 0x0000235C File Offset: 0x0000055C
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000045 RID: 69 RVA: 0x00002370 File Offset: 0x00000570
			[Register("build", "()Lcom/google/android/ump/ConsentDebugSettings;", "GetBuildHandler")]
			public virtual ConsentDebugSettings Build()
			{
				return Java.Lang.Object.GetObject<ConsentDebugSettings>(ConsentDebugSettings.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/google/android/ump/ConsentDebugSettings;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000046 RID: 70 RVA: 0x000023A2 File Offset: 0x000005A2
			private static Delegate GetSetDebugGeography_IHandler()
			{
				if (ConsentDebugSettings.Builder.cb_setDebugGeography_I == null)
				{
					ConsentDebugSettings.Builder.cb_setDebugGeography_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ConsentDebugSettings.Builder.n_SetDebugGeography_I));
				}
				return ConsentDebugSettings.Builder.cb_setDebugGeography_I;
			}

			// Token: 0x06000047 RID: 71 RVA: 0x000023C6 File Offset: 0x000005C6
			private static IntPtr n_SetDebugGeography_I(IntPtr jnienv, IntPtr native__this, int debugGeography)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDebugGeography(debugGeography));
			}

			// Token: 0x06000048 RID: 72 RVA: 0x000023DC File Offset: 0x000005DC
			[Register("setDebugGeography", "(I)Lcom/google/android/ump/ConsentDebugSettings$Builder;", "GetSetDebugGeography_IHandler")]
			public unsafe virtual ConsentDebugSettings.Builder SetDebugGeography(int debugGeography)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(debugGeography);
				return Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(ConsentDebugSettings.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setDebugGeography.(I)Lcom/google/android/ump/ConsentDebugSettings$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000049 RID: 73 RVA: 0x00002425 File Offset: 0x00000625
			private static Delegate GetSetForceTesting_ZHandler()
			{
				if (ConsentDebugSettings.Builder.cb_setForceTesting_Z == null)
				{
					ConsentDebugSettings.Builder.cb_setForceTesting_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(ConsentDebugSettings.Builder.n_SetForceTesting_Z));
				}
				return ConsentDebugSettings.Builder.cb_setForceTesting_Z;
			}

			// Token: 0x0600004A RID: 74 RVA: 0x00002449 File Offset: 0x00000649
			private static IntPtr n_SetForceTesting_Z(IntPtr jnienv, IntPtr native__this, bool forceTesting)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetForceTesting(forceTesting));
			}

			// Token: 0x0600004B RID: 75 RVA: 0x00002460 File Offset: 0x00000660
			[Register("setForceTesting", "(Z)Lcom/google/android/ump/ConsentDebugSettings$Builder;", "GetSetForceTesting_ZHandler")]
			public unsafe virtual ConsentDebugSettings.Builder SetForceTesting(bool forceTesting)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(forceTesting);
				return Java.Lang.Object.GetObject<ConsentDebugSettings.Builder>(ConsentDebugSettings.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setForceTesting.(Z)Lcom/google/android/ump/ConsentDebugSettings$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000004 RID: 4
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentDebugSettings$Builder", typeof(ConsentDebugSettings.Builder));

			// Token: 0x04000005 RID: 5
			private static Delegate cb_addTestDeviceHashedId_Ljava_lang_String_;

			// Token: 0x04000006 RID: 6
			private static Delegate cb_build;

			// Token: 0x04000007 RID: 7
			private static Delegate cb_setDebugGeography_I;

			// Token: 0x04000008 RID: 8
			private static Delegate cb_setForceTesting_Z;
		}

		// Token: 0x02000010 RID: 16
		[Register("com/google/android/ump/ConsentDebugSettings$DebugGeography", DoNotGenerateAcw = true)]
		public abstract class DebugGeography : Java.Lang.Object
		{
			// Token: 0x0600004D RID: 77 RVA: 0x000024C4 File Offset: 0x000006C4
			internal DebugGeography()
			{
			}

			// Token: 0x04000009 RID: 9
			[Register("DEBUG_GEOGRAPHY_DISABLED")]
			public const int DebugGeographyDisabled = 0;

			// Token: 0x0400000A RID: 10
			[Register("DEBUG_GEOGRAPHY_EEA")]
			public const int DebugGeographyEea = 1;

			// Token: 0x0400000B RID: 11
			[Register("DEBUG_GEOGRAPHY_NOT_EEA")]
			public const int DebugGeographyNotEea = 2;
		}

		// Token: 0x02000011 RID: 17
		[Register("com/google/android/ump/ConsentDebugSettings$DebugGeography", DoNotGenerateAcw = true)]
		[Obsolete("Use the 'DebugGeography' type. This type will be removed in a future release.", true)]
		public abstract class DebugGeographyConsts : ConsentDebugSettings.DebugGeography
		{
			// Token: 0x0600004E RID: 78 RVA: 0x000024CC File Offset: 0x000006CC
			private DebugGeographyConsts()
			{
			}
		}

		// Token: 0x02000012 RID: 18
		[Register("com/google/android/ump/ConsentDebugSettings$DebugGeography", "", "Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings/IDebugGeographyInvoker")]
		public interface IDebugGeography : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000013 RID: 19
		[Register("com/google/android/ump/ConsentDebugSettings$DebugGeography", DoNotGenerateAcw = true)]
		internal class IDebugGeographyInvoker : Java.Lang.Object, ConsentDebugSettings.IDebugGeography, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600004F RID: 79 RVA: 0x000024D4 File Offset: 0x000006D4
			private static IntPtr java_class_ref
			{
				get
				{
					return ConsentDebugSettings.IDebugGeographyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000050 RID: 80 RVA: 0x000024F8 File Offset: 0x000006F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ConsentDebugSettings.IDebugGeographyInvoker._members;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000051 RID: 81 RVA: 0x000024FF File Offset: 0x000006FF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00002507 File Offset: 0x00000707
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ConsentDebugSettings.IDebugGeographyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002513 File Offset: 0x00000713
			public static ConsentDebugSettings.IDebugGeography GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ConsentDebugSettings.IDebugGeography>(handle, transfer);
			}

			// Token: 0x06000054 RID: 84 RVA: 0x0000251C File Offset: 0x0000071C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ConsentDebugSettings.IDebugGeographyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentDebugSettings.DebugGeography'.");
				}
				return handle;
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00002547 File Offset: 0x00000747
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00002578 File Offset: 0x00000778
			public IDebugGeographyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ConsentDebugSettings.IDebugGeographyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000057 RID: 87 RVA: 0x000025B0 File Offset: 0x000007B0
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ConsentDebugSettings.IDebugGeographyInvoker.cb_annotationType == null)
				{
					ConsentDebugSettings.IDebugGeographyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConsentDebugSettings.IDebugGeographyInvoker.n_AnnotationType));
				}
				return ConsentDebugSettings.IDebugGeographyInvoker.cb_annotationType;
			}

			// Token: 0x06000058 RID: 88 RVA: 0x000025D4 File Offset: 0x000007D4
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConsentDebugSettings.IDebugGeography>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000059 RID: 89 RVA: 0x000025E8 File Offset: 0x000007E8
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600005A RID: 90 RVA: 0x00002639 File Offset: 0x00000839
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ConsentDebugSettings.IDebugGeographyInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ConsentDebugSettings.IDebugGeographyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ConsentDebugSettings.IDebugGeographyInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ConsentDebugSettings.IDebugGeographyInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x0600005B RID: 91 RVA: 0x00002660 File Offset: 0x00000860
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ConsentDebugSettings.IDebugGeography>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600005C RID: 92 RVA: 0x00002684 File Offset: 0x00000884
			public new unsafe bool Equals(Java.Lang.Object obj)
			{
				if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
			}

			// Token: 0x0600005D RID: 93 RVA: 0x000026F7 File Offset: 0x000008F7
			private static Delegate GetGetHashCodeHandler()
			{
				if (ConsentDebugSettings.IDebugGeographyInvoker.cb_hashCode == null)
				{
					ConsentDebugSettings.IDebugGeographyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ConsentDebugSettings.IDebugGeographyInvoker.n_GetHashCode));
				}
				return ConsentDebugSettings.IDebugGeographyInvoker.cb_hashCode;
			}

			// Token: 0x0600005E RID: 94 RVA: 0x0000271B File Offset: 0x0000091B
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ConsentDebugSettings.IDebugGeography>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600005F RID: 95 RVA: 0x0000272A File Offset: 0x0000092A
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000060 RID: 96 RVA: 0x0000276A File Offset: 0x0000096A
			private static Delegate GetToStringHandler()
			{
				if (ConsentDebugSettings.IDebugGeographyInvoker.cb_toString == null)
				{
					ConsentDebugSettings.IDebugGeographyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConsentDebugSettings.IDebugGeographyInvoker.n_ToString));
				}
				return ConsentDebugSettings.IDebugGeographyInvoker.cb_toString;
			}

			// Token: 0x06000061 RID: 97 RVA: 0x0000278E File Offset: 0x0000098E
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ConsentDebugSettings.IDebugGeography>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000062 RID: 98 RVA: 0x000027A4 File Offset: 0x000009A4
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400000C RID: 12
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentDebugSettings$DebugGeography", typeof(ConsentDebugSettings.IDebugGeographyInvoker));

			// Token: 0x0400000D RID: 13
			private IntPtr class_ref;

			// Token: 0x0400000E RID: 14
			private static Delegate cb_annotationType;

			// Token: 0x0400000F RID: 15
			private IntPtr id_annotationType;

			// Token: 0x04000010 RID: 16
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000011 RID: 17
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000012 RID: 18
			private static Delegate cb_hashCode;

			// Token: 0x04000013 RID: 19
			private IntPtr id_hashCode;

			// Token: 0x04000014 RID: 20
			private static Delegate cb_toString;

			// Token: 0x04000015 RID: 21
			private IntPtr id_toString;
		}
	}
}
