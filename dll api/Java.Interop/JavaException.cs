using System;

namespace Java.Interop
{
	// Token: 0x0200000B RID: 11
	[JniTypeSignature("java/lang/Throwable")]
	public class JavaException : Exception, IJavaPeerable, IDisposable
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000027AB File Offset: 0x000009AB
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000027B3 File Offset: 0x000009B3
		public string JavaStackTrace { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000027BC File Offset: 0x000009BC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000027C4 File Offset: 0x000009C4
		public int JniIdentityHashCode { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000027CD File Offset: 0x000009CD
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000027D5 File Offset: 0x000009D5
		public JniManagedPeerStates JniManagedPeerState { get; private set; }

		// Token: 0x0600005B RID: 91 RVA: 0x000027E0 File Offset: 0x000009E0
		public unsafe JavaException() : this(ref *JavaException.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			if (this.PeerReference.IsValid)
			{
				return;
			}
			JniObjectReference jniObjectReference = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", base.GetType(), null);
			this.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
			this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", this, null);
			this.JavaStackTrace = this.GetJavaStack(this.PeerReference);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000285C File Offset: 0x00000A5C
		public unsafe JavaException(string message) : base(message)
		{
			JniObjectReference value = JniEnvironment.Strings.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				JniObjectReference jniObjectReference = this.JniPeerMembers.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr);
				this.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
				this.JniPeerMembers.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JniObjectReference.Dispose(ref value, JniObjectReferenceOptions.CopyAndDispose);
			}
			this.JavaStackTrace = this.GetJavaStack(this.PeerReference);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000028FC File Offset: 0x00000AFC
		public JavaException(ref JniObjectReference reference, JniObjectReferenceOptions transfer) : base(JavaException.GetMessage(ref reference, transfer), JavaException.GetCause(ref reference, transfer))
		{
			this.Construct(ref reference, transfer);
			if (this.PeerReference.IsValid)
			{
				this.JavaStackTrace = this.GetJavaStack(this.PeerReference);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002947 File Offset: 0x00000B47
		protected void Construct(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			JniEnvironment.Runtime.ValueManager.ConstructPeer(this, ref reference, options);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000295C File Offset: 0x00000B5C
		~JavaException()
		{
			JniEnvironment.Runtime.ValueManager.FinalizePeer(this);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002994 File Offset: 0x00000B94
		public JniObjectReference PeerReference
		{
			get
			{
				return new JniObjectReference(this.handle, this.handle_type);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000029A7 File Offset: 0x00000BA7
		public virtual JniPeerMembers JniPeerMembers
		{
			get
			{
				return JavaException._members;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000029B0 File Offset: 0x00000BB0
		public override string StackTrace
		{
			get
			{
				return string.Concat(new string[]
				{
					base.StackTrace,
					Environment.NewLine,
					"  --- End of managed ",
					base.GetType().FullName,
					" stack trace ---",
					Environment.NewLine,
					this.JavaStackTrace
				});
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002A08 File Offset: 0x00000C08
		protected void SetPeerReference(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			if (options == JniObjectReferenceOptions.None)
			{
				((IJavaPeerable)this).SetPeerReference(default(JniObjectReference));
				return;
			}
			this.handle = reference.Handle;
			this.handle_type = reference.Type;
			JniObjectReference.Dispose(ref reference, options);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002A47 File Offset: 0x00000C47
		public void Dispose()
		{
			JniEnvironment.Runtime.ValueManager.DisposePeer(this);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002A59 File Offset: 0x00000C59
		public void DisposeUnlessReferenced()
		{
			JniEnvironment.Runtime.ValueManager.DisposePeerUnlessReferenced(this);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002A6C File Offset: 0x00000C6C
		protected virtual void Dispose(bool disposing)
		{
			JavaException ex = base.InnerException as JavaException;
			if (ex != null)
			{
				ex.Dispose();
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002A90 File Offset: 0x00000C90
		public override bool Equals(object obj)
		{
			JniPeerMembers.AssertSelf(this);
			if (obj == this)
			{
				return true;
			}
			IJavaPeerable javaPeerable = obj as IJavaPeerable;
			return javaPeerable != null && JniEnvironment.Types.IsSameObject(this.PeerReference, javaPeerable.PeerReference);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002AC6 File Offset: 0x00000CC6
		public override int GetHashCode()
		{
			return JavaException._members.InstanceMethods.InvokeVirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002AE0 File Offset: 0x00000CE0
		private static string GetMessage(ref JniObjectReference reference, JniObjectReferenceOptions transfer)
		{
			if (transfer == JniObjectReferenceOptions.None)
			{
				return null;
			}
			JniMethodInfo methodInfo = JavaException._members.InstanceMethods.GetMethodInfo("getMessage.()Ljava/lang/String;");
			JniObjectReference jniObjectReference = JniEnvironment.InstanceMethods.CallObjectMethod(reference, methodInfo);
			return JniEnvironment.Strings.ToString(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002B1C File Offset: 0x00000D1C
		private static Exception GetCause(ref JniObjectReference reference, JniObjectReferenceOptions transfer)
		{
			if (transfer == JniObjectReferenceOptions.None)
			{
				return null;
			}
			JniMethodInfo methodInfo = JavaException._members.InstanceMethods.GetMethodInfo("getCause.()Ljava/lang/Throwable;");
			JniObjectReference jniObjectReference = JniEnvironment.InstanceMethods.CallObjectMethod(reference, methodInfo);
			return JniEnvironment.Runtime.GetExceptionForThrowable(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002B60 File Offset: 0x00000D60
		private unsafe string GetJavaStack(JniObjectReference handle)
		{
			checked
			{
				string result;
				using (JniType jniType = new JniType("java/io/StringWriter"))
				{
					using (JniType jniType2 = new JniType("java/io/PrintWriter"))
					{
						JniMethodInfo constructor = jniType.GetConstructor("()V");
						JniMethodInfo constructor2 = jniType2.GetConstructor("(Ljava/io/Writer;)V");
						JniObjectReference value = jniType.NewObject(constructor, null);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue)];
							*ptr = new JniArgumentValue(value);
							JniObjectReference value2 = jniType2.NewObject(constructor2, ptr);
							try
							{
								JniMethodInfo methodInfo = JavaException._members.InstanceMethods.GetMethodInfo("printStackTrace.(Ljava/io/PrintWriter;)V");
								JniArgumentValue* ptr2 = stackalloc JniArgumentValue[unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue)];
								*ptr2 = new JniArgumentValue(value2);
								JniEnvironment.InstanceMethods.CallVoidMethod(handle, methodInfo, ptr2);
								JniObjectReference jniObjectReference = JniEnvironment.Object.ToString(value);
								result = JniEnvironment.Strings.ToString(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
							}
							finally
							{
								JniObjectReference.Dispose(ref value2, JniObjectReferenceOptions.CopyAndDispose);
							}
						}
						finally
						{
							JniObjectReference.Dispose(ref value, JniObjectReferenceOptions.CopyAndDispose);
						}
					}
				}
				return result;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C78 File Offset: 0x00000E78
		void IJavaPeerable.Disposed()
		{
			this.Dispose(true);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002C81 File Offset: 0x00000E81
		void IJavaPeerable.Finalized()
		{
			this.Dispose(false);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002C8A File Offset: 0x00000E8A
		void IJavaPeerable.SetJniIdentityHashCode(int value)
		{
			this.JniIdentityHashCode = value;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002C93 File Offset: 0x00000E93
		void IJavaPeerable.SetJniManagedPeerState(JniManagedPeerStates value)
		{
			this.JniManagedPeerState = value;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002C9C File Offset: 0x00000E9C
		void IJavaPeerable.SetPeerReference(JniObjectReference reference)
		{
			this.SetPeerReference(ref reference, JniObjectReferenceOptions.Copy);
		}

		// Token: 0x0400000C RID: 12
		private static readonly JniPeerMembers _members = new JniPeerMembers("java/lang/Throwable", typeof(JavaException));

		// Token: 0x04000010 RID: 16
		private IntPtr handle;

		// Token: 0x04000011 RID: 17
		private JniObjectReferenceType handle_type;

		// Token: 0x04000012 RID: 18
		private IntPtr weak_handle;

		// Token: 0x04000013 RID: 19
		private int refs_added;

		// Token: 0x04000014 RID: 20
		protected unsafe static readonly JniObjectReference* InvalidJniObjectReference = null;
	}
}
