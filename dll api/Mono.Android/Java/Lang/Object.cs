using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003EA RID: 1002
	[Register("java/lang/Object", DoNotGenerateAcw = true)]
	[Serializable]
	public class Object : IDisposable, IJavaObject, IJavaObjectEx, IJavaPeerable
	{
		// Token: 0x06002BFE RID: 11262 RVA: 0x00079A54 File Offset: 0x00077C54
		protected Object() : this(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (this.Handle != IntPtr.Zero)
			{
				return;
			}
			this.SetHandle(Object._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Object._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00079AC2 File Offset: 0x00077CC2
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (Object.cb_equals_Ljava_lang_Object_ == null)
			{
				Object.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Object.n_Equals_Ljava_lang_Object_));
			}
			return Object.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00079AE8 File Offset: 0x00077CE8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			Object @object = Object.GetObject<Object>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Object object2 = Object.GetObject<Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00079B0C File Offset: 0x00077D0C
		public unsafe virtual bool Equals(Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = Object._members.InstanceMethods.InvokeVirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00079B74 File Offset: 0x00077D74
		private static Delegate GetGetHashCodeHandler()
		{
			if (Object.cb_hashCode == null)
			{
				Object.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Object.n_GetHashCode));
			}
			return Object.cb_hashCode;
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00079B98 File Offset: 0x00077D98
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Object.GetObject<Object>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00079BA7 File Offset: 0x00077DA7
		public override int GetHashCode()
		{
			return Object._members.InstanceMethods.InvokeVirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00079BC0 File Offset: 0x00077DC0
		private static Delegate GetToStringHandler()
		{
			if (Object.cb_toString == null)
			{
				Object.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Object.n_ToString));
			}
			return Object.cb_toString;
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00079BE4 File Offset: 0x00077DE4
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<Object>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00079BF8 File Offset: 0x00077DF8
		public override string ToString()
		{
			return JNIEnv.GetString(Object._members.InstanceMethods.InvokeVirtualObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x00079C2A File Offset: 0x00077E2A
		// (set) Token: 0x06002C09 RID: 11273 RVA: 0x00079C32 File Offset: 0x00077E32
		IntPtr IJavaObjectEx.KeyHandle
		{
			get
			{
				return this.key_handle;
			}
			set
			{
				this.key_handle = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x00079C3B File Offset: 0x00077E3B
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x00079C43 File Offset: 0x00077E43
		bool IJavaObjectEx.IsProxy
		{
			get
			{
				return this.isProxy;
			}
			set
			{
				this.isProxy = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x00079C4C File Offset: 0x00077E4C
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x00079C54 File Offset: 0x00077E54
		bool IJavaObjectEx.NeedsActivation
		{
			get
			{
				return this.needsActivation;
			}
			set
			{
				this.needsActivation = true;
			}
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00079C60 File Offset: 0x00077E60
		IntPtr IJavaObjectEx.ToLocalJniHandle()
		{
			IntPtr result;
			lock (this)
			{
				if (this.handle == IntPtr.Zero)
				{
					result = this.handle;
				}
				else
				{
					result = JNIEnv.NewLocalRef(this.handle);
				}
			}
			return result;
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00079CC0 File Offset: 0x00077EC0
		~Object()
		{
			this.refs_added = 0;
			if (!Environment.HasShutdownStarted)
			{
				JniEnvironment.Runtime.ValueManager.FinalizePeer(this);
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00079D08 File Offset: 0x00077F08
		public Object(IntPtr handle, JniHandleOwnership transfer)
		{
			if (this.handle != IntPtr.Zero)
			{
				this.needsActivation = true;
				handle = this.handle;
				if (this.handle_type != JObjectRefType.Invalid)
				{
					return;
				}
				transfer = JniHandleOwnership.DoNotTransfer;
			}
			this.SetHandle(handle, transfer);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00079D48 File Offset: 0x00077F48
		[OnDeserialized]
		internal void SetHandleOnDeserialized(StreamingContext context)
		{
			if (this.Handle != IntPtr.Zero)
			{
				return;
			}
			this.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(this.Handle, "()V", Array.Empty<JValue>());
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x00079D99 File Offset: 0x00077F99
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int JniIdentityHashCode
		{
			get
			{
				return (int)this.key_handle;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x00079DA6 File Offset: 0x00077FA6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public JniObjectReference PeerReference
		{
			get
			{
				return new JniObjectReference(this.handle, (JniObjectReferenceType)this.handle_type);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00079DB9 File Offset: 0x00077FB9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual JniPeerMembers JniPeerMembers
		{
			get
			{
				return Object._members;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x00079DC0 File Offset: 0x00077FC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IntPtr Handle
		{
			get
			{
				if (this.weak_handle != IntPtr.Zero)
				{
					Logger.Log(LogLevel.Warn, "Mono.Android.dll", "Accessing object which is out for collection via original handle");
				}
				return this.handle;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x00079DEA File Offset: 0x00077FEA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected virtual IntPtr ThresholdClass
		{
			get
			{
				return Class.Object;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x00079DF1 File Offset: 0x00077FF1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected virtual Type ThresholdType
		{
			get
			{
				return typeof(Object);
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00079DFD File Offset: 0x00077FFD
		internal IntPtr GetThresholdClass()
		{
			return this.ThresholdClass;
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00079E05 File Offset: 0x00078005
		internal Type GetThresholdType()
		{
			return this.ThresholdType;
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x00079E10 File Offset: 0x00078010
		JniManagedPeerStates IJavaPeerable.JniManagedPeerState
		{
			get
			{
				JniManagedPeerStates jniManagedPeerStates = JniManagedPeerStates.None;
				if (((IJavaObjectEx)this).IsProxy)
				{
					jniManagedPeerStates |= JniManagedPeerStates.Replaceable;
				}
				if (((IJavaObjectEx)this).NeedsActivation)
				{
					jniManagedPeerStates |= JniManagedPeerStates.Activatable;
				}
				return jniManagedPeerStates;
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00079E38 File Offset: 0x00078038
		void IJavaPeerable.DisposeUnlessReferenced()
		{
			if (Object.PeekObject(this.handle, null) == null)
			{
				this.Dispose();
			}
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00079E4E File Offset: 0x0007804E
		void IJavaPeerable.Disposed()
		{
			this.Dispose(true);
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00079E57 File Offset: 0x00078057
		void IJavaPeerable.Finalized()
		{
			this.Dispose(false);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x00079E60 File Offset: 0x00078060
		void IJavaPeerable.SetJniIdentityHashCode(int value)
		{
			this.key_handle = (IntPtr)value;
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00079E70 File Offset: 0x00078070
		void IJavaPeerable.SetJniManagedPeerState(JniManagedPeerStates value)
		{
			if ((value & JniManagedPeerStates.Replaceable) == JniManagedPeerStates.Replaceable)
			{
				((IJavaObjectEx)this).IsProxy = true;
			}
			if ((value & JniManagedPeerStates.Activatable) == JniManagedPeerStates.Activatable)
			{
				((IJavaObjectEx)this).NeedsActivation = true;
			}
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00079E99 File Offset: 0x00078099
		void IJavaPeerable.SetPeerReference(JniObjectReference reference)
		{
			this.handle = reference.Handle;
			this.handle_type = (JObjectRefType)reference.Type;
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00079EB5 File Offset: 0x000780B5
		public void Dispose()
		{
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			if (androidValueManager == null)
			{
				return;
			}
			androidValueManager.DisposePeer(this);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00025BC2 File Offset: 0x00023DC2
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00079EC8 File Offset: 0x000780C8
		internal static void Dispose(IJavaPeerable instance, ref IntPtr handle, IntPtr key_handle, JObjectRefType handle_type)
		{
			if (handle == IntPtr.Zero)
			{
				return;
			}
			if (Logger.LogGlobalRef)
			{
				RuntimeNativeMethods._monodroid_gref_log(string.Format("Disposing handle 0x{0}\n", handle.ToString("x")));
			}
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			if (androidValueManager != null)
			{
				androidValueManager.RemovePeer(instance, key_handle);
			}
			IJavaPeerable obj;
			if (handle_type != JObjectRefType.Global)
			{
				if (handle_type != JObjectRefType.WeakGlobal)
				{
					goto IL_99;
				}
			}
			else
			{
				obj = instance;
				lock (obj)
				{
					JNIEnv.DeleteGlobalRef(handle);
					handle = IntPtr.Zero;
					return;
				}
			}
			obj = instance;
			lock (obj)
			{
				JNIEnv.DeleteWeakGlobalRef(handle);
				handle = IntPtr.Zero;
				return;
			}
			IL_99:
			throw new InvalidOperationException("Trying to dispose handle of type '" + handle_type.ToString() + "' which is not supported.");
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00079FAC File Offset: 0x000781AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SetHandle(IntPtr value, JniHandleOwnership transfer)
		{
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			if (androidValueManager != null)
			{
				androidValueManager.AddPeer(this, value, transfer, out this.handle);
			}
			this.handle_type = JObjectRefType.Global;
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00079FD0 File Offset: 0x000781D0
		internal static IJavaPeerable PeekObject(IntPtr handle, Type requiredType = null)
		{
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			IJavaPeerable javaPeerable = (androidValueManager != null) ? androidValueManager.PeekPeer(new JniObjectReference(handle, JniObjectReferenceType.Invalid)) : null;
			if (javaPeerable == null)
			{
				return null;
			}
			if (requiredType != null && !requiredType.IsAssignableFrom(javaPeerable.GetType()))
			{
				return null;
			}
			return javaPeerable;
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x0007A015 File Offset: 0x00078215
		public static T GetObject<T>(IntPtr jnienv, IntPtr handle, JniHandleOwnership transfer) where T : class, IJavaObject
		{
			JNIEnv.CheckHandle(jnienv);
			return Object.GetObject<T>(handle, transfer);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0007A024 File Offset: 0x00078224
		public static T GetObject<T>(IntPtr handle, JniHandleOwnership transfer) where T : class, IJavaObject
		{
			return Object._GetObject<T>(handle, transfer);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0007A030 File Offset: 0x00078230
		internal static T _GetObject<T>(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return default(T);
			}
			return (T)((object)Object.GetObject(handle, transfer, typeof(T)));
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x0007A06C File Offset: 0x0007826C
		internal static IJavaPeerable GetObject(IntPtr handle, JniHandleOwnership transfer, Type type = null)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaPeerable javaPeerable = Object.PeekObject(handle, type);
			if (javaPeerable != null)
			{
				JNIEnv.DeleteRef(handle, transfer);
				return javaPeerable;
			}
			return Java.Interop.TypeManager.CreateInstance(handle, transfer, type);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0007A0A4 File Offset: 0x000782A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public T[] ToArray<T>()
		{
			return JNIEnv.GetArray<T>(this.Handle);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x0007A0B1 File Offset: 0x000782B1
		public static implicit operator Object(int value)
		{
			return new Integer(value);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0007A0B9 File Offset: 0x000782B9
		public static implicit operator Object(long value)
		{
			return new Long(value);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x0007A0C1 File Offset: 0x000782C1
		public static implicit operator Object(string value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharSequenceInvoker(JNIEnv.NewString(value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x0007A0D4 File Offset: 0x000782D4
		public static explicit operator int(Object value)
		{
			return Convert.ToInt32(value);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x0007A0DC File Offset: 0x000782DC
		public static explicit operator long(Object value)
		{
			return Convert.ToInt64(value);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0007A0E4 File Offset: 0x000782E4
		public static explicit operator Object[](Object value)
		{
			if (value == null)
			{
				return null;
			}
			return value.ToArray<Object>();
		}

		// Token: 0x04001180 RID: 4480
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Object", typeof(Object));

		// Token: 0x04001181 RID: 4481
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04001182 RID: 4482
		private static Delegate cb_hashCode;

		// Token: 0x04001183 RID: 4483
		private static Delegate cb_toString;

		// Token: 0x04001184 RID: 4484
		[NonSerialized]
		private IntPtr key_handle;

		// Token: 0x04001185 RID: 4485
		[NonSerialized]
		private IntPtr weak_handle;

		// Token: 0x04001186 RID: 4486
		[NonSerialized]
		private int refs_added;

		// Token: 0x04001187 RID: 4487
		[NonSerialized]
		private JObjectRefType handle_type;

		// Token: 0x04001188 RID: 4488
		[NonSerialized]
		internal IntPtr handle;

		// Token: 0x04001189 RID: 4489
		[NonSerialized]
		private bool needsActivation;

		// Token: 0x0400118A RID: 4490
		[NonSerialized]
		private bool isProxy;
	}
}
