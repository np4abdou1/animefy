using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Collections
{
	// Token: 0x020002B6 RID: 694
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMutableMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public abstract class AbstractMutableMap : AbstractMap, IMap, IJavaObject, IDisposable, IJavaPeerable, IKMutableMap, IKMappedMarker
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0006BC04 File Offset: 0x00069E04
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractMutableMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0006BC28 File Offset: 0x00069E28
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableMap._members;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x0006BC30 File Offset: 0x00069E30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMutableMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x0006BC54 File Offset: 0x00069E54
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AbstractMutableMap._members.ManagedPeerType;
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0006BC60 File Offset: 0x00069E60
		protected AbstractMutableMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0006BC6C File Offset: 0x00069E6C
		[Register(".ctor", "()V", "")]
		protected AbstractMutableMap() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractMutableMap._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractMutableMap._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0006BCDA File Offset: 0x00069EDA
		[NullableContext(1)]
		private static Delegate GetGetEntriesHandler()
		{
			if (AbstractMutableMap.cb_getEntries == null)
			{
				AbstractMutableMap.cb_getEntries = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMutableMap.n_GetEntries));
			}
			return AbstractMutableMap.cb_getEntries;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0006BCFE File Offset: 0x00069EFE
		private static IntPtr n_GetEntries(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMutableMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Entries);
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600205C RID: 8284
		public abstract System.Collections.ICollection Entries { [Register("getEntries", "()Ljava/util/Set;", "GetGetEntriesHandler")] get; }

		// Token: 0x0600205D RID: 8285 RVA: 0x0006BD12 File Offset: 0x00069F12
		[NullableContext(1)]
		private static Delegate GetGetKeysHandler()
		{
			if (AbstractMutableMap.cb_getKeys == null)
			{
				AbstractMutableMap.cb_getKeys = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMutableMap.n_GetKeys));
			}
			return AbstractMutableMap.cb_getKeys;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0006BD36 File Offset: 0x00069F36
		private static IntPtr n_GetKeys(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMutableMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Keys);
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0006BD4C File Offset: 0x00069F4C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual ICollection<Java.Lang.Object> Keys
		{
			[Register("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return JavaSet<Java.Lang.Object>.FromJniHandle(AbstractMutableMap._members.InstanceMethods.InvokeVirtualObjectMethod("getKeys.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0006BD80 File Offset: 0x00069F80
		[Register("entrySet", "()Ljava/util/Set;", "")]
		public sealed override System.Collections.ICollection EntrySet()
		{
			return JavaSet.FromJniHandle(AbstractMutableMap._members.InstanceMethods.InvokeNonvirtualObjectMethod("entrySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0006BDB2 File Offset: 0x00069FB2
		[NullableContext(1)]
		private static Delegate GetGetSizeHandler()
		{
			if (AbstractMutableMap.cb_getSize == null)
			{
				AbstractMutableMap.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AbstractMutableMap.n_GetSize));
			}
			return AbstractMutableMap.cb_getSize;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0006BDD6 File Offset: 0x00069FD6
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMutableMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSize();
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0006BDE5 File Offset: 0x00069FE5
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public virtual int GetSize()
		{
			return AbstractMutableMap._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0006BDFE File Offset: 0x00069FFE
		[NullableContext(1)]
		private static Delegate GetGetValuesHandler()
		{
			if (AbstractMutableMap.cb_getValues == null)
			{
				AbstractMutableMap.cb_getValues = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMutableMap.n_GetValues));
			}
			return AbstractMutableMap.cb_getValues;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0006BE22 File Offset: 0x0006A022
		private static IntPtr n_GetValues(IntPtr jnienv, IntPtr native__this)
		{
			return JavaCollection<Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMutableMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetValues());
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0006BE38 File Offset: 0x0006A038
		[Register("getValues", "()Ljava/util/Collection;", "GetGetValuesHandler")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual ICollection<Java.Lang.Object> GetValues()
		{
			return JavaCollection<Java.Lang.Object>.FromJniHandle(AbstractMutableMap._members.InstanceMethods.InvokeVirtualObjectMethod("getValues.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0006BE6C File Offset: 0x0006A06C
		[Register("keySet", "()Ljava/util/Set;", "")]
		public sealed override System.Collections.ICollection KeySet()
		{
			return JavaSet.FromJniHandle(AbstractMutableMap._members.InstanceMethods.InvokeNonvirtualObjectMethod("keySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0006BE9E File Offset: 0x0006A09E
		[NullableContext(1)]
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (AbstractMutableMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				AbstractMutableMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AbstractMutableMap.n_Put_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return AbstractMutableMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0006BEC4 File Offset: 0x0006A0C4
		private static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			AbstractMutableMap @object = Java.Lang.Object.GetObject<AbstractMutableMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x0600206A RID: 8298
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public new abstract Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value);

		// Token: 0x0600206B RID: 8299 RVA: 0x0006BEF5 File Offset: 0x0006A0F5
		[Register("size", "()I", "")]
		public sealed override int Size()
		{
			return AbstractMutableMap._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0006BF10 File Offset: 0x0006A110
		[Register("values", "()Ljava/util/Collection;", "")]
		public sealed override System.Collections.ICollection Values()
		{
			return JavaCollection.FromJniHandle(AbstractMutableMap._members.InstanceMethods.InvokeNonvirtualObjectMethod("values.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000980 RID: 2432
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMutableMap", typeof(AbstractMutableMap));

		// Token: 0x04000981 RID: 2433
		private static Delegate cb_getEntries;

		// Token: 0x04000982 RID: 2434
		private static Delegate cb_getKeys;

		// Token: 0x04000983 RID: 2435
		private static Delegate cb_getSize;

		// Token: 0x04000984 RID: 2436
		private static Delegate cb_getValues;

		// Token: 0x04000985 RID: 2437
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
