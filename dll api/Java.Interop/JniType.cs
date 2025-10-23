using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Java.Interop
{
	// Token: 0x02000086 RID: 134
	public sealed class JniType : IDisposable
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000FE6B File Offset: 0x0000E06B
		public JniObjectReference PeerReference
		{
			get
			{
				return this.peerReference;
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000FE74 File Offset: 0x0000E074
		public JniType(string classname)
		{
			JniObjectReference jniObjectReference = JniEnvironment.Types.FindClass(classname);
			this.Initialize(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000FE97 File Offset: 0x0000E097
		public JniType(ref JniObjectReference peerReference, JniObjectReferenceOptions transfer)
		{
			this.Initialize(ref peerReference, transfer);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		private void Initialize(ref JniObjectReference peerReference, JniObjectReferenceOptions transfer)
		{
			if (!peerReference.IsValid)
			{
				throw new ArgumentException("handle must be valid.", "peerReference");
			}
			try
			{
				this.peerReference = peerReference.NewGlobalRef();
			}
			finally
			{
				JniObjectReference.Dispose(ref peerReference, transfer);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000FEF4 File Offset: 0x0000E0F4
		public string Name
		{
			get
			{
				this.AssertValid();
				return JniEnvironment.Types.GetJniTypeNameFromClass(this.PeerReference);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000FF07 File Offset: 0x0000E107
		public override string ToString()
		{
			return string.Format("JniType(Name='{0}' PeerReference={1})", this.Name, this.PeerReference);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000FF24 File Offset: 0x0000E124
		public void RegisterWithRuntime()
		{
			this.AssertValid();
			if (this.registered)
			{
				return;
			}
			JniEnvironment.Runtime.Track(this);
			this.registered = true;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000FF48 File Offset: 0x0000E148
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void AssertValid()
		{
			if (!this.PeerReference.IsValid)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000FF78 File Offset: 0x0000E178
		public static JniType GetCachedJniType(ref JniType cachedType, string classname)
		{
			if (cachedType != null && cachedType.PeerReference.IsValid)
			{
				return cachedType;
			}
			JniType jniType = new JniType(classname);
			if (Interlocked.CompareExchange<JniType>(ref cachedType, jniType, null) != null)
			{
				jniType.Dispose();
			}
			cachedType.RegisterWithRuntime();
			return cachedType;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		public void Dispose()
		{
			if (!this.PeerReference.IsValid)
			{
				return;
			}
			if (this.registered)
			{
				JniEnvironment.Runtime.UnTrack(this.PeerReference.Handle);
			}
			if (this.methods != null)
			{
				this.UnregisterNativeMethods();
			}
			JniObjectReference.Dispose(ref this.peerReference);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00010017 File Offset: 0x0000E217
		public void RegisterNativeMethods(params JniNativeMethodRegistration[] methods)
		{
			this.AssertValid();
			if (methods == null)
			{
				throw new ArgumentNullException("methods");
			}
			JniEnvironment.Types.RegisterNatives(this.PeerReference, methods, methods.Length);
			this.methods = methods;
			this.RegisterWithRuntime();
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00010049 File Offset: 0x0000E249
		public void UnregisterNativeMethods()
		{
			this.AssertValid();
			JniEnvironment.Types.UnregisterNatives(this.PeerReference);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001005C File Offset: 0x0000E25C
		public JniMethodInfo GetConstructor(string signature)
		{
			this.AssertValid();
			return JniEnvironment.InstanceMethods.GetMethodID(this.PeerReference, "<init>", signature);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00010075 File Offset: 0x0000E275
		public JniMethodInfo GetCachedConstructor(ref JniMethodInfo cachedMethod, string signature)
		{
			this.AssertValid();
			return this.GetCachedInstanceMethod(ref cachedMethod, "<init>", signature);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001008A File Offset: 0x0000E28A
		public JniObjectReference AllocObject()
		{
			this.AssertValid();
			return JniEnvironment.Object.AllocObject(this.PeerReference);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001009D File Offset: 0x0000E29D
		public unsafe JniObjectReference NewObject(JniMethodInfo constructor, JniArgumentValue* parameters)
		{
			this.AssertValid();
			return JniEnvironment.Object.NewObject(this.PeerReference, constructor, parameters);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000100B2 File Offset: 0x0000E2B2
		public JniFieldInfo GetInstanceField(string name, string signature)
		{
			this.AssertValid();
			return JniEnvironment.InstanceFields.GetFieldID(this.PeerReference, name, signature);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000100C7 File Offset: 0x0000E2C7
		public JniFieldInfo GetStaticField(string name, string signature)
		{
			this.AssertValid();
			return JniEnvironment.StaticFields.GetStaticFieldID(this.PeerReference, name, signature);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000100DC File Offset: 0x0000E2DC
		public JniMethodInfo GetInstanceMethod(string name, string signature)
		{
			this.AssertValid();
			return JniEnvironment.InstanceMethods.GetMethodID(this.PeerReference, name, signature);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000100F4 File Offset: 0x0000E2F4
		public JniMethodInfo GetCachedInstanceMethod(ref JniMethodInfo cachedMethod, string name, string signature)
		{
			this.AssertValid();
			if (cachedMethod != null && cachedMethod.IsValid)
			{
				return cachedMethod;
			}
			JniMethodInfo instanceMethod = this.GetInstanceMethod(name, signature);
			Interlocked.CompareExchange<JniMethodInfo>(ref cachedMethod, instanceMethod, null);
			return cachedMethod;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001012B File Offset: 0x0000E32B
		public JniMethodInfo GetStaticMethod(string name, string signature)
		{
			this.AssertValid();
			return JniEnvironment.StaticMethods.GetStaticMethodID(this.PeerReference, name, signature);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00010140 File Offset: 0x0000E340
		public JniMethodInfo GetCachedStaticMethod(ref JniMethodInfo cachedMethod, string name, string signature)
		{
			this.AssertValid();
			if (cachedMethod != null && cachedMethod.IsValid)
			{
				return cachedMethod;
			}
			JniMethodInfo staticMethod = this.GetStaticMethod(name, signature);
			Interlocked.CompareExchange<JniMethodInfo>(ref cachedMethod, staticMethod, null);
			return cachedMethod;
		}

		// Token: 0x04000136 RID: 310
		private bool registered;

		// Token: 0x04000137 RID: 311
		private JniObjectReference peerReference;

		// Token: 0x04000138 RID: 312
		private JniNativeMethodRegistration[] methods;
	}
}
