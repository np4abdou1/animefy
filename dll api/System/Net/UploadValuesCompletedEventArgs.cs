using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadValuesCompleted" /> event.</summary>
	// Token: 0x02000146 RID: 326
	public class UploadValuesCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00033328 File Offset: 0x00031528
		internal UploadValuesCompletedEventArgs(byte[] result, Exception exception, bool cancelled, object userToken) : base(exception, cancelled, userToken)
		{
			this._result = result;
		}

		/// <summary>Gets the server reply to a data upload operation started by calling an <see cref="Overload:System.Net.WebClient.UploadValuesAsync" /> method.</summary>
		/// <returns>A <see cref="T:System.Byte" /> array containing the server reply.</returns>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0003333B File Offset: 0x0003153B
		public byte[] Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return this._result;
			}
		}

		// Token: 0x0400067F RID: 1663
		private readonly byte[] _result;
	}
}
