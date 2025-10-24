using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
	/// <summary>Implements a <see cref="T:System.IO.TextWriter" /> for writing information to a string. The information is stored in an underlying <see cref="T:System.Text.StringBuilder" />.</summary>
	// Token: 0x0200055A RID: 1370
	[ComVisible(true)]
	[Serializable]
	public class StringWriter : TextWriter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class.</summary>
		// Token: 0x060028C6 RID: 10438 RVA: 0x000A273B File Offset: 0x000A093B
		public StringWriter() : this(new StringBuilder(), CultureInfo.CurrentCulture)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class with the specified format control.</summary>
		/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
		// Token: 0x060028C7 RID: 10439 RVA: 0x000A274D File Offset: 0x000A094D
		public StringWriter(IFormatProvider formatProvider) : this(new StringBuilder(), formatProvider)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <param name="sb">The <see cref="T:System.Text.StringBuilder" /> object to write to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sb" /> is <see langword="null" />. </exception>
		// Token: 0x060028C8 RID: 10440 RVA: 0x000A275B File Offset: 0x000A095B
		public StringWriter(StringBuilder sb) : this(sb, CultureInfo.CurrentCulture)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.StringWriter" /> class that writes to the specified <see cref="T:System.Text.StringBuilder" /> and has the specified format provider.</summary>
		/// <param name="sb">The <see cref="T:System.Text.StringBuilder" /> object to write to. </param>
		/// <param name="formatProvider">An <see cref="T:System.IFormatProvider" /> object that controls formatting. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="sb" /> is <see langword="null" />. </exception>
		// Token: 0x060028C9 RID: 10441 RVA: 0x000A2769 File Offset: 0x000A0969
		public StringWriter(StringBuilder sb, IFormatProvider formatProvider) : base(formatProvider)
		{
			if (sb == null)
			{
				throw new ArgumentNullException("sb", Environment.GetResourceString("Buffer cannot be null."));
			}
			this._sb = sb;
			this._isOpen = true;
		}

		/// <summary>Closes the current <see cref="T:System.IO.StringWriter" /> and the underlying stream.</summary>
		// Token: 0x060028CA RID: 10442 RVA: 0x000A2798 File Offset: 0x000A0998
		public override void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.IO.StringWriter" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060028CB RID: 10443 RVA: 0x000A27A1 File Offset: 0x000A09A1
		protected override void Dispose(bool disposing)
		{
			this._isOpen = false;
			base.Dispose(disposing);
		}

		/// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary>
		/// <returns>The <see langword="Encoding" /> in which the output is written.</returns>
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000A27B1 File Offset: 0x000A09B1
		public override Encoding Encoding
		{
			get
			{
				if (StringWriter.m_encoding == null)
				{
					StringWriter.m_encoding = new UnicodeEncoding(false, false);
				}
				return StringWriter.m_encoding;
			}
		}

		/// <summary>Writes a character to the string.</summary>
		/// <param name="value">The character to write. </param>
		/// <exception cref="T:System.ObjectDisposedException">The writer is closed. </exception>
		// Token: 0x060028CD RID: 10445 RVA: 0x000A27D1 File Offset: 0x000A09D1
		public override void Write(char value)
		{
			if (!this._isOpen)
			{
				__Error.WriterClosed();
			}
			this._sb.Append(value);
		}

		/// <summary>Writes a subarray of characters to the string.</summary>
		/// <param name="buffer">The character array to write data from. </param>
		/// <param name="index">The position in the buffer at which to start reading data.</param>
		/// <param name="count">The maximum number of characters to write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative. </exception>
		/// <exception cref="T:System.ArgumentException">(<paramref name="index" /> + <paramref name="count" />)&gt; <paramref name="buffer" />. <see langword="Length" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The writer is closed. </exception>
		// Token: 0x060028CE RID: 10446 RVA: 0x000A27F0 File Offset: 0x000A09F0
		public override void Write(char[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", Environment.GetResourceString("Buffer cannot be null."));
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("Non-negative number required."));
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Non-negative number required."));
			}
			if (buffer.Length - index < count)
			{
				throw new ArgumentException(Environment.GetResourceString("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."));
			}
			if (!this._isOpen)
			{
				__Error.WriterClosed();
			}
			this._sb.Append(buffer, index, count);
		}

		/// <summary>Writes a string to the current string.</summary>
		/// <param name="value">The string to write. </param>
		/// <exception cref="T:System.ObjectDisposedException">The writer is closed. </exception>
		// Token: 0x060028CF RID: 10447 RVA: 0x000A287B File Offset: 0x000A0A7B
		public override void Write(string value)
		{
			if (!this._isOpen)
			{
				__Error.WriterClosed();
			}
			if (value != null)
			{
				this._sb.Append(value);
			}
		}

		/// <summary>Writes a character to the string asynchronously.</summary>
		/// <param name="value">The character to write to the string.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
		// Token: 0x060028D0 RID: 10448 RVA: 0x0009F663 File Offset: 0x0009D863
		[ComVisible(false)]
		public override Task WriteAsync(char value)
		{
			this.Write(value);
			return Task.CompletedTask;
		}

		/// <summary>Writes a string to the current string asynchronously.</summary>
		/// <param name="value">The string to write. If <paramref name="value" /> is <see langword="null" />, nothing is written to the text stream.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
		// Token: 0x060028D1 RID: 10449 RVA: 0x0009F671 File Offset: 0x0009D871
		[ComVisible(false)]
		public override Task WriteAsync(string value)
		{
			this.Write(value);
			return Task.CompletedTask;
		}

		/// <summary>Writes a subarray of characters to the string asynchronously.</summary>
		/// <param name="buffer">The character array to write data from.</param>
		/// <param name="index">The position in the buffer at which to start reading data.</param>
		/// <param name="count">The maximum number of characters to write.</param>
		/// <returns>A task that represents the asynchronous write operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> plus <paramref name="count" /> is greater than the buffer length.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> or <paramref name="count" /> is negative.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The string writer is disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The string writer is currently in use by a previous write operation. </exception>
		// Token: 0x060028D2 RID: 10450 RVA: 0x0009F67F File Offset: 0x0009D87F
		[ComVisible(false)]
		public override Task WriteAsync(char[] buffer, int index, int count)
		{
			this.Write(buffer, index, count);
			return Task.CompletedTask;
		}

		/// <summary>Asynchronously clears all buffers for the current writer and causes any buffered data to be written to the underlying device. </summary>
		/// <returns>A task that represents the asynchronous flush operation.</returns>
		// Token: 0x060028D3 RID: 10451 RVA: 0x0004A3A6 File Offset: 0x000485A6
		[ComVisible(false)]
		public override Task FlushAsync()
		{
			return Task.CompletedTask;
		}

		/// <summary>Returns a string containing the characters written to the current <see langword="StringWriter" /> so far.</summary>
		/// <returns>The string containing the characters written to the current <see langword="StringWriter" />.</returns>
		// Token: 0x060028D4 RID: 10452 RVA: 0x000A289A File Offset: 0x000A0A9A
		public override string ToString()
		{
			return this._sb.ToString();
		}

		// Token: 0x0400153B RID: 5435
		private static volatile UnicodeEncoding m_encoding;

		// Token: 0x0400153C RID: 5436
		private StringBuilder _sb;

		// Token: 0x0400153D RID: 5437
		private bool _isOpen;
	}
}
