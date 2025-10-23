using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Persists an 8-byte <see cref="T:System.DateTime" /> constant for a field or parameter.</summary>
	// Token: 0x02000441 RID: 1089
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		/// <summary>Gets the number of 100-nanosecond ticks that represent the date and time of this instance.</summary>
		/// <returns>The number of 100-nanosecond ticks that represent the date and time of this instance.</returns>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00087EAB File Offset: 0x000860AB
		public override object Value
		{
			get
			{
				return this._date;
			}
		}

		// Token: 0x04000F40 RID: 3904
		private DateTime _date;
	}
}
