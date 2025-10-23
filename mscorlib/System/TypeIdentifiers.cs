using System;

namespace System
{
	// Token: 0x0200018A RID: 394
	internal class TypeIdentifiers
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x000400DC File Offset: 0x0003E2DC
		internal static TypeIdentifier FromDisplay(string displayName)
		{
			return new TypeIdentifiers.Display(displayName);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000400E4 File Offset: 0x0003E2E4
		internal static TypeIdentifier WithoutEscape(string simpleName)
		{
			return new TypeIdentifiers.NoEscape(simpleName);
		}

		// Token: 0x0200018B RID: 395
		private class Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
		{
			// Token: 0x06000F4B RID: 3915 RVA: 0x000400EC File Offset: 0x0003E2EC
			internal Display(string displayName)
			{
				this.displayName = displayName;
				this.internal_name = null;
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00040102 File Offset: 0x0003E302
			public override string DisplayName
			{
				get
				{
					return this.displayName;
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0004010A File Offset: 0x0003E30A
			public string InternalName
			{
				get
				{
					if (this.internal_name == null)
					{
						this.internal_name = this.GetInternalName();
					}
					return this.internal_name;
				}
			}

			// Token: 0x06000F4E RID: 3918 RVA: 0x00040126 File Offset: 0x0003E326
			private string GetInternalName()
			{
				return TypeSpec.UnescapeInternalName(this.displayName);
			}

			// Token: 0x040005C8 RID: 1480
			private string displayName;

			// Token: 0x040005C9 RID: 1481
			private string internal_name;
		}

		// Token: 0x0200018C RID: 396
		private class NoEscape : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
		{
			// Token: 0x06000F4F RID: 3919 RVA: 0x00040133 File Offset: 0x0003E333
			internal NoEscape(string simpleName)
			{
				this.simpleName = simpleName;
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00040142 File Offset: 0x0003E342
			public override string DisplayName
			{
				get
				{
					return this.simpleName;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000F51 RID: 3921 RVA: 0x00040142 File Offset: 0x0003E342
			public string InternalName
			{
				get
				{
					return this.simpleName;
				}
			}

			// Token: 0x040005CA RID: 1482
			private string simpleName;
		}
	}
}
