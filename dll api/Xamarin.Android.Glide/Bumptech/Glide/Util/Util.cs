using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000054 RID: 84
	[Register("com/bumptech/glide/util/Util", DoNotGenerateAcw = true)]
	public sealed class Util : Java.Lang.Object
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000C95C File Offset: 0x0000AB5C
		internal static IntPtr class_ref
		{
			get
			{
				return Util._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000C980 File Offset: 0x0000AB80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Util._members;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000C988 File Offset: 0x0000AB88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Util._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Util._members.ManagedPeerType;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		internal Util(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000C9C2 File Offset: 0x0000ABC2
		public static bool IsOnBackgroundThread
		{
			[Register("isOnBackgroundThread", "()Z", "")]
			get
			{
				return Util._members.StaticMethods.InvokeBooleanMethod("isOnBackgroundThread.()Z", null);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000C9DA File Offset: 0x0000ABDA
		public static bool IsOnMainThread
		{
			[Register("isOnMainThread", "()Z", "")]
			get
			{
				return Util._members.StaticMethods.InvokeBooleanMethod("isOnMainThread.()Z", null);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C9F2 File Offset: 0x0000ABF2
		[Register("assertBackgroundThread", "()V", "")]
		public static void AssertBackgroundThread()
		{
			Util._members.StaticMethods.InvokeVoidMethod("assertBackgroundThread.()V", null);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000CA0A File Offset: 0x0000AC0A
		[Register("assertMainThread", "()V", "")]
		public static void AssertMainThread()
		{
			Util._members.StaticMethods.InvokeVoidMethod("assertMainThread.()V", null);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000CA24 File Offset: 0x0000AC24
		[Register("bothModelsNullEquivalentOrEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public unsafe static bool BothModelsNullEquivalentOrEquals(Java.Lang.Object a, Java.Lang.Object b)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((a == null) ? IntPtr.Zero : a.Handle);
				ptr[1] = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				result = Util._members.StaticMethods.InvokeBooleanMethod("bothModelsNullEquivalentOrEquals.(Ljava/lang/Object;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return result;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Register("bothNullOrEqual", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public unsafe static bool BothNullOrEqual(Java.Lang.Object a, Java.Lang.Object b)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((a == null) ? IntPtr.Zero : a.Handle);
				ptr[1] = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				result = Util._members.StaticMethods.InvokeBooleanMethod("bothNullOrEqual.(Ljava/lang/Object;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return result;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		[Register("createQueue", "(I)Ljava/util/Queue;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IQueue CreateQueue(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return Java.Lang.Object.GetObject<IQueue>(Util._members.StaticMethods.InvokeObjectMethod("createQueue.(I)Ljava/util/Queue;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000CB84 File Offset: 0x0000AD84
		[Register("getBitmapByteSize", "(Landroid/graphics/Bitmap;)I", "")]
		public unsafe static int GetBitmapByteSize(Bitmap bitmap)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				result = Util._members.StaticMethods.InvokeInt32Method("getBitmapByteSize.(Landroid/graphics/Bitmap;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
			return result;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Register("getBitmapByteSize", "(IILandroid/graphics/Bitmap$Config;)I", "")]
		public unsafe static int GetBitmapByteSize(int width, int height, Bitmap.Config config)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				result = Util._members.StaticMethods.InvokeInt32Method("getBitmapByteSize.(IILandroid/graphics/Bitmap$Config;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return result;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Register("getBytesPerPixel", "(Landroid/graphics/Bitmap$Config;)I", "")]
		public unsafe static int GetBytesPerPixel(Bitmap.Config config)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				result = Util._members.StaticMethods.InvokeInt32Method("getBytesPerPixel.(Landroid/graphics/Bitmap$Config;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return result;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		[Obsolete("deprecated")]
		[Register("getSize", "(Landroid/graphics/Bitmap;)I", "")]
		public unsafe static int GetSize(Bitmap bitmap)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				result = Util._members.StaticMethods.InvokeInt32Method("getSize.(Landroid/graphics/Bitmap;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
			return result;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000CD40 File Offset: 0x0000AF40
		[Register("getSnapshot", "(Ljava/util/Collection;)Ljava/util/List;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static System.Collections.IList GetSnapshot(System.Collections.ICollection other)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(other);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(Util._members.StaticMethods.InvokeObjectMethod("getSnapshot.(Ljava/util/Collection;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Register("hashCode", "(Z)I", "")]
		public unsafe static int HashCode(bool value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Util._members.StaticMethods.InvokeInt32Method("hashCode.(Z)I", ptr);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		[Register("hashCode", "(ZI)I", "")]
		public unsafe static int HashCode(bool value, int accumulator)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			ptr[1] = new JniArgumentValue(accumulator);
			return Util._members.StaticMethods.InvokeInt32Method("hashCode.(ZI)I", ptr);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000CE3C File Offset: 0x0000B03C
		[Register("hashCode", "(F)I", "")]
		public unsafe static int HashCode(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Util._members.StaticMethods.InvokeInt32Method("hashCode.(F)I", ptr);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000CE78 File Offset: 0x0000B078
		[Register("hashCode", "(FI)I", "")]
		public unsafe static int HashCode(float value, int accumulator)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			ptr[1] = new JniArgumentValue(accumulator);
			return Util._members.StaticMethods.InvokeInt32Method("hashCode.(FI)I", ptr);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		[Register("hashCode", "(I)I", "")]
		public unsafe static int HashCode(int value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Util._members.StaticMethods.InvokeInt32Method("hashCode.(I)I", ptr);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000CF04 File Offset: 0x0000B104
		[Register("hashCode", "(II)I", "")]
		public unsafe static int HashCode(int value, int accumulator)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			ptr[1] = new JniArgumentValue(accumulator);
			return Util._members.StaticMethods.InvokeInt32Method("hashCode.(II)I", ptr);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000CF54 File Offset: 0x0000B154
		[Register("hashCode", "(Ljava/lang/Object;I)I", "")]
		public unsafe static int HashCode(Java.Lang.Object @object, int accumulator)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				ptr[1] = new JniArgumentValue(accumulator);
				result = Util._members.StaticMethods.InvokeInt32Method("hashCode.(Ljava/lang/Object;I)I", ptr);
			}
			finally
			{
				GC.KeepAlive(@object);
			}
			return result;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		[Register("isValidDimension", "(I)Z", "")]
		public unsafe static bool IsValidDimension(int dimen)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(dimen);
			return Util._members.StaticMethods.InvokeBooleanMethod("isValidDimension.(I)Z", ptr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000D008 File Offset: 0x0000B208
		[Register("isValidDimensions", "(II)Z", "")]
		public unsafe static bool IsValidDimensions(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Util._members.StaticMethods.InvokeBooleanMethod("isValidDimensions.(II)Z", ptr);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000D058 File Offset: 0x0000B258
		[Register("postOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe static void PostOnUiThread(IRunnable runnable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				Util._members.StaticMethods.InvokeVoidMethod("postOnUiThread.(Ljava/lang/Runnable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		[Register("removeCallbacksOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe static void RemoveCallbacksOnUiThread(IRunnable runnable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				Util._members.StaticMethods.InvokeVoidMethod("removeCallbacksOnUiThread.(Ljava/lang/Runnable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000D128 File Offset: 0x0000B328
		[Register("sha256BytesToHex", "([B)Ljava/lang/String;", "")]
		public unsafe static string Sha256BytesToHex(byte[] bytes)
		{
			IntPtr intPtr = JNIEnv.NewArray(bytes);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Util._members.StaticMethods.InvokeObjectMethod("sha256BytesToHex.([B)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (bytes != null)
				{
					JNIEnv.CopyArray(intPtr, bytes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(bytes);
			}
			return @string;
		}

		// Token: 0x040000CD RID: 205
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/Util", typeof(Util));
	}
}
