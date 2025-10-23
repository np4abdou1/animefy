using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001D7 RID: 471
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonReader : JsonReader
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00045C96 File Offset: 0x00043E96
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00045C9E File Offset: 0x00043E9E
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			get
			{
				return this._jsonNet35BinaryCompatibility;
			}
			set
			{
				this._jsonNet35BinaryCompatibility = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00045CA7 File Offset: 0x00043EA7
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00045CAF File Offset: 0x00043EAF
		public bool ReadRootValueAsArray
		{
			get
			{
				return this._readRootValueAsArray;
			}
			set
			{
				this._readRootValueAsArray = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00045CB8 File Offset: 0x00043EB8
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00045CC0 File Offset: 0x00043EC0
		public DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this._dateTimeKindHandling;
			}
			set
			{
				this._dateTimeKindHandling = value;
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00045CC9 File Offset: 0x00043EC9
		public BsonReader(Stream stream) : this(stream, false, DateTimeKind.Local)
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00045CD4 File Offset: 0x00043ED4
		public BsonReader(BinaryReader reader) : this(reader, false, DateTimeKind.Local)
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00045CDF File Offset: 0x00043EDF
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			ValidationUtils.ArgumentNotNull(stream, "stream");
			this._reader = new BinaryReader(stream);
			this._stack = new List<BsonReader.ContainerContext>();
			this._readRootValueAsArray = readRootValueAsArray;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00045D17 File Offset: 0x00043F17
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			this._reader = reader;
			this._stack = new List<BsonReader.ContainerContext>();
			this._readRootValueAsArray = readRootValueAsArray;
			this._dateTimeKindHandling = dateTimeKindHandling;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00045D4A File Offset: 0x00043F4A
		private string ReadElement()
		{
			this._currentElementType = this.ReadType();
			return this.ReadString();
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00045D60 File Offset: 0x00043F60
		public override bool Read()
		{
			bool result;
			try
			{
				bool flag;
				switch (this._bsonReaderState)
				{
				case BsonReader.BsonReaderState.Normal:
					flag = this.ReadNormal();
					break;
				case BsonReader.BsonReaderState.ReferenceStart:
				case BsonReader.BsonReaderState.ReferenceRef:
				case BsonReader.BsonReaderState.ReferenceId:
					flag = this.ReadReference();
					break;
				case BsonReader.BsonReaderState.CodeWScopeStart:
				case BsonReader.BsonReaderState.CodeWScopeCode:
				case BsonReader.BsonReaderState.CodeWScopeScope:
				case BsonReader.BsonReaderState.CodeWScopeScopeObject:
				case BsonReader.BsonReaderState.CodeWScopeScopeEnd:
					flag = this.ReadCodeWScope();
					break;
				default:
					throw JsonReaderException.Create(this, "Unexpected state: {0}".FormatWith(CultureInfo.InvariantCulture, this._bsonReaderState));
				}
				if (!flag)
				{
					base.SetToken(JsonToken.None);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (EndOfStreamException)
			{
				base.SetToken(JsonToken.None);
				result = false;
			}
			return result;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00045E0C File Offset: 0x0004400C
		public override void Close()
		{
			base.Close();
			if (base.CloseInput)
			{
				BinaryReader reader = this._reader;
				if (reader == null)
				{
					return;
				}
				reader.Close();
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00045E2C File Offset: 0x0004402C
		private bool ReadCodeWScope()
		{
			switch (this._bsonReaderState)
			{
			case BsonReader.BsonReaderState.CodeWScopeStart:
				base.SetToken(JsonToken.PropertyName, "$code");
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeCode;
				return true;
			case BsonReader.BsonReaderState.CodeWScopeCode:
				this.ReadInt32();
				base.SetToken(JsonToken.String, this.ReadLengthString());
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeScope;
				return true;
			case BsonReader.BsonReaderState.CodeWScopeScope:
			{
				if (base.CurrentState == JsonReader.State.PostValue)
				{
					base.SetToken(JsonToken.PropertyName, "$scope");
					return true;
				}
				base.SetToken(JsonToken.StartObject);
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeScopeObject;
				BsonReader.ContainerContext containerContext = new BsonReader.ContainerContext(BsonType.Object);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return true;
			}
			case BsonReader.BsonReaderState.CodeWScopeScopeObject:
			{
				bool flag = this.ReadNormal();
				if (flag && this.TokenType == JsonToken.EndObject)
				{
					this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeScopeEnd;
				}
				return flag;
			}
			case BsonReader.BsonReaderState.CodeWScopeScopeEnd:
				base.SetToken(JsonToken.EndObject);
				this._bsonReaderState = BsonReader.BsonReaderState.Normal;
				return true;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00045F08 File Offset: 0x00044108
		private bool ReadReference()
		{
			JsonReader.State currentState = base.CurrentState;
			if (currentState != JsonReader.State.Property)
			{
				if (currentState == JsonReader.State.ObjectStart)
				{
					base.SetToken(JsonToken.PropertyName, "$ref");
					this._bsonReaderState = BsonReader.BsonReaderState.ReferenceRef;
					return true;
				}
				if (currentState != JsonReader.State.PostValue)
				{
					throw JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + base.CurrentState.ToString());
				}
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceRef)
				{
					base.SetToken(JsonToken.PropertyName, "$id");
					this._bsonReaderState = BsonReader.BsonReaderState.ReferenceId;
					return true;
				}
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceId)
				{
					base.SetToken(JsonToken.EndObject);
					this._bsonReaderState = BsonReader.BsonReaderState.Normal;
					return true;
				}
				throw JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + this._bsonReaderState.ToString());
			}
			else
			{
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceRef)
				{
					base.SetToken(JsonToken.String, this.ReadLengthString());
					return true;
				}
				if (this._bsonReaderState == BsonReader.BsonReaderState.ReferenceId)
				{
					base.SetToken(JsonToken.Bytes, this.ReadBytes(12));
					return true;
				}
				throw JsonReaderException.Create(this, "Unexpected state when reading BSON reference: " + this._bsonReaderState.ToString());
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00046018 File Offset: 0x00044218
		private bool ReadNormal()
		{
			switch (base.CurrentState)
			{
			case JsonReader.State.Start:
				break;
			case JsonReader.State.Complete:
			case JsonReader.State.Closed:
				return false;
			case JsonReader.State.Property:
				this.ReadType(this._currentElementType);
				return true;
			case JsonReader.State.ObjectStart:
			case JsonReader.State.ArrayStart:
			case JsonReader.State.PostValue:
			{
				BsonReader.ContainerContext currentContext = this._currentContext;
				if (currentContext == null)
				{
					if (!base.SupportMultipleContent)
					{
						return false;
					}
				}
				else
				{
					int num = currentContext.Length - 1;
					if (currentContext.Position < num)
					{
						if (currentContext.Type == BsonType.Array)
						{
							this.ReadElement();
							this.ReadType(this._currentElementType);
							return true;
						}
						base.SetToken(JsonToken.PropertyName, this.ReadElement());
						return true;
					}
					else
					{
						if (currentContext.Position != num)
						{
							throw JsonReaderException.Create(this, "Read past end of current container context.");
						}
						if (this.ReadByte() != 0)
						{
							throw JsonReaderException.Create(this, "Unexpected end of object byte value.");
						}
						this.PopContext();
						if (this._currentContext != null)
						{
							this.MovePosition(currentContext.Length);
						}
						JsonToken token = (currentContext.Type == BsonType.Object) ? JsonToken.EndObject : JsonToken.EndArray;
						base.SetToken(token);
						return true;
					}
				}
				break;
			}
			case JsonReader.State.Object:
			case JsonReader.State.Array:
				goto IL_145;
			case JsonReader.State.ConstructorStart:
			case JsonReader.State.Constructor:
			case JsonReader.State.Error:
			case JsonReader.State.Finished:
				return false;
			default:
				goto IL_145;
			}
			JsonToken token2 = (!this._readRootValueAsArray) ? JsonToken.StartObject : JsonToken.StartArray;
			BsonType type = (!this._readRootValueAsArray) ? BsonType.Object : BsonType.Array;
			base.SetToken(token2);
			BsonReader.ContainerContext containerContext = new BsonReader.ContainerContext(type);
			this.PushContext(containerContext);
			containerContext.Length = this.ReadInt32();
			return true;
			IL_145:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00046174 File Offset: 0x00044374
		private void PopContext()
		{
			this._stack.RemoveAt(this._stack.Count - 1);
			if (this._stack.Count == 0)
			{
				this._currentContext = null;
				return;
			}
			this._currentContext = this._stack[this._stack.Count - 1];
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000461CC File Offset: 0x000443CC
		private void PushContext(BsonReader.ContainerContext newContext)
		{
			this._stack.Add(newContext);
			this._currentContext = newContext;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000461E1 File Offset: 0x000443E1
		private byte ReadByte()
		{
			this.MovePosition(1);
			return this._reader.ReadByte();
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x000461F8 File Offset: 0x000443F8
		private void ReadType(BsonType type)
		{
			switch (type)
			{
			case BsonType.Number:
			{
				double num = this.ReadDouble();
				if (this._floatParseHandling == FloatParseHandling.Decimal)
				{
					base.SetToken(JsonToken.Float, Convert.ToDecimal(num, CultureInfo.InvariantCulture));
					return;
				}
				base.SetToken(JsonToken.Float, num);
				return;
			}
			case BsonType.String:
			case BsonType.Symbol:
				base.SetToken(JsonToken.String, this.ReadLengthString());
				return;
			case BsonType.Object:
			{
				base.SetToken(JsonToken.StartObject);
				BsonReader.ContainerContext containerContext = new BsonReader.ContainerContext(BsonType.Object);
				this.PushContext(containerContext);
				containerContext.Length = this.ReadInt32();
				return;
			}
			case BsonType.Array:
			{
				base.SetToken(JsonToken.StartArray);
				BsonReader.ContainerContext containerContext2 = new BsonReader.ContainerContext(BsonType.Array);
				this.PushContext(containerContext2);
				containerContext2.Length = this.ReadInt32();
				return;
			}
			case BsonType.Binary:
			{
				BsonBinaryType bsonBinaryType;
				byte[] array = this.ReadBinary(out bsonBinaryType);
				object value = (bsonBinaryType != BsonBinaryType.Uuid) ? array : new Guid(array);
				base.SetToken(JsonToken.Bytes, value);
				return;
			}
			case BsonType.Undefined:
				base.SetToken(JsonToken.Undefined);
				return;
			case BsonType.Oid:
			{
				byte[] value2 = this.ReadBytes(12);
				base.SetToken(JsonToken.Bytes, value2);
				return;
			}
			case BsonType.Boolean:
			{
				bool flag = Convert.ToBoolean(this.ReadByte());
				base.SetToken(JsonToken.Boolean, flag);
				return;
			}
			case BsonType.Date:
			{
				DateTime dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(this.ReadInt64());
				DateTimeKind dateTimeKindHandling = this.DateTimeKindHandling;
				DateTime dateTime2;
				if (dateTimeKindHandling != DateTimeKind.Unspecified)
				{
					if (dateTimeKindHandling != DateTimeKind.Local)
					{
						dateTime2 = dateTime;
					}
					else
					{
						dateTime2 = dateTime.ToLocalTime();
					}
				}
				else
				{
					dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
				}
				base.SetToken(JsonToken.Date, dateTime2);
				return;
			}
			case BsonType.Null:
				base.SetToken(JsonToken.Null);
				return;
			case BsonType.Regex:
			{
				string str = this.ReadString();
				string str2 = this.ReadString();
				string value3 = "/" + str + "/" + str2;
				base.SetToken(JsonToken.String, value3);
				return;
			}
			case BsonType.Reference:
				base.SetToken(JsonToken.StartObject);
				this._bsonReaderState = BsonReader.BsonReaderState.ReferenceStart;
				return;
			case BsonType.Code:
				base.SetToken(JsonToken.String, this.ReadLengthString());
				return;
			case BsonType.CodeWScope:
				base.SetToken(JsonToken.StartObject);
				this._bsonReaderState = BsonReader.BsonReaderState.CodeWScopeStart;
				return;
			case BsonType.Integer:
				base.SetToken(JsonToken.Integer, (long)this.ReadInt32());
				return;
			case BsonType.TimeStamp:
			case BsonType.Long:
				base.SetToken(JsonToken.Integer, this.ReadInt64());
				return;
			default:
				throw new ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + type.ToString());
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00046448 File Offset: 0x00044648
		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			int count = this.ReadInt32();
			binaryType = (BsonBinaryType)this.ReadByte();
			if (binaryType == BsonBinaryType.BinaryOld && !this._jsonNet35BinaryCompatibility)
			{
				count = this.ReadInt32();
			}
			return this.ReadBytes(count);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00046480 File Offset: 0x00044680
		private string ReadString()
		{
			this.EnsureBuffers();
			StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num4;
			for (;;)
			{
				int num3 = num2;
				byte b;
				while (num3 < 128 && (b = this._reader.ReadByte()) > 0)
				{
					this._byteBuffer[num3++] = b;
				}
				num4 = num3 - num2;
				num += num4;
				if (num3 < 128 && stringBuilder == null)
				{
					break;
				}
				int lastFullCharStop = this.GetLastFullCharStop(num3 - 1);
				int chars = Encoding.UTF8.GetChars(this._byteBuffer, 0, lastFullCharStop + 1, this._charBuffer, 0);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(256);
				}
				stringBuilder.Append(this._charBuffer, 0, chars);
				if (lastFullCharStop < num4 - 1)
				{
					num2 = num4 - lastFullCharStop - 1;
					Array.Copy(this._byteBuffer, lastFullCharStop + 1, this._byteBuffer, 0, num2);
				}
				else
				{
					if (num3 < 128)
					{
						goto Block_6;
					}
					num2 = 0;
				}
			}
			int chars2 = Encoding.UTF8.GetChars(this._byteBuffer, 0, num4, this._charBuffer, 0);
			this.MovePosition(num + 1);
			return new string(this._charBuffer, 0, chars2);
			Block_6:
			this.MovePosition(num + 1);
			return stringBuilder.ToString();
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000465A0 File Offset: 0x000447A0
		private string ReadLengthString()
		{
			int num = this.ReadInt32();
			this.MovePosition(num);
			string @string = this.GetString(num - 1);
			this._reader.ReadByte();
			return @string;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000465D0 File Offset: 0x000447D0
		private string GetString(int length)
		{
			if (length == 0)
			{
				return string.Empty;
			}
			this.EnsureBuffers();
			StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num3;
			for (;;)
			{
				int count = (length - num > 128 - num2) ? (128 - num2) : (length - num);
				num3 = this._reader.Read(this._byteBuffer, num2, count);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num3 += num2;
				if (num3 == length)
				{
					goto Block_4;
				}
				int lastFullCharStop = this.GetLastFullCharStop(num3 - 1);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(length);
				}
				int chars = Encoding.UTF8.GetChars(this._byteBuffer, 0, lastFullCharStop + 1, this._charBuffer, 0);
				stringBuilder.Append(this._charBuffer, 0, chars);
				if (lastFullCharStop < num3 - 1)
				{
					num2 = num3 - lastFullCharStop - 1;
					Array.Copy(this._byteBuffer, lastFullCharStop + 1, this._byteBuffer, 0, num2);
				}
				else
				{
					num2 = 0;
				}
				if (num >= length)
				{
					goto Block_7;
				}
			}
			throw new EndOfStreamException("Unable to read beyond the end of the stream.");
			Block_4:
			int chars2 = Encoding.UTF8.GetChars(this._byteBuffer, 0, num3, this._charBuffer, 0);
			return new string(this._charBuffer, 0, chars2);
			Block_7:
			return stringBuilder.ToString();
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000466E8 File Offset: 0x000448E8
		private int GetLastFullCharStop(int start)
		{
			int i = start;
			int num = 0;
			while (i >= 0)
			{
				num = this.BytesInSequence(this._byteBuffer[i]);
				if (num == 0)
				{
					i--;
				}
				else
				{
					if (num != 1)
					{
						i--;
						break;
					}
					break;
				}
			}
			if (num == start - i)
			{
				return start;
			}
			return i;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004672C File Offset: 0x0004492C
		private int BytesInSequence(byte b)
		{
			if (b <= BsonReader.SeqRange1[1])
			{
				return 1;
			}
			if (b >= BsonReader.SeqRange2[0] && b <= BsonReader.SeqRange2[1])
			{
				return 2;
			}
			if (b >= BsonReader.SeqRange3[0] && b <= BsonReader.SeqRange3[1])
			{
				return 3;
			}
			if (b >= BsonReader.SeqRange4[0] && b <= BsonReader.SeqRange4[1])
			{
				return 4;
			}
			return 0;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00046788 File Offset: 0x00044988
		private void EnsureBuffers()
		{
			if (this._byteBuffer == null)
			{
				this._byteBuffer = new byte[128];
			}
			if (this._charBuffer == null)
			{
				int maxCharCount = Encoding.UTF8.GetMaxCharCount(128);
				this._charBuffer = new char[maxCharCount];
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x000467D1 File Offset: 0x000449D1
		private double ReadDouble()
		{
			this.MovePosition(8);
			return this._reader.ReadDouble();
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000467E5 File Offset: 0x000449E5
		private int ReadInt32()
		{
			this.MovePosition(4);
			return this._reader.ReadInt32();
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000467F9 File Offset: 0x000449F9
		private long ReadInt64()
		{
			this.MovePosition(8);
			return this._reader.ReadInt64();
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004680D File Offset: 0x00044A0D
		private BsonType ReadType()
		{
			this.MovePosition(1);
			return (BsonType)this._reader.ReadSByte();
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00046821 File Offset: 0x00044A21
		private void MovePosition(int count)
		{
			this._currentContext.Position += count;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00046836 File Offset: 0x00044A36
		private byte[] ReadBytes(int count)
		{
			this.MovePosition(count);
			return this._reader.ReadBytes(count);
		}

		// Token: 0x04000838 RID: 2104
		private const int MaxCharBytesSize = 128;

		// Token: 0x04000839 RID: 2105
		private static readonly byte[] SeqRange1 = new byte[]
		{
			0,
			127
		};

		// Token: 0x0400083A RID: 2106
		private static readonly byte[] SeqRange2 = new byte[]
		{
			194,
			223
		};

		// Token: 0x0400083B RID: 2107
		private static readonly byte[] SeqRange3 = new byte[]
		{
			224,
			239
		};

		// Token: 0x0400083C RID: 2108
		private static readonly byte[] SeqRange4 = new byte[]
		{
			240,
			244
		};

		// Token: 0x0400083D RID: 2109
		private readonly BinaryReader _reader;

		// Token: 0x0400083E RID: 2110
		private readonly List<BsonReader.ContainerContext> _stack;

		// Token: 0x0400083F RID: 2111
		private byte[] _byteBuffer;

		// Token: 0x04000840 RID: 2112
		private char[] _charBuffer;

		// Token: 0x04000841 RID: 2113
		private BsonType _currentElementType;

		// Token: 0x04000842 RID: 2114
		private BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x04000843 RID: 2115
		private BsonReader.ContainerContext _currentContext;

		// Token: 0x04000844 RID: 2116
		private bool _readRootValueAsArray;

		// Token: 0x04000845 RID: 2117
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x04000846 RID: 2118
		private DateTimeKind _dateTimeKindHandling;

		// Token: 0x020001D8 RID: 472
		private enum BsonReaderState
		{
			// Token: 0x04000848 RID: 2120
			Normal,
			// Token: 0x04000849 RID: 2121
			ReferenceStart,
			// Token: 0x0400084A RID: 2122
			ReferenceRef,
			// Token: 0x0400084B RID: 2123
			ReferenceId,
			// Token: 0x0400084C RID: 2124
			CodeWScopeStart,
			// Token: 0x0400084D RID: 2125
			CodeWScopeCode,
			// Token: 0x0400084E RID: 2126
			CodeWScopeScope,
			// Token: 0x0400084F RID: 2127
			CodeWScopeScopeObject,
			// Token: 0x04000850 RID: 2128
			CodeWScopeScopeEnd
		}

		// Token: 0x020001D9 RID: 473
		private class ContainerContext
		{
			// Token: 0x06001003 RID: 4099 RVA: 0x000468BA File Offset: 0x00044ABA
			public ContainerContext(BsonType type)
			{
				this.Type = type;
			}

			// Token: 0x04000851 RID: 2129
			public readonly BsonType Type;

			// Token: 0x04000852 RID: 2130
			public int Length;

			// Token: 0x04000853 RID: 2131
			public int Position;
		}
	}
}
