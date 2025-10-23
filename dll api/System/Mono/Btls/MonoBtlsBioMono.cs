using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000030 RID: 48
	internal class MonoBtlsBioMono : MonoBtlsBio
	{
		// Token: 0x06000104 RID: 260 RVA: 0x0000588C File Offset: 0x00003A8C
		public MonoBtlsBioMono(IMonoBtlsBioMono backend) : base(new MonoBtlsBio.BoringBioHandle(MonoBtlsBioMono.mono_btls_bio_mono_new()))
		{
			this.backend = backend;
			this.handle = GCHandle.Alloc(this);
			this.instance = GCHandle.ToIntPtr(this.handle);
			this.readFunc = new MonoBtlsBioMono.BioReadFunc(MonoBtlsBioMono.OnRead);
			this.writeFunc = new MonoBtlsBioMono.BioWriteFunc(MonoBtlsBioMono.OnWrite);
			this.controlFunc = new MonoBtlsBioMono.BioControlFunc(MonoBtlsBioMono.Control);
			this.readFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsBioMono.BioReadFunc>(this.readFunc);
			this.writeFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsBioMono.BioWriteFunc>(this.writeFunc);
			this.controlFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsBioMono.BioControlFunc>(this.controlFunc);
			MonoBtlsBioMono.mono_btls_bio_mono_initialize(base.Handle.DangerousGetHandle(), this.instance, this.readFuncPtr, this.writeFuncPtr, this.controlFuncPtr);
		}

		// Token: 0x06000105 RID: 261
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_bio_mono_new();

		// Token: 0x06000106 RID: 262
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc);

		// Token: 0x06000107 RID: 263 RVA: 0x0000595E File Offset: 0x00003B5E
		private long Control(MonoBtlsBioMono.ControlCommand command, long arg)
		{
			if (command == MonoBtlsBioMono.ControlCommand.Flush)
			{
				this.backend.Flush();
				return 1L;
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005978 File Offset: 0x00003B78
		private int OnRead(IntPtr data, int dataLength, out int wantMore)
		{
			byte[] array = new byte[dataLength];
			bool flag;
			int num = this.backend.Read(array, 0, dataLength, out flag);
			wantMore = (flag ? 1 : 0);
			if (num <= 0)
			{
				return num;
			}
			Marshal.Copy(array, 0, data, num);
			return num;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000059B8 File Offset: 0x00003BB8
		private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore)
		{
			MonoBtlsBioMono monoBtlsBioMono = (MonoBtlsBioMono)GCHandle.FromIntPtr(instance).Target;
			int result;
			try
			{
				result = monoBtlsBioMono.OnRead(data, dataLength, out wantMore);
			}
			catch (Exception exception)
			{
				monoBtlsBioMono.SetException(exception);
				wantMore = 0;
				result = -1;
			}
			return result;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00005A08 File Offset: 0x00003C08
		private int OnWrite(IntPtr data, int dataLength)
		{
			byte[] array = new byte[dataLength];
			Marshal.Copy(data, array, 0, dataLength);
			if (!this.backend.Write(array, 0, dataLength))
			{
				return -1;
			}
			return dataLength;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00005A38 File Offset: 0x00003C38
		private static int OnWrite(IntPtr instance, IntPtr data, int dataLength)
		{
			MonoBtlsBioMono monoBtlsBioMono = (MonoBtlsBioMono)GCHandle.FromIntPtr(instance).Target;
			int result;
			try
			{
				result = monoBtlsBioMono.OnWrite(data, dataLength);
			}
			catch (Exception exception)
			{
				monoBtlsBioMono.SetException(exception);
				result = -1;
			}
			return result;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005A84 File Offset: 0x00003C84
		private static long Control(IntPtr instance, MonoBtlsBioMono.ControlCommand command, long arg)
		{
			MonoBtlsBioMono monoBtlsBioMono = (MonoBtlsBioMono)GCHandle.FromIntPtr(instance).Target;
			long result;
			try
			{
				result = monoBtlsBioMono.Control(command, arg);
			}
			catch (Exception exception)
			{
				monoBtlsBioMono.SetException(exception);
				result = -1L;
			}
			return result;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005AD0 File Offset: 0x00003CD0
		protected override void Close()
		{
			try
			{
				if (this.backend != null)
				{
					this.backend.Close();
					this.backend = null;
				}
				if (this.handle.IsAllocated)
				{
					this.handle.Free();
				}
			}
			finally
			{
				base.Close();
			}
		}

		// Token: 0x040000A1 RID: 161
		private GCHandle handle;

		// Token: 0x040000A2 RID: 162
		private IntPtr instance;

		// Token: 0x040000A3 RID: 163
		private MonoBtlsBioMono.BioReadFunc readFunc;

		// Token: 0x040000A4 RID: 164
		private MonoBtlsBioMono.BioWriteFunc writeFunc;

		// Token: 0x040000A5 RID: 165
		private MonoBtlsBioMono.BioControlFunc controlFunc;

		// Token: 0x040000A6 RID: 166
		private IntPtr readFuncPtr;

		// Token: 0x040000A7 RID: 167
		private IntPtr writeFuncPtr;

		// Token: 0x040000A8 RID: 168
		private IntPtr controlFuncPtr;

		// Token: 0x040000A9 RID: 169
		private IMonoBtlsBioMono backend;

		// Token: 0x02000031 RID: 49
		private enum ControlCommand
		{
			// Token: 0x040000AB RID: 171
			Flush = 1
		}

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600010F RID: 271
		private delegate int BioReadFunc(IntPtr bio, IntPtr data, int dataLength, out int wantMore);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000113 RID: 275
		private delegate int BioWriteFunc(IntPtr bio, IntPtr data, int dataLength);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000117 RID: 279
		private delegate long BioControlFunc(IntPtr bio, MonoBtlsBioMono.ControlCommand command, long arg);
	}
}
