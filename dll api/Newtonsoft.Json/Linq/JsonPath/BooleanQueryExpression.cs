using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001A1 RID: 417
	[NullableContext(1)]
	[Nullable(0)]
	internal class BooleanQueryExpression : QueryExpression
	{
		// Token: 0x06000E60 RID: 3680 RVA: 0x0003FC1C File Offset: 0x0003DE1C
		public BooleanQueryExpression(QueryOperator @operator, object left, [Nullable(2)] object right) : base(@operator)
		{
			this.Left = left;
			this.Right = right;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0003FC34 File Offset: 0x0003DE34
		private IEnumerable<JToken> GetResult(JToken root, JToken t, [Nullable(2)] object o)
		{
			JToken jtoken = o as JToken;
			if (jtoken != null)
			{
				return new JToken[]
				{
					jtoken
				};
			}
			List<PathFilter> list = o as List<PathFilter>;
			if (list != null)
			{
				return JPath.Evaluate(list, root, t, null);
			}
			return CollectionUtils.ArrayEmpty<JToken>();
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0003FC70 File Offset: 0x0003DE70
		public override bool IsMatch(JToken root, JToken t, [Nullable(2)] JsonSelectSettings settings)
		{
			if (this.Operator == QueryOperator.Exists)
			{
				return this.GetResult(root, t, this.Left).Any<JToken>();
			}
			using (IEnumerator<JToken> enumerator = this.GetResult(root, t, this.Left).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					IEnumerable<JToken> result = this.GetResult(root, t, this.Right);
					ICollection<JToken> collection = (result as ICollection<JToken>) ?? result.ToList<JToken>();
					do
					{
						JToken leftResult = enumerator.Current;
						foreach (JToken rightResult in collection)
						{
							if (this.MatchTokens(leftResult, rightResult, settings))
							{
								return true;
							}
						}
					}
					while (enumerator.MoveNext());
				}
			}
			return false;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003FD4C File Offset: 0x0003DF4C
		private bool MatchTokens(JToken leftResult, JToken rightResult, [Nullable(2)] JsonSelectSettings settings)
		{
			JValue jvalue = leftResult as JValue;
			if (jvalue != null)
			{
				JValue jvalue2 = rightResult as JValue;
				if (jvalue2 != null)
				{
					switch (this.Operator)
					{
					case QueryOperator.Equals:
						if (BooleanQueryExpression.EqualsWithStringCoercion(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					case QueryOperator.NotEquals:
						if (!BooleanQueryExpression.EqualsWithStringCoercion(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					case QueryOperator.Exists:
						return true;
					case QueryOperator.LessThan:
						if (jvalue.CompareTo(jvalue2) < 0)
						{
							return true;
						}
						return false;
					case QueryOperator.LessThanOrEquals:
						if (jvalue.CompareTo(jvalue2) <= 0)
						{
							return true;
						}
						return false;
					case QueryOperator.GreaterThan:
						if (jvalue.CompareTo(jvalue2) > 0)
						{
							return true;
						}
						return false;
					case QueryOperator.GreaterThanOrEquals:
						if (jvalue.CompareTo(jvalue2) >= 0)
						{
							return true;
						}
						return false;
					case QueryOperator.And:
					case QueryOperator.Or:
						return false;
					case QueryOperator.RegexEquals:
						if (BooleanQueryExpression.RegexEquals(jvalue, jvalue2, settings))
						{
							return true;
						}
						return false;
					case QueryOperator.StrictEquals:
						if (BooleanQueryExpression.EqualsWithStrictMatch(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					case QueryOperator.StrictNotEquals:
						if (!BooleanQueryExpression.EqualsWithStrictMatch(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					default:
						return false;
					}
				}
			}
			QueryOperator @operator = this.Operator;
			if (@operator - QueryOperator.NotEquals <= 1)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0003FE30 File Offset: 0x0003E030
		private static bool RegexEquals(JValue input, JValue pattern, [Nullable(2)] JsonSelectSettings settings)
		{
			if (input.Type != JTokenType.String || pattern.Type != JTokenType.String)
			{
				return false;
			}
			string text = (string)pattern.Value;
			int num = text.LastIndexOf('/');
			string pattern2 = text.Substring(1, num - 1);
			string optionsText = text.Substring(num + 1);
			TimeSpan matchTimeout = ((settings != null) ? settings.RegexMatchTimeout : null) ?? Regex.InfiniteMatchTimeout;
			return Regex.IsMatch((string)input.Value, pattern2, MiscellaneousUtils.GetRegexOptions(optionsText), matchTimeout);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
		internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			if (value.Equals(queryValue))
			{
				return true;
			}
			if ((value.Type == JTokenType.Integer && queryValue.Type == JTokenType.Float) || (value.Type == JTokenType.Float && queryValue.Type == JTokenType.Integer))
			{
				return JValue.Compare(value.Type, value.Value, queryValue.Value) == 0;
			}
			if (queryValue.Type != JTokenType.String)
			{
				return false;
			}
			string b = (string)queryValue.Value;
			string a;
			switch (value.Type)
			{
			case JTokenType.Date:
				using (StringWriter stringWriter = StringUtils.CreateStringWriter(64))
				{
					object value2 = value.Value;
					if (value2 is DateTimeOffset)
					{
						DateTimeOffset value3 = (DateTimeOffset)value2;
						DateTimeUtils.WriteDateTimeOffsetString(stringWriter, value3, DateFormatHandling.IsoDateFormat, null, CultureInfo.InvariantCulture);
					}
					else
					{
						DateTimeUtils.WriteDateTimeString(stringWriter, (DateTime)value.Value, DateFormatHandling.IsoDateFormat, null, CultureInfo.InvariantCulture);
					}
					a = stringWriter.ToString();
					goto IL_122;
				}
				break;
			case JTokenType.Raw:
				return false;
			case JTokenType.Bytes:
				break;
			case JTokenType.Guid:
			case JTokenType.TimeSpan:
				a = value.Value.ToString();
				goto IL_122;
			case JTokenType.Uri:
				a = ((Uri)value.Value).OriginalString;
				goto IL_122;
			default:
				return false;
			}
			a = Convert.ToBase64String((byte[])value.Value);
			IL_122:
			return string.Equals(a, b, StringComparison.Ordinal);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00040008 File Offset: 0x0003E208
		internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue)
		{
			if ((value.Type == JTokenType.Integer && queryValue.Type == JTokenType.Float) || (value.Type == JTokenType.Float && queryValue.Type == JTokenType.Integer))
			{
				return JValue.Compare(value.Type, value.Value, queryValue.Value) == 0;
			}
			return value.Type == queryValue.Type && value.Equals(queryValue);
		}

		// Token: 0x040007BD RID: 1981
		public readonly object Left;

		// Token: 0x040007BE RID: 1982
		[Nullable(2)]
		public readonly object Right;
	}
}
