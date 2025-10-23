using System;

namespace System.Diagnostics
{
	/// <summary>Indicates to compilers that a method call or attribute should be ignored unless a specified conditional compilation symbol is defined.</summary>
	// Token: 0x020005B5 RID: 1461
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	[Serializable]
	public sealed class ConditionalAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.ConditionalAttribute" /> class.</summary>
		/// <param name="conditionString">A string that specifies the case-sensitive conditional compilation symbol that is associated with the attribute. </param>
		// Token: 0x06002C25 RID: 11301 RVA: 0x000B7480 File Offset: 0x000B5680
		public ConditionalAttribute(string conditionString)
		{
			this.<ConditionString>k__BackingField = conditionString;
		}
	}
}
