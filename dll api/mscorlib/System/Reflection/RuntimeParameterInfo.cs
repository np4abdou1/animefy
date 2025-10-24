using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection
{
	// Token: 0x020004DF RID: 1247
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_ParameterInfo))]
	[ClassInterface(ClassInterfaceType.None)]
	[Serializable]
	internal class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x060023D2 RID: 9170 RVA: 0x0008E286 File Offset: 0x0008C486
		internal RuntimeParameterInfo(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			this.NameImpl = name;
			this.ClassImpl = type;
			this.PositionImpl = position;
			this.AttrsImpl = (ParameterAttributes)attrs;
			this.DefaultValueImpl = defaultValue;
			this.MemberImpl = member;
			this.marshalAs = marshalAs;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0008E2C4 File Offset: 0x0008C4C4
		internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization)
		{
			for (int i = 0; i < p.Length; i++)
			{
				if (i > 0)
				{
					sb.Append(", ");
				}
				Type parameterType = p[i].ParameterType;
				string text = parameterType.FormatTypeName(serialization);
				if (parameterType.IsByRef && !serialization)
				{
					sb.Append(text.TrimEnd(new char[]
					{
						'&'
					}));
					sb.Append(" ByRef");
				}
				else
				{
					sb.Append(text);
				}
			}
			if ((callingConvention & CallingConventions.VarArgs) != (CallingConventions)0)
			{
				if (p.Length != 0)
				{
					sb.Append(", ");
				}
				sb.Append("...");
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0008E358 File Offset: 0x0008C558
		internal RuntimeParameterInfo(ParameterBuilder pb, Type type, MemberInfo member, int position)
		{
			this.ClassImpl = type;
			this.MemberImpl = member;
			if (pb != null)
			{
				this.NameImpl = pb.Name;
				this.PositionImpl = pb.Position - 1;
				this.AttrsImpl = (ParameterAttributes)pb.Attributes;
				return;
			}
			this.NameImpl = null;
			this.PositionImpl = position - 1;
			this.AttrsImpl = ParameterAttributes.None;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0008E3BB File Offset: 0x0008C5BB
		internal static ParameterInfo New(ParameterBuilder pb, Type type, MemberInfo member, int position)
		{
			return new RuntimeParameterInfo(pb, type, member, position);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0008E3C8 File Offset: 0x0008C5C8
		internal RuntimeParameterInfo(ParameterInfo pinfo, Type type, MemberInfo member, int position)
		{
			this.ClassImpl = type;
			this.MemberImpl = member;
			if (pinfo != null)
			{
				this.NameImpl = pinfo.Name;
				this.PositionImpl = pinfo.Position - 1;
				this.AttrsImpl = pinfo.Attributes;
				return;
			}
			this.NameImpl = null;
			this.PositionImpl = position - 1;
			this.AttrsImpl = ParameterAttributes.None;
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0008E42C File Offset: 0x0008C62C
		internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
		{
			this.ClassImpl = pinfo.ParameterType;
			this.MemberImpl = member;
			this.NameImpl = pinfo.Name;
			this.PositionImpl = pinfo.Position;
			this.AttrsImpl = pinfo.Attributes;
			this.DefaultValueImpl = this.GetDefaultValueImpl(pinfo);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0008E483 File Offset: 0x0008C683
		internal RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			this.ClassImpl = type;
			this.MemberImpl = member;
			this.NameImpl = null;
			this.PositionImpl = -1;
			this.AttrsImpl = ParameterAttributes.Retval;
			this.marshalAs = marshalAs;
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0008E4B8 File Offset: 0x0008C6B8
		public override object DefaultValue
		{
			get
			{
				if (this.ClassImpl == typeof(decimal) || this.ClassImpl == typeof(decimal?))
				{
					DecimalConstantAttribute[] array = (DecimalConstantAttribute[])this.GetCustomAttributes(typeof(DecimalConstantAttribute), false);
					if (array.Length != 0)
					{
						return array[0].Value;
					}
				}
				else if (this.ClassImpl == typeof(DateTime) || this.ClassImpl == typeof(DateTime?))
				{
					DateTimeConstantAttribute[] array2 = (DateTimeConstantAttribute[])this.GetCustomAttributes(typeof(DateTimeConstantAttribute), false);
					if (array2.Length != 0)
					{
						return array2[0].Value;
					}
				}
				return this.DefaultValueImpl;
			}
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0008E574 File Offset: 0x0008C774
		public override object[] GetCustomAttributes(bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, false);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0008E57D File Offset: 0x0008C77D
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.GetCustomAttributes(this, attributeType, false);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0008E587 File Offset: 0x0008C787
		internal object GetDefaultValueImpl(ParameterInfo pinfo)
		{
			return typeof(ParameterInfo).GetField("DefaultValueImpl", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(pinfo);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00032332 File Offset: 0x00030532
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0008E5A8 File Offset: 0x0008C7A8
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			if (base.IsIn)
			{
				num++;
			}
			if (base.IsOut)
			{
				num++;
			}
			if (base.IsOptional)
			{
				num++;
			}
			if (this.marshalAs != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if (base.IsIn)
			{
				array[num++] = new InAttribute();
			}
			if (base.IsOut)
			{
				array[num++] = new OutAttribute();
			}
			if (base.IsOptional)
			{
				array[num++] = new OptionalAttribute();
			}
			if (this.marshalAs != null)
			{
				array[num++] = this.marshalAs.Copy();
			}
			return array;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0008E64C File Offset: 0x0008C84C
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			if (base.IsIn)
			{
				num++;
			}
			if (base.IsOut)
			{
				num++;
			}
			if (base.IsOptional)
			{
				num++;
			}
			if (this.marshalAs != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if (base.IsIn)
			{
				array[num++] = new CustomAttributeData(typeof(InAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (base.IsOut)
			{
				array[num++] = new CustomAttributeData(typeof(OutAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (base.IsOptional)
			{
				array[num++] = new CustomAttributeData(typeof(OptionalAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (this.marshalAs != null)
			{
				CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(UnmanagedType), this.marshalAs.Value)
				};
				array[num++] = new CustomAttributeData(typeof(MarshalAsAttribute).GetConstructor(new Type[]
				{
					typeof(UnmanagedType)
				}), ctorArgs, EmptyArray<CustomAttributeNamedArgument>.Value);
			}
			return array;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0008E77B File Offset: 0x0008C97B
		internal static ParameterInfo New(ParameterInfo pinfo, Type type, MemberInfo member, int position)
		{
			return new RuntimeParameterInfo(pinfo, type, member, position);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0008E786 File Offset: 0x0008C986
		internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			return new RuntimeParameterInfo(pinfo, member);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0008E78F File Offset: 0x0008C98F
		internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs)
		{
			return new RuntimeParameterInfo(type, member, marshalAs);
		}

		// Token: 0x04001145 RID: 4421
		internal MarshalAsAttribute marshalAs;
	}
}
