using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace AndroidX.Collection
{
	// Token: 0x02000013 RID: 19
	[Register("androidx/collection/ArrayMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public class ArrayMap : SimpleArrayMap, IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0000207F File Offset: 0x0000027F
		public System.Collections.ICollection EntrySet()
		{
			return (System.Collections.ICollection)this._EntrySet();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000208C File Offset: 0x0000028C
		internal new static IntPtr class_ref
		{
			get
			{
				return ArrayMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000020B0 File Offset: 0x000002B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ArrayMap._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000020B8 File Offset: 0x000002B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrayMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000020DC File Offset: 0x000002DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ArrayMap._members.ManagedPeerType;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020E8 File Offset: 0x000002E8
		protected ArrayMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020F4 File Offset: 0x000002F4
		[Register(".ctor", "()V", "")]
		public ArrayMap() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ArrayMap._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ArrayMap._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002164 File Offset: 0x00000364
		[Register(".ctor", "(Landroidx/collection/SimpleArrayMap;)V", "")]
		public unsafe ArrayMap(SimpleArrayMap map) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((map == null) ? IntPtr.Zero : map.Handle);
				base.SetHandle(ArrayMap._members.InstanceMethods.StartCreateInstance("(Landroidx/collection/SimpleArrayMap;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ArrayMap._members.InstanceMethods.FinishCreateInstance("(Landroidx/collection/SimpleArrayMap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(map);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002214 File Offset: 0x00000414
		[Register(".ctor", "(I)V", "")]
		public unsafe ArrayMap(int capacity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(capacity);
			base.SetHandle(ArrayMap._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ArrayMap._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002298 File Offset: 0x00000498
		private static Delegate GetContainsAll_Ljava_util_Collection_Handler()
		{
			if (ArrayMap.cb_containsAll_Ljava_util_Collection_ == null)
			{
				ArrayMap.cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ArrayMap.n_ContainsAll_Ljava_util_Collection_));
			}
			return ArrayMap.cb_containsAll_Ljava_util_Collection_;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000022BC File Offset: 0x000004BC
		private static bool n_ContainsAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			ArrayMap @object = Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection<object> collection = JavaCollection<object>.FromJniHandle(native_collection, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsAll(collection);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022E0 File Offset: 0x000004E0
		[Register("containsAll", "(Ljava/util/Collection;)Z", "GetContainsAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool ContainsAll(ICollection<object> collection)
		{
			IntPtr intPtr = JavaCollection<object>.ToLocalJniHandle(collection);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(collection);
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002344 File Offset: 0x00000544
		private static Delegate Get_EntrySetHandler()
		{
			if (ArrayMap.cb_entrySet == null)
			{
				ArrayMap.cb_entrySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ArrayMap.n__EntrySet));
			}
			return ArrayMap.cb_entrySet;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002368 File Offset: 0x00000568
		private static IntPtr n__EntrySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<IMapEntry>.ToLocalJniHandle(Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)._EntrySet());
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000237C File Offset: 0x0000057C
		[Register("entrySet", "()Ljava/util/Set;", "Get_EntrySetHandler")]
		public virtual ICollection<IMapEntry> _EntrySet()
		{
			return JavaSet<IMapEntry>.FromJniHandle(ArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("entrySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000023AE File Offset: 0x000005AE
		private static Delegate GetKeySetHandler()
		{
			if (ArrayMap.cb_keySet == null)
			{
				ArrayMap.cb_keySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ArrayMap.n_KeySet));
			}
			return ArrayMap.cb_keySet;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000023D2 File Offset: 0x000005D2
		private static IntPtr n_KeySet(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).KeySet());
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000023E8 File Offset: 0x000005E8
		[Register("keySet", "()Ljava/util/Set;", "GetKeySetHandler")]
		public virtual System.Collections.ICollection KeySet()
		{
			return JavaSet.FromJniHandle(ArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("keySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000241A File Offset: 0x0000061A
		private static Delegate GetPutAll_Ljava_util_Map_Handler()
		{
			if (ArrayMap.cb_putAll_Ljava_util_Map_ == null)
			{
				ArrayMap.cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ArrayMap.n_PutAll_Ljava_util_Map_));
			}
			return ArrayMap.cb_putAll_Ljava_util_Map_;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002440 File Offset: 0x00000640
		private static void n_PutAll_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_map)
		{
			ArrayMap @object = Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary map = JavaDictionary.FromJniHandle(native_map, JniHandleOwnership.DoNotTransfer);
			@object.PutAll(map);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002464 File Offset: 0x00000664
		[Register("putAll", "(Ljava/util/Map;)V", "GetPutAll_Ljava_util_Map_Handler")]
		public unsafe virtual void PutAll(IDictionary map)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(map);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ArrayMap._members.InstanceMethods.InvokeVirtualVoidMethod("putAll.(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(map);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000024C8 File Offset: 0x000006C8
		private static Delegate GetRemoveAll_Ljava_util_Collection_Handler()
		{
			if (ArrayMap.cb_removeAll_Ljava_util_Collection_ == null)
			{
				ArrayMap.cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ArrayMap.n_RemoveAll_Ljava_util_Collection_));
			}
			return ArrayMap.cb_removeAll_Ljava_util_Collection_;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000024EC File Offset: 0x000006EC
		private static bool n_RemoveAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			ArrayMap @object = Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection<object> collection = JavaCollection<object>.FromJniHandle(native_collection, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAll(collection);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002510 File Offset: 0x00000710
		[Register("removeAll", "(Ljava/util/Collection;)Z", "GetRemoveAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool RemoveAll(ICollection<object> collection)
		{
			IntPtr intPtr = JavaCollection<object>.ToLocalJniHandle(collection);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(collection);
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002574 File Offset: 0x00000774
		private static Delegate GetRetainAll_Ljava_util_Collection_Handler()
		{
			if (ArrayMap.cb_retainAll_Ljava_util_Collection_ == null)
			{
				ArrayMap.cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ArrayMap.n_RetainAll_Ljava_util_Collection_));
			}
			return ArrayMap.cb_retainAll_Ljava_util_Collection_;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002598 File Offset: 0x00000798
		private static bool n_RetainAll_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_collection)
		{
			ArrayMap @object = Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection<object> collection = JavaCollection<object>.FromJniHandle(native_collection, JniHandleOwnership.DoNotTransfer);
			return @object.RetainAll(collection);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000025BC File Offset: 0x000007BC
		[Register("retainAll", "(Ljava/util/Collection;)Z", "GetRetainAll_Ljava_util_Collection_Handler")]
		public unsafe virtual bool RetainAll(ICollection<object> collection)
		{
			IntPtr intPtr = JavaCollection<object>.ToLocalJniHandle(collection);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayMap._members.InstanceMethods.InvokeVirtualBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(collection);
			}
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002620 File Offset: 0x00000820
		private static Delegate GetValuesHandler()
		{
			if (ArrayMap.cb_values == null)
			{
				ArrayMap.cb_values = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ArrayMap.n_Values));
			}
			return ArrayMap.cb_values;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002644 File Offset: 0x00000844
		private static IntPtr n_Values(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection.ToLocalJniHandle(Java.Lang.Object.GetObject<ArrayMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Values());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002658 File Offset: 0x00000858
		[Register("values", "()Ljava/util/Collection;", "GetValuesHandler")]
		public virtual System.Collections.ICollection Values()
		{
			return JavaCollection.FromJniHandle(ArrayMap._members.InstanceMethods.InvokeVirtualObjectMethod("values.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/collection/ArrayMap", typeof(ArrayMap));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_containsAll_Ljava_util_Collection_;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_entrySet;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_keySet;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_putAll_Ljava_util_Map_;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_removeAll_Ljava_util_Collection_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_retainAll_Ljava_util_Collection_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_values;
	}
}
