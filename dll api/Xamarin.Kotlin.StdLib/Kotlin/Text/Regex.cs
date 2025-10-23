using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Regex;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Sequences;

namespace Kotlin.Text
{
	// Token: 0x020000E9 RID: 233
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/Regex", DoNotGenerateAcw = true)]
	public sealed class Regex : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000144FC File Offset: 0x000126FC
		[Register("Companion")]
		public static Regex.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<Regex.CompanionStatic>(Regex._members.StaticFields.GetObjectValue("Companion.Lkotlin/text/Regex$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0001452C File Offset: 0x0001272C
		internal static IntPtr class_ref
		{
			get
			{
				return Regex._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00014550 File Offset: 0x00012750
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Regex._members;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00014558 File Offset: 0x00012758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Regex._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0001457C File Offset: 0x0001277C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Regex._members.ManagedPeerType;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00014588 File Offset: 0x00012788
		internal Regex(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00014594 File Offset: 0x00012794
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Regex(string pattern) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(pattern);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(Regex._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Regex._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00014638 File Offset: 0x00012838
		[Register(".ctor", "(Ljava/lang/String;Ljava/util/Set;)V", "")]
		public unsafe Regex(string pattern, ICollection<RegexOption> options) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(pattern);
			IntPtr intPtr2 = JavaSet<RegexOption>.ToLocalJniHandle(options);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(Regex._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/util/Set;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Regex._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/util/Set;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00014704 File Offset: 0x00012904
		[Register(".ctor", "(Ljava/lang/String;Lkotlin/text/RegexOption;)V", "")]
		public unsafe Regex(string pattern, RegexOption option) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(pattern);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((option == null) ? IntPtr.Zero : option.Handle);
				base.SetHandle(Regex._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lkotlin/text/RegexOption;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Regex._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lkotlin/text/RegexOption;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(option);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000147D0 File Offset: 0x000129D0
		public ICollection<RegexOption> Options
		{
			[Register("getOptions", "()Ljava/util/Set;", "")]
			get
			{
				return JavaSet<RegexOption>.FromJniHandle(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOptions.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00014804 File Offset: 0x00012A04
		public string Pattern
		{
			[Register("getPattern", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("getPattern.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00014838 File Offset: 0x00012A38
		[Register("containsMatchIn", "(Ljava/lang/CharSequence;)Z", "")]
		public unsafe bool ContainsMatchIn(ICharSequence input)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Regex._members.InstanceMethods.InvokeNonvirtualBooleanMethod("containsMatchIn.(Ljava/lang/CharSequence;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return result;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001489C File Offset: 0x00012A9C
		public bool ContainsMatchIn(string input)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			bool result = this.ContainsMatchIn(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000148C8 File Offset: 0x00012AC8
		[Register("find", "(Ljava/lang/CharSequence;I)Lkotlin/text/MatchResult;", "")]
		[return: Nullable(2)]
		public unsafe IMatchResult Find(ICharSequence input, int startIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			IMatchResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				@object = Java.Lang.Object.GetObject<IMatchResult>(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("find.(Ljava/lang/CharSequence;I)Lkotlin/text/MatchResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001494C File Offset: 0x00012B4C
		[return: Nullable(2)]
		public IMatchResult Find(string input, int startIndex)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			IMatchResult result = this.Find(@string, startIndex);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00014978 File Offset: 0x00012B78
		[Register("findAll", "(Ljava/lang/CharSequence;I)Lkotlin/sequences/Sequence;", "")]
		public unsafe ISequence FindAll(ICharSequence input, int startIndex)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				@object = Java.Lang.Object.GetObject<ISequence>(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("findAll.(Ljava/lang/CharSequence;I)Lkotlin/sequences/Sequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000149FC File Offset: 0x00012BFC
		public ISequence FindAll(string input, int startIndex)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			ISequence result = this.FindAll(@string, startIndex);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00014A28 File Offset: 0x00012C28
		[Register("matchAt", "(Ljava/lang/CharSequence;I)Lkotlin/text/MatchResult;", "")]
		[return: Nullable(2)]
		public unsafe IMatchResult MatchAt(ICharSequence input, int index)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			IMatchResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				@object = Java.Lang.Object.GetObject<IMatchResult>(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("matchAt.(Ljava/lang/CharSequence;I)Lkotlin/text/MatchResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00014AAC File Offset: 0x00012CAC
		[return: Nullable(2)]
		public IMatchResult MatchAt(string input, int index)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			IMatchResult result = this.MatchAt(@string, index);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00014AD8 File Offset: 0x00012CD8
		[Register("matchEntire", "(Ljava/lang/CharSequence;)Lkotlin/text/MatchResult;", "")]
		[return: Nullable(2)]
		public unsafe IMatchResult MatchEntire(ICharSequence input)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			IMatchResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMatchResult>(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("matchEntire.(Ljava/lang/CharSequence;)Lkotlin/text/MatchResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00014B4C File Offset: 0x00012D4C
		[return: Nullable(2)]
		public IMatchResult MatchEntire(string input)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			IMatchResult result = this.MatchEntire(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00014B78 File Offset: 0x00012D78
		[Register("matches", "(Ljava/lang/CharSequence;)Z", "")]
		public unsafe bool Matches(ICharSequence input)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Regex._members.InstanceMethods.InvokeNonvirtualBooleanMethod("matches.(Ljava/lang/CharSequence;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return result;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00014BDC File Offset: 0x00012DDC
		public bool Matches(string input)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			bool result = this.Matches(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00014C08 File Offset: 0x00012E08
		[Register("matchesAt", "(Ljava/lang/CharSequence;I)Z", "")]
		public unsafe bool MatchesAt(ICharSequence input, int index)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				result = Regex._members.InstanceMethods.InvokeNonvirtualBooleanMethod("matchesAt.(Ljava/lang/CharSequence;I)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return result;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00014C80 File Offset: 0x00012E80
		public bool MatchesAt(string input, int index)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			bool result = this.MatchesAt(@string, index);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00014CAC File Offset: 0x00012EAC
		[Register("replace", "(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string Replace(ICharSequence input, string replacement)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			IntPtr intPtr2 = JNIEnv.NewString(replacement);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("replace.(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(input);
			}
			return @string;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00014D40 File Offset: 0x00012F40
		public string Replace(string input, string replacement)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			string result = this.Replace(@string, replacement);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00014D6C File Offset: 0x00012F6C
		[Register("replace", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/String;", "")]
		public unsafe string Replace(ICharSequence input, IFunction1 transform)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@string = JNIEnv.GetString(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("replace.(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
				GC.KeepAlive(transform);
			}
			return @string;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00014E0C File Offset: 0x0001300C
		public string Replace(string input, IFunction1 transform)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			string result = this.Replace(@string, transform);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00014E38 File Offset: 0x00013038
		[Register("replaceFirst", "(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string ReplaceFirst(ICharSequence input, string replacement)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			IntPtr intPtr2 = JNIEnv.NewString(replacement);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("replaceFirst.(Ljava/lang/CharSequence;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(input);
			}
			return @string;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00014ECC File Offset: 0x000130CC
		public string ReplaceFirst(string input, string replacement)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			string result = this.ReplaceFirst(@string, replacement);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Register("split", "(Ljava/lang/CharSequence;I)Ljava/util/List;", "")]
		public unsafe IList<string> Split(ICharSequence input, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(limit);
				result = JavaList<string>.FromJniHandle(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("split.(Ljava/lang/CharSequence;I)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return result;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00014F7C File Offset: 0x0001317C
		public IList<string> Split(string input, int limit)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			IList<string> result = this.Split(@string, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00014FA8 File Offset: 0x000131A8
		[Register("splitToSequence", "(Ljava/lang/CharSequence;I)Lkotlin/sequences/Sequence;", "")]
		public unsafe ISequence SplitToSequence(ICharSequence input, int limit)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(input);
			ISequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(limit);
				@object = Java.Lang.Object.GetObject<ISequence>(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("splitToSequence.(Ljava/lang/CharSequence;I)Lkotlin/sequences/Sequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
			return @object;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001502C File Offset: 0x0001322C
		public ISequence SplitToSequence(string input, int limit)
		{
			Java.Lang.String @string = (input == null) ? null : new Java.Lang.String(input);
			ISequence result = this.SplitToSequence(@string, limit);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00015058 File Offset: 0x00013258
		[Register("toPattern", "()Ljava/util/regex/Pattern;", "")]
		public Pattern ToPattern()
		{
			return Java.Lang.Object.GetObject<Pattern>(Regex._members.InstanceMethods.InvokeNonvirtualObjectMethod("toPattern.()Ljava/util/regex/Pattern;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000228 RID: 552
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/Regex", typeof(Regex));

		// Token: 0x020002E5 RID: 741
		[Nullable(0)]
		[Register("kotlin/text/Regex$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06002996 RID: 10646 RVA: 0x000B86E0 File Offset: 0x000B68E0
			internal static IntPtr class_ref
			{
				get
				{
					return Regex.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x06002997 RID: 10647 RVA: 0x000B8704 File Offset: 0x000B6904
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Regex.CompanionStatic._members;
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x06002998 RID: 10648 RVA: 0x000B870C File Offset: 0x000B690C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Regex.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x06002999 RID: 10649 RVA: 0x000B8730 File Offset: 0x000B6930
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Regex.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x0600299A RID: 10650 RVA: 0x000B873C File Offset: 0x000B693C
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600299B RID: 10651 RVA: 0x000B8748 File Offset: 0x000B6948
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe CompanionStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(Regex.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Regex.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x0600299C RID: 10652 RVA: 0x000B87F8 File Offset: 0x000B69F8
			[Register("escape", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public unsafe string Escape(string literal)
			{
				IntPtr intPtr = JNIEnv.NewString(literal);
				string @string;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@string = JNIEnv.GetString(Regex.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("escape.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @string;
			}

			// Token: 0x0600299D RID: 10653 RVA: 0x000B8864 File Offset: 0x000B6A64
			[Register("escapeReplacement", "(Ljava/lang/String;)Ljava/lang/String;", "")]
			public unsafe string EscapeReplacement(string literal)
			{
				IntPtr intPtr = JNIEnv.NewString(literal);
				string @string;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@string = JNIEnv.GetString(Regex.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("escapeReplacement.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @string;
			}

			// Token: 0x0600299E RID: 10654 RVA: 0x000B88D0 File Offset: 0x000B6AD0
			[Register("fromLiteral", "(Ljava/lang/String;)Lkotlin/text/Regex;", "")]
			public unsafe Regex FromLiteral(string literal)
			{
				IntPtr intPtr = JNIEnv.NewString(literal);
				Regex @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Regex>(Regex.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("fromLiteral.(Ljava/lang/String;)Lkotlin/text/Regex;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x040009DC RID: 2524
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/Regex$Companion", typeof(Regex.CompanionStatic));
		}
	}
}
