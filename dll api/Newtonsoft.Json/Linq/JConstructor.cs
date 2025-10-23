using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000164 RID: 356
	[NullableContext(1)]
	[Nullable(0)]
	public class JConstructor : JContainer
	{
		// Token: 0x06000B46 RID: 2886 RVA: 0x0003430C File Offset: 0x0003250C
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			JConstructor.<WriteToAsync>d__0 <WriteToAsync>d__;
			<WriteToAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteToAsync>d__.<>4__this = this;
			<WriteToAsync>d__.writer = writer;
			<WriteToAsync>d__.cancellationToken = cancellationToken;
			<WriteToAsync>d__.converters = converters;
			<WriteToAsync>d__.<>1__state = -1;
			<WriteToAsync>d__.<>t__builder.Start<JConstructor.<WriteToAsync>d__0>(ref <WriteToAsync>d__);
			return <WriteToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00034367 File Offset: 0x00032567
		public new static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return JConstructor.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00034374 File Offset: 0x00032574
		public new static Task<JConstructor> LoadAsync(JsonReader reader, [Nullable(2)] JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			JConstructor.<LoadAsync>d__2 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<JConstructor>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<JConstructor.<LoadAsync>d__2>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000343C7 File Offset: 0x000325C7
		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000343CF File Offset: 0x000325CF
		[NullableContext(2)]
		internal override int IndexOfItem(JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._values.IndexOfReference(item);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000343E4 File Offset: 0x000325E4
		internal override void MergeItem(object content, [Nullable(2)] JsonMergeSettings settings)
		{
			JConstructor jconstructor = content as JConstructor;
			if (jconstructor == null)
			{
				return;
			}
			if (jconstructor.Name != null)
			{
				this.Name = jconstructor.Name;
			}
			JContainer.MergeEnumerableContent(this, jconstructor, settings);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00034418 File Offset: 0x00032618
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00034420 File Offset: 0x00032620
		[Nullable(2)]
		public string Name
		{
			[NullableContext(2)]
			get
			{
				return this._name;
			}
			[NullableContext(2)]
			set
			{
				this._name = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00034429 File Offset: 0x00032629
		public override JTokenType Type
		{
			get
			{
				return JTokenType.Constructor;
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0003442C File Offset: 0x0003262C
		public JConstructor()
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0003443F File Offset: 0x0003263F
		public JConstructor(JConstructor other) : base(other, null)
		{
			this._name = other.Name;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00034460 File Offset: 0x00032660
		internal JConstructor(JConstructor other, [Nullable(2)] JsonCloneSettings settings) : base(other, settings)
		{
			this._name = other.Name;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00034481 File Offset: 0x00032681
		public JConstructor(string name, params object[] content) : this(name, content)
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0003448B File Offset: 0x0003268B
		public JConstructor(string name, object content) : this(name)
		{
			this.Add(content);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0003449B File Offset: 0x0003269B
		public JConstructor(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Constructor name cannot be empty.", "name");
			}
			this._name = name;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000344DC File Offset: 0x000326DC
		internal override bool DeepEquals(JToken node)
		{
			JConstructor jconstructor = node as JConstructor;
			return jconstructor != null && this._name == jconstructor.Name && base.ContentsEqual(jconstructor);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0003450F File Offset: 0x0003270F
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings = null)
		{
			return new JConstructor(this, settings);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00034518 File Offset: 0x00032718
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			writer.WriteStartConstructor(this._name);
			int count = this._values.Count;
			for (int i = 0; i < count; i++)
			{
				this._values[i].WriteTo(writer, converters);
			}
			writer.WriteEndConstructor();
		}

		// Token: 0x170001D9 RID: 473
		[Nullable(2)]
		public override JToken this[object key]
		{
			[return: Nullable(2)]
			get
			{
				ValidationUtils.ArgumentNotNull(key, "key");
				if (key is int)
				{
					int index = (int)key;
					return this.GetItem(index);
				}
				throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
			}
			[param: Nullable(2)]
			set
			{
				ValidationUtils.ArgumentNotNull(key, "key");
				if (key is int)
				{
					int index = (int)key;
					this.SetItem(index, value);
					return;
				}
				throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(CultureInfo.InvariantCulture, MiscellaneousUtils.ToString(key)));
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000345FC File Offset: 0x000327FC
		internal override int GetDeepHashCode()
		{
			string name = this._name;
			return ((name != null) ? name.GetHashCode() : 0) ^ base.ContentsHashCode();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00034617 File Offset: 0x00032817
		public new static JConstructor Load(JsonReader reader)
		{
			return JConstructor.Load(reader, null);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00034620 File Offset: 0x00032820
		public new static JConstructor Load(JsonReader reader, [Nullable(2)] JsonLoadSettings settings)
		{
			if (reader.TokenType == JsonToken.None && !reader.Read())
			{
				throw JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != JsonToken.StartConstructor)
			{
				throw JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			JConstructor jconstructor = new JConstructor((string)reader.Value);
			jconstructor.SetLineInfo(reader as IJsonLineInfo, settings);
			jconstructor.ReadTokenFrom(reader, settings);
			return jconstructor;
		}

		// Token: 0x0400068B RID: 1675
		[Nullable(2)]
		private string _name;

		// Token: 0x0400068C RID: 1676
		private readonly List<JToken> _values = new List<JToken>();
	}
}
