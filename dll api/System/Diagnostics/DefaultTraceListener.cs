using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	/// <summary>Provides the default output methods and behavior for tracing.</summary>
	// Token: 0x020000D2 RID: 210
	public class DefaultTraceListener : TraceListener
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x00025104 File Offset: 0x00023304
		static DefaultTraceListener()
		{
			if (!DefaultTraceListener.OnWin32)
			{
				string text = Environment.GetEnvironmentVariable("MONO_TRACE_LISTENER");
				if (text == null)
				{
					text = "Console.Out";
				}
				if (text != null)
				{
					string monoTraceFile;
					string monoTracePrefix;
					if (text.StartsWith("Console.Out"))
					{
						monoTraceFile = "Console.Out";
						monoTracePrefix = DefaultTraceListener.GetPrefix(text, "Console.Out");
					}
					else if (text.StartsWith("Console.Error"))
					{
						monoTraceFile = "Console.Error";
						monoTracePrefix = DefaultTraceListener.GetPrefix(text, "Console.Error");
					}
					else
					{
						monoTraceFile = text;
						monoTracePrefix = "";
					}
					DefaultTraceListener.MonoTraceFile = monoTraceFile;
					DefaultTraceListener.MonoTracePrefix = monoTracePrefix;
				}
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00025197 File Offset: 0x00023397
		private static string GetPrefix(string var, string target)
		{
			if (var.Length > target.Length)
			{
				return var.Substring(target.Length + 1);
			}
			return "";
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DefaultTraceListener" /> class with "Default" as its <see cref="P:System.Diagnostics.TraceListener.Name" /> property value.</summary>
		// Token: 0x0600060A RID: 1546 RVA: 0x000251BB File Offset: 0x000233BB
		public DefaultTraceListener() : base("Default")
		{
		}

		/// <summary>Gets or sets the name of a log file to write trace or debug messages to.</summary>
		/// <returns>The name of a log file to write trace or debug messages to.</returns>
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x000251C8 File Offset: 0x000233C8
		public string LogFileName
		{
			get
			{
				return this.logFileName;
			}
		}

		// Token: 0x0600060C RID: 1548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void WriteWindowsDebugString(char* message);

		// Token: 0x0600060D RID: 1549 RVA: 0x000251D0 File Offset: 0x000233D0
		private unsafe void WriteDebugString(string message)
		{
			if (DefaultTraceListener.OnWin32)
			{
				fixed (string text = message)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					DefaultTraceListener.WriteWindowsDebugString(ptr);
				}
				return;
			}
			this.WriteMonoTrace(message);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00025204 File Offset: 0x00023404
		private void WriteMonoTrace(string message)
		{
			string monoTraceFile = DefaultTraceListener.MonoTraceFile;
			if (monoTraceFile == "Console.Out")
			{
				Console.Out.Write(message);
				return;
			}
			if (!(monoTraceFile == "Console.Error"))
			{
				this.WriteLogFile(message, DefaultTraceListener.MonoTraceFile);
				return;
			}
			Console.Error.Write(message);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00025257 File Offset: 0x00023457
		private void WritePrefix()
		{
			if (!DefaultTraceListener.OnWin32)
			{
				this.WriteMonoTrace(DefaultTraceListener.MonoTracePrefix);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0002526B File Offset: 0x0002346B
		private void WriteImpl(string message)
		{
			if (base.NeedIndent)
			{
				this.WriteIndent();
				this.WritePrefix();
			}
			if (Debugger.IsLogging())
			{
				Debugger.Log(0, null, message);
			}
			else
			{
				this.WriteDebugString(message);
			}
			this.WriteLogFile(message, this.LogFileName);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000252A8 File Offset: 0x000234A8
		private void WriteLogFile(string message, string logFile)
		{
			if (logFile != null && logFile.Length != 0)
			{
				FileInfo fileInfo = new FileInfo(logFile);
				StreamWriter streamWriter = null;
				try
				{
					if (fileInfo.Exists)
					{
						streamWriter = fileInfo.AppendText();
					}
					else
					{
						streamWriter = fileInfo.CreateText();
					}
				}
				catch
				{
					return;
				}
				using (streamWriter)
				{
					streamWriter.Write(message);
					streamWriter.Flush();
				}
			}
		}

		/// <summary>Writes the output to the <see langword="OutputDebugString" /> function and to the <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" /> method.</summary>
		/// <param name="message">The message to write to <see langword="OutputDebugString" /> and <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" />. </param>
		// Token: 0x06000612 RID: 1554 RVA: 0x00025320 File Offset: 0x00023520
		public override void Write(string message)
		{
			this.WriteImpl(message);
		}

		/// <summary>Writes the output to the <see langword="OutputDebugString" /> function and to the <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" /> method, followed by a carriage return and line feed (\r\n).</summary>
		/// <param name="message">The message to write to <see langword="OutputDebugString" /> and <see cref="M:System.Diagnostics.Debugger.Log(System.Int32,System.String,System.String)" />. </param>
		// Token: 0x06000613 RID: 1555 RVA: 0x0002532C File Offset: 0x0002352C
		public override void WriteLine(string message)
		{
			string message2 = message + Environment.NewLine;
			this.WriteImpl(message2);
			base.NeedIndent = true;
		}

		// Token: 0x04000407 RID: 1031
		private static readonly bool OnWin32 = Path.DirectorySeparatorChar == '\\';

		// Token: 0x04000408 RID: 1032
		private static readonly string MonoTracePrefix;

		// Token: 0x04000409 RID: 1033
		private static readonly string MonoTraceFile;

		// Token: 0x0400040A RID: 1034
		private string logFileName;
	}
}
