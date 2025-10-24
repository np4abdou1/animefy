using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001D0 RID: 464
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/TypeIntrinsics", DoNotGenerateAcw = true)]
	public class TypeIntrinsics : Java.Lang.Object
	{
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x0004B678 File Offset: 0x00049878
		internal static IntPtr class_ref
		{
			get
			{
				return TypeIntrinsics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x0004B69C File Offset: 0x0004989C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return TypeIntrinsics._members;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0004B6A4 File Offset: 0x000498A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeIntrinsics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0004B6C8 File Offset: 0x000498C8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return TypeIntrinsics._members.ManagedPeerType;
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0004B6D4 File Offset: 0x000498D4
		protected TypeIntrinsics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0004B6E0 File Offset: 0x000498E0
		[Register(".ctor", "()V", "")]
		public TypeIntrinsics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TypeIntrinsics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TypeIntrinsics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0004B750 File Offset: 0x00049950
		[Register("asMutableCollection", "(Ljava/lang/Object;)Ljava/util/Collection;", "")]
		public unsafe static System.Collections.ICollection AsMutableCollection(Java.Lang.Object obj)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaCollection.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableCollection.(Ljava/lang/Object;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x0004B7C4 File Offset: 0x000499C4
		[Register("asMutableCollection", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Collection;", "")]
		public unsafe static System.Collections.ICollection AsMutableCollection(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaCollection.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableCollection.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0004B858 File Offset: 0x00049A58
		[Register("asMutableIterable", "(Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable AsMutableIterable(Java.Lang.Object obj)
		{
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IIterable>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableIterable.(Ljava/lang/Object;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0004B8CC File Offset: 0x00049ACC
		[Register("asMutableIterable", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable AsMutableIterable(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterable>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableIterable.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0004B960 File Offset: 0x00049B60
		[Register("asMutableIterator", "(Ljava/lang/Object;)Ljava/util/Iterator;", "")]
		public unsafe static IIterator AsMutableIterator(Java.Lang.Object obj)
		{
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IIterator>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableIterator.(Ljava/lang/Object;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0004B9D4 File Offset: 0x00049BD4
		[Register("asMutableIterator", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Iterator;", "")]
		public unsafe static IIterator AsMutableIterator(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IIterator>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableIterator.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0004BA68 File Offset: 0x00049C68
		[Register("asMutableList", "(Ljava/lang/Object;)Ljava/util/List;", "")]
		public unsafe static System.Collections.IList AsMutableList(Java.Lang.Object obj)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaList.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableList.(Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0004BADC File Offset: 0x00049CDC
		[Register("asMutableList", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe static System.Collections.IList AsMutableList(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableList.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0004BB70 File Offset: 0x00049D70
		[Register("asMutableListIterator", "(Ljava/lang/Object;)Ljava/util/ListIterator;", "")]
		public unsafe static IListIterator AsMutableListIterator(Java.Lang.Object obj)
		{
			IListIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IListIterator>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableListIterator.(Ljava/lang/Object;)Ljava/util/ListIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		[Register("asMutableListIterator", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/ListIterator;", "")]
		public unsafe static IListIterator AsMutableListIterator(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			IListIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IListIterator>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableListIterator.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/ListIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0004BC78 File Offset: 0x00049E78
		[Register("asMutableMap", "(Ljava/lang/Object;)Ljava/util/Map;", "")]
		public unsafe static IDictionary AsMutableMap(Java.Lang.Object obj)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaDictionary.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableMap.(Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0004BCEC File Offset: 0x00049EEC
		[Register("asMutableMap", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Map;", "")]
		public unsafe static IDictionary AsMutableMap(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaDictionary.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableMap.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0004BD80 File Offset: 0x00049F80
		[Register("asMutableMapEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", "")]
		public unsafe static IMapEntry AsMutableMapEntry(Java.Lang.Object obj)
		{
			IMapEntry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IMapEntry>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableMapEntry.(Ljava/lang/Object;)Ljava/util/Map$Entry;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0004BDF4 File Offset: 0x00049FF4
		[Register("asMutableMapEntry", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Map$Entry;", "")]
		public unsafe static IMapEntry AsMutableMapEntry(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			IMapEntry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMapEntry>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableMapEntry.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Map$Entry;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0004BE88 File Offset: 0x0004A088
		[Register("asMutableSet", "(Ljava/lang/Object;)Ljava/util/Set;", "")]
		public unsafe static System.Collections.ICollection AsMutableSet(Java.Lang.Object obj)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaSet.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableSet.(Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0004BEFC File Offset: 0x0004A0FC
		[Register("asMutableSet", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Set;", "")]
		public unsafe static System.Collections.ICollection AsMutableSet(Java.Lang.Object obj, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("asMutableSet.(Ljava/lang/Object;Ljava/lang/String;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0004BF90 File Offset: 0x0004A190
		[Register("beforeCheckcastToFunctionOfArity", "(Ljava/lang/Object;I)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object BeforeCheckcastToFunctionOfArity(Java.Lang.Object obj, int arity)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(arity);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("beforeCheckcastToFunctionOfArity.(Ljava/lang/Object;I)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0004C018 File Offset: 0x0004A218
		[Register("beforeCheckcastToFunctionOfArity", "(Ljava/lang/Object;ILjava/lang/String;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object BeforeCheckcastToFunctionOfArity(Java.Lang.Object obj, int arity, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(arity);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("beforeCheckcastToFunctionOfArity.(Ljava/lang/Object;ILjava/lang/String;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x0004C0C0 File Offset: 0x0004A2C0
		[Register("castToCollection", "(Ljava/lang/Object;)Ljava/util/Collection;", "")]
		public unsafe static System.Collections.ICollection CastToCollection(Java.Lang.Object obj)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaCollection.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToCollection.(Ljava/lang/Object;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x0004C134 File Offset: 0x0004A334
		[Register("castToIterable", "(Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		public unsafe static IIterable CastToIterable(Java.Lang.Object obj)
		{
			IIterable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IIterable>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToIterable.(Ljava/lang/Object;)Ljava/lang/Iterable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0004C1A8 File Offset: 0x0004A3A8
		[Register("castToIterator", "(Ljava/lang/Object;)Ljava/util/Iterator;", "")]
		public unsafe static IIterator CastToIterator(Java.Lang.Object obj)
		{
			IIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IIterator>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToIterator.(Ljava/lang/Object;)Ljava/util/Iterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0004C21C File Offset: 0x0004A41C
		[Register("castToList", "(Ljava/lang/Object;)Ljava/util/List;", "")]
		public unsafe static System.Collections.IList CastToList(Java.Lang.Object obj)
		{
			System.Collections.IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaList.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToList.(Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0004C290 File Offset: 0x0004A490
		[Register("castToListIterator", "(Ljava/lang/Object;)Ljava/util/ListIterator;", "")]
		public unsafe static IListIterator CastToListIterator(Java.Lang.Object obj)
		{
			IListIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IListIterator>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToListIterator.(Ljava/lang/Object;)Ljava/util/ListIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x0004C304 File Offset: 0x0004A504
		[Register("castToMap", "(Ljava/lang/Object;)Ljava/util/Map;", "")]
		public unsafe static IDictionary CastToMap(Java.Lang.Object obj)
		{
			IDictionary result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaDictionary.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToMap.(Ljava/lang/Object;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0004C378 File Offset: 0x0004A578
		[Register("castToMapEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", "")]
		public unsafe static IMapEntry CastToMapEntry(Java.Lang.Object obj)
		{
			IMapEntry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IMapEntry>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToMapEntry.(Ljava/lang/Object;)Ljava/util/Map$Entry;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		[Register("castToSet", "(Ljava/lang/Object;)Ljava/util/Set;", "")]
		public unsafe static System.Collections.ICollection CastToSet(Java.Lang.Object obj)
		{
			System.Collections.ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = JavaSet.FromJniHandle(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("castToSet.(Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0004C460 File Offset: 0x0004A660
		[Register("getFunctionArity", "(Ljava/lang/Object;)I", "")]
		public unsafe static int GetFunctionArity(Java.Lang.Object obj)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeInt32Method("getFunctionArity.(Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0004C4C4 File Offset: 0x0004A6C4
		[Register("isFunctionOfArity", "(Ljava/lang/Object;I)Z", "")]
		public unsafe static bool IsFunctionOfArity(Java.Lang.Object obj, int arity)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(arity);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isFunctionOfArity.(Ljava/lang/Object;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0004C53C File Offset: 0x0004A73C
		[Register("isMutableCollection", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableCollection(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableCollection.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0004C5A0 File Offset: 0x0004A7A0
		[Register("isMutableIterable", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableIterable(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableIterable.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0004C604 File Offset: 0x0004A804
		[Register("isMutableIterator", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableIterator(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableIterator.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0004C668 File Offset: 0x0004A868
		[Register("isMutableList", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableList(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableList.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0004C6CC File Offset: 0x0004A8CC
		[Register("isMutableListIterator", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableListIterator(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableListIterator.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0004C730 File Offset: 0x0004A930
		[Register("isMutableMap", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableMap(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableMap.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0004C794 File Offset: 0x0004A994
		[Register("isMutableMapEntry", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableMapEntry(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableMapEntry.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0004C7F8 File Offset: 0x0004A9F8
		[Register("isMutableSet", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsMutableSet(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TypeIntrinsics._members.StaticMethods.InvokeBooleanMethod("isMutableSet.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0004C85C File Offset: 0x0004AA5C
		[Register("throwCce", "(Ljava/lang/ClassCastException;)Ljava/lang/ClassCastException;", "")]
		public unsafe static ClassCastException ThrowCce(ClassCastException e)
		{
			ClassCastException @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				@object = Java.Lang.Object.GetObject<ClassCastException>(TypeIntrinsics._members.StaticMethods.InvokeObjectMethod("throwCce.(Ljava/lang/ClassCastException;)Ljava/lang/ClassCastException;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return @object;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0004C8D0 File Offset: 0x0004AAD0
		[Register("throwCce", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
		public unsafe static void ThrowCce(Java.Lang.Object argument, string requestedClassName)
		{
			IntPtr intPtr = JNIEnv.NewString(requestedClassName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((argument == null) ? IntPtr.Zero : argument.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				TypeIntrinsics._members.StaticMethods.InvokeVoidMethod("throwCce.(Ljava/lang/Object;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(argument);
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0004C954 File Offset: 0x0004AB54
		[Register("throwCce", "(Ljava/lang/String;)V", "")]
		public unsafe static void ThrowCce(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				TypeIntrinsics._members.StaticMethods.InvokeVoidMethod("throwCce.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000745 RID: 1861
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/TypeIntrinsics", typeof(TypeIntrinsics));
	}
}
