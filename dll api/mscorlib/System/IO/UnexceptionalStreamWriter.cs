using System;
using System.Text;

namespace System.IO
{
	// Token: 0x02000567 RID: 1383
	internal class UnexceptionalStreamWriter : StreamWriter
	{
		// Token: 0x06002961 RID: 10593 RVA: 0x000A5490 File Offset: 0x000A3690
		public UnexceptionalStreamWriter(Stream stream, Encoding encoding) : base(stream, encoding, 1024, true)
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000A54A0 File Offset: 0x000A36A0
		public override void Flush()
		{
			try
			{
				base.Flush();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000A54C8 File Offset: 0x000A36C8
		public override void Write(char[] buffer, int index, int count)
		{
			try
			{
				base.Write(buffer, index, count);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000A54F4 File Offset: 0x000A36F4
		public override void Write(char value)
		{
			try
			{
				base.Write(value);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000A5520 File Offset: 0x000A3720
		public override void Write(char[] value)
		{
			try
			{
				base.Write(value);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000A554C File Offset: 0x000A374C
		public override void Write(string value)
		{
			try
			{
				base.Write(value);
			}
			catch (Exception)
			{
			}
		}
	}
}
