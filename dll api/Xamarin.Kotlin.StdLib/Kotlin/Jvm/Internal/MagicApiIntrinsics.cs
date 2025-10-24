using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001B3 RID: 435
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/MagicApiIntrinsics", DoNotGenerateAcw = true)]
	public class MagicApiIntrinsics : Java.Lang.Object
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x00044DE0 File Offset: 0x00042FE0
		internal static IntPtr class_ref
		{
			get
			{
				return MagicApiIntrinsics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x00044E04 File Offset: 0x00043004
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MagicApiIntrinsics._members;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00044E0C File Offset: 0x0004300C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MagicApiIntrinsics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x00044E30 File Offset: 0x00043030
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MagicApiIntrinsics._members.ManagedPeerType;
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00044E3C File Offset: 0x0004303C
		protected MagicApiIntrinsics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00044E48 File Offset: 0x00043048
		[Register(".ctor", "()V", "")]
		public MagicApiIntrinsics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MagicApiIntrinsics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MagicApiIntrinsics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00044EB8 File Offset: 0x000430B8
		[Register("anyMagicApiCall", "(I)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object AnyMagicApiCall(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(MagicApiIntrinsics._members.StaticMethods.InvokeObjectMethod("anyMagicApiCall.(I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00044F00 File Offset: 0x00043100
		[Register("anyMagicApiCall", "(ILjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object AnyMagicApiCall(int id, Java.Lang.Object anyData1, Java.Lang.Object anyData2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((anyData1 == null) ? IntPtr.Zero : anyData1.Handle);
				ptr[2] = new JniArgumentValue((anyData2 == null) ? IntPtr.Zero : anyData2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MagicApiIntrinsics._members.StaticMethods.InvokeObjectMethod("anyMagicApiCall.(ILjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(anyData1);
				GC.KeepAlive(anyData2);
			}
			return @object;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00044FB0 File Offset: 0x000431B0
		[Register("anyMagicApiCall", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object AnyMagicApiCall(int id, Java.Lang.Object anyData1, Java.Lang.Object anyData2, Java.Lang.Object anyData3, Java.Lang.Object anyData4)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((anyData1 == null) ? IntPtr.Zero : anyData1.Handle);
				ptr[2] = new JniArgumentValue((anyData2 == null) ? IntPtr.Zero : anyData2.Handle);
				ptr[3] = new JniArgumentValue((anyData3 == null) ? IntPtr.Zero : anyData3.Handle);
				ptr[4] = new JniArgumentValue((anyData4 == null) ? IntPtr.Zero : anyData4.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MagicApiIntrinsics._members.StaticMethods.InvokeObjectMethod("anyMagicApiCall.(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(anyData1);
				GC.KeepAlive(anyData2);
				GC.KeepAlive(anyData3);
				GC.KeepAlive(anyData4);
			}
			return @object;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000450BC File Offset: 0x000432BC
		[Register("anyMagicApiCall", "(IJLjava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object AnyMagicApiCall(int id, long longData, Java.Lang.Object anyData)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue(longData);
				ptr[2] = new JniArgumentValue((anyData == null) ? IntPtr.Zero : anyData.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MagicApiIntrinsics._members.StaticMethods.InvokeObjectMethod("anyMagicApiCall.(IJLjava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(anyData);
			}
			return @object;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00045158 File Offset: 0x00043358
		[Register("anyMagicApiCall", "(IJJLjava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object AnyMagicApiCall(int id, long longData1, long longData2, Java.Lang.Object anyData)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue(longData1);
				ptr[2] = new JniArgumentValue(longData2);
				ptr[3] = new JniArgumentValue((anyData == null) ? IntPtr.Zero : anyData.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MagicApiIntrinsics._members.StaticMethods.InvokeObjectMethod("anyMagicApiCall.(IJJLjava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(anyData);
			}
			return @object;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0004520C File Offset: 0x0004340C
		[Register("anyMagicApiCall", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object AnyMagicApiCall(Java.Lang.Object data)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MagicApiIntrinsics._members.StaticMethods.InvokeObjectMethod("anyMagicApiCall.(Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00045280 File Offset: 0x00043480
		[Register("intMagicApiCall", "(I)I", "")]
		public unsafe static int IntMagicApiCall(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return MagicApiIntrinsics._members.StaticMethods.InvokeInt32Method("intMagicApiCall.(I)I", ptr);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000452BC File Offset: 0x000434BC
		[Register("intMagicApiCall", "(ILjava/lang/Object;Ljava/lang/Object;)I", "")]
		public unsafe static int IntMagicApiCall(int id, Java.Lang.Object anyData1, Java.Lang.Object anyData2)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((anyData1 == null) ? IntPtr.Zero : anyData1.Handle);
				ptr[2] = new JniArgumentValue((anyData2 == null) ? IntPtr.Zero : anyData2.Handle);
				result = MagicApiIntrinsics._members.StaticMethods.InvokeInt32Method("intMagicApiCall.(ILjava/lang/Object;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(anyData1);
				GC.KeepAlive(anyData2);
			}
			return result;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00045360 File Offset: 0x00043560
		[Register("intMagicApiCall", "(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public unsafe static int IntMagicApiCall(int id, Java.Lang.Object anyData1, Java.Lang.Object anyData2, Java.Lang.Object anyData3, Java.Lang.Object anyData4)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((anyData1 == null) ? IntPtr.Zero : anyData1.Handle);
				ptr[2] = new JniArgumentValue((anyData2 == null) ? IntPtr.Zero : anyData2.Handle);
				ptr[3] = new JniArgumentValue((anyData3 == null) ? IntPtr.Zero : anyData3.Handle);
				ptr[4] = new JniArgumentValue((anyData4 == null) ? IntPtr.Zero : anyData4.Handle);
				result = MagicApiIntrinsics._members.StaticMethods.InvokeInt32Method("intMagicApiCall.(ILjava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(anyData1);
				GC.KeepAlive(anyData2);
				GC.KeepAlive(anyData3);
				GC.KeepAlive(anyData4);
			}
			return result;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0004545C File Offset: 0x0004365C
		[Register("intMagicApiCall", "(IJLjava/lang/Object;)I", "")]
		public unsafe static int IntMagicApiCall(int id, long longData, Java.Lang.Object anyData)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue(longData);
				ptr[2] = new JniArgumentValue((anyData == null) ? IntPtr.Zero : anyData.Handle);
				result = MagicApiIntrinsics._members.StaticMethods.InvokeInt32Method("intMagicApiCall.(IJLjava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(anyData);
			}
			return result;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000454EC File Offset: 0x000436EC
		[Register("intMagicApiCall", "(IJJLjava/lang/Object;)I", "")]
		public unsafe static int IntMagicApiCall(int id, long longData1, long longData2, Java.Lang.Object anyData)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue(longData1);
				ptr[2] = new JniArgumentValue(longData2);
				ptr[3] = new JniArgumentValue((anyData == null) ? IntPtr.Zero : anyData.Handle);
				result = MagicApiIntrinsics._members.StaticMethods.InvokeInt32Method("intMagicApiCall.(IJJLjava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(anyData);
			}
			return result;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00045590 File Offset: 0x00043790
		[Register("intMagicApiCall", "(Ljava/lang/Object;)I", "")]
		public unsafe static int IntMagicApiCall(Java.Lang.Object data)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				result = MagicApiIntrinsics._members.StaticMethods.InvokeInt32Method("intMagicApiCall.(Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
			return result;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000455F4 File Offset: 0x000437F4
		[Register("voidMagicApiCall", "(I)V", "")]
		public unsafe static void VoidMagicApiCall(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			MagicApiIntrinsics._members.StaticMethods.InvokeVoidMethod("voidMagicApiCall.(I)V", ptr);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00045630 File Offset: 0x00043830
		[Register("voidMagicApiCall", "(Ljava/lang/Object;)V", "")]
		public unsafe static void VoidMagicApiCall(Java.Lang.Object data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				MagicApiIntrinsics._members.StaticMethods.InvokeVoidMethod("voidMagicApiCall.(Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x040006E6 RID: 1766
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MagicApiIntrinsics", typeof(MagicApiIntrinsics));
	}
}
