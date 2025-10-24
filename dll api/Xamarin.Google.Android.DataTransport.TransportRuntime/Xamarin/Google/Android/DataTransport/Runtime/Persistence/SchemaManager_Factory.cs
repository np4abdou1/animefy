using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Database.Sqlite;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000072 RID: 114
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/SchemaManager_Factory", DoNotGenerateAcw = true)]
	public sealed class SchemaManager_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		internal static IntPtr class_ref
		{
			get
			{
				return SchemaManager_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000C118 File Offset: 0x0000A318
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchemaManager_Factory._members;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000C120 File Offset: 0x0000A320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchemaManager_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000C144 File Offset: 0x0000A344
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchemaManager_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SchemaManager_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000C150 File Offset: 0x0000A350
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe SchemaManager_Factory(IProvider contextProvider, IProvider dbNameProvider, IProvider schemaVersionProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				ptr[1] = new JniArgumentValue((dbNameProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)dbNameProvider).Handle);
				ptr[2] = new JniArgumentValue((schemaVersionProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schemaVersionProvider).Handle);
				base.SetHandle(SchemaManager_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SchemaManager_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
				GC.KeepAlive(dbNameProvider);
				GC.KeepAlive(schemaVersionProvider);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000C260 File Offset: 0x0000A460
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/SchemaManager_Factory;", "")]
		public unsafe static SchemaManager_Factory Create(IProvider contextProvider, IProvider dbNameProvider, IProvider schemaVersionProvider)
		{
			SchemaManager_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				ptr[1] = new JniArgumentValue((dbNameProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)dbNameProvider).Handle);
				ptr[2] = new JniArgumentValue((schemaVersionProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schemaVersionProvider).Handle);
				@object = Java.Lang.Object.GetObject<SchemaManager_Factory>(SchemaManager_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/SchemaManager_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
				GC.KeepAlive(dbNameProvider);
				GC.KeepAlive(schemaVersionProvider);
			}
			return @object;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000C334 File Offset: 0x0000A534
		[Register("get", "()Landroid/database/sqlite/SQLiteOpenHelper;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SchemaManager_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Landroid/database/sqlite/SQLiteOpenHelper;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000C368 File Offset: 0x0000A568
		[Register("newInstance", "(Landroid/content/Context;Ljava/lang/String;I)Landroid/database/sqlite/SQLiteOpenHelper;", "")]
		public unsafe static SQLiteOpenHelper NewInstance(Context context, string dbName, int schemaVersion)
		{
			IntPtr intPtr = JNIEnv.NewString(dbName);
			SQLiteOpenHelper @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(schemaVersion);
				@object = Java.Lang.Object.GetObject<SQLiteOpenHelper>(SchemaManager_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Landroid/content/Context;Ljava/lang/String;I)Landroid/database/sqlite/SQLiteOpenHelper;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040000E7 RID: 231
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/SchemaManager_Factory", typeof(SchemaManager_Factory));
	}
}
