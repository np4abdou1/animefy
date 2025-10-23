using System;
using System.IO;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Nio.Channels;

namespace Android.Runtime
{
	// Token: 0x020002CA RID: 714
	public class InputStreamInvoker : Stream
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x000466BF File Offset: 0x000448BF
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x000466C7 File Offset: 0x000448C7
		public InputStream BaseInputStream { get; private set; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x000466D0 File Offset: 0x000448D0
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x000466D8 File Offset: 0x000448D8
		private protected FileChannel BaseFileChannel { protected get; private set; }

		// Token: 0x06001B00 RID: 6912 RVA: 0x000466E4 File Offset: 0x000448E4
		public InputStreamInvoker(InputStream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.BaseInputStream = stream;
			FileInputStream fileInputStream = stream as FileInputStream;
			if (fileInputStream != null)
			{
				this.BaseFileChannel = fileInputStream.Channel;
			}
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00046724 File Offset: 0x00044924
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.BaseInputStream != null)
			{
				try
				{
					this.BaseFileChannel = null;
					this.BaseInputStream.Close();
					this.BaseInputStream.Dispose();
				}
				catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Dispose"))
				{
					throw new System.IO.IOException(ex.Message, ex);
				}
			}
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00046798 File Offset: 0x00044998
		public override void Close()
		{
			try
			{
				this.BaseInputStream.Close();
			}
			catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Close"))
			{
				throw new System.IO.IOException(ex.Message, ex);
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00025BC2 File Offset: 0x00023DC2
		public override void Flush()
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000467F0 File Offset: 0x000449F0
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num;
			try
			{
				num = this.BaseInputStream.Read(buffer, offset, count);
			}
			catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Read"))
			{
				throw new System.IO.IOException(ex.Message, ex);
			}
			if (num == -1)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00046850 File Offset: 0x00044A50
		public override long Seek(long offset, SeekOrigin origin)
		{
			if (this.BaseFileChannel == null)
			{
				throw new NotSupportedException();
			}
			switch (origin)
			{
			case SeekOrigin.Begin:
				this.BaseFileChannel.Position(offset);
				break;
			case SeekOrigin.Current:
				this.BaseFileChannel.Position(this.BaseFileChannel.Position() + offset);
				break;
			case SeekOrigin.End:
				this.BaseFileChannel.Position(this.BaseFileChannel.Size() + offset);
				break;
			}
			return this.BaseFileChannel.Position();
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000029D4 File Offset: 0x00000BD4
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000029D4 File Offset: 0x00000BD4
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x000468CD File Offset: 0x00044ACD
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x000468D0 File Offset: 0x00044AD0
		public override bool CanSeek
		{
			get
			{
				return this.BaseFileChannel != null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00045ABE File Offset: 0x00043CBE
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000468DB File Offset: 0x00044ADB
		public override long Length
		{
			get
			{
				if (this.BaseFileChannel != null)
				{
					return this.BaseFileChannel.Size();
				}
				throw new NotSupportedException();
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x000468F6 File Offset: 0x00044AF6
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x00046911 File Offset: 0x00044B11
		public override long Position
		{
			get
			{
				if (this.BaseFileChannel != null)
				{
					return this.BaseFileChannel.Position();
				}
				throw new NotSupportedException();
			}
			set
			{
				if (this.BaseFileChannel != null)
				{
					this.BaseFileChannel.Position(value);
					return;
				}
				throw new NotSupportedException();
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00046930 File Offset: 0x00044B30
		public static Stream FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = (IJavaObject)TypeManager.CreateInstance(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return new InputStreamInvoker((InputStream)javaObject);
		}
	}
}
