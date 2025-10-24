using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Database;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000280 RID: 640
	[Register("android/content/ContentProvider", DoNotGenerateAcw = true)]
	internal class ContentProviderInvoker : ContentProvider
	{
		// Token: 0x06001854 RID: 6228 RVA: 0x0003EE19 File Offset: 0x0003D019
		public ContentProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0003EE23 File Offset: 0x0003D023
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentProviderInvoker._members;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0003EE2A File Offset: 0x0003D02A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0003EE38 File Offset: 0x0003D038
		public unsafe override int Delete(Android.Net.Uri uri, string selection, string[] selectionArgs)
		{
			IntPtr intPtr = JNIEnv.NewString(selection);
			IntPtr intPtr2 = JNIEnv.NewArray(selectionArgs);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = ContentProviderInvoker._members.InstanceMethods.InvokeAbstractInt32Method("delete.(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (selectionArgs != null)
				{
					JNIEnv.CopyArray(intPtr2, selectionArgs);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(uri);
				GC.KeepAlive(selectionArgs);
			}
			return result;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0003EEF0 File Offset: 0x0003D0F0
		public unsafe override string GetType(Android.Net.Uri uri)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@string = JNIEnv.GetString(ContentProviderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getType.(Landroid/net/Uri;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return @string;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0003EF64 File Offset: 0x0003D164
		public unsafe override Android.Net.Uri Insert(Android.Net.Uri uri, ContentValues values)
		{
			Android.Net.Uri @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue((values == null) ? IntPtr.Zero : values.Handle);
				@object = Java.Lang.Object.GetObject<Android.Net.Uri>(ContentProviderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("insert.(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(values);
			}
			return @object;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0003F000 File Offset: 0x0003D200
		public override bool OnCreate()
		{
			return ContentProviderInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("onCreate.()Z", this, null);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0003F01C File Offset: 0x0003D21C
		public unsafe override ICursor Query(Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder)
		{
			IntPtr intPtr = JNIEnv.NewArray(projection);
			IntPtr intPtr2 = JNIEnv.NewString(selection);
			IntPtr intPtr3 = JNIEnv.NewArray(selectionArgs);
			IntPtr intPtr4 = JNIEnv.NewString(sortOrder);
			ICursor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				@object = Java.Lang.Object.GetObject<ICursor>(ContentProviderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("query.(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (projection != null)
				{
					JNIEnv.CopyArray(intPtr, projection);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				if (selectionArgs != null)
				{
					JNIEnv.CopyArray(intPtr3, selectionArgs);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(uri);
				GC.KeepAlive(projection);
				GC.KeepAlive(selectionArgs);
			}
			return @object;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0003F148 File Offset: 0x0003D348
		public unsafe override int Update(Android.Net.Uri uri, ContentValues values, string selection, string[] selectionArgs)
		{
			IntPtr intPtr = JNIEnv.NewString(selection);
			IntPtr intPtr2 = JNIEnv.NewArray(selectionArgs);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue((values == null) ? IntPtr.Zero : values.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				result = ContentProviderInvoker._members.InstanceMethods.InvokeAbstractInt32Method("update.(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (selectionArgs != null)
				{
					JNIEnv.CopyArray(intPtr2, selectionArgs);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(uri);
				GC.KeepAlive(values);
				GC.KeepAlive(selectionArgs);
			}
			return result;
		}

		// Token: 0x04000A53 RID: 2643
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ContentProvider", typeof(ContentProviderInvoker));
	}
}
