using System;
using System.Runtime.CompilerServices;
using System.Text;
using Mono;

namespace System.IO
{
	// Token: 0x0200055F RID: 1375
	internal class LogcatTextWriter : TextWriter
	{
		// Token: 0x06002910 RID: 10512 RVA: 0x000A3AD1 File Offset: 0x000A1CD1
		public LogcatTextWriter(string appname, TextWriter stdout)
		{
			this.appname = Encoding.UTF8.GetBytes(appname + "\0");
			this.stdout = stdout;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002911 RID: 10513 RVA: 0x000A3B06 File Offset: 0x000A1D06
		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000A3B10 File Offset: 0x000A1D10
		public override void Write(string s)
		{
			if (s != null)
			{
				foreach (char value in s)
				{
					this.Write(value);
				}
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000A3B42 File Offset: 0x000A1D42
		public override void Write(char value)
		{
			if (value == '\n')
			{
				this.WriteLine();
				return;
			}
			this.line.Append(value);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000A3B60 File Offset: 0x000A1D60
		public override void WriteLine()
		{
			string text = this.line.ToString();
			this.line.Clear();
			this.Log(text);
			this.stdout.WriteLine(text);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000A3B98 File Offset: 0x000A1D98
		private unsafe void Log(string message)
		{
			if (Encoding.UTF8.GetByteCount(message) < 512)
			{
				try
				{
					try
					{
						fixed (string text = message)
						{
							char* ptr = text;
							if (ptr != null)
							{
								ptr += RuntimeHelpers.OffsetToStringData / 2;
							}
							byte* ptr2 = stackalloc byte[(UIntPtr)512];
							int bytes = Encoding.UTF8.GetBytes(ptr, message.Length, ptr2, 511);
							ptr2[bytes] = 0;
							this.Log(ptr2);
						}
					}
					finally
					{
						string text = null;
					}
					return;
				}
				catch (ArgumentException)
				{
				}
			}
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(message))
			{
				this.Log((byte*)((void*)safeStringMarshal.Value));
			}
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000A3C50 File Offset: 0x000A1E50
		private unsafe void Log(byte* b_message)
		{
			byte[] array;
			byte* ptr;
			if ((array = this.appname) == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			LogcatTextWriter.Log(ptr, 32, b_message);
			array = null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000A3C85 File Offset: 0x000A1E85
		public static bool IsRunningOnAndroid()
		{
			return File.Exists("/system/lib/liblog.so") || File.Exists("/system/lib64/liblog.so");
		}

		// Token: 0x06002918 RID: 10520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Log(byte* appname, int level, byte* message);

		// Token: 0x04001558 RID: 5464
		private readonly byte[] appname;

		// Token: 0x04001559 RID: 5465
		private TextWriter stdout;

		// Token: 0x0400155A RID: 5466
		private StringBuilder line = new StringBuilder();
	}
}
