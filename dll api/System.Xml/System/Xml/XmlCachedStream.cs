using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x020001A6 RID: 422
	internal class XmlCachedStream : MemoryStream
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x000605BC File Offset: 0x0005E7BC
		internal XmlCachedStream(Uri uri, Stream stream)
		{
			this.uri = uri;
			try
			{
				byte[] buffer = new byte[4096];
				int count;
				while ((count = stream.Read(buffer, 0, 4096)) > 0)
				{
					this.Write(buffer, 0, count);
				}
				base.Position = 0L;
			}
			finally
			{
				stream.Close();
			}
		}

		// Token: 0x04000AB7 RID: 2743
		private Uri uri;
	}
}
