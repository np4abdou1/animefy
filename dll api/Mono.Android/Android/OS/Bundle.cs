using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001DF RID: 479
	[Register("android/os/Bundle", DoNotGenerateAcw = true)]
	public sealed class Bundle : BaseBundle, IParcelable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0002E0CB File Offset: 0x0002C2CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Bundle._members;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0002E0D4 File Offset: 0x0002C2D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Bundle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Bundle._members.ManagedPeerType;
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0002E104 File Offset: 0x0002C304
		internal Bundle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0002E110 File Offset: 0x0002C310
		public Bundle() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Bundle._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Bundle._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0002E17E File Offset: 0x0002C37E
		public int DescribeContents()
		{
			return Bundle._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0002E198 File Offset: 0x0002C398
		public unsafe override bool GetBoolean(string key, bool defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = Bundle._members.InstanceMethods.InvokeAbstractBooleanMethod("getBoolean.(Ljava/lang/String;Z)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0002E208 File Offset: 0x0002C408
		public unsafe float GetFloat(string key, float defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = Bundle._members.InstanceMethods.InvokeAbstractSingleMethod("getFloat.(Ljava/lang/String;F)F", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0002E278 File Offset: 0x0002C478
		public unsafe override int GetInt(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Bundle._members.InstanceMethods.InvokeAbstractInt32Method("getInt.(Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		public unsafe override int GetInt(string key, int defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(defaultValue);
				result = Bundle._members.InstanceMethods.InvokeAbstractInt32Method("getInt.(Ljava/lang/String;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0002E348 File Offset: 0x0002C548
		public unsafe override string GetString(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Bundle._members.InstanceMethods.InvokeAbstractObjectMethod("getString.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0002E3B4 File Offset: 0x0002C5B4
		public unsafe override string GetString(string key, string defaultValue)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(defaultValue);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(Bundle._members.InstanceMethods.InvokeAbstractObjectMethod("getString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0002E444 File Offset: 0x0002C644
		public unsafe override void PutBoolean(string key, bool value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				Bundle._members.InstanceMethods.InvokeAbstractVoidMethod("putBoolean.(Ljava/lang/String;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
		public unsafe void PutFloat(string key, float value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				Bundle._members.InstanceMethods.InvokeAbstractVoidMethod("putFloat.(Ljava/lang/String;F)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0002E524 File Offset: 0x0002C724
		public unsafe override void PutInt(string key, int value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				Bundle._members.InstanceMethods.InvokeAbstractVoidMethod("putInt.(Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0002E594 File Offset: 0x0002C794
		public unsafe override void PutString(string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				Bundle._members.InstanceMethods.InvokeAbstractVoidMethod("putString.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0002E610 File Offset: 0x0002C810
		public unsafe void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Bundle._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x040007D7 RID: 2007
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Bundle", typeof(Bundle));
	}
}
