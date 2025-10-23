﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace System
{
	// Token: 0x02000190 RID: 400
	internal class TypeSpec
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x0004022D File Offset: 0x0003E42D
		internal bool HasModifiers
		{
			get
			{
				return this.modifier_spec != null;
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00040238 File Offset: 0x0003E438
		private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			bool flag = (flags & TypeSpec.DisplayNameFormat.WANT_ASSEMBLY) > TypeSpec.DisplayNameFormat.Default;
			bool flag2 = (flags & TypeSpec.DisplayNameFormat.NO_MODIFIERS) == TypeSpec.DisplayNameFormat.Default;
			StringBuilder stringBuilder = new StringBuilder(this.name.DisplayName);
			if (this.nested != null)
			{
				foreach (TypeIdentifier typeIdentifier in this.nested)
				{
					stringBuilder.Append('+').Append(typeIdentifier.DisplayName);
				}
			}
			if (this.generic_params != null)
			{
				stringBuilder.Append('[');
				for (int i = 0; i < this.generic_params.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(", ");
					}
					if (this.generic_params[i].assembly_name != null)
					{
						stringBuilder.Append('[').Append(this.generic_params[i].DisplayFullName).Append(']');
					}
					else
					{
						stringBuilder.Append(this.generic_params[i].DisplayFullName);
					}
				}
				stringBuilder.Append(']');
			}
			if (flag2)
			{
				this.GetModifierString(stringBuilder);
			}
			if (this.assembly_name != null && flag)
			{
				stringBuilder.Append(", ").Append(this.assembly_name);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00040394 File Offset: 0x0003E594
		private StringBuilder GetModifierString(StringBuilder sb)
		{
			if (this.modifier_spec != null)
			{
				foreach (ModifierSpec modifierSpec in this.modifier_spec)
				{
					modifierSpec.Append(sb);
				}
			}
			if (this.is_byref)
			{
				sb.Append('&');
			}
			return sb;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00040400 File Offset: 0x0003E600
		internal string DisplayFullName
		{
			get
			{
				if (this.display_fullname == null)
				{
					this.display_fullname = this.GetDisplayFullName(TypeSpec.DisplayNameFormat.Default);
				}
				return this.display_fullname;
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00040420 File Offset: 0x0003E620
		internal static TypeSpec Parse(string typeName)
		{
			int num = 0;
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			TypeSpec result = TypeSpec.Parse(typeName, ref num, false, true);
			if (num < typeName.Length)
			{
				throw new ArgumentException("Count not parse the whole type name", "typeName");
			}
			return result;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00040460 File Offset: 0x0003E660
		internal static string UnescapeInternalName(string displayName)
		{
			StringBuilder stringBuilder = new StringBuilder(displayName.Length);
			for (int i = 0; i < displayName.Length; i++)
			{
				char c = displayName[i];
				if (c == '\\' && ++i < displayName.Length)
				{
					c = displayName[i];
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000404BC File Offset: 0x0003E6BC
		internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			Assembly assembly = null;
			if (assemblyResolver == null && typeResolver == null)
			{
				return RuntimeType.GetType(this.DisplayFullName, throwOnError, ignoreCase, false, ref stackMark);
			}
			if (this.assembly_name != null)
			{
				if (assemblyResolver != null)
				{
					assembly = assemblyResolver(new AssemblyName(this.assembly_name));
				}
				else
				{
					assembly = Assembly.Load(this.assembly_name);
				}
				if (assembly == null)
				{
					if (throwOnError)
					{
						throw new FileNotFoundException("Could not resolve assembly '" + this.assembly_name + "'");
					}
					return null;
				}
			}
			Type type = null;
			if (typeResolver != null)
			{
				type = typeResolver(assembly, this.name.DisplayName, ignoreCase);
			}
			else
			{
				type = assembly.GetType(this.name.DisplayName, false, ignoreCase);
			}
			if (!(type == null))
			{
				if (this.nested != null)
				{
					foreach (TypeIdentifier typeIdentifier in this.nested)
					{
						Type nestedType = type.GetNestedType(typeIdentifier.DisplayName, BindingFlags.Public | BindingFlags.NonPublic);
						if (nestedType == null)
						{
							if (throwOnError)
							{
								string str = "Could not resolve type '";
								TypeIdentifier typeIdentifier2 = typeIdentifier;
								throw new TypeLoadException(str + ((typeIdentifier2 != null) ? typeIdentifier2.ToString() : null) + "'");
							}
							return null;
						}
						else
						{
							type = nestedType;
						}
					}
				}
				if (this.generic_params != null)
				{
					Type[] array = new Type[this.generic_params.Count];
					int i = 0;
					while (i < array.Length)
					{
						Type type2 = this.generic_params[i].Resolve(assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackMark);
						if (type2 == null)
						{
							if (throwOnError)
							{
								string str2 = "Could not resolve type '";
								TypeIdentifier typeIdentifier3 = this.generic_params[i].name;
								throw new TypeLoadException(str2 + ((typeIdentifier3 != null) ? typeIdentifier3.ToString() : null) + "'");
							}
							return null;
						}
						else
						{
							array[i] = type2;
							i++;
						}
					}
					type = type.MakeGenericType(array);
				}
				if (this.modifier_spec != null)
				{
					foreach (ModifierSpec modifierSpec in this.modifier_spec)
					{
						type = modifierSpec.Resolve(type);
					}
				}
				if (this.is_byref)
				{
					type = type.MakeByRefType();
				}
				return type;
			}
			if (throwOnError)
			{
				string str3 = "Could not resolve type '";
				TypeIdentifier typeIdentifier4 = this.name;
				throw new TypeLoadException(str3 + ((typeIdentifier4 != null) ? typeIdentifier4.ToString() : null) + "'");
			}
			return null;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00040728 File Offset: 0x0003E928
		private void AddName(string type_name)
		{
			if (this.name == null)
			{
				this.name = TypeSpec.ParsedTypeIdentifier(type_name);
				return;
			}
			if (this.nested == null)
			{
				this.nested = new List<TypeIdentifier>();
			}
			this.nested.Add(TypeSpec.ParsedTypeIdentifier(type_name));
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00040763 File Offset: 0x0003E963
		private void AddModifier(ModifierSpec md)
		{
			if (this.modifier_spec == null)
			{
				this.modifier_spec = new List<ModifierSpec>();
			}
			this.modifier_spec.Add(md);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00040784 File Offset: 0x0003E984
		private static void SkipSpace(string name, ref int pos)
		{
			int num = pos;
			while (num < name.Length && char.IsWhiteSpace(name[num]))
			{
				num++;
			}
			pos = num;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000407B4 File Offset: 0x0003E9B4
		private static void BoundCheck(int idx, string s)
		{
			if (idx >= s.Length)
			{
				throw new ArgumentException("Invalid generic arguments spec", "typeName");
			}
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000407CF File Offset: 0x0003E9CF
		private static TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			return TypeIdentifiers.FromDisplay(displayName);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000407D8 File Offset: 0x0003E9D8
		private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			int i = p;
			bool flag = false;
			TypeSpec typeSpec = new TypeSpec();
			TypeSpec.SkipSpace(name, ref i);
			int num = i;
			while (i < name.Length)
			{
				char c = name[i];
				switch (c)
				{
				case '&':
				case '*':
					goto IL_98;
				case '\'':
				case '(':
				case ')':
					break;
				case '+':
					typeSpec.AddName(name.Substring(num, i - num));
					num = i + 1;
					break;
				case ',':
					goto IL_77;
				default:
					switch (c)
					{
					case '[':
						goto IL_98;
					case '\\':
						i++;
						break;
					case ']':
						goto IL_77;
					}
					break;
				}
				IL_D6:
				if (!flag)
				{
					i++;
					continue;
				}
				break;
				IL_77:
				typeSpec.AddName(name.Substring(num, i - num));
				num = i + 1;
				flag = true;
				if (is_recurse && !allow_aqn)
				{
					p = i;
					return typeSpec;
				}
				goto IL_D6;
				IL_98:
				if (name[i] != '[' && is_recurse)
				{
					throw new ArgumentException("Generic argument can't be byref or pointer type", "typeName");
				}
				typeSpec.AddName(name.Substring(num, i - num));
				num = i + 1;
				flag = true;
				goto IL_D6;
			}
			if (num < i)
			{
				typeSpec.AddName(name.Substring(num, i - num));
			}
			else if (num == i)
			{
				typeSpec.AddName(string.Empty);
			}
			if (flag)
			{
				while (i < name.Length)
				{
					char c = name[i];
					if (c <= '*')
					{
						if (c != '&')
						{
							if (c != '*')
							{
								goto IL_4BE;
							}
							if (typeSpec.is_byref)
							{
								throw new ArgumentException("Can't have a pointer to a byref type", "typeName");
							}
							int num2 = 1;
							while (i + 1 < name.Length && name[i + 1] == '*')
							{
								i++;
								num2++;
							}
							typeSpec.AddModifier(new PointerSpec(num2));
						}
						else
						{
							if (typeSpec.is_byref)
							{
								throw new ArgumentException("Can't have a byref of a byref", "typeName");
							}
							typeSpec.is_byref = true;
						}
					}
					else if (c != ',')
					{
						if (c != '[')
						{
							if (c != ']')
							{
								goto IL_4BE;
							}
							if (is_recurse)
							{
								p = i;
								return typeSpec;
							}
							throw new ArgumentException("Unmatched ']'", "typeName");
						}
						else
						{
							if (typeSpec.is_byref)
							{
								throw new ArgumentException("Byref qualifier must be the last one of a type", "typeName");
							}
							i++;
							if (i >= name.Length)
							{
								throw new ArgumentException("Invalid array/generic spec", "typeName");
							}
							TypeSpec.SkipSpace(name, ref i);
							if (name[i] != ',' && name[i] != '*' && name[i] != ']')
							{
								List<TypeSpec> list = new List<TypeSpec>();
								if (typeSpec.HasModifiers)
								{
									throw new ArgumentException("generic args after array spec or pointer type", "typeName");
								}
								while (i < name.Length)
								{
									TypeSpec.SkipSpace(name, ref i);
									bool flag2 = name[i] == '[';
									if (flag2)
									{
										i++;
									}
									list.Add(TypeSpec.Parse(name, ref i, true, flag2));
									TypeSpec.BoundCheck(i, name);
									if (flag2)
									{
										if (name[i] != ']')
										{
											throw new ArgumentException("Unclosed assembly-qualified type name at " + name[i].ToString(), "typeName");
										}
										i++;
										TypeSpec.BoundCheck(i, name);
									}
									if (name[i] == ']')
									{
										break;
									}
									if (name[i] != ',')
									{
										throw new ArgumentException("Invalid generic arguments separator " + name[i].ToString(), "typeName");
									}
									i++;
								}
								if (i >= name.Length || name[i] != ']')
								{
									throw new ArgumentException("Error parsing generic params spec", "typeName");
								}
								typeSpec.generic_params = list;
							}
							else
							{
								int num3 = 1;
								bool flag3 = false;
								while (i < name.Length && name[i] != ']')
								{
									if (name[i] == '*')
									{
										if (flag3)
										{
											throw new ArgumentException("Array spec cannot have 2 bound dimensions", "typeName");
										}
										flag3 = true;
									}
									else
									{
										if (name[i] != ',')
										{
											throw new ArgumentException("Invalid character in array spec " + name[i].ToString(), "typeName");
										}
										num3++;
									}
									i++;
									TypeSpec.SkipSpace(name, ref i);
								}
								if (i >= name.Length || name[i] != ']')
								{
									throw new ArgumentException("Error parsing array spec", "typeName");
								}
								if (num3 > 1 && flag3)
								{
									throw new ArgumentException("Invalid array spec, multi-dimensional array cannot be bound", "typeName");
								}
								typeSpec.AddModifier(new ArraySpec(num3, flag3));
							}
						}
					}
					else if (is_recurse && allow_aqn)
					{
						int num4 = i;
						while (num4 < name.Length && name[num4] != ']')
						{
							num4++;
						}
						if (num4 >= name.Length)
						{
							throw new ArgumentException("Unmatched ']' while parsing generic argument assembly name");
						}
						typeSpec.assembly_name = name.Substring(i + 1, num4 - i - 1).Trim();
						p = num4;
						return typeSpec;
					}
					else
					{
						if (is_recurse)
						{
							p = i;
							return typeSpec;
						}
						if (allow_aqn)
						{
							typeSpec.assembly_name = name.Substring(i + 1).Trim();
							i = name.Length;
						}
					}
					i++;
					continue;
					IL_4BE:
					throw new ArgumentException("Bad type def, can't handle '" + name[i].ToString() + "' at " + i.ToString(), "typeName");
				}
			}
			p = i;
			return typeSpec;
		}

		// Token: 0x040005CE RID: 1486
		private TypeIdentifier name;

		// Token: 0x040005CF RID: 1487
		private string assembly_name;

		// Token: 0x040005D0 RID: 1488
		private List<TypeIdentifier> nested;

		// Token: 0x040005D1 RID: 1489
		private List<TypeSpec> generic_params;

		// Token: 0x040005D2 RID: 1490
		private List<ModifierSpec> modifier_spec;

		// Token: 0x040005D3 RID: 1491
		private bool is_byref;

		// Token: 0x040005D4 RID: 1492
		private string display_fullname;

		// Token: 0x02000191 RID: 401
		[Flags]
		internal enum DisplayNameFormat
		{
			// Token: 0x040005D6 RID: 1494
			Default = 0,
			// Token: 0x040005D7 RID: 1495
			WANT_ASSEMBLY = 1,
			// Token: 0x040005D8 RID: 1496
			NO_MODIFIERS = 2
		}
	}
}
