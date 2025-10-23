using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000178 RID: 376
	[NullableContext(1)]
	[Nullable(0)]
	public class JPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x0003809E File Offset: 0x0003629E
		public JPropertyDescriptor(string name) : base(name, null)
		{
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000380A8 File Offset: 0x000362A8
		private static JObject CastInstance(object instance)
		{
			return (JObject)instance;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00016B42 File Offset: 0x00014D42
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000380B0 File Offset: 0x000362B0
		[NullableContext(2)]
		public override object GetValue(object component)
		{
			JObject jobject = component as JObject;
			if (jobject == null)
			{
				return null;
			}
			return jobject[this.Name];
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000153AD File Offset: 0x000135AD
		public override void ResetValue(object component)
		{
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000380CC File Offset: 0x000362CC
		[NullableContext(2)]
		public override void SetValue(object component, object value)
		{
			JObject jobject = component as JObject;
			if (jobject != null)
			{
				JToken value2 = (value as JToken) ?? new JValue(value);
				jobject[this.Name] = value2;
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00016B42 File Offset: 0x00014D42
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00038101 File Offset: 0x00036301
		public override Type ComponentType
		{
			get
			{
				return typeof(JObject);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00016B42 File Offset: 0x00014D42
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0003810D File Offset: 0x0003630D
		public override Type PropertyType
		{
			get
			{
				return typeof(object);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00038119 File Offset: 0x00036319
		protected override int NameHashCode
		{
			get
			{
				return base.NameHashCode;
			}
		}
	}
}
