using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Ranges;

namespace Kotlin.Random
{
	// Token: 0x02000142 RID: 322
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/random/URandomKt", DoNotGenerateAcw = true)]
	public sealed class URandomKt : Java.Lang.Object
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00038B2C File Offset: 0x00036D2C
		internal static IntPtr class_ref
		{
			get
			{
				return URandomKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00038B50 File Offset: 0x00036D50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return URandomKt._members;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00038B58 File Offset: 0x00036D58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return URandomKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x00038B7C File Offset: 0x00036D7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return URandomKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00038B88 File Offset: 0x00036D88
		internal URandomKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00038B94 File Offset: 0x00036D94
		[Register("nextUBytes", "(Lkotlin/random/Random;I)[B", "")]
		public unsafe static byte[] NextUBytes(Random obj, int size)
		{
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(size);
				result = (byte[])JNIEnv.GetArray(URandomKt._members.StaticMethods.InvokeObjectMethod("nextUBytes.(Lkotlin/random/Random;I)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00038C28 File Offset: 0x00036E28
		[Register("nextUBytes-EVgfTAA", "(Lkotlin/random/Random;[B)[B", "")]
		public unsafe static byte[] NextUBytes(Random obj, byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(URandomKt._members.StaticMethods.InvokeObjectMethod("nextUBytes-EVgfTAA.(Lkotlin/random/Random;[B)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(obj);
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00038CDC File Offset: 0x00036EDC
		[Register("nextUBytes-Wvrt4B4", "(Lkotlin/random/Random;[BII)[B", "")]
		public unsafe static byte[] NextUBytes(Random obj, byte[] array, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(fromIndex);
				ptr[3] = new JniArgumentValue(toIndex);
				result = (byte[])JNIEnv.GetArray(URandomKt._members.StaticMethods.InvokeObjectMethod("nextUBytes-Wvrt4B4.(Lkotlin/random/Random;[BII)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(obj);
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00038DBC File Offset: 0x00036FBC
		[Register("nextUInt", "(Lkotlin/random/Random;)I", "")]
		public unsafe static uint NextUInt(Random obj)
		{
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = (uint)URandomKt._members.StaticMethods.InvokeInt32Method("nextUInt.(Lkotlin/random/Random;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00038E20 File Offset: 0x00037020
		[Register("nextUInt", "(Lkotlin/random/Random;Lkotlin/ranges/UIntRange;)I", "")]
		public unsafe static uint NextUInt(Random obj, UIntRange range)
		{
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				result = (uint)URandomKt._members.StaticMethods.InvokeInt32Method("nextUInt.(Lkotlin/random/Random;Lkotlin/ranges/UIntRange;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00038EAC File Offset: 0x000370AC
		[Register("nextUInt-a8DCA5k", "(Lkotlin/random/Random;II)I", "")]
		public unsafe static uint NextUInt(Random obj, uint from, uint until)
		{
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(from);
				ptr[2] = new JniArgumentValue(until);
				result = (uint)URandomKt._members.StaticMethods.InvokeInt32Method("nextUInt-a8DCA5k.(Lkotlin/random/Random;II)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00038F3C File Offset: 0x0003713C
		[Register("nextUInt-qCasIEU", "(Lkotlin/random/Random;I)I", "")]
		public unsafe static uint NextUInt(Random obj, uint until)
		{
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(until);
				result = (uint)URandomKt._members.StaticMethods.InvokeInt32Method("nextUInt-qCasIEU.(Lkotlin/random/Random;I)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00038FB4 File Offset: 0x000371B4
		[Register("nextULong", "(Lkotlin/random/Random;)J", "")]
		public unsafe static ulong NextULong(Random obj)
		{
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = (ulong)URandomKt._members.StaticMethods.InvokeInt64Method("nextULong.(Lkotlin/random/Random;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00039018 File Offset: 0x00037218
		[Register("nextULong", "(Lkotlin/random/Random;Lkotlin/ranges/ULongRange;)J", "")]
		public unsafe static ulong NextULong(Random obj, ULongRange range)
		{
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				result = (ulong)URandomKt._members.StaticMethods.InvokeInt64Method("nextULong.(Lkotlin/random/Random;Lkotlin/ranges/ULongRange;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000390A4 File Offset: 0x000372A4
		[Register("nextULong-V1Xi4fY", "(Lkotlin/random/Random;J)J", "")]
		public unsafe static ulong NextULong(Random obj, ulong until)
		{
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(until);
				result = (ulong)URandomKt._members.StaticMethods.InvokeInt64Method("nextULong-V1Xi4fY.(Lkotlin/random/Random;J)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0003911C File Offset: 0x0003731C
		[Register("nextULong-jmpaW-c", "(Lkotlin/random/Random;JJ)J", "")]
		public unsafe static ulong NextULong(Random obj, ulong from, ulong until)
		{
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(from);
				ptr[2] = new JniArgumentValue(until);
				result = (ulong)URandomKt._members.StaticMethods.InvokeInt64Method("nextULong-jmpaW-c.(Lkotlin/random/Random;JJ)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x04000585 RID: 1413
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/random/URandomKt", typeof(URandomKt));
	}
}
