using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.IO.Compression
{
	// Token: 0x0200022D RID: 557
	internal class DeflateStreamNative
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x0000222D File Offset: 0x0000042D
		private DeflateStreamNative()
		{
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0004CA28 File Offset: 0x0004AC28
		public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
			DeflateStreamNative deflateStreamNative = new DeflateStreamNative();
			deflateStreamNative.data = GCHandle.Alloc(deflateStreamNative);
			deflateStreamNative.feeder = ((mode == CompressionMode.Compress) ? new DeflateStreamNative.UnmanagedReadOrWrite(DeflateStreamNative.UnmanagedWrite) : new DeflateStreamNative.UnmanagedReadOrWrite(DeflateStreamNative.UnmanagedRead));
			deflateStreamNative.z_stream = DeflateStreamNative.CreateZStream(mode, gzip, deflateStreamNative.feeder, GCHandle.ToIntPtr(deflateStreamNative.data));
			if (deflateStreamNative.z_stream.IsInvalid)
			{
				deflateStreamNative.Dispose(true);
				return null;
			}
			deflateStreamNative.base_stream = compressedStream;
			return deflateStreamNative;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0004CAA8 File Offset: 0x0004ACA8
		~DeflateStreamNative()
		{
			this.Dispose(false);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
		public void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				GC.SuppressFinalize(this);
			}
			else
			{
				this.base_stream = Stream.Null;
			}
			this.io_buffer = null;
			if (this.z_stream != null && !this.z_stream.IsInvalid)
			{
				this.z_stream.Dispose();
			}
			GCHandle gchandle = this.data;
			if (this.data.IsAllocated)
			{
				this.data.Free();
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004CB50 File Offset: 0x0004AD50
		public void Flush()
		{
			int result = DeflateStreamNative.Flush(this.z_stream);
			this.CheckResult(result, "Flush");
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0004CB78 File Offset: 0x0004AD78
		public int ReadZStream(IntPtr buffer, int length)
		{
			int result = DeflateStreamNative.ReadZStream(this.z_stream, buffer, length);
			this.CheckResult(result, "ReadInternal");
			return result;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0004CBA0 File Offset: 0x0004ADA0
		public void WriteZStream(IntPtr buffer, int length)
		{
			int result = DeflateStreamNative.WriteZStream(this.z_stream, buffer, length);
			this.CheckResult(result, "WriteInternal");
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
		private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			DeflateStreamNative deflateStreamNative = GCHandle.FromIntPtr(data).Target as DeflateStreamNative;
			if (deflateStreamNative == null)
			{
				return -1;
			}
			return deflateStreamNative.UnmanagedRead(buffer, length);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		private int UnmanagedRead(IntPtr buffer, int length)
		{
			if (this.io_buffer == null)
			{
				this.io_buffer = new byte[4096];
			}
			int count = Math.Min(length, this.io_buffer.Length);
			int num;
			try
			{
				num = this.base_stream.Read(this.io_buffer, 0, count);
			}
			catch (Exception ex)
			{
				this.last_error = ex;
				return -12;
			}
			if (num > 0)
			{
				Marshal.Copy(this.io_buffer, 0, buffer, num);
			}
			return num;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004CC74 File Offset: 0x0004AE74
		private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			DeflateStreamNative deflateStreamNative = GCHandle.FromIntPtr(data).Target as DeflateStreamNative;
			if (deflateStreamNative == null)
			{
				return -1;
			}
			return deflateStreamNative.UnmanagedWrite(buffer, length);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0004CCA4 File Offset: 0x0004AEA4
		private unsafe int UnmanagedWrite(IntPtr buffer, int length)
		{
			int num = 0;
			while (length > 0)
			{
				if (this.io_buffer == null)
				{
					this.io_buffer = new byte[4096];
				}
				int num2 = Math.Min(length, this.io_buffer.Length);
				Marshal.Copy(buffer, this.io_buffer, 0, num2);
				try
				{
					this.base_stream.Write(this.io_buffer, 0, num2);
				}
				catch (Exception ex)
				{
					this.last_error = ex;
					return -12;
				}
				buffer = new IntPtr((void*)((byte*)buffer.ToPointer() + num2));
				length -= num2;
				num += num2;
			}
			return num;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0004CD3C File Offset: 0x0004AF3C
		private void CheckResult(int result, string where)
		{
			if (result >= 0)
			{
				return;
			}
			Exception ex = Interlocked.Exchange<Exception>(ref this.last_error, null);
			if (ex != null)
			{
				throw ex;
			}
			string str;
			switch (result)
			{
			case -11:
				str = "IO error";
				goto IL_94;
			case -10:
				str = "Invalid argument(s)";
				goto IL_94;
			case -6:
				str = "Invalid version";
				goto IL_94;
			case -5:
				str = "Internal error (no progress possible)";
				goto IL_94;
			case -4:
				str = "Not enough memory";
				goto IL_94;
			case -3:
				str = "Corrupted data";
				goto IL_94;
			case -2:
				str = "Internal error";
				goto IL_94;
			case -1:
				str = "Unknown error";
				goto IL_94;
			}
			str = "Unknown error";
			IL_94:
			throw new IOException(str + " " + where);
		}

		// Token: 0x06000F4D RID: 3917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr CreateZStream(int compress, bool gzip, IntPtr feeder, IntPtr data);

		// Token: 0x06000F4E RID: 3918 RVA: 0x0004CDF0 File Offset: 0x0004AFF0
		private static DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data)
		{
			DeflateStreamNative.SafeDeflateStreamHandle result;
			try
			{
			}
			finally
			{
				result = new DeflateStreamNative.SafeDeflateStreamHandle(DeflateStreamNative.CreateZStream((int)compress, gzip, Marshal.GetFunctionPointerForDelegate<DeflateStreamNative.UnmanagedReadOrWrite>(feeder), data));
			}
			return result;
		}

		// Token: 0x06000F4F RID: 3919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int CloseZStream(IntPtr stream);

		// Token: 0x06000F50 RID: 3920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Flush(IntPtr stream);

		// Token: 0x06000F51 RID: 3921 RVA: 0x0004CE28 File Offset: 0x0004B028
		private static int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream)
		{
			bool flag = false;
			int result;
			try
			{
				stream.DangerousAddRef(ref flag);
				result = DeflateStreamNative.Flush(stream.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					stream.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06000F52 RID: 3922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int ReadZStream(IntPtr stream, IntPtr buffer, int length);

		// Token: 0x06000F53 RID: 3923 RVA: 0x0004CE68 File Offset: 0x0004B068
		private static int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			bool flag = false;
			int result;
			try
			{
				stream.DangerousAddRef(ref flag);
				result = DeflateStreamNative.ReadZStream(stream.DangerousGetHandle(), buffer, length);
			}
			finally
			{
				if (flag)
				{
					stream.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x06000F54 RID: 3924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int WriteZStream(IntPtr stream, IntPtr buffer, int length);

		// Token: 0x06000F55 RID: 3925 RVA: 0x0004CEAC File Offset: 0x0004B0AC
		private static int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			bool flag = false;
			int result;
			try
			{
				stream.DangerousAddRef(ref flag);
				result = DeflateStreamNative.WriteZStream(stream.DangerousGetHandle(), buffer, length);
			}
			finally
			{
				if (flag)
				{
					stream.DangerousRelease();
				}
			}
			return result;
		}

		// Token: 0x04000BF0 RID: 3056
		private DeflateStreamNative.UnmanagedReadOrWrite feeder;

		// Token: 0x04000BF1 RID: 3057
		private Stream base_stream;

		// Token: 0x04000BF2 RID: 3058
		private DeflateStreamNative.SafeDeflateStreamHandle z_stream;

		// Token: 0x04000BF3 RID: 3059
		private GCHandle data;

		// Token: 0x04000BF4 RID: 3060
		private bool disposed;

		// Token: 0x04000BF5 RID: 3061
		private byte[] io_buffer;

		// Token: 0x04000BF6 RID: 3062
		private Exception last_error;

		// Token: 0x0200022E RID: 558
		// (Invoke) Token: 0x06000F57 RID: 3927
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int UnmanagedReadOrWrite(IntPtr buffer, int length, IntPtr data);

		// Token: 0x0200022F RID: 559
		private sealed class SafeDeflateStreamHandle : SafeHandle
		{
			// Token: 0x17000311 RID: 785
			// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000067BE File Offset: 0x000049BE
			public override bool IsInvalid
			{
				get
				{
					return this.handle == IntPtr.Zero;
				}
			}

			// Token: 0x06000F5B RID: 3931 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
			internal SafeDeflateStreamHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x06000F5C RID: 3932 RVA: 0x0004CEFC File Offset: 0x0004B0FC
			protected override bool ReleaseHandle()
			{
				try
				{
					DeflateStreamNative.CloseZStream(this.handle);
				}
				catch
				{
				}
				return true;
			}
		}
	}
}
