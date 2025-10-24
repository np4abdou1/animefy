using System;
using System.IO;
using System.Text;

namespace System
{
	/// <summary>Represents the standard input, output, and error streams for console applications. This class cannot be inherited.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200016B RID: 363
	public static class Console
	{
		// Token: 0x06000E7C RID: 3708 RVA: 0x0003D284 File Offset: 0x0003B484
		static Console()
		{
			int num = 0;
			EncodingHelper.InternalCodePage(ref num);
			if (num != -1 && ((num & 268435455) == 3 || (num & 268435456) != 0))
			{
				Console.inputEncoding = (Console.outputEncoding = EncodingHelper.UTF8Unmarked);
			}
			else
			{
				Console.inputEncoding = (Console.outputEncoding = Encoding.Default);
			}
			Console.SetupStreams(Console.inputEncoding, Console.outputEncoding);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0003D2F0 File Offset: 0x0003B4F0
		private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
		{
			Console.stdin = TextReader.Synchronized(new UnexceptionalStreamReader(Console.OpenStandardInput(0), inputEncoding));
			Console.stdout = TextWriter.Synchronized(new UnexceptionalStreamWriter(Console.OpenStandardOutput(0), outputEncoding)
			{
				AutoFlush = true
			});
			Console.stderr = TextWriter.Synchronized(new UnexceptionalStreamWriter(Console.OpenStandardError(0), outputEncoding)
			{
				AutoFlush = true
			});
			if (LogcatTextWriter.IsRunningOnAndroid())
			{
				Console.stdout = TextWriter.Synchronized(new LogcatTextWriter("mono-stdout", Console.stdout));
				Console.stderr = TextWriter.Synchronized(new LogcatTextWriter("mono-stderr", Console.stderr));
			}
			GC.SuppressFinalize(Console.stdout);
			GC.SuppressFinalize(Console.stderr);
			GC.SuppressFinalize(Console.stdin);
		}

		/// <summary>Gets the standard error output stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard error output stream.</returns>
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0003D3A4 File Offset: 0x0003B5A4
		public static TextWriter Error
		{
			get
			{
				return Console.stderr;
			}
		}

		/// <summary>Gets the standard output stream.</summary>
		/// <returns>A <see cref="T:System.IO.TextWriter" /> that represents the standard output stream.</returns>
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0003D3AB File Offset: 0x0003B5AB
		public static TextWriter Out
		{
			get
			{
				return Console.stdout;
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0003D3B4 File Offset: 0x0003B5B4
		private static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
		{
			Stream result;
			try
			{
				FileStream fileStream = new FileStream(handle, access, false, bufferSize, false, true);
				GC.SuppressFinalize(fileStream);
				result = fileStream;
			}
			catch (IOException)
			{
				result = Stream.Null;
			}
			return result;
		}

		/// <summary>Acquires the standard error stream, which is set to a specified buffer size.</summary>
		/// <param name="bufferSize">The internal stream buffer size. </param>
		/// <returns>The standard error stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		// Token: 0x06000E81 RID: 3713 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
		public static Stream OpenStandardError(int bufferSize)
		{
			return Console.Open(MonoIO.ConsoleError, FileAccess.Write, bufferSize);
		}

		/// <summary>Acquires the standard input stream, which is set to a specified buffer size.</summary>
		/// <param name="bufferSize">The internal stream buffer size. </param>
		/// <returns>The standard input stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		// Token: 0x06000E82 RID: 3714 RVA: 0x0003D3FE File Offset: 0x0003B5FE
		public static Stream OpenStandardInput(int bufferSize)
		{
			return Console.Open(MonoIO.ConsoleInput, FileAccess.Read, bufferSize);
		}

		/// <summary>Acquires the standard output stream, which is set to a specified buffer size.</summary>
		/// <param name="bufferSize">The internal stream buffer size. </param>
		/// <returns>The standard output stream.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="bufferSize" /> is less than or equal to zero. </exception>
		// Token: 0x06000E83 RID: 3715 RVA: 0x0003D40C File Offset: 0x0003B60C
		public static Stream OpenStandardOutput(int bufferSize)
		{
			return Console.Open(MonoIO.ConsoleOutput, FileAccess.Write, bufferSize);
		}

		/// <summary>Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">An object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		// Token: 0x06000E84 RID: 3716 RVA: 0x0003D41A File Offset: 0x0003B61A
		public static void WriteLine(string format, object arg0)
		{
			Console.stdout.WriteLine(format, arg0);
		}

		/// <summary>Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.</summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to write using <paramref name="format" />. </param>
		/// <param name="arg1">The second object to write using <paramref name="format" />. </param>
		/// <param name="arg2">The third object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		// Token: 0x06000E85 RID: 3717 RVA: 0x0003D428 File Offset: 0x0003B628
		public static void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			Console.stdout.WriteLine(format, arg0, arg1, arg2);
		}

		// Token: 0x04000576 RID: 1398
		internal static TextWriter stdout;

		// Token: 0x04000577 RID: 1399
		private static TextWriter stderr;

		// Token: 0x04000578 RID: 1400
		private static TextReader stdin;

		// Token: 0x04000579 RID: 1401
		private static Encoding inputEncoding;

		// Token: 0x0400057A RID: 1402
		private static Encoding outputEncoding;

		// Token: 0x0400057B RID: 1403
		private static ConsoleColor s_trackedForegroundColor = (ConsoleColor)(-1);

		// Token: 0x0400057C RID: 1404
		private static ConsoleColor s_trackedBackgroundColor = (ConsoleColor)(-1);
	}
}
