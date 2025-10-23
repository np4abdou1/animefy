using System;

namespace System.Diagnostics
{
	/// <summary>Identifies the level type for a switch. </summary>
	// Token: 0x020000BF RID: 191
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class SwitchLevelAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.SwitchLevelAttribute" /> class, specifying the type that determines whether a trace should be written.</summary>
		/// <param name="switchLevelType">The <see cref="T:System.Type" /> that determines whether a trace should be written.</param>
		// Token: 0x060005B3 RID: 1459 RVA: 0x0002400C File Offset: 0x0002220C
		public SwitchLevelAttribute(Type switchLevelType)
		{
			this.SwitchLevelType = switchLevelType;
		}

		/// <summary>Gets or sets the type that determines whether a trace should be written.</summary>
		/// <returns>The <see cref="T:System.Type" /> that determines whether a trace should be written.</returns>
		/// <exception cref="T:System.ArgumentNullException">The set operation failed because the value is <see langword="null" />.</exception>
		// Token: 0x170000BC RID: 188
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0002401B File Offset: 0x0002221B
		public Type SwitchLevelType
		{
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.type = value;
			}
		}

		// Token: 0x040003A4 RID: 932
		private Type type;
	}
}
