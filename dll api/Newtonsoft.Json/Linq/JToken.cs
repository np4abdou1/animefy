using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000180 RID: 384
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		// Token: 0x06000CAD RID: 3245 RVA: 0x00036E43 File Offset: 0x00035043
		public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0003883C File Offset: 0x00036A3C
		public Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, default(CancellationToken), converters);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0003885A File Offset: 0x00036A5A
		public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JToken.ReadFromAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00038864 File Offset: 0x00036A64
		public static Task<JToken> ReadFromAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			JToken.<ReadFromAsync>d__3 <ReadFromAsync>d__;
			<ReadFromAsync>d__.<>t__builder = AsyncTaskMethodBuilder<JToken>.Create();
			<ReadFromAsync>d__.reader = reader;
			<ReadFromAsync>d__.settings = settings;
			<ReadFromAsync>d__.cancellationToken = cancellationToken;
			<ReadFromAsync>d__.<>1__state = -1;
			<ReadFromAsync>d__.<>t__builder.Start<JToken.<ReadFromAsync>d__3>(ref <ReadFromAsync>d__);
			return <ReadFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000388B7 File Offset: 0x00036AB7
		public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JToken.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000388C1 File Offset: 0x00036AC1
		public static Task<JToken> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JToken.ReadFromAsync(reader, settings, cancellationToken);
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000388CB File Offset: 0x00036ACB
		public static JTokenEqualityComparer EqualityComparer
		{
			get
			{
				if (JToken._equalityComparer == null)
				{
					JToken._equalityComparer = new JTokenEqualityComparer();
				}
				return JToken._equalityComparer;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000388E3 File Offset: 0x00036AE3
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x000388EB File Offset: 0x00036AEB
		[Nullable(2)]
		public JContainer Parent
		{
			[NullableContext(2)]
			[DebuggerStepThrough]
			get
			{
				return this._parent;
			}
			[NullableContext(2)]
			internal set
			{
				this._parent = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000388F4 File Offset: 0x00036AF4
		public JToken Root
		{
			get
			{
				JContainer parent = this.Parent;
				if (parent == null)
				{
					return this;
				}
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				return parent;
			}
		}

		// Token: 0x06000CB7 RID: 3255
		internal abstract JToken CloneToken([Nullable(2)] JsonCloneSettings settings);

		// Token: 0x06000CB8 RID: 3256
		internal abstract bool DeepEquals(JToken node);

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000CB9 RID: 3257
		public abstract JTokenType Type { get; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000CBA RID: 3258
		public abstract bool HasValues { get; }

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003891D File Offset: 0x00036B1D
		[NullableContext(2)]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return t1 == t2 || (t1 != null && t2 != null && t1.DeepEquals(t2));
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00038934 File Offset: 0x00036B34
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0003893C File Offset: 0x00036B3C
		[Nullable(2)]
		public JToken Next
		{
			[NullableContext(2)]
			get
			{
				return this._next;
			}
			[NullableContext(2)]
			internal set
			{
				this._next = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00038945 File Offset: 0x00036B45
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x0003894D File Offset: 0x00036B4D
		[Nullable(2)]
		public JToken Previous
		{
			[NullableContext(2)]
			get
			{
				return this._previous;
			}
			[NullableContext(2)]
			internal set
			{
				this._previous = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00038958 File Offset: 0x00036B58
		public string Path
		{
			get
			{
				if (this.Parent == null)
				{
					return string.Empty;
				}
				List<JsonPosition> list = new List<JsonPosition>();
				JToken jtoken = null;
				for (JToken jtoken2 = this; jtoken2 != null; jtoken2 = jtoken2.Parent)
				{
					JTokenType type = jtoken2.Type;
					if (type - JTokenType.Array > 1)
					{
						if (type == JTokenType.Property)
						{
							JProperty jproperty = (JProperty)jtoken2;
							List<JsonPosition> list2 = list;
							JsonPosition item = new JsonPosition(JsonContainerType.Object)
							{
								PropertyName = jproperty.Name
							};
							list2.Add(item);
						}
					}
					else if (jtoken != null)
					{
						int position = ((IList<JToken>)jtoken2).IndexOf(jtoken);
						List<JsonPosition> list3 = list;
						JsonPosition item = new JsonPosition(JsonContainerType.Array)
						{
							Position = position
						};
						list3.Add(item);
					}
					jtoken = jtoken2;
				}
				list.FastReverse<JsonPosition>();
				return JsonPosition.BuildPath(list, null);
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002E5E File Offset: 0x0000105E
		internal JToken()
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00038A08 File Offset: 0x00036C08
		[NullableContext(2)]
		public void AddAfterSelf(object content)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int num = this._parent.IndexOfItem(this);
			this._parent.TryAddInternal(num + 1, content, false, true);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00038A48 File Offset: 0x00036C48
		[NullableContext(2)]
		public void AddBeforeSelf(object content)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int index = this._parent.IndexOfItem(this);
			this._parent.TryAddInternal(index, content, false, true);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00038A85 File Offset: 0x00036C85
		public IEnumerable<JToken> Ancestors()
		{
			return this.GetAncestors(false);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00038A8E File Offset: 0x00036C8E
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			return this.GetAncestors(true);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00038A97 File Offset: 0x00036C97
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			JToken current;
			for (current = (self ? this : this.Parent); current != null; current = current.Parent)
			{
				yield return current;
			}
			current = null;
			yield break;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00038AAE File Offset: 0x00036CAE
		public IEnumerable<JToken> AfterSelf()
		{
			if (this.Parent == null)
			{
				yield break;
			}
			JToken o;
			for (o = this.Next; o != null; o = o.Next)
			{
				yield return o;
			}
			o = null;
			yield break;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00038ABE File Offset: 0x00036CBE
		public IEnumerable<JToken> BeforeSelf()
		{
			if (this.Parent == null)
			{
				yield break;
			}
			JToken o = this.Parent.First;
			while (o != this && o != null)
			{
				yield return o;
				o = o.Next;
			}
			o = null;
			yield break;
		}

		// Token: 0x1700021C RID: 540
		[Nullable(2)]
		public virtual JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
			[param: Nullable(2)]
			set
			{
				throw new InvalidOperationException("Cannot set child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00038B08 File Offset: 0x00036D08
		[NullableContext(2)]
		public virtual T Value<T>([Nullable(1)] object key)
		{
			JToken jtoken = this[key];
			if (jtoken != null)
			{
				return jtoken.Convert<JToken, T>();
			}
			return default(T);
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00038ACE File Offset: 0x00036CCE
		[Nullable(2)]
		public virtual JToken First
		{
			[NullableContext(2)]
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00038ACE File Offset: 0x00036CCE
		[Nullable(2)]
		public virtual JToken Last
		{
			[NullableContext(2)]
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00038B30 File Offset: 0x00036D30
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual JEnumerable<JToken> Children()
		{
			return JEnumerable<JToken>.Empty;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00038B37 File Offset: 0x00036D37
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public JEnumerable<T> Children<T>() where T : JToken
		{
			return new JEnumerable<T>(this.Children().OfType<T>());
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00038ACE File Offset: 0x00036CCE
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual IEnumerable<T> Values<T>()
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00038B4E File Offset: 0x00036D4E
		public void Remove()
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this._parent.RemoveItem(this);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00038B70 File Offset: 0x00036D70
		public void Replace(JToken value)
		{
			if (this._parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this._parent.ReplaceItem(this, value);
		}

		// Token: 0x06000CD3 RID: 3283
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00038B92 File Offset: 0x00036D92
		public override string ToString()
		{
			return this.ToString(Formatting.Indented, Array.Empty<JsonConverter>());
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00038BA0 File Offset: 0x00036DA0
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				this.WriteTo(new JsonTextWriter(stringWriter)
				{
					Formatting = formatting
				}, converters);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00038BF4 File Offset: 0x00036DF4
		[return: Nullable(2)]
		private static JValue EnsureValue(JToken value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			JProperty jproperty = value as JProperty;
			if (jproperty != null)
			{
				value = jproperty.Value;
			}
			return value as JValue;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00038C28 File Offset: 0x00036E28
		private static string GetType(JToken token)
		{
			ValidationUtils.ArgumentNotNull(token, "token");
			JProperty jproperty = token as JProperty;
			if (jproperty != null)
			{
				token = jproperty.Value;
			}
			return token.Type.ToString();
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00038C66 File Offset: 0x00036E66
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable)
		{
			return Array.IndexOf<JTokenType>(validTypes, o.Type) != -1 || (nullable && (o.Type == JTokenType.Null || o.Type == JTokenType.Undefined));
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00038C94 File Offset: 0x00036E94
		public static explicit operator bool(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.BooleanTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return Convert.ToBoolean((int)value3);
			}
			return Convert.ToBoolean(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00038D08 File Offset: 0x00036F08
		public static explicit operator DateTimeOffset(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.DateTimeTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is DateTimeOffset)
			{
				return (DateTimeOffset)value2;
			}
			string text = jvalue.Value as string;
			if (text != null)
			{
				return DateTimeOffset.Parse(text, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00038D90 File Offset: 0x00036F90
		[NullableContext(2)]
		public static explicit operator bool?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.BooleanTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new bool?(Convert.ToBoolean((int)value3));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00038E2C File Offset: 0x0003702C
		public static explicit operator long(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (long)value3;
			}
			return Convert.ToInt64(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00038E9C File Offset: 0x0003709C
		[NullableContext(2)]
		public static explicit operator DateTime?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.DateTimeTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is DateTimeOffset)
			{
				return new DateTime?(((DateTimeOffset)value2).DateTime);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new DateTime?(Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00038F34 File Offset: 0x00037134
		[NullableContext(2)]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.DateTimeTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			object value2 = jvalue.Value;
			if (value2 is DateTimeOffset)
			{
				DateTimeOffset value3 = (DateTimeOffset)value2;
				return new DateTimeOffset?(value3);
			}
			string text = jvalue.Value as string;
			if (text != null)
			{
				return new DateTimeOffset?(DateTimeOffset.Parse(text, CultureInfo.InvariantCulture));
			}
			return new DateTimeOffset?(new DateTimeOffset(Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00038FF0 File Offset: 0x000371F0
		[NullableContext(2)]
		public static explicit operator decimal?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new decimal?((decimal)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new decimal?(Convert.ToDecimal(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00039088 File Offset: 0x00037288
		[NullableContext(2)]
		public static explicit operator double?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new double?((double)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new double?(Convert.ToDouble(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00039120 File Offset: 0x00037320
		[NullableContext(2)]
		public static explicit operator char?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.CharTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Char.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new char?((char)((ushort)value3));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new char?(Convert.ToChar(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000391B8 File Offset: 0x000373B8
		public static explicit operator int(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (int)value3;
			}
			return Convert.ToInt32(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00039228 File Offset: 0x00037428
		public static explicit operator short(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (short)value3;
			}
			return Convert.ToInt16(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00039298 File Offset: 0x00037498
		[CLSCompliant(false)]
		public static explicit operator ushort(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (ushort)value3;
			}
			return Convert.ToUInt16(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00039308 File Offset: 0x00037508
		[CLSCompliant(false)]
		public static explicit operator char(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.CharTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Char.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (char)((ushort)value3);
			}
			return Convert.ToChar(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00039378 File Offset: 0x00037578
		public static explicit operator byte(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Byte.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (byte)value3;
			}
			return Convert.ToByte(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000393E8 File Offset: 0x000375E8
		[CLSCompliant(false)]
		public static explicit operator sbyte(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to SByte.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (sbyte)value3;
			}
			return Convert.ToSByte(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00039458 File Offset: 0x00037658
		[NullableContext(2)]
		public static explicit operator int?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new int?((int)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new int?(Convert.ToInt32(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000394F0 File Offset: 0x000376F0
		[NullableContext(2)]
		public static explicit operator short?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new short?((short)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new short?(Convert.ToInt16(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00039588 File Offset: 0x00037788
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator ushort?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new ushort?((ushort)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new ushort?(Convert.ToUInt16(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00039620 File Offset: 0x00037820
		[NullableContext(2)]
		public static explicit operator byte?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Byte.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new byte?((byte)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new byte?(Convert.ToByte(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000396B8 File Offset: 0x000378B8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator sbyte?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to SByte.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new sbyte?((sbyte)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new sbyte?(Convert.ToSByte(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00039750 File Offset: 0x00037950
		public static explicit operator DateTime(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.DateTimeTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is DateTimeOffset)
			{
				return ((DateTimeOffset)value2).DateTime;
			}
			return Convert.ToDateTime(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000397C0 File Offset: 0x000379C0
		[NullableContext(2)]
		public static explicit operator long?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new long?((long)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new long?(Convert.ToInt64(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00039858 File Offset: 0x00037A58
		[NullableContext(2)]
		public static explicit operator float?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new float?((float)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new float?(Convert.ToSingle(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000398F0 File Offset: 0x00037AF0
		public static explicit operator decimal(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (decimal)value3;
			}
			return Convert.ToDecimal(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00039960 File Offset: 0x00037B60
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator uint?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new uint?((uint)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new uint?(Convert.ToUInt32(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000399F8 File Offset: 0x00037BF8
		[NullableContext(2)]
		[CLSCompliant(false)]
		public static explicit operator ulong?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return new ulong?((ulong)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new ulong?(Convert.ToUInt64(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00039A90 File Offset: 0x00037C90
		public static explicit operator double(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (double)value3;
			}
			return Convert.ToDouble(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00039B00 File Offset: 0x00037D00
		public static explicit operator float(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (float)value3;
			}
			return Convert.ToSingle(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00039B70 File Offset: 0x00037D70
		[NullableContext(2)]
		public static explicit operator string(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.StringTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to String.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return Convert.ToBase64String(array);
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				return ((BigInteger)value2).ToString(CultureInfo.InvariantCulture);
			}
			return Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00039C08 File Offset: 0x00037E08
		[CLSCompliant(false)]
		public static explicit operator uint(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (uint)value3;
			}
			return Convert.ToUInt32(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00039C78 File Offset: 0x00037E78
		[CLSCompliant(false)]
		public static explicit operator ulong(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.NumberTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				BigInteger value3 = (BigInteger)value2;
				return (ulong)value3;
			}
			return Convert.ToUInt64(jvalue.Value, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00039CE8 File Offset: 0x00037EE8
		[NullableContext(2)]
		public static explicit operator byte[](JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.BytesTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value is string)
			{
				return Convert.FromBase64String(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			}
			object value2 = jvalue.Value;
			if (value2 is BigInteger)
			{
				return ((BigInteger)value2).ToByteArray();
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return array;
			}
			throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00039D9C File Offset: 0x00037F9C
		public static explicit operator Guid(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.GuidTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to Guid.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return new Guid(array);
			}
			object value2 = jvalue.Value;
			if (value2 is Guid)
			{
				return (Guid)value2;
			}
			return new Guid(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00039E24 File Offset: 0x00038024
		[NullableContext(2)]
		public static explicit operator Guid?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.GuidTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Guid.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return new Guid?(new Guid(array));
			}
			object value2 = jvalue.Value;
			Guid value3;
			if (value2 is Guid)
			{
				Guid guid = (Guid)value2;
				value3 = guid;
			}
			else
			{
				value3 = new Guid(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			}
			return new Guid?(value3);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00039ED8 File Offset: 0x000380D8
		public static explicit operator TimeSpan(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.TimeSpanTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is TimeSpan)
			{
				return (TimeSpan)value2;
			}
			return ConvertUtils.ParseTimeSpan(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00039F48 File Offset: 0x00038148
		[NullableContext(2)]
		public static explicit operator TimeSpan?(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.TimeSpanTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			object value2 = jvalue.Value;
			TimeSpan value3;
			if (value2 is TimeSpan)
			{
				TimeSpan timeSpan = (TimeSpan)value2;
				value3 = timeSpan;
			}
			else
			{
				value3 = ConvertUtils.ParseTimeSpan(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			}
			return new TimeSpan?(value3);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00039FDC File Offset: 0x000381DC
		[NullableContext(2)]
		public static explicit operator Uri(JToken value)
		{
			if (value == null)
			{
				return null;
			}
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.UriTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to Uri.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			Uri uri = jvalue.Value as Uri;
			if (uri == null)
			{
				return new Uri(Convert.ToString(jvalue.Value, CultureInfo.InvariantCulture));
			}
			return uri;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0003A054 File Offset: 0x00038254
		private static BigInteger ToBigInteger(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.BigIntegerTypes, false))
			{
				throw new ArgumentException("Can not convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			return ConvertUtils.ToBigInteger(jvalue.Value);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0003A0A0 File Offset: 0x000382A0
		private static BigInteger? ToBigIntegerNullable(JToken value)
		{
			JValue jvalue = JToken.EnsureValue(value);
			if (jvalue == null || !JToken.ValidateToken(jvalue, JToken.BigIntegerTypes, true))
			{
				throw new ArgumentException("Can not convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new BigInteger?(ConvertUtils.ToBigInteger(jvalue.Value));
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0003A102 File Offset: 0x00038302
		public static implicit operator JToken(bool value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0003A10A File Offset: 0x0003830A
		public static implicit operator JToken(DateTimeOffset value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0003A112 File Offset: 0x00038312
		public static implicit operator JToken(byte value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0003A11B File Offset: 0x0003831B
		public static implicit operator JToken(byte? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0003A128 File Offset: 0x00038328
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0003A131 File Offset: 0x00038331
		[CLSCompliant(false)]
		public static implicit operator JToken(sbyte? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0003A13E File Offset: 0x0003833E
		public static implicit operator JToken(bool? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0003A14B File Offset: 0x0003834B
		public static implicit operator JToken(long value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0003A153 File Offset: 0x00038353
		public static implicit operator JToken(DateTime? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0003A160 File Offset: 0x00038360
		public static implicit operator JToken(DateTimeOffset? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0003A16D File Offset: 0x0003836D
		public static implicit operator JToken(decimal? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0003A17A File Offset: 0x0003837A
		public static implicit operator JToken(double? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0003A128 File Offset: 0x00038328
		[CLSCompliant(false)]
		public static implicit operator JToken(short value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0003A112 File Offset: 0x00038312
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0003A128 File Offset: 0x00038328
		public static implicit operator JToken(int value)
		{
			return new JValue((long)value);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0003A187 File Offset: 0x00038387
		public static implicit operator JToken(int? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0003A194 File Offset: 0x00038394
		public static implicit operator JToken(DateTime value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0003A19C File Offset: 0x0003839C
		public static implicit operator JToken(long? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0003A1A9 File Offset: 0x000383A9
		public static implicit operator JToken(float? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0003A1B6 File Offset: 0x000383B6
		public static implicit operator JToken(decimal value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0003A1BE File Offset: 0x000383BE
		[CLSCompliant(false)]
		public static implicit operator JToken(short? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0003A1CB File Offset: 0x000383CB
		[CLSCompliant(false)]
		public static implicit operator JToken(ushort? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0003A1D8 File Offset: 0x000383D8
		[CLSCompliant(false)]
		public static implicit operator JToken(uint? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0003A1E5 File Offset: 0x000383E5
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0003A1F2 File Offset: 0x000383F2
		public static implicit operator JToken(double value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0003A1FA File Offset: 0x000383FA
		public static implicit operator JToken(float value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0003A202 File Offset: 0x00038402
		public static implicit operator JToken([Nullable(2)] string value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0003A112 File Offset: 0x00038312
		[CLSCompliant(false)]
		public static implicit operator JToken(uint value)
		{
			return new JValue((long)((ulong)value));
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0003A20A File Offset: 0x0003840A
		[CLSCompliant(false)]
		public static implicit operator JToken(ulong value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0003A212 File Offset: 0x00038412
		public static implicit operator JToken(byte[] value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0003A21A File Offset: 0x0003841A
		public static implicit operator JToken([Nullable(2)] Uri value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0003A222 File Offset: 0x00038422
		public static implicit operator JToken(TimeSpan value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0003A22A File Offset: 0x0003842A
		public static implicit operator JToken(TimeSpan? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003A237 File Offset: 0x00038437
		public static implicit operator JToken(Guid value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003A23F File Offset: 0x0003843F
		public static implicit operator JToken(Guid? value)
		{
			return new JValue(value);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0003A24C File Offset: 0x0003844C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<JToken>)this).GetEnumerator();
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0003A254 File Offset: 0x00038454
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x06000D25 RID: 3365
		internal abstract int GetDeepHashCode();

		// Token: 0x1700021F RID: 543
		IJEnumerable<JToken> IJEnumerable<JToken>.this[object key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0003A278 File Offset: 0x00038478
		public JsonReader CreateReader()
		{
			return new JTokenReader(this);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0003A280 File Offset: 0x00038480
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			JToken token;
			using (JTokenWriter jtokenWriter = new JTokenWriter())
			{
				jsonSerializer.Serialize(jtokenWriter, o);
				token = jtokenWriter.Token;
			}
			return token;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0003A2D8 File Offset: 0x000384D8
		public static JToken FromObject(object o)
		{
			return JToken.FromObjectInternal(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0003A2E5 File Offset: 0x000384E5
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return JToken.FromObjectInternal(o, jsonSerializer);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0003A2EE File Offset: 0x000384EE
		[NullableContext(2)]
		public T ToObject<T>()
		{
			return (T)((object)this.ToObject(typeof(T)));
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0003A308 File Offset: 0x00038508
		[return: Nullable(2)]
		public object ToObject(Type objectType)
		{
			if (JsonConvert.DefaultSettings == null)
			{
				bool flag;
				PrimitiveTypeCode typeCode = ConvertUtils.GetTypeCode(objectType, out flag);
				if (flag)
				{
					if (this.Type == JTokenType.String)
					{
						try
						{
							return this.ToObject(objectType, JsonSerializer.CreateDefault());
						}
						catch (Exception innerException)
						{
							Type type = objectType.IsEnum() ? objectType : Nullable.GetUnderlyingType(objectType);
							throw new ArgumentException("Could not convert '{0}' to {1}.".FormatWith(CultureInfo.InvariantCulture, (string)this, type.Name), innerException);
						}
					}
					if (this.Type == JTokenType.Integer)
					{
						return Enum.ToObject(objectType.IsEnum() ? objectType : Nullable.GetUnderlyingType(objectType), ((JValue)this).Value);
					}
				}
				switch (typeCode)
				{
				case PrimitiveTypeCode.Char:
					return (char)this;
				case PrimitiveTypeCode.CharNullable:
					return (char?)this;
				case PrimitiveTypeCode.Boolean:
					return (bool)this;
				case PrimitiveTypeCode.BooleanNullable:
					return (bool?)this;
				case PrimitiveTypeCode.SByte:
					return (sbyte)this;
				case PrimitiveTypeCode.SByteNullable:
					return (sbyte?)this;
				case PrimitiveTypeCode.Int16:
					return (short)this;
				case PrimitiveTypeCode.Int16Nullable:
					return (short?)this;
				case PrimitiveTypeCode.UInt16:
					return (ushort)this;
				case PrimitiveTypeCode.UInt16Nullable:
					return (ushort?)this;
				case PrimitiveTypeCode.Int32:
					return (int)this;
				case PrimitiveTypeCode.Int32Nullable:
					return (int?)this;
				case PrimitiveTypeCode.Byte:
					return (byte)this;
				case PrimitiveTypeCode.ByteNullable:
					return (byte?)this;
				case PrimitiveTypeCode.UInt32:
					return (uint)this;
				case PrimitiveTypeCode.UInt32Nullable:
					return (uint?)this;
				case PrimitiveTypeCode.Int64:
					return (long)this;
				case PrimitiveTypeCode.Int64Nullable:
					return (long?)this;
				case PrimitiveTypeCode.UInt64:
					return (ulong)this;
				case PrimitiveTypeCode.UInt64Nullable:
					return (ulong?)this;
				case PrimitiveTypeCode.Single:
					return (float)this;
				case PrimitiveTypeCode.SingleNullable:
					return (float?)this;
				case PrimitiveTypeCode.Double:
					return (double)this;
				case PrimitiveTypeCode.DoubleNullable:
					return (double?)this;
				case PrimitiveTypeCode.DateTime:
					return (DateTime)this;
				case PrimitiveTypeCode.DateTimeNullable:
					return (DateTime?)this;
				case PrimitiveTypeCode.DateTimeOffset:
					return (DateTimeOffset)this;
				case PrimitiveTypeCode.DateTimeOffsetNullable:
					return (DateTimeOffset?)this;
				case PrimitiveTypeCode.Decimal:
					return (decimal)this;
				case PrimitiveTypeCode.DecimalNullable:
					return (decimal?)this;
				case PrimitiveTypeCode.Guid:
					return (Guid)this;
				case PrimitiveTypeCode.GuidNullable:
					return (Guid?)this;
				case PrimitiveTypeCode.TimeSpan:
					return (TimeSpan)this;
				case PrimitiveTypeCode.TimeSpanNullable:
					return (TimeSpan?)this;
				case PrimitiveTypeCode.BigInteger:
					return JToken.ToBigInteger(this);
				case PrimitiveTypeCode.BigIntegerNullable:
					return JToken.ToBigIntegerNullable(this);
				case PrimitiveTypeCode.Uri:
					return (Uri)this;
				case PrimitiveTypeCode.String:
					return (string)this;
				}
			}
			return this.ToObject(objectType, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0003A62C File Offset: 0x0003882C
		[NullableContext(2)]
		public T ToObject<T>([Nullable(1)] JsonSerializer jsonSerializer)
		{
			return (T)((object)this.ToObject(typeof(T), jsonSerializer));
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0003A644 File Offset: 0x00038844
		[NullableContext(2)]
		public object ToObject(Type objectType, [Nullable(1)] JsonSerializer jsonSerializer)
		{
			ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			object result;
			using (JTokenReader jtokenReader = new JTokenReader(this))
			{
				JsonSerializerProxy jsonSerializerProxy = jsonSerializer as JsonSerializerProxy;
				if (jsonSerializerProxy != null)
				{
					CultureInfo cultureInfo;
					DateTimeZoneHandling? dateTimeZoneHandling;
					DateParseHandling? dateParseHandling;
					FloatParseHandling? floatParseHandling;
					int? num;
					string text;
					jsonSerializerProxy._serializer.SetupReader(jtokenReader, out cultureInfo, out dateTimeZoneHandling, out dateParseHandling, out floatParseHandling, out num, out text);
				}
				result = jsonSerializer.Deserialize(jtokenReader, objectType);
			}
			return result;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0003A6B0 File Offset: 0x000388B0
		public static JToken ReadFrom(JsonReader reader)
		{
			return JToken.ReadFrom(reader, null);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0003A6BC File Offset: 0x000388BC
		public static JToken ReadFrom(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			bool flag;
			if (reader.TokenType == JsonToken.None)
			{
				flag = ((settings != null && settings.CommentHandling == CommentHandling.Ignore) ? reader.ReadAndMoveToContent() : reader.Read());
			}
			else
			{
				flag = (reader.TokenType != JsonToken.Comment || settings == null || settings.CommentHandling != CommentHandling.Ignore || reader.ReadAndMoveToContent());
			}
			if (!flag)
			{
				throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader.");
			}
			IJsonLineInfo lineInfo = reader as IJsonLineInfo;
			switch (reader.TokenType)
			{
			case JsonToken.StartObject:
				return JObject.Load(reader, settings);
			case JsonToken.StartArray:
				return JArray.Load(reader, settings);
			case JsonToken.StartConstructor:
				return JConstructor.Load(reader, settings);
			case JsonToken.PropertyName:
				return JProperty.Load(reader, settings);
			case JsonToken.Comment:
			{
				JValue jvalue = JValue.CreateComment(reader.Value.ToString());
				jvalue.SetLineInfo(lineInfo, settings);
				return jvalue;
			}
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
			{
				JValue jvalue2 = new JValue(reader.Value);
				jvalue2.SetLineInfo(lineInfo, settings);
				return jvalue2;
			}
			case JsonToken.Null:
			{
				JValue jvalue3 = JValue.CreateNull();
				jvalue3.SetLineInfo(lineInfo, settings);
				return jvalue3;
			}
			case JsonToken.Undefined:
			{
				JValue jvalue4 = JValue.CreateUndefined();
				jvalue4.SetLineInfo(lineInfo, settings);
				return jvalue4;
			}
			}
			throw JsonReaderException.Create(reader, "Error reading JToken from JsonReader. Unexpected token: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0003A80B File Offset: 0x00038A0B
		public static JToken Parse(string json)
		{
			return JToken.Parse(json, null);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0003A814 File Offset: 0x00038A14
		public static JToken Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			JToken result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				JToken jtoken = JToken.Load(jsonReader, settings);
				while (jsonReader.Read())
				{
				}
				result = jtoken;
			}
			return result;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0003A85C File Offset: 0x00038A5C
		public static JToken Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			return JToken.ReadFrom(reader, settings);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0003A865 File Offset: 0x00038A65
		public static JToken Load(JsonReader reader)
		{
			return JToken.Load(reader, null);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0003A86E File Offset: 0x00038A6E
		[NullableContext(2)]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
			if (settings != null && settings.LineInfoHandling != LineInfoHandling.Load)
			{
				return;
			}
			if (lineInfo == null || !lineInfo.HasLineInfo())
			{
				return;
			}
			this.SetLineInfo(lineInfo.LineNumber, lineInfo.LinePosition);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0003A89B File Offset: 0x00038A9B
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			this.AddAnnotation(new JToken.LineInfoAnnotation(lineNumber, linePosition));
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0003A8AA File Offset: 0x00038AAA
		bool IJsonLineInfo.HasLineInfo()
		{
			return this.Annotation<JToken.LineInfoAnnotation>() != null;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0003A8B8 File Offset: 0x00038AB8
		int IJsonLineInfo.LineNumber
		{
			get
			{
				JToken.LineInfoAnnotation lineInfoAnnotation = this.Annotation<JToken.LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0003A8D8 File Offset: 0x00038AD8
		int IJsonLineInfo.LinePosition
		{
			get
			{
				JToken.LineInfoAnnotation lineInfoAnnotation = this.Annotation<JToken.LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0003A8F7 File Offset: 0x00038AF7
		[return: Nullable(2)]
		public JToken SelectToken(string path)
		{
			return this.SelectToken(path, null);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0003A904 File Offset: 0x00038B04
		[return: Nullable(2)]
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			object obj;
			if (!errorWhenNoMatch)
			{
				obj = null;
			}
			else
			{
				(obj = new JsonSelectSettings()).ErrorWhenNoMatch = true;
			}
			JsonSelectSettings settings = obj;
			return this.SelectToken(path, settings);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0003A92C File Offset: 0x00038B2C
		[NullableContext(2)]
		public JToken SelectToken([Nullable(1)] string path, JsonSelectSettings settings)
		{
			JPath jpath = new JPath(path);
			JToken jtoken = null;
			foreach (JToken jtoken2 in jpath.Evaluate(this, this, settings))
			{
				if (jtoken != null)
				{
					throw new JsonException("Path returned multiple tokens.");
				}
				jtoken = jtoken2;
			}
			return jtoken;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0003A98C File Offset: 0x00038B8C
		public IEnumerable<JToken> SelectTokens(string path)
		{
			return this.SelectTokens(path, null);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0003A998 File Offset: 0x00038B98
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			object obj;
			if (!errorWhenNoMatch)
			{
				obj = null;
			}
			else
			{
				(obj = new JsonSelectSettings()).ErrorWhenNoMatch = true;
			}
			JsonSelectSettings settings = obj;
			return this.SelectTokens(path, settings);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0003A9C0 File Offset: 0x00038BC0
		public IEnumerable<JToken> SelectTokens(string path, [Nullable(2)] JsonSelectSettings settings)
		{
			return new JPath(path).Evaluate(this, this, settings);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0003A9D0 File Offset: 0x00038BD0
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JToken>(parameter, this, new DynamicProxy<JToken>());
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0003A9DE File Offset: 0x00038BDE
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return this.GetMetaObject(parameter);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0003A9E7 File Offset: 0x00038BE7
		object ICloneable.Clone()
		{
			return this.DeepClone();
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0003A9EF File Offset: 0x00038BEF
		public JToken DeepClone()
		{
			return this.CloneToken(null);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		public JToken DeepClone(JsonCloneSettings settings)
		{
			return this.CloneToken(settings);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0003AA04 File Offset: 0x00038C04
		public void AddAnnotation(object annotation)
		{
			if (annotation == null)
			{
				throw new ArgumentNullException("annotation");
			}
			if (this._annotations == null)
			{
				object annotations;
				if (!(annotation is object[]))
				{
					annotations = annotation;
				}
				else
				{
					(annotations = new object[1])[0] = annotation;
				}
				this._annotations = annotations;
				return;
			}
			object[] array = this._annotations as object[];
			if (array == null)
			{
				this._annotations = new object[]
				{
					this._annotations,
					annotation
				};
				return;
			}
			int num = 0;
			while (num < array.Length && array[num] != null)
			{
				num++;
			}
			if (num == array.Length)
			{
				Array.Resize<object>(ref array, num * 2);
				this._annotations = array;
			}
			array[num] = annotation;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0003AA9C File Offset: 0x00038C9C
		[return: Nullable(2)]
		public T Annotation<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					return this._annotations as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0003AB08 File Offset: 0x00038D08
		[return: Nullable(2)]
		public object Annotation(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (type.IsInstanceOfType(this._annotations))
					{
						return this._annotations;
					}
				}
				else
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (type.IsInstanceOfType(obj))
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0003AB76 File Offset: 0x00038D76
		public IEnumerable<T> Annotations<T>() where T : class
		{
			if (this._annotations == null)
			{
				yield break;
			}
			object annotations2 = this._annotations;
			object[] annotations = annotations2 as object[];
			if (annotations != null)
			{
				int num;
				for (int i = 0; i < annotations.Length; i = num + 1)
				{
					object obj = annotations[i];
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						yield return t;
					}
					num = i;
				}
				yield break;
			}
			T t2 = this._annotations as T;
			if (t2 == null)
			{
				yield break;
			}
			yield return t2;
			yield break;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003AB86 File Offset: 0x00038D86
		public IEnumerable<object> Annotations(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this._annotations == null)
			{
				yield break;
			}
			object annotations2 = this._annotations;
			object[] annotations = annotations2 as object[];
			if (annotations != null)
			{
				int num;
				for (int i = 0; i < annotations.Length; i = num + 1)
				{
					object obj = annotations[i];
					if (obj == null)
					{
						break;
					}
					if (type.IsInstanceOfType(obj))
					{
						yield return obj;
					}
					num = i;
				}
				yield break;
			}
			if (!type.IsInstanceOfType(this._annotations))
			{
				yield break;
			}
			yield return this._annotations;
			yield break;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0003ABA0 File Offset: 0x00038DA0
		public void RemoveAnnotations<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (this._annotations is T)
					{
						this._annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!(obj is T))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this._annotations = null;
				}
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0003AC1C File Offset: 0x00038E1C
		public void RemoveAnnotations(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (type.IsInstanceOfType(this._annotations))
					{
						this._annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!type.IsInstanceOfType(obj))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this._annotations = null;
				}
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0003ACAC File Offset: 0x00038EAC
		internal void CopyAnnotations(JToken target, JToken source)
		{
			object[] array = source._annotations as object[];
			if (array != null)
			{
				target._annotations = array.ToArray<object>();
				return;
			}
			target._annotations = source._annotations;
		}

		// Token: 0x04000705 RID: 1797
		[Nullable(2)]
		private static JTokenEqualityComparer _equalityComparer;

		// Token: 0x04000706 RID: 1798
		[Nullable(2)]
		private JContainer _parent;

		// Token: 0x04000707 RID: 1799
		[Nullable(2)]
		private JToken _previous;

		// Token: 0x04000708 RID: 1800
		[Nullable(2)]
		private JToken _next;

		// Token: 0x04000709 RID: 1801
		[Nullable(2)]
		private object _annotations;

		// Token: 0x0400070A RID: 1802
		private static readonly JTokenType[] BooleanTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean
		};

		// Token: 0x0400070B RID: 1803
		private static readonly JTokenType[] NumberTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean
		};

		// Token: 0x0400070C RID: 1804
		private static readonly JTokenType[] BigIntegerTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean,
			JTokenType.Bytes
		};

		// Token: 0x0400070D RID: 1805
		private static readonly JTokenType[] StringTypes = new JTokenType[]
		{
			JTokenType.Date,
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Boolean,
			JTokenType.Bytes,
			JTokenType.Guid,
			JTokenType.TimeSpan,
			JTokenType.Uri
		};

		// Token: 0x0400070E RID: 1806
		private static readonly JTokenType[] GuidTypes = new JTokenType[]
		{
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Guid,
			JTokenType.Bytes
		};

		// Token: 0x0400070F RID: 1807
		private static readonly JTokenType[] TimeSpanTypes = new JTokenType[]
		{
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.TimeSpan
		};

		// Token: 0x04000710 RID: 1808
		private static readonly JTokenType[] UriTypes = new JTokenType[]
		{
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Uri
		};

		// Token: 0x04000711 RID: 1809
		private static readonly JTokenType[] CharTypes = new JTokenType[]
		{
			JTokenType.Integer,
			JTokenType.Float,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw
		};

		// Token: 0x04000712 RID: 1810
		private static readonly JTokenType[] DateTimeTypes = new JTokenType[]
		{
			JTokenType.Date,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw
		};

		// Token: 0x04000713 RID: 1811
		private static readonly JTokenType[] BytesTypes = new JTokenType[]
		{
			JTokenType.Bytes,
			JTokenType.String,
			JTokenType.Comment,
			JTokenType.Raw,
			JTokenType.Integer
		};

		// Token: 0x02000181 RID: 385
		[NullableContext(0)]
		private class LineInfoAnnotation
		{
			// Token: 0x06000D4E RID: 3406 RVA: 0x0003ADCE File Offset: 0x00038FCE
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
				this.LineNumber = lineNumber;
				this.LinePosition = linePosition;
			}

			// Token: 0x04000714 RID: 1812
			internal readonly int LineNumber;

			// Token: 0x04000715 RID: 1813
			internal readonly int LinePosition;
		}
	}
}
