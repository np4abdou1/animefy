using System;
using System.Collections.Generic;

namespace Java.Interop
{
	// Token: 0x0200006B RID: 107
	public struct JniNativeMethodRegistrationArguments
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0000DC37 File Offset: 0x0000BE37
		public JniNativeMethodRegistrationArguments(ICollection<JniNativeMethodRegistration> registrations, string methods)
		{
			if (registrations == null)
			{
				throw new ArgumentNullException("registrations");
			}
			this._registrations = registrations;
			this.<Methods>k__BackingField = methods;
		}

		// Token: 0x040000F5 RID: 245
		private ICollection<JniNativeMethodRegistration> _registrations;
	}
}
