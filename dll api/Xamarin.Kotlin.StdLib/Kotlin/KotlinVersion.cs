using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000088 RID: 136
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/KotlinVersion", DoNotGenerateAcw = true)]
	public sealed class KotlinVersion : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00008E84 File Offset: 0x00007084
		[Register("CURRENT")]
		public static KotlinVersion Current
		{
			get
			{
				return Java.Lang.Object.GetObject<KotlinVersion>(KotlinVersion._members.StaticFields.GetObjectValue("CURRENT.Lkotlin/KotlinVersion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00008EB4 File Offset: 0x000070B4
		internal static IntPtr class_ref
		{
			get
			{
				return KotlinVersion._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00008ED8 File Offset: 0x000070D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KotlinVersion._members;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00008EE0 File Offset: 0x000070E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KotlinVersion._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00008F04 File Offset: 0x00007104
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KotlinVersion._members.ManagedPeerType;
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00008F10 File Offset: 0x00007110
		internal KotlinVersion(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00008F1C File Offset: 0x0000711C
		[Register(".ctor", "(II)V", "")]
		public unsafe KotlinVersion(int major, int minor) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(major);
			ptr[1] = new JniArgumentValue(minor);
			base.SetHandle(KotlinVersion._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			KotlinVersion._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00008FB4 File Offset: 0x000071B4
		[Register(".ctor", "(III)V", "")]
		public unsafe KotlinVersion(int major, int minor, int patch) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(major);
			ptr[1] = new JniArgumentValue(minor);
			ptr[2] = new JniArgumentValue(patch);
			base.SetHandle(KotlinVersion._members.InstanceMethods.StartCreateInstance("(III)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			KotlinVersion._members.InstanceMethods.FinishCreateInstance("(III)V", this, ptr);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00009061 File Offset: 0x00007261
		public int Major
		{
			[Register("getMajor", "()I", "")]
			get
			{
				return KotlinVersion._members.InstanceMethods.InvokeNonvirtualInt32Method("getMajor.()I", this, null);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000907A File Offset: 0x0000727A
		public int Minor
		{
			[Register("getMinor", "()I", "")]
			get
			{
				return KotlinVersion._members.InstanceMethods.InvokeNonvirtualInt32Method("getMinor.()I", this, null);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00009093 File Offset: 0x00007293
		public int Patch
		{
			[Register("getPatch", "()I", "")]
			get
			{
				return KotlinVersion._members.InstanceMethods.InvokeNonvirtualInt32Method("getPatch.()I", this, null);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000090AC File Offset: 0x000072AC
		[Register("compareTo", "(Lkotlin/KotlinVersion;)I", "")]
		public unsafe int CompareTo(Java.Lang.Object other)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = KotlinVersion._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Lkotlin/KotlinVersion;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00009114 File Offset: 0x00007314
		[Register("isAtLeast", "(II)Z", "")]
		public unsafe bool IsAtLeast(int major, int minor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(major);
			ptr[1] = new JniArgumentValue(minor);
			return KotlinVersion._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isAtLeast.(II)Z", this, ptr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00009164 File Offset: 0x00007364
		[Register("isAtLeast", "(III)Z", "")]
		public unsafe bool IsAtLeast(int major, int minor, int patch)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(major);
			ptr[1] = new JniArgumentValue(minor);
			ptr[2] = new JniArgumentValue(patch);
			return KotlinVersion._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isAtLeast.(III)Z", this, ptr);
		}

		// Token: 0x04000137 RID: 311
		[Register("MAX_COMPONENT_VALUE")]
		public const int MaxComponentValue = 255;

		// Token: 0x04000138 RID: 312
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/KotlinVersion", typeof(KotlinVersion));
	}
}
