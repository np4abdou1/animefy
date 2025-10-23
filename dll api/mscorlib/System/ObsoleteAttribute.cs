using System;

namespace System
{
	/// <summary>Marks the program elements that are no longer in use. This class cannot be inherited.</summary>
	// Token: 0x020000E4 RID: 228
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[Serializable]
	public sealed class ObsoleteAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ObsoleteAttribute" /> class with default properties.</summary>
		// Token: 0x060007AD RID: 1965 RVA: 0x00022EC9 File Offset: 0x000210C9
		public ObsoleteAttribute()
		{
			this._message = null;
			this._error = false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ObsoleteAttribute" /> class with a specified workaround message.</summary>
		/// <param name="message">The text string that describes alternative workarounds. </param>
		// Token: 0x060007AE RID: 1966 RVA: 0x00022EDF File Offset: 0x000210DF
		public ObsoleteAttribute(string message)
		{
			this._message = message;
			this._error = false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ObsoleteAttribute" /> class with a workaround message and a Boolean value indicating whether the obsolete element usage is considered an error.</summary>
		/// <param name="message">The text string that describes alternative workarounds. </param>
		/// <param name="error">
		///       <see langword="true" /> if the obsolete element usage generates a compiler error; <see langword="false" /> if it generates a compiler warning. </param>
		// Token: 0x060007AF RID: 1967 RVA: 0x00022EF5 File Offset: 0x000210F5
		public ObsoleteAttribute(string message, bool error)
		{
			this._message = message;
			this._error = error;
		}

		// Token: 0x04000346 RID: 838
		private string _message;

		// Token: 0x04000347 RID: 839
		private bool _error;
	}
}
