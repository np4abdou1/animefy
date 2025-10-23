using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Graphics
{
	// Token: 0x02000055 RID: 85
	[Register("androidx/core/graphics/Insets", DoNotGenerateAcw = true)]
	public sealed class Insets : Java.Lang.Object
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000064ED File Offset: 0x000046ED
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00006504 File Offset: 0x00004704
		[Register("bottom")]
		public int Bottom
		{
			get
			{
				return Insets._members.InstanceFields.GetInt32Value("bottom.I", this);
			}
			set
			{
				Insets._members.InstanceFields.SetValue("bottom.I", this, value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000651C File Offset: 0x0000471C
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00006533 File Offset: 0x00004733
		[Register("left")]
		public int Left
		{
			get
			{
				return Insets._members.InstanceFields.GetInt32Value("left.I", this);
			}
			set
			{
				Insets._members.InstanceFields.SetValue("left.I", this, value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000654C File Offset: 0x0000474C
		[Register("NONE")]
		public static Insets None
		{
			get
			{
				return Java.Lang.Object.GetObject<Insets>(Insets._members.StaticFields.GetObjectValue("NONE.Landroidx/core/graphics/Insets;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000657B File Offset: 0x0000477B
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00006592 File Offset: 0x00004792
		[Register("right")]
		public int Right
		{
			get
			{
				return Insets._members.InstanceFields.GetInt32Value("right.I", this);
			}
			set
			{
				Insets._members.InstanceFields.SetValue("right.I", this, value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000289 RID: 649 RVA: 0x000065AA File Offset: 0x000047AA
		// (set) Token: 0x0600028A RID: 650 RVA: 0x000065C1 File Offset: 0x000047C1
		[Register("top")]
		public int Top
		{
			get
			{
				return Insets._members.InstanceFields.GetInt32Value("top.I", this);
			}
			set
			{
				Insets._members.InstanceFields.SetValue("top.I", this, value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000065DC File Offset: 0x000047DC
		internal static IntPtr class_ref
		{
			get
			{
				return Insets._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00006600 File Offset: 0x00004800
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Insets._members;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00006608 File Offset: 0x00004808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Insets._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000662C File Offset: 0x0000482C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Insets._members.ManagedPeerType;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002384 File Offset: 0x00000584
		internal Insets(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00006638 File Offset: 0x00004838
		[Register("add", "(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Add(Insets a, Insets b)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((a == null) ? IntPtr.Zero : a.Handle);
				ptr[1] = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("add.(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000066D4 File Offset: 0x000048D4
		[Register("max", "(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Max(Insets a, Insets b)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((a == null) ? IntPtr.Zero : a.Handle);
				ptr[1] = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("max.(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00006770 File Offset: 0x00004970
		[Register("min", "(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Min(Insets a, Insets b)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((a == null) ? IntPtr.Zero : a.Handle);
				ptr[1] = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("min.(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000680C File Offset: 0x00004A0C
		[Register("of", "(Landroid/graphics/Rect;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Of(Rect r)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((r == null) ? IntPtr.Zero : r.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("of.(Landroid/graphics/Rect;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(r);
			}
			return @object;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00006880 File Offset: 0x00004A80
		[Register("of", "(IIII)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Of(int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(left);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(right);
			ptr[3] = new JniArgumentValue(bottom);
			return Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("of.(IIII)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00006908 File Offset: 0x00004B08
		[Register("subtract", "(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Subtract(Insets a, Insets b)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((a == null) ? IntPtr.Zero : a.Handle);
				ptr[1] = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("subtract.(Landroidx/core/graphics/Insets;Landroidx/core/graphics/Insets;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(a);
				GC.KeepAlive(b);
			}
			return @object;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Register("toCompatInsets", "(Landroid/graphics/Insets;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets ToCompatInsets(Insets insets)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("toCompatInsets.(Landroid/graphics/Insets;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(insets);
			}
			return @object;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00006A18 File Offset: 0x00004C18
		[Register("toPlatformInsets", "()Landroid/graphics/Insets;", "")]
		public Insets ToPlatformInsets()
		{
			return Java.Lang.Object.GetObject<Insets>(Insets._members.InstanceMethods.InvokeAbstractObjectMethod("toPlatformInsets.()Landroid/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Register("wrap", "(Landroid/graphics/Insets;)Landroidx/core/graphics/Insets;", "")]
		public unsafe static Insets Wrap(Insets insets)
		{
			Insets @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				@object = Java.Lang.Object.GetObject<Insets>(Insets._members.StaticMethods.InvokeObjectMethod("wrap.(Landroid/graphics/Insets;)Landroidx/core/graphics/Insets;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(insets);
			}
			return @object;
		}

		// Token: 0x040000BA RID: 186
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/graphics/Insets", typeof(Insets));
	}
}
