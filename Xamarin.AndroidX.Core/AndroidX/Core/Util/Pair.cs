using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Util
{
	// Token: 0x0200004C RID: 76
	[Register("androidx/core/util/Pair", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"F",
		"S"
	})]
	public class Pair : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002230 File Offset: 0x00000430
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002260 File Offset: 0x00000460
		[Register("first")]
		public Java.Lang.Object First
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Pair._members.InstanceFields.GetObjectValue("first.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					Pair._members.InstanceFields.SetValue("first.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000022DC File Offset: 0x000004DC
		[Register("second")]
		public Java.Lang.Object Second
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Pair._members.InstanceFields.GetObjectValue("second.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					Pair._members.InstanceFields.SetValue("second.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002328 File Offset: 0x00000528
		internal static IntPtr class_ref
		{
			get
			{
				return Pair._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000234C File Offset: 0x0000054C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Pair._members;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002354 File Offset: 0x00000554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Pair._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002378 File Offset: 0x00000578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Pair._members.ManagedPeerType;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002384 File Offset: 0x00000584
		protected Pair(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002390 File Offset: 0x00000590
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe Pair(Java.Lang.Object first, Java.Lang.Object second) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(first);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(second);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(Pair._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Pair._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002460 File Offset: 0x00000660
		[Register("create", "(Ljava/lang/Object;Ljava/lang/Object;)Landroidx/core/util/Pair;", "")]
		[JavaTypeParameters(new string[]
		{
			"A",
			"B"
		})]
		public unsafe static Pair Create(Java.Lang.Object a, Java.Lang.Object b)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			Pair @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Pair>(Pair._members.StaticMethods.InvokeObjectMethod("create.(Ljava/lang/Object;Ljava/lang/Object;)Landroidx/core/util/Pair;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/util/Pair", typeof(Pair));
	}
}
