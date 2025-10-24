using System;

namespace Java.Interop
{
	// Token: 0x02000087 RID: 135
	public struct JniTypeSignature : IEquatable<JniTypeSignature>
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00010177 File Offset: 0x0000E377
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0001017F File Offset: 0x0000E37F
		internal bool IsKeyword { readonly get; private set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00010188 File Offset: 0x0000E388
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00010190 File Offset: 0x0000E390
		public string SimpleReference { readonly get; private set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00010199 File Offset: 0x0000E399
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x000101A1 File Offset: 0x0000E3A1
		public int ArrayRank { readonly get; private set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000101AA File Offset: 0x0000E3AA
		public bool IsValid
		{
			get
			{
				return this.SimpleReference != null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public string QualifiedReference
		{
			get
			{
				string text;
				if (!this.IsKeyword)
				{
					text = "L" + this.SimpleReference + ";";
				}
				else if ((text = this.SimpleReference) == null)
				{
					throw new InvalidOperationException();
				}
				string text2 = text;
				if (this.ArrayRank != 0)
				{
					return new string('[', this.ArrayRank) + text2;
				}
				return text2;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00010212 File Offset: 0x0000E412
		public string Name
		{
			get
			{
				if (this.ArrayRank != 0)
				{
					return this.QualifiedReference;
				}
				string simpleReference = this.SimpleReference;
				if (simpleReference == null)
				{
					throw new InvalidOperationException();
				}
				return simpleReference;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00010234 File Offset: 0x0000E434
		public JniTypeSignature(string simpleReference, int arrayRank = 0, bool keyword = false)
		{
			if (simpleReference != null)
			{
				if (simpleReference.Length < 1)
				{
					throw new ArgumentException("The empty string is not a valid JNI simple reference.", "simpleReference");
				}
				if (simpleReference.IndexOf('.') >= 0)
				{
					throw new ArgumentException("JNI type names do not contain '.', they use '/'. Are you sure you're using a JNI type name?", "simpleReference");
				}
				if (simpleReference[0] == '[')
				{
					throw new ArgumentException("To specify an array, use the ArrayRank property.", "simpleReference");
				}
				if (simpleReference[0] == 'L' && simpleReference[simpleReference.Length - 1] == ';')
				{
					throw new ArgumentException("JNI type references are not supported.", "simpleReference");
				}
			}
			this.SimpleReference = simpleReference;
			this.ArrayRank = arrayRank;
			this.IsKeyword = keyword;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000102D5 File Offset: 0x0000E4D5
		public JniTypeSignature AddArrayRank(int rank)
		{
			if (this.SimpleReference == null)
			{
				throw new InvalidOperationException();
			}
			return new JniTypeSignature(this.SimpleReference, this.ArrayRank + rank, this.IsKeyword);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00010300 File Offset: 0x0000E500
		public JniTypeSignature GetPrimitivePeerTypeSignature()
		{
			if (!this.IsKeyword)
			{
				return this;
			}
			string simpleReference = this.SimpleReference;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(simpleReference);
			if (num <= 3339451269U)
			{
				if (num <= 3272340793U)
				{
					if (num != 3238785555U)
					{
						if (num == 3272340793U)
						{
							if (simpleReference == "F")
							{
								return new JniTypeSignature("java/lang/Float", this.ArrayRank, false);
							}
						}
					}
					else if (simpleReference == "D")
					{
						return new JniTypeSignature("java/lang/Double", this.ArrayRank, false);
					}
				}
				else if (num != 3322673650U)
				{
					if (num == 3339451269U)
					{
						if (simpleReference == "B")
						{
							return new JniTypeSignature("java/lang/Byte", this.ArrayRank, false);
						}
					}
				}
				else if (simpleReference == "C")
				{
					return new JniTypeSignature("java/lang/Character", this.ArrayRank, false);
				}
			}
			else if (num <= 3473672221U)
			{
				if (num != 3423339364U)
				{
					if (num == 3473672221U)
					{
						if (simpleReference == "J")
						{
							return new JniTypeSignature("java/lang/Long", this.ArrayRank, false);
						}
					}
				}
				else if (simpleReference == "I")
				{
					return new JniTypeSignature("java/lang/Integer", this.ArrayRank, false);
				}
			}
			else if (num != 3540782697U)
			{
				if (num != 3591115554U)
				{
					if (num == 3742114125U)
					{
						if (simpleReference == "Z")
						{
							return new JniTypeSignature("java/lang/Boolean", this.ArrayRank, false);
						}
					}
				}
				else if (simpleReference == "S")
				{
					return new JniTypeSignature("java/lang/Short", this.ArrayRank, false);
				}
			}
			else if (simpleReference == "V")
			{
				return new JniTypeSignature("java/lang/Void", this.ArrayRank, false);
			}
			throw new InvalidOperationException(string.Format("SimpleReference '{0}' isn't a known keyword reference, yet is a keyword.", this.SimpleReference));
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00010521 File Offset: 0x0000E721
		public static bool TryParse(string signature, out JniTypeSignature result)
		{
			return JniTypeSignature.TryParseWithException(signature, out result) == null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00010530 File Offset: 0x0000E730
		private static Exception TryParseWithException(string signature, out JniTypeSignature result)
		{
			result = default(JniTypeSignature);
			if (signature == null)
			{
				return new ArgumentNullException("signature");
			}
			if (signature.Length < 1)
			{
				return new ArgumentException("The empty string is not a valid JNI simple reference.", "signature");
			}
			int num = 0;
			int num2 = 0;
			bool keyword = false;
			while (num < signature.Length && signature[num] == '[')
			{
				num++;
				num2++;
			}
			char c = signature[num];
			string text;
			switch (c)
			{
			case 'B':
			case 'C':
			case 'D':
			case 'F':
			case 'I':
			case 'J':
				break;
			case 'E':
			case 'G':
			case 'H':
			case 'K':
				goto IL_17F;
			case 'L':
			{
				int num3 = signature.IndexOf(';', num);
				if (num3 >= num && num3 != signature.Length - 1)
				{
					return new ArgumentException(string.Format("Malformed JNI type reference: trailing text after ';' in '{0}'.", signature), "signature");
				}
				if (num == 0)
				{
					text = ((num3 > num) ? signature.Substring(num + 1, num3 - num - 1) : signature);
					goto IL_1A6;
				}
				if (num3 < num)
				{
					return new ArgumentException(string.Format("Malformed JNI type reference; no terminating ';' for type ref: '{0}'.", signature.Substring(num)), "signature");
				}
				if (num3 != signature.Length - 1)
				{
					return new ArgumentException(string.Format("Malformed jNI type reference: invalid trailing text: '{0}'.", signature.Substring(num)), "signature");
				}
				text = signature.Substring(num + 1, num3 - num - 1);
				goto IL_1A6;
			}
			default:
				if (c != 'S' && c != 'Z')
				{
					goto IL_17F;
				}
				break;
			}
			if (signature.Length - num > 1)
			{
				text = signature.Substring(num);
				goto IL_1A6;
			}
			text = signature[num].ToString();
			keyword = true;
			goto IL_1A6;
			IL_17F:
			if (num != 0)
			{
				return new ArgumentException(string.Format("Malformed JNI type reference: found unrecognized char '{0}' in '{1}'.", signature[num], signature), "signature");
			}
			text = signature;
			IL_1A6:
			int num4 = text.IndexOfAny(new char[]
			{
				'.',
				';'
			});
			if (num4 >= 0)
			{
				return new ArgumentException(string.Format("Malformed JNI type reference: contains '{0}': {1}", text[num4], signature), "signature");
			}
			result = new JniTypeSignature(text, num2, keyword);
			return null;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00010732 File Offset: 0x0000E932
		public override int GetHashCode()
		{
			return this.QualifiedReference.GetHashCode();
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00010740 File Offset: 0x0000E940
		public override bool Equals(object obj)
		{
			JniTypeSignature? jniTypeSignature = obj as JniTypeSignature?;
			return jniTypeSignature != null && this.Equals(jniTypeSignature.Value);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00010771 File Offset: 0x0000E971
		public bool Equals(JniTypeSignature other)
		{
			return this.IsKeyword == other.IsKeyword && this.SimpleReference == other.SimpleReference && this.ArrayRank == other.ArrayRank;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000107A7 File Offset: 0x0000E9A7
		public override string ToString()
		{
			return string.Format("JniTypeSignature(TypeName={0} ArrayRank={1} Keyword={2})", this.SimpleReference, this.ArrayRank, this.IsKeyword);
		}

		// Token: 0x04000139 RID: 313
		public static readonly JniTypeSignature Empty;
	}
}
