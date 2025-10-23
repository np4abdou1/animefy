using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001B6 RID: 438
	[Register("android/text/SpannedString", DoNotGenerateAcw = true)]
	public sealed class SpannedString : SpannableStringInternal, IGetChars, ICharSequence, IJavaObject, IDisposable, IJavaPeerable, IEnumerable<char>, IEnumerable, ISpanned
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00029BF1 File Offset: 0x00027DF1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SpannedString._members;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00029BF8 File Offset: 0x00027DF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SpannedString._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00029C1C File Offset: 0x00027E1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SpannedString._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00027990 File Offset: 0x00025B90
		internal SpannedString(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00029C28 File Offset: 0x00027E28
		public unsafe override bool Equals(Java.Lang.Object o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = SpannedString._members.InstanceMethods.InvokeAbstractBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00029C90 File Offset: 0x00027E90
		public unsafe override int GetSpanEnd(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannedString._members.InstanceMethods.InvokeAbstractInt32Method("getSpanEnd.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00029CF8 File Offset: 0x00027EF8
		public unsafe override SpanTypes GetSpanFlags(Java.Lang.Object what)
		{
			SpanTypes result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = (SpanTypes)SpannedString._members.InstanceMethods.InvokeAbstractInt32Method("getSpanFlags.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00029D60 File Offset: 0x00027F60
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe override Java.Lang.Object[] GetSpans(int queryStart, int queryEnd, Class kind)
		{
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(queryStart);
				ptr[1] = new JniArgumentValue(queryEnd);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = (Java.Lang.Object[])JNIEnv.GetArray(SpannedString._members.InstanceMethods.InvokeAbstractObjectMethod("getSpans.(IILjava/lang/Class;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00029E0C File Offset: 0x0002800C
		public unsafe override int GetSpanStart(Java.Lang.Object what)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((what == null) ? IntPtr.Zero : what.Handle);
				result = SpannedString._members.InstanceMethods.InvokeAbstractInt32Method("getSpanStart.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(what);
			}
			return result;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00029E74 File Offset: 0x00028074
		public override int GetHashCode()
		{
			return SpannedString._members.InstanceMethods.InvokeAbstractInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00029E90 File Offset: 0x00028090
		public unsafe override int NextSpanTransition(int start, int limit, Class kind)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(limit);
				ptr[2] = new JniArgumentValue((kind == null) ? IntPtr.Zero : kind.Handle);
				result = SpannedString._members.InstanceMethods.InvokeAbstractInt32Method("nextSpanTransition.(IILjava/lang/Class;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(kind);
			}
			return result;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00029F20 File Offset: 0x00028120
		public unsafe ICharSequence SubSequenceFormatted(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Java.Lang.Object.GetObject<ICharSequence>(SpannedString._members.InstanceMethods.InvokeAbstractObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00029F7C File Offset: 0x0002817C
		public unsafe override char CharAt(int i)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(i);
			return SpannedString._members.InstanceMethods.InvokeAbstractCharMethod("charAt.(I)C", this, ptr);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00029FB8 File Offset: 0x000281B8
		public unsafe override void GetChars(int start, int end, char[] dest, int off)
		{
			IntPtr intPtr = JNIEnv.NewArray(dest);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(end);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(off);
				SpannedString._members.InstanceMethods.InvokeAbstractVoidMethod("getChars.(II[CI)V", this, ptr);
			}
			finally
			{
				if (dest != null)
				{
					JNIEnv.CopyArray(intPtr, dest);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0002A064 File Offset: 0x00028264
		public override int Length()
		{
			return SpannedString._members.InstanceMethods.InvokeAbstractInt32Method("length.()I", this, null);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0002A080 File Offset: 0x00028280
		public override string ToString()
		{
			return JNIEnv.GetString(SpannedString._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0002A0B2 File Offset: 0x000282B2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0002A0BA File Offset: 0x000282BA
		public IEnumerator<char> GetEnumerator()
		{
			int num;
			for (int i = 0; i < this.Length(); i = num + 1)
			{
				yield return this.CharAt(i);
				num = i;
			}
			yield break;
		}

		// Token: 0x04000752 RID: 1874
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/SpannedString", typeof(SpannedString));
	}
}
