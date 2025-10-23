using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x020001A5 RID: 421
	internal class XmlRegisteredNonCachedStream : Stream
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x000603FA File Offset: 0x0005E5FA
		internal XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host)
		{
			this.stream = stream;
			this.downloadManager = downloadManager;
			this.host = host;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00060418 File Offset: 0x0005E618
		~XmlRegisteredNonCachedStream()
		{
			if (this.downloadManager != null)
			{
				this.downloadManager.Remove(this.host);
			}
			this.stream = null;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00060460 File Offset: 0x0005E660
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.stream != null)
				{
					if (this.downloadManager != null)
					{
						this.downloadManager.Remove(this.host);
					}
					this.stream.Close();
				}
				this.stream = null;
				GC.SuppressFinalize(this);
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000604C4 File Offset: 0x0005E6C4
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.stream.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000604D8 File Offset: 0x0005E6D8
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.stream.BeginWrite(buffer, offset, count, callback, state);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000604EC File Offset: 0x0005E6EC
		public override int EndRead(IAsyncResult asyncResult)
		{
			return this.stream.EndRead(asyncResult);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000604FA File Offset: 0x0005E6FA
		public override void EndWrite(IAsyncResult asyncResult)
		{
			this.stream.EndWrite(asyncResult);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00060508 File Offset: 0x0005E708
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00060515 File Offset: 0x0005E715
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.stream.Read(buffer, offset, count);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00060525 File Offset: 0x0005E725
		public override int ReadByte()
		{
			return this.stream.ReadByte();
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00060532 File Offset: 0x0005E732
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.stream.Seek(offset, origin);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00060541 File Offset: 0x0005E741
		public override void SetLength(long value)
		{
			this.stream.SetLength(value);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0006054F File Offset: 0x0005E74F
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.stream.Write(buffer, offset, count);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0006055F File Offset: 0x0005E75F
		public override void WriteByte(byte value)
		{
			this.stream.WriteByte(value);
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0006056D File Offset: 0x0005E76D
		public override bool CanRead
		{
			get
			{
				return this.stream.CanRead;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0006057A File Offset: 0x0005E77A
		public override bool CanSeek
		{
			get
			{
				return this.stream.CanSeek;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00060587 File Offset: 0x0005E787
		public override bool CanWrite
		{
			get
			{
				return this.stream.CanWrite;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00060594 File Offset: 0x0005E794
		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000605A1 File Offset: 0x0005E7A1
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x000605AE File Offset: 0x0005E7AE
		public override long Position
		{
			get
			{
				return this.stream.Position;
			}
			set
			{
				this.stream.Position = value;
			}
		}

		// Token: 0x04000AB4 RID: 2740
		protected Stream stream;

		// Token: 0x04000AB5 RID: 2741
		private XmlDownloadManager downloadManager;

		// Token: 0x04000AB6 RID: 2742
		private string host;
	}
}
