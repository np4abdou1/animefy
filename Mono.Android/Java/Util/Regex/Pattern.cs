using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util.Regex
{
	// Token: 0x0200032B RID: 811
	[Register("java/util/regex/Pattern", DoNotGenerateAcw = true)]
	public sealed class Pattern : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00061CFA File Offset: 0x0005FEFA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Pattern._members;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x00061D04 File Offset: 0x0005FF04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Pattern._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00061D28 File Offset: 0x0005FF28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Pattern._members.ManagedPeerType;
			}
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Pattern(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00061D34 File Offset: 0x0005FF34
		public unsafe static Pattern Compile(string regex, [GeneratedEnum] RegexOptions flags)
		{
			IntPtr intPtr = JNIEnv.NewString(regex);
			Pattern @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((int)flags);
				@object = Java.Lang.Object.GetObject<Pattern>(Pattern._members.StaticMethods.InvokeObjectMethod("compile.(Ljava/lang/String;I)Ljava/util/regex/Pattern;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00061DB4 File Offset: 0x0005FFB4
		public unsafe Matcher Matcher(ICharSequence input)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			Matcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Matcher>(Pattern._members.InstanceMethods.InvokeAbstractObjectMethod("matcher.(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00061E28 File Offset: 0x00060028
		public Matcher Matcher(string input)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			Matcher result = this.Matcher(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x04000E4C RID: 3660
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/regex/Pattern", typeof(Pattern));
	}
}
