using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Represents a writer that can write a sequential series of characters. This class is abstract.</summary>
	// Token: 0x0200053C RID: 1340
	[Serializable]
	public abstract class TextWriter : MarshalByRefObject, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.TextWriter" /> class.</summary>
		// Token: 0x06002791 RID: 10129 RVA: 0x0009F2AD File Offset: 0x0009D4AD
		protected TextWriter()
		{
			this._internalFormatProvider = null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.TextWriter" /> class with the specified format provider.</summary>
		/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
		// Token: 0x06002792 RID: 10130 RVA: 0x0009F2D2 File Offset: 0x0009D4D2
		protected TextWriter(IFormatProvider formatProvider)
		{
			this._internalFormatProvider = formatProvider;
		}

		/// <summary>Gets an object that controls formatting.</summary>
		/// <returns>An <see cref="T:System.IFormatProvider" /> object for a specific culture, or the formatting of the current culture if no other culture is specified.</returns>
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x0009F2F7 File Offset: 0x0009D4F7
		public virtual IFormatProvider FormatProvider
		{
			get
			{
				if (this._internalFormatProvider == null)
				{
					return CultureInfo.CurrentCulture;
				}
				return this._internalFormatProvider;
			}
		}

		/// <summary>Closes the current writer and releases any system resources associated with the writer.</summary>
		// Token: 0x06002794 RID: 10132 RVA: 0x0009DA4B File Offset: 0x0009BC4B
		public virtual void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.TextWriter" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06002795 RID: 10133 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Releases all resources used by the <see cref="T:System.IO.TextWriter" /> object.</summary>
		// Token: 0x06002796 RID: 10134 RVA: 0x0009DA4B File Offset: 0x0009BC4B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Clears all buffers for the current writer and causes any buffered data to be written to the underlying device.</summary>
		// Token: 0x06002797 RID: 10135 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void Flush()
		{
		}

		/// <summary>When overridden in a derived class, returns the character encoding in which the output is written.</summary>
		/// <returns>The character encoding in which the output is written.</returns>
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002798 RID: 10136
		public abstract Encoding Encoding { get; }

		/// <summary>Gets or sets the line terminator string used by the current <see langword="TextWriter" />.</summary>
		/// <returns>The line terminator string for the current <see langword="TextWriter" />.</returns>
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x0009F30D File Offset: 0x0009D50D
		public virtual string NewLine
		{
			get
			{
				return this.CoreNewLineStr;
			}
		}

		/// <summary>Writes a character to the text string or stream.</summary>
		/// <param name="value">The character to write to the text stream. </param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600279A RID: 10138 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void Write(char value)
		{
		}

		/// <summary>Writes a character array to the text string or stream.</summary>
		/// <param name="buffer">The character array to write to the text stream. </param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600279B RID: 10139 RVA: 0x0009F315 File Offset: 0x0009D515
		public virtual void Write(char[] buffer)
		{
			if (buffer != null)
			{
				this.Write(buffer, 0, buffer.Length);
			}
		}

		/// <summary>Writes a subarray of characters to the text string or stream.</summary>
		/// <param name="buffer">The character array to write data from. </param>
		/// <param name="index">The character position in the buffer at which to start retrieving data. </param>
		/// <param name="count">The number of characters to write. </param>
		/// <exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index" /> is less than <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600279C RID: 10140 RVA: 0x0009F328 File Offset: 0x0009D528
		public virtual void Write(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Non-negative number required.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			for (int i = 0; i < count; i++)
			{
				this.Write(buffer[index + i]);
			}
		}

		/// <summary>Writes a string to the text string or stream.</summary>
		/// <param name="value">The string to write. </param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600279D RID: 10141 RVA: 0x0009F39A File Offset: 0x0009D59A
		public virtual void Write(string value)
		{
			if (value != null)
			{
				this.Write(value.ToCharArray());
			}
		}

		/// <summary>Writes a line terminator to the text string or stream.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600279E RID: 10142 RVA: 0x0009F3AB File Offset: 0x0009D5AB
		public virtual void WriteLine()
		{
			this.Write(this.CoreNewLine);
		}

		/// <summary>Writes a string followed by a line terminator to the text string or stream.</summary>
		/// <param name="value">The string to write. If <paramref name="value" /> is <see langword="null" />, only the line terminator is written. </param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		// Token: 0x0600279F RID: 10143 RVA: 0x0009F3B9 File Offset: 0x0009D5B9
		public virtual void WriteLine(string value)
		{
			if (value != null)
			{
				this.Write(value);
			}
			this.Write(this.CoreNewLineStr);
		}

		/// <summary>Writes a formatted string and a new line to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object)" /> method.</summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The object to format and write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is one). </exception>
		// Token: 0x060027A0 RID: 10144 RVA: 0x0009F3D1 File Offset: 0x0009D5D1
		public virtual void WriteLine(string format, object arg0)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0));
		}

		/// <summary>Writes a formatted string and a new line to the text string or stream, using the same semantics as the <see cref="M:System.String.Format(System.String,System.Object,System.Object)" /> method.</summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to format and write. </param>
		/// <param name="arg1">The second object to format and write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is two). </exception>
		// Token: 0x060027A1 RID: 10145 RVA: 0x0009F3E6 File Offset: 0x0009D5E6
		public virtual void WriteLine(string format, object arg0, object arg1)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0, arg1));
		}

		/// <summary>Writes out a formatted string and a new line, using the same semantics as <see cref="M:System.String.Format(System.String,System.Object)" />.</summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to format and write. </param>
		/// <param name="arg1">The second object to format and write. </param>
		/// <param name="arg2">The third object to format and write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="format" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.IO.TextWriter" /> is closed. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is not a valid composite format string.-or- The index of a format item is less than 0 (zero), or greater than or equal to the number of objects to be formatted (which, for this method overload, is three). </exception>
		// Token: 0x060027A2 RID: 10146 RVA: 0x0009F3FC File Offset: 0x0009D5FC
		public virtual void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			this.WriteLine(string.Format(this.FormatProvider, format, arg0, arg1, arg2));
		}

		/// <summary>Writes a character to the text string or stream asynchronously.</summary>
		/// <param name="value">The character to write to the text stream.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
		// Token: 0x060027A3 RID: 10147 RVA: 0x0009F414 File Offset: 0x0009D614
		public virtual Task WriteAsync(char value)
		{
			Tuple<TextWriter, char> state2 = new Tuple<TextWriter, char>(this, value);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, char> tuple = (Tuple<TextWriter, char>)state;
				tuple.Item1.Write(tuple.Item2);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Writes a string to the text string or stream asynchronously.</summary>
		/// <param name="value">The string to write. If <paramref name="value" /> is <see langword="null" />, nothing is written to the text stream.</param>
		/// <returns>A task that represents the asynchronous write operation. </returns>
		/// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
		// Token: 0x060027A4 RID: 10148 RVA: 0x0009F460 File Offset: 0x0009D660
		public virtual Task WriteAsync(string value)
		{
			Tuple<TextWriter, string> state2 = new Tuple<TextWriter, string>(this, value);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, string> tuple = (Tuple<TextWriter, string>)state;
				tuple.Item1.Write(tuple.Item2);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Writes a subarray of characters to the text string or stream asynchronously. </summary>
		/// <param name="buffer">The character array to write data from. </param>
		/// <param name="index">The character position in the buffer at which to start retrieving data. </param>
		/// <param name="count">The number of characters to write. </param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation. </exception>
		// Token: 0x060027A5 RID: 10149 RVA: 0x0009F4AC File Offset: 0x0009D6AC
		public virtual Task WriteAsync(char[] buffer, int index, int count)
		{
			Tuple<TextWriter, char[], int, int> state2 = new Tuple<TextWriter, char[], int, int>(this, buffer, index, count);
			return Task.Factory.StartNew(delegate(object state)
			{
				Tuple<TextWriter, char[], int, int> tuple = (Tuple<TextWriter, char[], int, int>)state;
				tuple.Item1.Write(tuple.Item2, tuple.Item3, tuple.Item4);
			}, state2, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Asynchronously clears all buffers for the current writer and causes any buffered data to be written to the underlying device. </summary>
		/// <returns>A task that represents the asynchronous flush operation. </returns>
		/// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The writer is currently in use by a previous write operation. </exception>
		// Token: 0x060027A6 RID: 10150 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
		public virtual Task FlushAsync()
		{
			return Task.Factory.StartNew(delegate(object state)
			{
				((TextWriter)state).Flush();
			}, this, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
		}

		/// <summary>Creates a thread-safe wrapper around the specified <see langword="TextWriter" />.</summary>
		/// <param name="writer">The <see langword="TextWriter" /> to synchronize. </param>
		/// <returns>A thread-safe wrapper.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="writer" /> is <see langword="null" />. </exception>
		// Token: 0x060027A7 RID: 10151 RVA: 0x0009F52F File Offset: 0x0009D72F
		public static TextWriter Synchronized(TextWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (!(writer is TextWriter.SyncTextWriter))
			{
				return new TextWriter.SyncTextWriter(writer);
			}
			return writer;
		}

		/// <summary>Provides a <see langword="TextWriter" /> with no backing store that can be written to, but not read from.</summary>
		// Token: 0x040014C0 RID: 5312
		public static readonly TextWriter Null = new TextWriter.NullTextWriter();

		// Token: 0x040014C1 RID: 5313
		private static readonly char[] s_coreNewLine = Environment.NewLine.ToCharArray();

		/// <summary>Stores the newline characters used for this <see langword="TextWriter" />.</summary>
		// Token: 0x040014C2 RID: 5314
		protected char[] CoreNewLine = TextWriter.s_coreNewLine;

		// Token: 0x040014C3 RID: 5315
		private string CoreNewLineStr = Environment.NewLine;

		// Token: 0x040014C4 RID: 5316
		private IFormatProvider _internalFormatProvider;

		// Token: 0x0200053D RID: 1341
		[Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			// Token: 0x060027A9 RID: 10153 RVA: 0x0009F56A File Offset: 0x0009D76A
			internal NullTextWriter() : base(CultureInfo.InvariantCulture)
			{
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x060027AA RID: 10154 RVA: 0x0009CFE9 File Offset: 0x0009B1E9
			public override Encoding Encoding
			{
				get
				{
					return Encoding.Unicode;
				}
			}

			// Token: 0x060027AB RID: 10155 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void Write(char[] buffer, int index, int count)
			{
			}

			// Token: 0x060027AC RID: 10156 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void Write(string value)
			{
			}

			// Token: 0x060027AD RID: 10157 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void WriteLine()
			{
			}

			// Token: 0x060027AE RID: 10158 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void WriteLine(string value)
			{
			}

			// Token: 0x060027AF RID: 10159 RVA: 0x00002A7D File Offset: 0x00000C7D
			public override void Write(char value)
			{
			}
		}

		// Token: 0x0200053E RID: 1342
		[Serializable]
		internal sealed class SyncTextWriter : TextWriter, IDisposable
		{
			// Token: 0x060027B0 RID: 10160 RVA: 0x0009F577 File Offset: 0x0009D777
			internal SyncTextWriter(TextWriter t) : base(t.FormatProvider)
			{
				this._out = t;
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x060027B1 RID: 10161 RVA: 0x0009F58C File Offset: 0x0009D78C
			public override Encoding Encoding
			{
				get
				{
					return this._out.Encoding;
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x060027B2 RID: 10162 RVA: 0x0009F599 File Offset: 0x0009D799
			public override IFormatProvider FormatProvider
			{
				get
				{
					return this._out.FormatProvider;
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x060027B3 RID: 10163 RVA: 0x0009F5A6 File Offset: 0x0009D7A6
			public override string NewLine
			{
				[MethodImpl(MethodImplOptions.Synchronized)]
				get
				{
					return this._out.NewLine;
				}
			}

			// Token: 0x060027B4 RID: 10164 RVA: 0x0009F5B3 File Offset: 0x0009D7B3
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Close()
			{
				this._out.Close();
			}

			// Token: 0x060027B5 RID: 10165 RVA: 0x0009F5C0 File Offset: 0x0009D7C0
			[MethodImpl(MethodImplOptions.Synchronized)]
			protected override void Dispose(bool disposing)
			{
				if (disposing)
				{
					((IDisposable)this._out).Dispose();
				}
			}

			// Token: 0x060027B6 RID: 10166 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Flush()
			{
				this._out.Flush();
			}

			// Token: 0x060027B7 RID: 10167 RVA: 0x0009F5DD File Offset: 0x0009D7DD
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char value)
			{
				this._out.Write(value);
			}

			// Token: 0x060027B8 RID: 10168 RVA: 0x0009F5EB File Offset: 0x0009D7EB
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer)
			{
				this._out.Write(buffer);
			}

			// Token: 0x060027B9 RID: 10169 RVA: 0x0009F5F9 File Offset: 0x0009D7F9
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(char[] buffer, int index, int count)
			{
				this._out.Write(buffer, index, count);
			}

			// Token: 0x060027BA RID: 10170 RVA: 0x0009F609 File Offset: 0x0009D809
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void Write(string value)
			{
				this._out.Write(value);
			}

			// Token: 0x060027BB RID: 10171 RVA: 0x0009F617 File Offset: 0x0009D817
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine()
			{
				this._out.WriteLine();
			}

			// Token: 0x060027BC RID: 10172 RVA: 0x0009F624 File Offset: 0x0009D824
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string value)
			{
				this._out.WriteLine(value);
			}

			// Token: 0x060027BD RID: 10173 RVA: 0x0009F632 File Offset: 0x0009D832
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, object arg0)
			{
				this._out.WriteLine(format, arg0);
			}

			// Token: 0x060027BE RID: 10174 RVA: 0x0009F641 File Offset: 0x0009D841
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, object arg0, object arg1)
			{
				this._out.WriteLine(format, arg0, arg1);
			}

			// Token: 0x060027BF RID: 10175 RVA: 0x0009F651 File Offset: 0x0009D851
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override void WriteLine(string format, object arg0, object arg1, object arg2)
			{
				this._out.WriteLine(format, arg0, arg1, arg2);
			}

			// Token: 0x060027C0 RID: 10176 RVA: 0x0009F663 File Offset: 0x0009D863
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(char value)
			{
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x060027C1 RID: 10177 RVA: 0x0009F671 File Offset: 0x0009D871
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(string value)
			{
				this.Write(value);
				return Task.CompletedTask;
			}

			// Token: 0x060027C2 RID: 10178 RVA: 0x0009F67F File Offset: 0x0009D87F
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task WriteAsync(char[] buffer, int index, int count)
			{
				this.Write(buffer, index, count);
				return Task.CompletedTask;
			}

			// Token: 0x060027C3 RID: 10179 RVA: 0x0009F68F File Offset: 0x0009D88F
			[MethodImpl(MethodImplOptions.Synchronized)]
			public override Task FlushAsync()
			{
				this.Flush();
				return Task.CompletedTask;
			}

			// Token: 0x040014C5 RID: 5317
			private readonly TextWriter _out;
		}
	}
}
