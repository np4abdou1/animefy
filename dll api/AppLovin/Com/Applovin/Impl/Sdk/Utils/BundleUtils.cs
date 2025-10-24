using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk.Utils
{
	// Token: 0x02000138 RID: 312
	[Register("com/applovin/impl/sdk/utils/BundleUtils", DoNotGenerateAcw = true)]
	public class BundleUtils : Java.Lang.Object
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00026C10 File Offset: 0x00024E10
		internal static IntPtr class_ref
		{
			get
			{
				return BundleUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00026C34 File Offset: 0x00024E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BundleUtils._members;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00026C3C File Offset: 0x00024E3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BundleUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00026C60 File Offset: 0x00024E60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BundleUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000021F0 File Offset: 0x000003F0
		protected BundleUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00026C6C File Offset: 0x00024E6C
		[Register(".ctor", "()V", "")]
		public BundleUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BundleUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BundleUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00026CDC File Offset: 0x00024EDC
		[Register("containsAtLeastOneKey", "(Ljava/util/Set;Landroid/os/Bundle;)Z", "")]
		public unsafe static bool ContainsAtLeastOneKey(ICollection<string> p0, Bundle p1)
		{
			IntPtr intPtr = JavaSet<string>.ToLocalJniHandle(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = BundleUtils._members.StaticMethods.InvokeBooleanMethod("containsAtLeastOneKey.(Ljava/util/Set;Landroid/os/Bundle;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00026D68 File Offset: 0x00024F68
		[Register("getBoolean", "(Ljava/lang/String;Landroid/os/Bundle;)Z", "")]
		public unsafe static bool GetBoolean(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = BundleUtils._members.StaticMethods.InvokeBooleanMethod("getBoolean.(Ljava/lang/String;Landroid/os/Bundle;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00026DEC File Offset: 0x00024FEC
		[Register("getBoolean", "(Ljava/lang/String;ZLandroid/os/Bundle;)Z", "")]
		public unsafe static bool GetBoolean(string p0, bool p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				result = BundleUtils._members.StaticMethods.InvokeBooleanMethod("getBoolean.(Ljava/lang/String;ZLandroid/os/Bundle;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00026E88 File Offset: 0x00025088
		[Register("getBundle", "(Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle GetBundle(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(BundleUtils._members.StaticMethods.InvokeObjectMethod("getBundle.(Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00026F1C File Offset: 0x0002511C
		[Register("getBundle", "(Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle GetBundle(string p0, Bundle p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(BundleUtils._members.StaticMethods.InvokeObjectMethod("getBundle.(Ljava/lang/String;Landroid/os/Bundle;Landroid/os/Bundle;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00026FDC File Offset: 0x000251DC
		[Register("getInt", "(Ljava/lang/String;Landroid/os/Bundle;)I", "")]
		public unsafe static int GetInt(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = BundleUtils._members.StaticMethods.InvokeInt32Method("getInt.(Ljava/lang/String;Landroid/os/Bundle;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00027060 File Offset: 0x00025260
		[Register("getInt", "(Ljava/lang/String;ILandroid/os/Bundle;)I", "")]
		public unsafe static int GetInt(string p0, int p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				result = BundleUtils._members.StaticMethods.InvokeInt32Method("getInt.(Ljava/lang/String;ILandroid/os/Bundle;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000270FC File Offset: 0x000252FC
		[Register("getLong", "(Ljava/lang/String;Landroid/os/Bundle;)J", "")]
		public unsafe static long GetLong(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = BundleUtils._members.StaticMethods.InvokeInt64Method("getLong.(Ljava/lang/String;Landroid/os/Bundle;)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00027180 File Offset: 0x00025380
		[Register("getLong", "(Ljava/lang/String;JLandroid/os/Bundle;)J", "")]
		public unsafe static long GetLong(string p0, long p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				result = BundleUtils._members.StaticMethods.InvokeInt64Method("getLong.(Ljava/lang/String;JLandroid/os/Bundle;)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0002721C File Offset: 0x0002541C
		[Register("getString", "(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public unsafe static string GetString(string p0, Bundle p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@string = JNIEnv.GetString(BundleUtils._members.StaticMethods.InvokeObjectMethod("getString.(Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @string;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000272B0 File Offset: 0x000254B0
		[Register("getString", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", "")]
		public unsafe static string GetString(string p0, string p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@string = JNIEnv.GetString(BundleUtils._members.StaticMethods.InvokeObjectMethod("getString.(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p2);
			}
			return @string;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00027368 File Offset: 0x00025568
		[Register("put", "(Ljava/lang/String;Ljava/lang/Object;Landroid/os/Bundle;)V", "")]
		public unsafe static void Put(string p0, Java.Lang.Object p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("put.(Ljava/lang/String;Ljava/lang/Object;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00027418 File Offset: 0x00025618
		[Register("putBoolean", "(Ljava/lang/String;Ljava/lang/Boolean;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutBoolean(string p0, Java.Lang.Boolean p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putBoolean.(Ljava/lang/String;Ljava/lang/Boolean;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000274C8 File Offset: 0x000256C8
		[Register("putBooleanArray", "(Ljava/lang/String;[ZLandroid/os/Bundle;)V", "")]
		public unsafe static void PutBooleanArray(string p0, bool[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putBooleanArray.(Ljava/lang/String;[ZLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00027580 File Offset: 0x00025780
		[Register("putByte", "(Ljava/lang/String;Ljava/lang/Byte;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutByte(string p0, Java.Lang.Byte p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putByte.(Ljava/lang/String;Ljava/lang/Byte;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00027630 File Offset: 0x00025830
		[Register("putByteArray", "(Ljava/lang/String;[BLandroid/os/Bundle;)V", "")]
		public unsafe static void PutByteArray(string p0, byte[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putByteArray.(Ljava/lang/String;[BLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000276E8 File Offset: 0x000258E8
		[Register("putChar", "(Ljava/lang/String;Ljava/lang/Character;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutChar(string p0, Character p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putChar.(Ljava/lang/String;Ljava/lang/Character;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00027798 File Offset: 0x00025998
		[Register("putCharArray", "(Ljava/lang/String;[CLandroid/os/Bundle;)V", "")]
		public unsafe static void PutCharArray(string p0, char[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putCharArray.(Ljava/lang/String;[CLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00027850 File Offset: 0x00025A50
		[Register("putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutCharSequence(string p0, ICharSequence p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putCharSequence.(Ljava/lang/String;Ljava/lang/CharSequence;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000278FC File Offset: 0x00025AFC
		public static void PutCharSequence(string p0, string p1, Bundle p2)
		{
			Java.Lang.String @string = (p1 == null) ? null : new Java.Lang.String(p1);
			BundleUtils.PutCharSequence(p0, @string, p2);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00027928 File Offset: 0x00025B28
		[Register("putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutCharSequenceArray(string p0, ICharSequence[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray<ICharSequence>(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putCharSequenceArray.(Ljava/lang/String;[Ljava/lang/CharSequence;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray<ICharSequence>(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000279E0 File Offset: 0x00025BE0
		public static void PutCharSequenceArray(string p0, string[] p1, Bundle p2)
		{
			ICharSequence[] array = CharSequence.ArrayFromStringArray(p1);
			BundleUtils.PutCharSequenceArray(p0, array, p2);
			if (array != null)
			{
				foreach (ICharSequence charSequence in array)
				{
					if (charSequence != null)
					{
						charSequence.Dispose();
					}
				}
			}
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00027A20 File Offset: 0x00025C20
		[Register("putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutCharSequenceArrayList(string p0, IList<ICharSequence> p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<ICharSequence>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putCharSequenceArrayList.(Ljava/lang/String;Ljava/util/ArrayList;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00027ACC File Offset: 0x00025CCC
		[Register("putDouble", "(Ljava/lang/String;Ljava/lang/Double;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutDouble(string p0, Java.Lang.Double p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putDouble.(Ljava/lang/String;Ljava/lang/Double;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00027B7C File Offset: 0x00025D7C
		[Register("putDoubleArray", "(Ljava/lang/String;[DLandroid/os/Bundle;)V", "")]
		public unsafe static void PutDoubleArray(string p0, double[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putDoubleArray.(Ljava/lang/String;[DLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00027C34 File Offset: 0x00025E34
		[Register("putFloat", "(Ljava/lang/String;Ljava/lang/Float;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutFloat(string p0, Float p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putFloat.(Ljava/lang/String;Ljava/lang/Float;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00027CE4 File Offset: 0x00025EE4
		[Register("putFloatArray", "(Ljava/lang/String;[FLandroid/os/Bundle;)V", "")]
		public unsafe static void PutFloatArray(string p0, float[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putFloatArray.(Ljava/lang/String;[FLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00027D9C File Offset: 0x00025F9C
		[Register("putInt", "(Ljava/lang/String;Ljava/lang/Integer;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutInt(string p0, Integer p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putInt.(Ljava/lang/String;Ljava/lang/Integer;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00027E4C File Offset: 0x0002604C
		[Register("putIntArray", "(Ljava/lang/String;[ILandroid/os/Bundle;)V", "")]
		public unsafe static void PutIntArray(string p0, int[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putIntArray.(Ljava/lang/String;[ILandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00027F04 File Offset: 0x00026104
		[Register("putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutIntegerArrayList(string p0, IList<Integer> p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<Integer>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putIntegerArrayList.(Ljava/lang/String;Ljava/util/ArrayList;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00027FB0 File Offset: 0x000261B0
		[Register("putLong", "(Ljava/lang/String;Ljava/lang/Long;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutLong(string p0, Long p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putLong.(Ljava/lang/String;Ljava/lang/Long;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00028060 File Offset: 0x00026260
		[Register("putLongArray", "(Ljava/lang/String;[JLandroid/os/Bundle;)V", "")]
		public unsafe static void PutLongArray(string p0, long[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putLongArray.(Ljava/lang/String;[JLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00028118 File Offset: 0x00026318
		[Register("putShort", "(Ljava/lang/String;Ljava/lang/Short;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutShort(string p0, Short p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putShort.(Ljava/lang/String;Ljava/lang/Short;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000281C8 File Offset: 0x000263C8
		[Register("putShortArray", "(Ljava/lang/String;[SLandroid/os/Bundle;)V", "")]
		public unsafe static void PutShortArray(string p0, short[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putShortArray.(Ljava/lang/String;[SLandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00028280 File Offset: 0x00026480
		[Register("putString", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutString(string p0, string p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putString.(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00028328 File Offset: 0x00026528
		[Register("putStringArray", "(Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutStringArray(string p0, string[] p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putStringArray.(Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p1 != null)
				{
					JNIEnv.CopyArray(intPtr2, p1);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000283E0 File Offset: 0x000265E0
		[Register("putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutStringArrayList(string p0, IList<string> p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putStringArrayList.(Ljava/lang/String;Ljava/util/ArrayList;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0002848C File Offset: 0x0002668C
		[Register("putStringIfValid", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public unsafe static void PutStringIfValid(string p0, string p1, Bundle p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				BundleUtils._members.StaticMethods.InvokeVoidMethod("putStringIfValid.(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00028534 File Offset: 0x00026734
		[Register("toJSONObject", "(Landroid/os/Bundle;)Lorg/json/JSONObject;", "")]
		public unsafe static JSONObject ToJSONObject(Bundle p0)
		{
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(BundleUtils._members.StaticMethods.InvokeObjectMethod("toJSONObject.(Landroid/os/Bundle;)Lorg/json/JSONObject;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000285A8 File Offset: 0x000267A8
		[Register("toMap", "(Landroid/os/Bundle;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, Java.Lang.Object> ToMap(Bundle p0)
		{
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(BundleUtils._members.StaticMethods.InvokeObjectMethod("toMap.(Landroid/os/Bundle;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0002861C File Offset: 0x0002681C
		[Register("toStringMap", "(Landroid/os/Bundle;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, string> ToStringMap(Bundle p0)
		{
			IDictionary<string, string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaDictionary<string, string>.FromJniHandle(BundleUtils._members.StaticMethods.InvokeObjectMethod("toStringMap.(Landroid/os/Bundle;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x040004EC RID: 1260
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/BundleUtils", typeof(BundleUtils));
	}
}
