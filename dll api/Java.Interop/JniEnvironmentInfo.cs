using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000065 RID: 101
	internal sealed class JniEnvironmentInfo : IDisposable
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000D716 File Offset: 0x0000B916
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000D71E File Offset: 0x0000B91E
		public int LocalReferenceCount { get; internal set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000D727 File Offset: 0x0000B927
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000D72F File Offset: 0x0000B92F
		public bool WithinNewObjectScope { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000D738 File Offset: 0x0000B938
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000D74A File Offset: 0x0000B94A
		public JniRuntime Runtime
		{
			get
			{
				JniRuntime jniRuntime = this.runtime;
				if (jniRuntime == null)
				{
					throw new NotSupportedException();
				}
				return jniRuntime;
			}
			private set
			{
				this.runtime = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000D753 File Offset: 0x0000B953
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000D75C File Offset: 0x0000B95C
		public IntPtr EnvironmentPointer
		{
			get
			{
				return this.environmentPointer;
			}
			set
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException("JniEnvironmentInfo");
				}
				if (this.environmentPointer == value)
				{
					return;
				}
				this.environmentPointer = value;
				IntPtr zero = IntPtr.Zero;
				int javaVM = JniEnvironment.References.GetJavaVM(this.EnvironmentPointer, out zero);
				if (javaVM < 0)
				{
					throw new InvalidOperationException("JNIEnv::GetJavaVM() returned: " + javaVM.ToString());
				}
				JniRuntime registeredRuntime = JniRuntime.GetRegisteredRuntime(zero);
				if (registeredRuntime == null)
				{
					throw new NotSupportedException(string.Format("No JavaVM registered with handle 0x{0}.", zero.ToString("x")));
				}
				this.Runtime = registeredRuntime;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		public bool IsValid
		{
			get
			{
				return this.Runtime != null && this.environmentPointer != IntPtr.Zero;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000D80C File Offset: 0x0000BA0C
		public JniEnvironmentInfo()
		{
			this.Runtime = JniRuntime.CurrentRuntime;
			this.EnvironmentPointer = this.Runtime._AttachCurrentThread(null, default(JniObjectReference));
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000D845 File Offset: 0x0000BA45
		internal JniEnvironmentInfo(IntPtr environmentPointer, JniRuntime runtime)
		{
			this.EnvironmentPointer = environmentPointer;
			this.Runtime = runtime;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000D85C File Offset: 0x0000BA5C
		internal unsafe JniObjectReference ToJavaName(string jniTypeName)
		{
			if (jniTypeName.IndexOf("/", StringComparison.Ordinal) == -1)
			{
				return JniEnvironment.Strings.NewString(jniTypeName);
			}
			int length = jniTypeName.Length;
			if (length > 512)
			{
				return JniEnvironment.Strings.NewString(jniTypeName.Replace('/', '.'));
			}
			if (this.nameBuffer == null)
			{
				this.nameBuffer = new char[512];
			}
			char* ptr = jniTypeName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			char[] array;
			char* ptr2;
			if ((array = this.nameBuffer) == null || array.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &array[0];
			}
			char* ptr3 = ptr;
			char* ptr4 = ptr2;
			char* ptr5 = ptr + length;
			while (ptr3 < ptr5)
			{
				*ptr4 = ((*ptr3 == '/') ? '.' : (*ptr3));
				ptr3++;
				ptr4++;
			}
			return JniEnvironment.Strings.NewString(ptr2, length);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000D920 File Offset: 0x0000BB20
		public void Dispose()
		{
			if (this.disposed)
			{
				return;
			}
			this.runtime = null;
			this.environmentPointer = IntPtr.Zero;
			this.nameBuffer = null;
			this.LocalReferenceCount = 0;
			this.disposed = true;
		}

		// Token: 0x040000E3 RID: 227
		private IntPtr environmentPointer;

		// Token: 0x040000E4 RID: 228
		private char[] nameBuffer;

		// Token: 0x040000E5 RID: 229
		private bool disposed;

		// Token: 0x040000E6 RID: 230
		private JniRuntime runtime;
	}
}
