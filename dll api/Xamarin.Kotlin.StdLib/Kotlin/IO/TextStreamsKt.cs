using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Net;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;

namespace Kotlin.IO
{
	// Token: 0x02000228 RID: 552
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/TextStreamsKt", DoNotGenerateAcw = true)]
	public sealed class TextStreamsKt : Java.Lang.Object
	{
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00055EF8 File Offset: 0x000540F8
		internal static IntPtr class_ref
		{
			get
			{
				return TextStreamsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00055F1C File Offset: 0x0005411C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextStreamsKt._members;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00055F24 File Offset: 0x00054124
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextStreamsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00055F48 File Offset: 0x00054148
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextStreamsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00055F54 File Offset: 0x00054154
		internal TextStreamsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00055F60 File Offset: 0x00054160
		[Register("copyTo", "(Ljava/io/Reader;Ljava/io/Writer;I)J", "")]
		public unsafe static long CopyTo(Reader obj, Writer @out, int bufferSize)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[2] = new JniArgumentValue(bufferSize);
				result = TextStreamsKt._members.StaticMethods.InvokeInt64Method("copyTo.(Ljava/io/Reader;Ljava/io/Writer;I)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(@out);
			}
			return result;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00056004 File Offset: 0x00054204
		[Register("forEachLine", "(Ljava/io/Reader;Lkotlin/jvm/functions/Function1;)V", "")]
		public unsafe static void ForEachLine(Reader obj, IFunction1 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				TextStreamsKt._members.StaticMethods.InvokeVoidMethod("forEachLine.(Ljava/io/Reader;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00056094 File Offset: 0x00054294
		[Register("lineSequence", "(Ljava/io/BufferedReader;)Lkotlin/sequences/Sequence;", "")]
		public unsafe static ISequence LineSequence(BufferedReader obj)
		{
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<ISequence>(TextStreamsKt._members.StaticMethods.InvokeObjectMethod("lineSequence.(Ljava/io/BufferedReader;)Lkotlin/sequences/Sequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00056108 File Offset: 0x00054308
		[Register("readBytes", "(Ljava/net/URL;)[B", "")]
		public unsafe static byte[] ReadBytes(URL obj)
		{
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = (byte[])JNIEnv.GetArray(TextStreamsKt._members.StaticMethods.InvokeObjectMethod("readBytes.(Ljava/net/URL;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0005618C File Offset: 0x0005438C
		[Register("readLines", "(Ljava/io/Reader;)Ljava/util/List;", "")]
		public unsafe static IList<string> ReadLines(Reader obj)
		{
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaList<string>.FromJniHandle(TextStreamsKt._members.StaticMethods.InvokeObjectMethod("readLines.(Ljava/io/Reader;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00056200 File Offset: 0x00054400
		[Register("readText", "(Ljava/io/Reader;)Ljava/lang/String;", "")]
		public unsafe static string ReadText(Reader obj)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@string = JNIEnv.GetString(TextStreamsKt._members.StaticMethods.InvokeObjectMethod("readText.(Ljava/io/Reader;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @string;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00056274 File Offset: 0x00054474
		[Register("useLines", "(Ljava/io/Reader;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object UseLines(Reader obj, IFunction1 block)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TextStreamsKt._members.StaticMethods.InvokeObjectMethod("useLines.(Ljava/io/Reader;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x040007D9 RID: 2009
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/TextStreamsKt", typeof(TextStreamsKt));
	}
}
