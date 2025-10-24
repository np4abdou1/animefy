using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000DE RID: 222
	[Register("com/bumptech/glide/load/Option", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class Option : Java.Lang.Object
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00022B84 File Offset: 0x00020D84
		internal static IntPtr class_ref
		{
			get
			{
				return Option._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00022BA8 File Offset: 0x00020DA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Option._members;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00022BB0 File Offset: 0x00020DB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Option._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00022BD4 File Offset: 0x00020DD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Option._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00022BE0 File Offset: 0x00020DE0
		internal Option(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00022BEC File Offset: 0x00020DEC
		public Java.Lang.Object DefaultValue
		{
			[Register("getDefaultValue", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Option._members.InstanceMethods.InvokeAbstractObjectMethod("getDefaultValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00022C20 File Offset: 0x00020E20
		[Register("disk", "(Ljava/lang/String;Lcom/bumptech/glide/load/Option$CacheKeyUpdater;)Lcom/bumptech/glide/load/Option;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Option Disk(string key, Option.ICacheKeyUpdater cacheKeyUpdater)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Option @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((cacheKeyUpdater == null) ? IntPtr.Zero : ((Java.Lang.Object)cacheKeyUpdater).Handle);
				@object = Java.Lang.Object.GetObject<Option>(Option._members.StaticMethods.InvokeObjectMethod("disk.(Ljava/lang/String;Lcom/bumptech/glide/load/Option$CacheKeyUpdater;)Lcom/bumptech/glide/load/Option;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cacheKeyUpdater);
			}
			return @object;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00022CB8 File Offset: 0x00020EB8
		[Register("disk", "(Ljava/lang/String;Ljava/lang/Object;Lcom/bumptech/glide/load/Option$CacheKeyUpdater;)Lcom/bumptech/glide/load/Option;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Option Disk(string key, Java.Lang.Object defaultValue, Option.ICacheKeyUpdater cacheKeyUpdater)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(defaultValue);
			Option @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((cacheKeyUpdater == null) ? IntPtr.Zero : ((Java.Lang.Object)cacheKeyUpdater).Handle);
				@object = Java.Lang.Object.GetObject<Option>(Option._members.StaticMethods.InvokeObjectMethod("disk.(Ljava/lang/String;Ljava/lang/Object;Lcom/bumptech/glide/load/Option$CacheKeyUpdater;)Lcom/bumptech/glide/load/Option;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(defaultValue);
				GC.KeepAlive(cacheKeyUpdater);
			}
			return @object;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00022D7C File Offset: 0x00020F7C
		[Register("memory", "(Ljava/lang/String;)Lcom/bumptech/glide/load/Option;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Option Memory(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Option @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Option>(Option._members.StaticMethods.InvokeObjectMethod("memory.(Ljava/lang/String;)Lcom/bumptech/glide/load/Option;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00022DE8 File Offset: 0x00020FE8
		[Register("memory", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/bumptech/glide/load/Option;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Option Memory(string key, Java.Lang.Object defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(defaultValue);
			Option @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Option>(Option._members.StaticMethods.InvokeObjectMethod("memory.(Ljava/lang/String;Ljava/lang/Object;)Lcom/bumptech/glide/load/Option;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(defaultValue);
			}
			return @object;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00022E7C File Offset: 0x0002107C
		[Register("update", "(Ljava/lang/Object;Ljava/security/MessageDigest;)V", "")]
		public unsafe void Update(Java.Lang.Object value, MessageDigest messageDigest)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				Option._members.InstanceMethods.InvokeAbstractVoidMethod("update.(Ljava/lang/Object;Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040002C8 RID: 712
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Option", typeof(Option));

		// Token: 0x020001C4 RID: 452
		[Register("com/bumptech/glide/load/Option$CacheKeyUpdater", "", "Bumptech.Glide.Load.Option/ICacheKeyUpdaterInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface ICacheKeyUpdater : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060015D4 RID: 5588
			[Register("update", "([BLjava/lang/Object;Ljava/security/MessageDigest;)V", "GetUpdate_arrayBLjava_lang_Object_Ljava_security_MessageDigest_Handler:Bumptech.Glide.Load.Option/ICacheKeyUpdaterInvoker, Xamarin.Android.Glide")]
			void Update(byte[] p0, Java.Lang.Object p1, MessageDigest p2);
		}

		// Token: 0x020001C5 RID: 453
		[Register("com/bumptech/glide/load/Option$CacheKeyUpdater", DoNotGenerateAcw = true)]
		internal class ICacheKeyUpdaterInvoker : Java.Lang.Object, Option.ICacheKeyUpdater, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x060015D5 RID: 5589 RVA: 0x000448D4 File Offset: 0x00042AD4
			private static IntPtr java_class_ref
			{
				get
				{
					return Option.ICacheKeyUpdaterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000448F8 File Offset: 0x00042AF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Option.ICacheKeyUpdaterInvoker._members;
				}
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x060015D7 RID: 5591 RVA: 0x000448FF File Offset: 0x00042AFF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00044907 File Offset: 0x00042B07
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Option.ICacheKeyUpdaterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060015D9 RID: 5593 RVA: 0x00044913 File Offset: 0x00042B13
			public static Option.ICacheKeyUpdater GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Option.ICacheKeyUpdater>(handle, transfer);
			}

			// Token: 0x060015DA RID: 5594 RVA: 0x0004491C File Offset: 0x00042B1C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Option.ICacheKeyUpdaterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.Option.CacheKeyUpdater'.");
				}
				return handle;
			}

			// Token: 0x060015DB RID: 5595 RVA: 0x00044947 File Offset: 0x00042B47
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060015DC RID: 5596 RVA: 0x00044978 File Offset: 0x00042B78
			public ICacheKeyUpdaterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Option.ICacheKeyUpdaterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060015DD RID: 5597 RVA: 0x000449B0 File Offset: 0x00042BB0
			private static Delegate GetUpdate_arrayBLjava_lang_Object_Ljava_security_MessageDigest_Handler()
			{
				if (Option.ICacheKeyUpdaterInvoker.cb_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_ == null)
				{
					Option.ICacheKeyUpdaterInvoker.cb_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Option.ICacheKeyUpdaterInvoker.n_Update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_));
				}
				return Option.ICacheKeyUpdaterInvoker.cb_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_;
			}

			// Token: 0x060015DE RID: 5598 RVA: 0x000449D4 File Offset: 0x00042BD4
			private static void n_Update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				Option.ICacheKeyUpdater @object = Java.Lang.Object.GetObject<Option.ICacheKeyUpdater>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] array = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
				MessageDigest object3 = Java.Lang.Object.GetObject<MessageDigest>(native_p2, JniHandleOwnership.DoNotTransfer);
				@object.Update(array, object2, object3);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_p0);
				}
			}

			// Token: 0x060015DF RID: 5599 RVA: 0x00044A24 File Offset: 0x00042C24
			public unsafe void Update(byte[] p0, Java.Lang.Object p1, MessageDigest p2)
			{
				if (this.id_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_ == IntPtr.Zero)
				{
					this.id_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID(this.class_ref, "update", "([BLjava/lang/Object;Ljava/security/MessageDigest;)V");
				}
				IntPtr intPtr = JNIEnv.NewArray(p0);
				IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				ptr[1] = new JValue(intPtr2);
				ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_, ptr);
				if (p0 != null)
				{
					JNIEnv.CopyArray(intPtr, p0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
			}

			// Token: 0x04000538 RID: 1336
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Option$CacheKeyUpdater", typeof(Option.ICacheKeyUpdaterInvoker));

			// Token: 0x04000539 RID: 1337
			private IntPtr class_ref;

			// Token: 0x0400053A RID: 1338
			private static Delegate cb_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_;

			// Token: 0x0400053B RID: 1339
			private IntPtr id_update_arrayBLjava_lang_Object_Ljava_security_MessageDigest_;
		}
	}
}
