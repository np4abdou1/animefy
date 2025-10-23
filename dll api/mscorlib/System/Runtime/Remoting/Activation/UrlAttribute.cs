using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Defines an attribute that can be used at the call site to specify the URL where the activation will happen. This class cannot be inherited.</summary>
	// Token: 0x02000355 RID: 853
	[ComVisible(true)]
	[Serializable]
	public sealed class UrlAttribute : ContextAttribute
	{
		/// <summary>Gets the URL value of the <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</summary>
		/// <returns>The URL value of the <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000753C8 File Offset: 0x000735C8
		public string UrlValue
		{
			get
			{
				return this.url;
			}
		}

		// Token: 0x04000B4C RID: 2892
		private string url;
	}
}
