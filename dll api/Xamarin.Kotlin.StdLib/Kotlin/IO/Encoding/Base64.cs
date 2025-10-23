using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.IO.Encoding
{
	// Token: 0x02000235 RID: 565
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/encoding/Base64", DoNotGenerateAcw = true)]
	public class Base64 : Java.Lang.Object
	{
		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0005825C File Offset: 0x0005645C
		[Register("Default")]
		public static Base64.DefaultStatic Default
		{
			get
			{
				return Java.Lang.Object.GetObject<Base64.DefaultStatic>(Base64._members.StaticFields.GetObjectValue("Default.Lkotlin/io/encoding/Base64$Default;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0005828C File Offset: 0x0005648C
		internal static IntPtr class_ref
		{
			get
			{
				return Base64._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x000582B0 File Offset: 0x000564B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Base64._members;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000582B8 File Offset: 0x000564B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Base64._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x000582DC File Offset: 0x000564DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Base64._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000582E8 File Offset: 0x000564E8
		protected Base64(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000582F4 File Offset: 0x000564F4
		[NullableContext(2)]
		[Register(".ctor", "(ZZLkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe Base64(bool isUrlSafe, bool isMimeScheme, DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(isUrlSafe);
				ptr[1] = new JniArgumentValue(isMimeScheme);
				ptr[2] = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
				base.SetHandle(Base64._members.InstanceMethods.StartCreateInstance("(ZZLkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Base64._members.InstanceMethods.FinishCreateInstance("(ZZLkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_constructor_marker);
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000583CC File Offset: 0x000565CC
		[Register("decode", "([BII)[B", "")]
		public unsafe byte[] Decode(byte[] source, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(source);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				result = (byte[])JNIEnv.GetArray(Base64._members.InstanceMethods.InvokeNonvirtualObjectMethod("decode.([BII)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (source != null)
				{
					JNIEnv.CopyArray(intPtr, source);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(source);
			}
			return result;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00058480 File Offset: 0x00056680
		[Register("decode", "(Ljava/lang/CharSequence;II)[B", "")]
		public unsafe byte[] Decode(ICharSequence source, int startIndex, int endIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				result = (byte[])JNIEnv.GetArray(Base64._members.InstanceMethods.InvokeNonvirtualObjectMethod("decode.(Ljava/lang/CharSequence;II)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
			}
			return result;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0005852C File Offset: 0x0005672C
		public byte[] Decode(string source, int startIndex, int endIndex)
		{
			Java.Lang.String @string = (source == null) ? null : new Java.Lang.String(source);
			byte[] result = this.Decode(@string, startIndex, endIndex);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00058558 File Offset: 0x00056758
		[Register("decodeIntoByteArray", "([B[BIII)I", "")]
		public unsafe int DecodeIntoByteArray(byte[] source, byte[] destination, int destinationOffset, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(source);
			IntPtr intPtr2 = JNIEnv.NewArray(destination);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(destinationOffset);
				ptr[3] = new JniArgumentValue(startIndex);
				ptr[4] = new JniArgumentValue(endIndex);
				result = Base64._members.InstanceMethods.InvokeNonvirtualInt32Method("decodeIntoByteArray.([B[BIII)I", this, ptr);
			}
			finally
			{
				if (source != null)
				{
					JNIEnv.CopyArray(intPtr, source);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (destination != null)
				{
					JNIEnv.CopyArray(intPtr2, destination);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(source);
				GC.KeepAlive(destination);
			}
			return result;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0005863C File Offset: 0x0005683C
		[Register("decodeIntoByteArray", "(Ljava/lang/CharSequence;[BIII)I", "")]
		public unsafe int DecodeIntoByteArray(ICharSequence source, byte[] destination, int destinationOffset, int startIndex, int endIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			IntPtr intPtr2 = JNIEnv.NewArray(destination);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(destinationOffset);
				ptr[3] = new JniArgumentValue(startIndex);
				ptr[4] = new JniArgumentValue(endIndex);
				result = Base64._members.InstanceMethods.InvokeNonvirtualInt32Method("decodeIntoByteArray.(Ljava/lang/CharSequence;[BIII)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (destination != null)
				{
					JNIEnv.CopyArray(intPtr2, destination);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(source);
				GC.KeepAlive(destination);
			}
			return result;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00058714 File Offset: 0x00056914
		public int DecodeIntoByteArray(string source, byte[] destination, int destinationOffset, int startIndex, int endIndex)
		{
			Java.Lang.String @string = (source == null) ? null : new Java.Lang.String(source);
			int result = this.DecodeIntoByteArray(@string, destination, destinationOffset, startIndex, endIndex);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00058744 File Offset: 0x00056944
		[Register("encode", "([BII)Ljava/lang/String;", "")]
		public unsafe string Encode(byte[] source, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(source);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				@string = JNIEnv.GetString(Base64._members.InstanceMethods.InvokeNonvirtualObjectMethod("encode.([BII)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (source != null)
				{
					JNIEnv.CopyArray(intPtr, source);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(source);
			}
			return @string;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000587E8 File Offset: 0x000569E8
		[Register("encodeIntoByteArray", "([B[BIII)I", "")]
		public unsafe int EncodeIntoByteArray(byte[] source, byte[] destination, int destinationOffset, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(source);
			IntPtr intPtr2 = JNIEnv.NewArray(destination);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(destinationOffset);
				ptr[3] = new JniArgumentValue(startIndex);
				ptr[4] = new JniArgumentValue(endIndex);
				result = Base64._members.InstanceMethods.InvokeNonvirtualInt32Method("encodeIntoByteArray.([B[BIII)I", this, ptr);
			}
			finally
			{
				if (source != null)
				{
					JNIEnv.CopyArray(intPtr, source);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (destination != null)
				{
					JNIEnv.CopyArray(intPtr2, destination);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(source);
				GC.KeepAlive(destination);
			}
			return result;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000588CC File Offset: 0x00056ACC
		[Register("encodeToAppendable", "([BLjava/lang/Appendable;II)Ljava/lang/Appendable;", "")]
		[JavaTypeParameters(new string[]
		{
			"A extends java.lang.Appendable"
		})]
		public unsafe Java.Lang.Object EncodeToAppendable(byte[] source, Java.Lang.Object destination, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(source);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(startIndex);
				ptr[3] = new JniArgumentValue(endIndex);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Base64._members.InstanceMethods.InvokeNonvirtualObjectMethod("encodeToAppendable.([BLjava/lang/Appendable;II)Ljava/lang/Appendable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (source != null)
				{
					JNIEnv.CopyArray(intPtr, source);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(source);
				GC.KeepAlive(destination);
			}
			return @object;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0005899C File Offset: 0x00056B9C
		[Register("encodeToByteArray", "([BII)[B", "")]
		public unsafe byte[] EncodeToByteArray(byte[] source, int startIndex, int endIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(source);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				result = (byte[])JNIEnv.GetArray(Base64._members.InstanceMethods.InvokeNonvirtualObjectMethod("encodeToByteArray.([BII)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (source != null)
				{
					JNIEnv.CopyArray(intPtr, source);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(source);
			}
			return result;
		}

		// Token: 0x040007F7 RID: 2039
		[Register("bytesPerGroup")]
		public const int BytesPerGroup = 3;

		// Token: 0x040007F8 RID: 2040
		[Register("mimeLineLength")]
		public const int MimeLineLength = 76;

		// Token: 0x040007F9 RID: 2041
		[Register("padSymbol")]
		public const sbyte PadSymbol = 61;

		// Token: 0x040007FA RID: 2042
		[Register("symbolsPerGroup")]
		public const int SymbolsPerGroup = 4;

		// Token: 0x040007FB RID: 2043
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/encoding/Base64", typeof(Base64));

		// Token: 0x020002F7 RID: 759
		[Nullable(0)]
		[Register("kotlin/io/encoding/Base64$Default", DoNotGenerateAcw = true)]
		public sealed class DefaultStatic : Base64
		{
			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000B9E3C File Offset: 0x000B803C
			internal new static IntPtr class_ref
			{
				get
				{
					return Base64.DefaultStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000B9E60 File Offset: 0x000B8060
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Base64.DefaultStatic._members;
				}
			}

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000B9E68 File Offset: 0x000B8068
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Base64.DefaultStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000B9E8C File Offset: 0x000B808C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Base64.DefaultStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A31 RID: 10801 RVA: 0x000B9E98 File Offset: 0x000B8098
			internal DefaultStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A32 RID: 10802 RVA: 0x000B9EA4 File Offset: 0x000B80A4
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe DefaultStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(Base64.DefaultStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Base64.DefaultStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x06002A33 RID: 10803 RVA: 0x000B9F54 File Offset: 0x000B8154
			public Base64 Mime
			{
				[Register("getMime", "()Lkotlin/io/encoding/Base64;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Base64>(Base64.DefaultStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getMime.()Lkotlin/io/encoding/Base64;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000B9F88 File Offset: 0x000B8188
			public Base64 UrlSafe
			{
				[Register("getUrlSafe", "()Lkotlin/io/encoding/Base64;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Base64>(Base64.DefaultStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getUrlSafe.()Lkotlin/io/encoding/Base64;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009EE RID: 2542
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/encoding/Base64$Default", typeof(Base64.DefaultStatic));
		}
	}
}
