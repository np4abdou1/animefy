using System;
using System.Collections.Generic;
using System.Reflection;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002C0 RID: 704
	internal class AndroidValueManager : JniRuntime.JniValueManager
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00045C77 File Offset: 0x00043E77
		public override IJavaPeerable CreatePeer(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			IJavaPeerable result = TypeManager.CreateInstance(reference.Handle, JniHandleOwnership.DoNotTransfer, targetType);
			JniObjectReference.Dispose(ref reference, options);
			return result;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00045C98 File Offset: 0x00043E98
		public override void AddPeer(IJavaPeerable value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!value.PeerReference.IsValid)
			{
				throw new ArgumentException("Must have a valid JNI object reference!", "value");
			}
			JniObjectReference peerReference = value.PeerReference;
			IntPtr hash = JNIEnv.IdentityHash(peerReference.Handle);
			this.AddPeer(value, peerReference, hash);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00045CF0 File Offset: 0x00043EF0
		internal void AddPeer(IJavaPeerable value, JniObjectReference reference, IntPtr hash)
		{
			Dictionary<IntPtr, IdentityHashTargets> obj = this.instances;
			lock (obj)
			{
				IdentityHashTargets identityHashTargets;
				if (!this.instances.TryGetValue(hash, out identityHashTargets))
				{
					identityHashTargets = new IdentityHashTargets(value);
					this.instances.Add(hash, identityHashTargets);
				}
				else
				{
					bool flag2 = false;
					for (int i = 0; i < identityHashTargets.Count; i++)
					{
						WeakReference<IJavaPeerable> current = identityHashTargets[i];
						IJavaPeerable javaPeerable;
						if (this.ShouldReplaceMapping(current, reference, out javaPeerable))
						{
							flag2 = true;
							identityHashTargets[i] = IdentityHashTargets.CreateWeakReference(value);
							break;
						}
						if (JniEnvironment.Types.IsSameObject(value.PeerReference, javaPeerable.PeerReference))
						{
							flag2 = true;
							if (Logger.LogGlobalRef)
							{
								Logger.Log(LogLevel.Info, "monodroid-gref", string.Format("warning: not replacing previous registered handle {0} with handle {1} for key_handle 0x{2}", javaPeerable.PeerReference.ToString(), reference.ToString(), hash.ToString("x")));
							}
						}
					}
					if (!flag2)
					{
						identityHashTargets.Add(value);
					}
				}
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00045E04 File Offset: 0x00044004
		internal void AddPeer(IJavaPeerable value, IntPtr handle, JniHandleOwnership transfer, out IntPtr handleField)
		{
			if (handle == IntPtr.Zero)
			{
				handleField = handle;
				return;
			}
			switch (transfer & (JniHandleOwnership.TransferLocalRef | JniHandleOwnership.TransferGlobalRef))
			{
			case JniHandleOwnership.DoNotTransfer:
				handleField = JNIEnv.NewGlobalRef(handle);
				break;
			case JniHandleOwnership.TransferLocalRef:
				handleField = JNIEnv.NewGlobalRef(handle);
				JNIEnv.DeleteLocalRef(handle);
				break;
			case JniHandleOwnership.TransferGlobalRef:
				handleField = handle;
				break;
			default:
			{
				string paramName = "transfer";
				object actualValue = transfer;
				string str = "Invalid `transfer` value: ";
				string str2 = transfer.ToString();
				string str3 = " on type ";
				Type type = value.GetType();
				throw new ArgumentOutOfRangeException(paramName, actualValue, str + str2 + str3 + ((type != null) ? type.ToString() : null));
			}
			}
			if (handleField == IntPtr.Zero)
			{
				throw new InvalidOperationException("Unable to allocate Global Reference for object '" + value.ToString() + "'!");
			}
			IntPtr intPtr = JNIEnv.IdentityHash(handleField);
			value.SetJniIdentityHashCode((int)intPtr);
			if ((transfer & JniHandleOwnership.DoNotRegister) == JniHandleOwnership.DoNotTransfer)
			{
				this.AddPeer(value, new JniObjectReference(handleField, JniObjectReferenceType.Global), intPtr);
			}
			if (Logger.LogGlobalRef)
			{
				RuntimeNativeMethods._monodroid_gref_log(string.Concat(new string[]
				{
					"handle 0x",
					handleField.ToString("x"),
					"; key_handle 0x",
					intPtr.ToString("x"),
					": Java Type: `",
					JNIEnv.GetClassNameFromInstance(handleField),
					"`; MCW type: `",
					value.GetType().FullName,
					"`\n"
				}));
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00045F6C File Offset: 0x0004416C
		private bool ShouldReplaceMapping(WeakReference<IJavaPeerable> current, JniObjectReference reference, out IJavaPeerable target)
		{
			target = null;
			return current == null || (!current.TryGetTarget(out target) || target == null) || !target.PeerReference.IsValid || (JniEnvironment.Types.IsSameObject(target.PeerReference, reference) && (target.JniManagedPeerState & JniManagedPeerStates.Replaceable) == JniManagedPeerStates.Replaceable);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00045FC4 File Offset: 0x000441C4
		public override void RemovePeer(IJavaPeerable value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			JniObjectReference peerReference = value.PeerReference;
			if (!peerReference.IsValid)
			{
				return;
			}
			IntPtr hash = JNIEnv.IdentityHash(peerReference.Handle);
			this.RemovePeer(value, hash);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00046008 File Offset: 0x00044208
		internal void RemovePeer(IJavaPeerable value, IntPtr hash)
		{
			Dictionary<IntPtr, IdentityHashTargets> obj = this.instances;
			lock (obj)
			{
				IdentityHashTargets identityHashTargets;
				if (this.instances.TryGetValue(hash, out identityHashTargets))
				{
					for (int i = identityHashTargets.Count - 1; i >= 0; i--)
					{
						IJavaPeerable javaPeerable;
						if (!identityHashTargets[i].TryGetTarget(out javaPeerable))
						{
							identityHashTargets.RemoveAt(i);
						}
						else if (javaPeerable == value)
						{
							identityHashTargets.RemoveAt(i);
						}
					}
					if (identityHashTargets.Count == 0)
					{
						this.instances.Remove(hash);
					}
				}
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000460A4 File Offset: 0x000442A4
		public override IJavaPeerable PeekPeer(JniObjectReference reference)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			IntPtr key = JNIEnv.IdentityHash(reference.Handle);
			Dictionary<IntPtr, IdentityHashTargets> obj = this.instances;
			lock (obj)
			{
				IdentityHashTargets identityHashTargets;
				if (this.instances.TryGetValue(key, out identityHashTargets))
				{
					for (int i = identityHashTargets.Count - 1; i >= 0; i--)
					{
						IJavaPeerable javaPeerable;
						if (!identityHashTargets[i].TryGetTarget(out javaPeerable) || !javaPeerable.PeerReference.IsValid)
						{
							identityHashTargets.RemoveAt(i);
						}
						else if (JniEnvironment.Types.IsSameObject(reference, javaPeerable.PeerReference))
						{
							return javaPeerable;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00046164 File Offset: 0x00044364
		public override void ActivatePeer(IJavaPeerable self, JniObjectReference reference, ConstructorInfo cinfo, object[] argumentValues)
		{
			TypeManager.Activate(reference.Handle, cinfo, argumentValues);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00046178 File Offset: 0x00044378
		protected override bool TryUnboxPeerObject(IJavaPeerable value, out object result)
		{
			JavaProxyThrowable javaProxyThrowable = value as JavaProxyThrowable;
			if (javaProxyThrowable != null)
			{
				result = javaProxyThrowable.InnerException;
				return true;
			}
			return base.TryUnboxPeerObject(value, out result);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000461A4 File Offset: 0x000443A4
		internal Exception UnboxException(IJavaPeerable value)
		{
			object obj;
			if (this.TryUnboxPeerObject(value, out obj))
			{
				Exception ex = obj as Exception;
				if (ex != null)
				{
					return ex;
				}
			}
			return null;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x000461CC File Offset: 0x000443CC
		public override void FinalizePeer(IJavaPeerable value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (Logger.LogGlobalRef)
			{
				RuntimeNativeMethods._monodroid_gref_log(string.Format("Finalizing handle {0}\n", value.PeerReference));
			}
			if (value.PeerReference.IsValid)
			{
				GC.ReRegisterForFinalize(value);
				return;
			}
			this.RemovePeer(value, (IntPtr)value.JniIdentityHashCode);
			value.SetPeerReference(default(JniObjectReference));
			value.Finalized();
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00046248 File Offset: 0x00044448
		public override List<JniSurfacedPeerInfo> GetSurfacedPeers()
		{
			Dictionary<IntPtr, IdentityHashTargets> obj = this.instances;
			List<JniSurfacedPeerInfo> result;
			lock (obj)
			{
				List<JniSurfacedPeerInfo> list = new List<JniSurfacedPeerInfo>(this.instances.Count);
				foreach (KeyValuePair<IntPtr, IdentityHashTargets> keyValuePair in this.instances)
				{
					for (int i = 0; i < keyValuePair.Value.Count; i++)
					{
						WeakReference<IJavaPeerable> surfacedPeer = keyValuePair.Value[i];
						list.Add(new JniSurfacedPeerInfo(keyValuePair.Key.ToInt32(), surfacedPeer));
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x04000B79 RID: 2937
		private Dictionary<IntPtr, IdentityHashTargets> instances = new Dictionary<IntPtr, IdentityHashTargets>();
	}
}
