using System;
using System.ComponentModel;

namespace System.Diagnostics
{
	/// <summary>Specifies a description for a property or event.</summary>
	// Token: 0x020000D3 RID: 211
	[AttributeUsage(AttributeTargets.All)]
	public class MonitoringDescriptionAttribute : DescriptionAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.MonitoringDescriptionAttribute" /> class, using the specified description.</summary>
		/// <param name="description">The application-defined description text. </param>
		// Token: 0x06000614 RID: 1556 RVA: 0x00015CC5 File Offset: 0x00013EC5
		public MonitoringDescriptionAttribute(string description) : base(description)
		{
		}

		/// <summary>Gets description text associated with the item monitored.</summary>
		/// <returns>An application-defined description.</returns>
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00025353 File Offset: 0x00023553
		public override string Description
		{
			get
			{
				return base.Description;
			}
		}
	}
}
