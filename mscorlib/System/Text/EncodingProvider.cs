using System;

namespace System.Text
{
	/// <summary>Provides the base class for an encoding provider, which supplies encodings that are unavailable on a particular platform. </summary>
	// Token: 0x0200025A RID: 602
	public abstract class EncodingProvider
	{
		/// <summary>Returns the encoding with the specified name. </summary>
		/// <param name="name">The name of the requested encoding. </param>
		/// <returns>The encoding that is associated with the specified name, or <see langword="null" /> if this <see cref="T:System.Text.EncodingProvider" /> cannot return a valid encoding that corresponds to <paramref name="name" />.</returns>
		// Token: 0x060014B5 RID: 5301
		public abstract Encoding GetEncoding(string name);

		/// <summary>Returns the encoding associated with the specified code page identifier. </summary>
		/// <param name="codepage">The code page identifier of the requested encoding. </param>
		/// <returns>The encoding that is associated with the specified code page, or <see langword="null" /> if this <see cref="T:System.Text.EncodingProvider" /> cannot return a valid encoding that corresponds to <paramref name="codepage" />. </returns>
		// Token: 0x060014B6 RID: 5302
		public abstract Encoding GetEncoding(int codepage);

		// Token: 0x060014B7 RID: 5303 RVA: 0x00051BA4 File Offset: 0x0004FDA4
		internal static Encoding GetEncodingFromProvider(int codepage)
		{
			if (EncodingProvider.s_providers == null)
			{
				return null;
			}
			EncodingProvider[] array = EncodingProvider.s_providers;
			for (int i = 0; i < array.Length; i++)
			{
				Encoding encoding = array[i].GetEncoding(codepage);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		internal static Encoding GetEncodingFromProvider(string encodingName)
		{
			if (EncodingProvider.s_providers == null)
			{
				return null;
			}
			EncodingProvider[] array = EncodingProvider.s_providers;
			for (int i = 0; i < array.Length; i++)
			{
				Encoding encoding = array[i].GetEncoding(encodingName);
				if (encoding != null)
				{
					return encoding;
				}
			}
			return null;
		}

		// Token: 0x0400083A RID: 2106
		private static object s_InternalSyncObject = new object();

		// Token: 0x0400083B RID: 2107
		private static volatile EncodingProvider[] s_providers;
	}
}
