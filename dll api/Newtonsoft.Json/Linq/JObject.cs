using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200016C RID: 364
	[NullableContext(1)]
	[Nullable(0)]
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		// Token: 0x06000BDC RID: 3036 RVA: 0x000365F8 File Offset: 0x000347F8
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			Task task = writer.WriteStartObjectAsync(cancellationToken);
			if (!task.IsCompletedSuccessfully())
			{
				return this.<WriteToAsync>g__AwaitProperties|0_0(task, 0, writer, cancellationToken, converters);
			}
			for (int i = 0; i < this._properties.Count; i++)
			{
				task = this._properties[i].WriteToAsync(writer, cancellationToken, converters);
				if (!task.IsCompletedSuccessfully())
				{
					return this.<WriteToAsync>g__AwaitProperties|0_0(task, i + 1, writer, cancellationToken, converters);
				}
			}
			return writer.WriteEndObjectAsync(cancellationToken);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00036669 File Offset: 0x00034869
		public new static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JObject.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00036674 File Offset: 0x00034874
		public new static Task<JObject> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			JObject.<LoadAsync>d__2 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<JObject>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<JObject.<LoadAsync>d__2>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000366C7 File Offset: 0x000348C7
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this._properties;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000BE0 RID: 3040 RVA: 0x000366D0 File Offset: 0x000348D0
		// (remove) Token: 0x06000BE1 RID: 3041 RVA: 0x00036708 File Offset: 0x00034908
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000BE2 RID: 3042 RVA: 0x00036740 File Offset: 0x00034940
		// (remove) Token: 0x06000BE3 RID: 3043 RVA: 0x00036778 File Offset: 0x00034978
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event PropertyChangingEventHandler PropertyChanging;

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000367AD File Offset: 0x000349AD
		public JObject()
		{
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000367C0 File Offset: 0x000349C0
		public JObject(JObject other) : base(other, null)
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000367D5 File Offset: 0x000349D5
		internal JObject(JObject other, [Nullable(2)] JsonCloneSettings settings) : base(other, settings)
		{
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000367EA File Offset: 0x000349EA
		public JObject(params object[] content) : this(content)
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000367F3 File Offset: 0x000349F3
		public JObject(object content)
		{
			this.Add(content);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00036810 File Offset: 0x00034A10
		internal override bool DeepEquals(JToken node)
		{
			JObject jobject = node as JObject;
			return jobject != null && this._properties.Compare(jobject._properties);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0003683A File Offset: 0x00034A3A
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._properties.IndexOfReference(item);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0003684D File Offset: 0x00034A4D
		[NullableContext(2)]
		internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			return (item == null || item.Type != JTokenType.Comment) && base.InsertItem(index, item, skipParentCheck, copyAnnotations);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00036868 File Offset: 0x00034A68
		internal override void ValidateToken(JToken o, [Nullable(2)] JToken existing)
		{
			ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type != JTokenType.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".FormatWith(CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
			JProperty jproperty = (JProperty)o;
			if (existing != null)
			{
				JProperty jproperty2 = (JProperty)existing;
				if (jproperty.Name == jproperty2.Name)
				{
					return;
				}
			}
			if (this._properties.TryGetValue(jproperty.Name, out existing))
			{
				throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".FormatWith(CultureInfo.InvariantCulture, jproperty.Name, base.GetType()));
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00036908 File Offset: 0x00034B08
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			JObject jobject = content as JObject;
			if (jobject == null)
			{
				return;
			}
			foreach (KeyValuePair<string, JToken> keyValuePair in jobject)
			{
				JProperty jproperty = this.Property(keyValuePair.Key, (settings != null) ? settings.PropertyNameComparison : StringComparison.Ordinal);
				if (jproperty == null)
				{
					this.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else if (keyValuePair.Value != null)
				{
					JContainer jcontainer = jproperty.Value as JContainer;
					if (jcontainer == null || jcontainer.Type != keyValuePair.Value.Type)
					{
						if (!JObject.IsNull(keyValuePair.Value) || (settings != null && settings.MergeNullValueHandling == MergeNullValueHandling.Merge))
						{
							jproperty.Value = keyValuePair.Value;
						}
					}
					else
					{
						jcontainer.Merge(keyValuePair.Value, settings);
					}
				}
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000369F4 File Offset: 0x00034BF4
		private static bool IsNull(JToken token)
		{
			if (token.Type == JTokenType.Null)
			{
				return true;
			}
			JValue jvalue = token as JValue;
			return jvalue != null && jvalue.Value == null;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00036A24 File Offset: 0x00034C24
		internal void InternalPropertyChanged(JProperty childProperty)
		{
			this.OnPropertyChanged(childProperty.Name);
			if (this._listChanged != null)
			{
				this.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, this.IndexOfItem(childProperty)));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, childProperty, childProperty, this.IndexOfItem(childProperty)));
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00036A75 File Offset: 0x00034C75
		internal void InternalPropertyChanging(JProperty childProperty)
		{
			this.OnPropertyChanging(childProperty.Name);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00036A83 File Offset: 0x00034C83
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return new JObject(this, settings);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00002E5B File Offset: 0x0000105B
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Object;
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00036A8C File Offset: 0x00034C8C
		public IEnumerable<JProperty> Properties()
		{
			return this._properties.Cast<JProperty>();
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00036A99 File Offset: 0x00034C99
		[return: Nullable(2)]
		public JProperty Property(string name)
		{
			return this.Property(name, StringComparison.Ordinal);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00036AA4 File Offset: 0x00034CA4
		[return: Nullable(2)]
		public JProperty Property(string name, StringComparison comparison)
		{
			if (name == null)
			{
				return null;
			}
			JToken jtoken;
			if (this._properties.TryGetValue(name, out jtoken))
			{
				return (JProperty)jtoken;
			}
			if (comparison != StringComparison.Ordinal)
			{
				for (int i = 0; i < this._properties.Count; i++)
				{
					JProperty jproperty = (JProperty)this._properties[i];
					if (string.Equals(jproperty.Name, name, comparison))
					{
						return jproperty;
					}
				}
			}
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00036B0B File Offset: 0x00034D0B
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public JEnumerable<JToken> PropertyValues()
		{
			return new JEnumerable<JToken>(from p in this.Properties()
			select p.Value);
		}

		// Token: 0x170001F4 RID: 500
		[Nullable(2)]
		public override JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				ValidationUtils.ArgumentNotNull(key, "key");
				string text = key as string;
				if (text == null)
				{
					throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				return this[text];
			}
			[param: Nullable(2)]
			set
			{
				ValidationUtils.ArgumentNotNull(key, "key");
				string text = key as string;
				if (text == null)
				{
					throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
				}
				this[text] = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		[Nullable(2)]
		public JToken this[string propertyName]
		{
			[return: Nullable(2)]
			get
			{
				ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
				JProperty jproperty = this.Property(propertyName, StringComparison.Ordinal);
				if (jproperty == null)
				{
					return null;
				}
				return jproperty.Value;
			}
			[param: Nullable(2)]
			set
			{
				JProperty jproperty = this.Property(propertyName, StringComparison.Ordinal);
				if (jproperty != null)
				{
					jproperty.Value = value;
					return;
				}
				this.OnPropertyChanging(propertyName);
				this.Add(propertyName, value);
				this.OnPropertyChanged(propertyName);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00036C1F File Offset: 0x00034E1F
		public new static JObject Load(JsonReader reader)
		{
			return JObject.Load(reader, null);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00036C28 File Offset: 0x00034E28
		public new static JObject Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JObject from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != JsonToken.StartObject)
			{
				throw JsonReaderException.Create(reader, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JObject jobject = new JObject();
			jobject.SetLineInfo(reader as IJsonLineInfo, settings);
			jobject.ReadTokenFrom(reader, settings);
			return jobject;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00036CA7 File Offset: 0x00034EA7
		public new static JObject Parse(string json)
		{
			return JObject.Parse(json, null);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00036CB0 File Offset: 0x00034EB0
		public new static JObject Parse(string json, [Nullable(2)] JsonLoadSettings settings)
		{
			JObject result;
			using (JsonReader jsonReader = new JsonTextReader(new StringReader(json)))
			{
				JObject jobject = JObject.Load(jsonReader, settings);
				while (jsonReader.Read())
				{
				}
				result = jobject;
			}
			return result;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00036CF8 File Offset: 0x00034EF8
		public new static JObject FromObject(object o)
		{
			return JObject.FromObject(o, JsonSerializer.CreateDefault());
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00036D08 File Offset: 0x00034F08
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			JToken jtoken = JToken.FromObjectInternal(o, jsonSerializer);
			if (jtoken.Type != JTokenType.Object)
			{
				throw new ArgumentException("Object serialized to {0}. JObject instance expected.".FormatWith(CultureInfo.InvariantCulture, jtoken.Type));
			}
			return (JObject)jtoken;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00036D4C File Offset: 0x00034F4C
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartObject();
			for (int i = 0; i < this._properties.Count; i++)
			{
				this._properties[i].WriteTo(writer, converters);
			}
			writer.WriteEndObject();
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00036D8E File Offset: 0x00034F8E
		[NullableContext(2)]
		public JToken GetValue(string propertyName)
		{
			return this.GetValue(propertyName, StringComparison.Ordinal);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00036D98 File Offset: 0x00034F98
		[NullableContext(2)]
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			if (propertyName == null)
			{
				return null;
			}
			JProperty jproperty = this.Property(propertyName, comparison);
			if (jproperty == null)
			{
				return null;
			}
			return jproperty.Value;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00036DB2 File Offset: 0x00034FB2
		public bool TryGetValue(string propertyName, StringComparison comparison, [Nullable(2)] [NotNullWhen(true)] out JToken value)
		{
			value = this.GetValue(propertyName, comparison);
			return value != null;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00036DC3 File Offset: 0x00034FC3
		public void Add(string propertyName, [Nullable(2)] JToken value)
		{
			this.Add(new JProperty(propertyName, value));
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00036DD2 File Offset: 0x00034FD2
		public bool ContainsKey(string propertyName)
		{
			ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
			return this._properties.Contains(propertyName);
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00036DEB File Offset: 0x00034FEB
		ICollection<string> IDictionary<string, JToken>.Keys
		{
			get
			{
				return this._properties.Keys;
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00036DF8 File Offset: 0x00034FF8
		public bool Remove(string propertyName)
		{
			JProperty jproperty = this.Property(propertyName, StringComparison.Ordinal);
			if (jproperty == null)
			{
				return false;
			}
			jproperty.Remove();
			return true;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00036E1C File Offset: 0x0003501C
		public bool TryGetValue(string propertyName, [Nullable(2)] [NotNullWhen(true)] out JToken value)
		{
			JProperty jproperty = this.Property(propertyName, StringComparison.Ordinal);
			if (jproperty == null)
			{
				value = null;
				return false;
			}
			value = jproperty.Value;
			return true;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00036E43 File Offset: 0x00035043
		[Nullable(new byte[]
		{
			1,
			2
		})]
		ICollection<JToken> IDictionary<string, JToken>.Values
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00036E4A File Offset: 0x0003504A
		void ICollection<KeyValuePair<string, JToken>>.Add([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JToken> item)
		{
			this.Add(new JProperty(item.Key, item.Value));
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00036E65 File Offset: 0x00035065
		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
			base.RemoveAll();
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00036E70 File Offset: 0x00035070
		bool ICollection<KeyValuePair<string, JToken>>.Contains([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JToken> item)
		{
			JProperty jproperty = this.Property(item.Key, StringComparison.Ordinal);
			return jproperty != null && jproperty.Value == item.Value;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00036EA0 File Offset: 0x000350A0
		void ICollection<KeyValuePair<string, JToken>>.CopyTo([Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= array.Length && arrayIndex != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (base.Count > array.Length - arrayIndex)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (JToken jtoken in this._properties)
			{
				JProperty jproperty = (JProperty)jtoken;
				array[arrayIndex + num] = new KeyValuePair<string, JToken>(jproperty.Name, jproperty.Value);
				num++;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00016B42 File Offset: 0x00014D42
		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00036F5C File Offset: 0x0003515C
		bool ICollection<KeyValuePair<string, JToken>>.Remove([Nullable(new byte[]
		{
			0,
			1,
			2
		})] KeyValuePair<string, JToken> item)
		{
			if (!((ICollection<KeyValuePair<string, JToken>>)this).Contains(item))
			{
				return false;
			}
			((IDictionary<string, JToken>)this).Remove(item.Key);
			return true;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00033E74 File Offset: 0x00032074
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00036F78 File Offset: 0x00035178
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			foreach (JToken jtoken in this._properties)
			{
				JProperty jproperty = (JProperty)jtoken;
				yield return new KeyValuePair<string, JToken>(jproperty.Name, jproperty.Value);
			}
			IEnumerator<JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00036F87 File Offset: 0x00035187
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00036FA0 File Offset: 0x000351A0
		protected virtual void OnPropertyChanging(string propertyName)
		{
			PropertyChangingEventHandler propertyChanging = this.PropertyChanging;
			if (propertyChanging == null)
			{
				return;
			}
			propertyChanging(this, new PropertyChangingEventArgs(propertyName));
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00036FB9 File Offset: 0x000351B9
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00036FC4 File Offset: 0x000351C4
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties([Nullable(new byte[]
		{
			2,
			1
		})] Attribute[] attributes)
		{
			PropertyDescriptor[] array = new PropertyDescriptor[base.Count];
			int num = 0;
			foreach (KeyValuePair<string, JToken> keyValuePair in this)
			{
				array[num] = new JPropertyDescriptor(keyValuePair.Key);
				num++;
			}
			return new PropertyDescriptorCollection(array);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0003702C File Offset: 0x0003522C
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return AttributeCollection.Empty;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00035A47 File Offset: 0x00033C47
		[NullableContext(2)]
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00035A47 File Offset: 0x00033C47
		[NullableContext(2)]
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00037033 File Offset: 0x00035233
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return new TypeConverter();
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00035A47 File Offset: 0x00033C47
		[NullableContext(2)]
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00035A47 File Offset: 0x00033C47
		[NullableContext(2)]
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00035A47 File Offset: 0x00033C47
		[return: Nullable(2)]
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0003703A File Offset: 0x0003523A
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents([Nullable(new byte[]
		{
			2,
			1
		})] Attribute[] attributes)
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003703A File Offset: 0x0003523A
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return EventDescriptorCollection.Empty;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00037041 File Offset: 0x00035241
		[NullableContext(2)]
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			if (pd is JPropertyDescriptor)
			{
				return this;
			}
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003704E File Offset: 0x0003524E
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicProxyMetaObject<JObject>(parameter, this, new JObject.JObjectDynamicProxy());
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0003705C File Offset: 0x0003525C
		[CompilerGenerated]
		private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters)
		{
			JObject.<<WriteToAsync>g__AwaitProperties|0_0>d <<WriteToAsync>g__AwaitProperties|0_0>d;
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>4__this = this;
			<<WriteToAsync>g__AwaitProperties|0_0>d.task = task;
			<<WriteToAsync>g__AwaitProperties|0_0>d.i = i;
			<<WriteToAsync>g__AwaitProperties|0_0>d.Writer = Writer;
			<<WriteToAsync>g__AwaitProperties|0_0>d.CancellationToken = CancellationToken;
			<<WriteToAsync>g__AwaitProperties|0_0>d.Converters = Converters;
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>1__state = -1;
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>t__builder.Start<JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>(ref <<WriteToAsync>g__AwaitProperties|0_0>d);
			return <<WriteToAsync>g__AwaitProperties|0_0>d.<>t__builder.Task;
		}

		// Token: 0x040006C0 RID: 1728
		private readonly JPropertyKeyedCollection _properties = new JPropertyKeyedCollection();

		// Token: 0x0200016D RID: 365
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			// Token: 0x06000C23 RID: 3107 RVA: 0x000370C9 File Offset: 0x000352C9
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, [Nullable(2)] out object result)
			{
				result = instance[binder.Name];
				return true;
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x000370DC File Offset: 0x000352DC
			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				JToken jtoken = value as JToken;
				if (jtoken == null)
				{
					jtoken = new JValue(value);
				}
				instance[binder.Name] = jtoken;
				return true;
			}

			// Token: 0x06000C25 RID: 3109 RVA: 0x00037108 File Offset: 0x00035308
			public override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				return from p in instance.Properties()
				select p.Name;
			}
		}
	}
}
