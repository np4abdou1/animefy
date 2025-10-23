using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AB RID: 171
	internal abstract class RegexCompiler
	{
		// Token: 0x06000473 RID: 1139 RVA: 0x00019C40 File Offset: 0x00017E40
		static RegexCompiler()
		{
			RegexCompiler.s_isECMABoundaryM = RegexCompiler.RegexRunnerMethod("IsECMABoundary");
			RegexCompiler.s_crawlposM = RegexCompiler.RegexRunnerMethod("Crawlpos");
			RegexCompiler.s_checkTimeoutM = RegexCompiler.RegexRunnerMethod("CheckTimeout");
			RegexCompiler.s_chartolowerM = typeof(char).GetMethod("ToLower", new Type[]
			{
				typeof(char),
				typeof(CultureInfo)
			});
			RegexCompiler.s_getcharM = typeof(string).GetMethod("get_Chars", new Type[]
			{
				typeof(int)
			});
			RegexCompiler.s_getCurrentCulture = typeof(CultureInfo).GetMethod("get_CurrentCulture");
			RegexCompiler.s_getInvariantCulture = typeof(CultureInfo).GetMethod("get_InvariantCulture");
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00019E2E File Offset: 0x0001802E
		private static FieldInfo RegexRunnerField(string fieldname)
		{
			return typeof(RegexRunner).GetField(fieldname, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00019E42 File Offset: 0x00018042
		private static MethodInfo RegexRunnerMethod(string methname)
		{
			return typeof(RegexRunner).GetMethod(methname, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00019E56 File Offset: 0x00018056
		internal static RegexRunnerFactory Compile(RegexCode code, RegexOptions options)
		{
			return new RegexLWCGCompiler().FactoryInstanceFromCode(code, options);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00019E64 File Offset: 0x00018064
		private int AddBacktrackNote(int flags, Label l, int codepos)
		{
			if (this._notes == null || this._notecount >= this._notes.Length)
			{
				RegexCompiler.BacktrackNote[] array = new RegexCompiler.BacktrackNote[(this._notes == null) ? 16 : (this._notes.Length * 2)];
				if (this._notes != null)
				{
					Array.Copy(this._notes, 0, array, 0, this._notecount);
				}
				this._notes = array;
			}
			this._notes[this._notecount] = new RegexCompiler.BacktrackNote(flags, l, codepos);
			int notecount = this._notecount;
			this._notecount = notecount + 1;
			return notecount;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00019EEE File Offset: 0x000180EE
		private int AddTrack()
		{
			return this.AddTrack(128);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00019EFB File Offset: 0x000180FB
		private int AddTrack(int flags)
		{
			return this.AddBacktrackNote(flags, this.DefineLabel(), this._codepos);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00019F10 File Offset: 0x00018110
		private int AddGoto(int destpos)
		{
			if (this._goto[destpos] == -1)
			{
				this._goto[destpos] = this.AddBacktrackNote(0, this._labels[destpos], destpos);
			}
			return this._goto[destpos];
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00019F41 File Offset: 0x00018141
		private int AddUniqueTrack(int i)
		{
			return this.AddUniqueTrack(i, 128);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00019F4F File Offset: 0x0001814F
		private int AddUniqueTrack(int i, int flags)
		{
			if (this._uniquenote[i] == -1)
			{
				this._uniquenote[i] = this.AddTrack(flags);
			}
			return this._uniquenote[i];
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00019F73 File Offset: 0x00018173
		private Label DefineLabel()
		{
			return this._ilg.DefineLabel();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00019F80 File Offset: 0x00018180
		private void MarkLabel(Label l)
		{
			this._ilg.MarkLabel(l);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00019F8E File Offset: 0x0001818E
		private int Operand(int i)
		{
			return this._codes[this._codepos + i + 1];
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00019FA1 File Offset: 0x000181A1
		private bool IsRtl()
		{
			return (this._regexopcode & 64) != 0;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00019FAF File Offset: 0x000181AF
		private bool IsCi()
		{
			return (this._regexopcode & 512) != 0;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00019FC0 File Offset: 0x000181C0
		private int Code()
		{
			return this._regexopcode & 63;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00019FCB File Offset: 0x000181CB
		private void Ldstr(string str)
		{
			this._ilg.Emit(OpCodes.Ldstr, str);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00019FDE File Offset: 0x000181DE
		private void Ldc(int i)
		{
			if (i <= 127 && i >= -128)
			{
				this._ilg.Emit(OpCodes.Ldc_I4_S, (byte)i);
				return;
			}
			this._ilg.Emit(OpCodes.Ldc_I4, i);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001A00E File Offset: 0x0001820E
		private void Dup()
		{
			this._ilg.Emit(OpCodes.Dup);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001A020 File Offset: 0x00018220
		private void Ret()
		{
			this._ilg.Emit(OpCodes.Ret);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001A032 File Offset: 0x00018232
		private void Pop()
		{
			this._ilg.Emit(OpCodes.Pop);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001A044 File Offset: 0x00018244
		private void Add()
		{
			this._ilg.Emit(OpCodes.Add);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001A056 File Offset: 0x00018256
		private void Add(bool negate)
		{
			if (negate)
			{
				this._ilg.Emit(OpCodes.Sub);
				return;
			}
			this._ilg.Emit(OpCodes.Add);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001A07C File Offset: 0x0001827C
		private void Sub()
		{
			this._ilg.Emit(OpCodes.Sub);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001A08E File Offset: 0x0001828E
		private void Sub(bool negate)
		{
			if (negate)
			{
				this._ilg.Emit(OpCodes.Add);
				return;
			}
			this._ilg.Emit(OpCodes.Sub);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001A0B4 File Offset: 0x000182B4
		private void Ldloc(LocalBuilder lt)
		{
			this._ilg.Emit(OpCodes.Ldloc_S, lt);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001A0C7 File Offset: 0x000182C7
		private void Stloc(LocalBuilder lt)
		{
			this._ilg.Emit(OpCodes.Stloc_S, lt);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001A0DA File Offset: 0x000182DA
		private void Ldthis()
		{
			this._ilg.Emit(OpCodes.Ldarg_0);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001A0EC File Offset: 0x000182EC
		private void Ldthisfld(FieldInfo ft)
		{
			this.Ldthis();
			this._ilg.Emit(OpCodes.Ldfld, ft);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001A105 File Offset: 0x00018305
		private void Mvfldloc(FieldInfo ft, LocalBuilder lt)
		{
			this.Ldthisfld(ft);
			this.Stloc(lt);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001A115 File Offset: 0x00018315
		private void Mvlocfld(LocalBuilder lt, FieldInfo ft)
		{
			this.Ldthis();
			this.Ldloc(lt);
			this.Stfld(ft);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001A12B File Offset: 0x0001832B
		private void Stfld(FieldInfo ft)
		{
			this._ilg.Emit(OpCodes.Stfld, ft);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001A13E File Offset: 0x0001833E
		private void Callvirt(MethodInfo mt)
		{
			this._ilg.Emit(OpCodes.Callvirt, mt);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001A151 File Offset: 0x00018351
		private void Call(MethodInfo mt)
		{
			this._ilg.Emit(OpCodes.Call, mt);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001A164 File Offset: 0x00018364
		private void BrfalseFar(Label l)
		{
			this._ilg.Emit(OpCodes.Brfalse, l);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001A177 File Offset: 0x00018377
		private void BrtrueFar(Label l)
		{
			this._ilg.Emit(OpCodes.Brtrue, l);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001A18A File Offset: 0x0001838A
		private void BrFar(Label l)
		{
			this._ilg.Emit(OpCodes.Br, l);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001A19D File Offset: 0x0001839D
		private void BleFar(Label l)
		{
			this._ilg.Emit(OpCodes.Ble, l);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001A1B0 File Offset: 0x000183B0
		private void BltFar(Label l)
		{
			this._ilg.Emit(OpCodes.Blt, l);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001A1C3 File Offset: 0x000183C3
		private void BgeFar(Label l)
		{
			this._ilg.Emit(OpCodes.Bge, l);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001A1D6 File Offset: 0x000183D6
		private void BgtFar(Label l)
		{
			this._ilg.Emit(OpCodes.Bgt, l);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001A1E9 File Offset: 0x000183E9
		private void BneFar(Label l)
		{
			this._ilg.Emit(OpCodes.Bne_Un, l);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001A1FC File Offset: 0x000183FC
		private void BeqFar(Label l)
		{
			this._ilg.Emit(OpCodes.Beq, l);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001A20F File Offset: 0x0001840F
		private void Brfalse(Label l)
		{
			this._ilg.Emit(OpCodes.Brfalse_S, l);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001A222 File Offset: 0x00018422
		private void Br(Label l)
		{
			this._ilg.Emit(OpCodes.Br_S, l);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001A235 File Offset: 0x00018435
		private void Ble(Label l)
		{
			this._ilg.Emit(OpCodes.Ble_S, l);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001A248 File Offset: 0x00018448
		private void Blt(Label l)
		{
			this._ilg.Emit(OpCodes.Blt_S, l);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001A25B File Offset: 0x0001845B
		private void Bge(Label l)
		{
			this._ilg.Emit(OpCodes.Bge_S, l);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001A26E File Offset: 0x0001846E
		private void Bgt(Label l)
		{
			this._ilg.Emit(OpCodes.Bgt_S, l);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001A281 File Offset: 0x00018481
		private void Bgtun(Label l)
		{
			this._ilg.Emit(OpCodes.Bgt_Un_S, l);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001A294 File Offset: 0x00018494
		private void Bne(Label l)
		{
			this._ilg.Emit(OpCodes.Bne_Un_S, l);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001A2A7 File Offset: 0x000184A7
		private void Beq(Label l)
		{
			this._ilg.Emit(OpCodes.Beq_S, l);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001A2BA File Offset: 0x000184BA
		private void Ldlen()
		{
			this._ilg.Emit(OpCodes.Ldlen);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001A2CC File Offset: 0x000184CC
		private void Rightchar()
		{
			this.Ldloc(this._textV);
			this.Ldloc(this._textposV);
			this.Callvirt(RegexCompiler.s_getcharM);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001A2F4 File Offset: 0x000184F4
		private void Rightcharnext()
		{
			this.Ldloc(this._textV);
			this.Ldloc(this._textposV);
			this.Dup();
			this.Ldc(1);
			this.Add();
			this.Stloc(this._textposV);
			this.Callvirt(RegexCompiler.s_getcharM);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001A343 File Offset: 0x00018543
		private void Leftchar()
		{
			this.Ldloc(this._textV);
			this.Ldloc(this._textposV);
			this.Ldc(1);
			this.Sub();
			this.Callvirt(RegexCompiler.s_getcharM);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001A378 File Offset: 0x00018578
		private void Leftcharnext()
		{
			this.Ldloc(this._textV);
			this.Ldloc(this._textposV);
			this.Ldc(1);
			this.Sub();
			this.Dup();
			this.Stloc(this._textposV);
			this.Callvirt(RegexCompiler.s_getcharM);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001A3C7 File Offset: 0x000185C7
		private void Track()
		{
			this.ReadyPushTrack();
			this.Ldc(this.AddTrack());
			this.DoPush();
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001A3E1 File Offset: 0x000185E1
		private void Trackagain()
		{
			this.ReadyPushTrack();
			this.Ldc(this._backpos);
			this.DoPush();
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001A3FB File Offset: 0x000185FB
		private void PushTrack(LocalBuilder lt)
		{
			this.ReadyPushTrack();
			this.Ldloc(lt);
			this.DoPush();
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001A410 File Offset: 0x00018610
		private void TrackUnique(int i)
		{
			this.ReadyPushTrack();
			this.Ldc(this.AddUniqueTrack(i));
			this.DoPush();
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001A42B File Offset: 0x0001862B
		private void TrackUnique2(int i)
		{
			this.ReadyPushTrack();
			this.Ldc(this.AddUniqueTrack(i, 256));
			this.DoPush();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001A44C File Offset: 0x0001864C
		private void ReadyPushTrack()
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._trackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._trackposV);
			this._ilg.Emit(OpCodes.Ldc_I4_1);
			this._ilg.Emit(OpCodes.Sub);
			this._ilg.Emit(OpCodes.Dup);
			this._ilg.Emit(OpCodes.Stloc_S, this._trackposV);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001A4CC File Offset: 0x000186CC
		private void PopTrack()
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._trackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._trackposV);
			this._ilg.Emit(OpCodes.Dup);
			this._ilg.Emit(OpCodes.Ldc_I4_1);
			this._ilg.Emit(OpCodes.Add);
			this._ilg.Emit(OpCodes.Stloc_S, this._trackposV);
			this._ilg.Emit(OpCodes.Ldelem_I4);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001A55B File Offset: 0x0001875B
		private void TopTrack()
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._trackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._trackposV);
			this._ilg.Emit(OpCodes.Ldelem_I4);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001A599 File Offset: 0x00018799
		private void PushStack(LocalBuilder lt)
		{
			this.ReadyPushStack();
			this._ilg.Emit(OpCodes.Ldloc_S, lt);
			this.DoPush();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001A5B8 File Offset: 0x000187B8
		internal void ReadyReplaceStack(int i)
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackposV);
			if (i != 0)
			{
				this.Ldc(i);
				this._ilg.Emit(OpCodes.Add);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001A60C File Offset: 0x0001880C
		private void ReadyPushStack()
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackposV);
			this._ilg.Emit(OpCodes.Ldc_I4_1);
			this._ilg.Emit(OpCodes.Sub);
			this._ilg.Emit(OpCodes.Dup);
			this._ilg.Emit(OpCodes.Stloc_S, this._stackposV);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001A68B File Offset: 0x0001888B
		private void TopStack()
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackposV);
			this._ilg.Emit(OpCodes.Ldelem_I4);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001A6CC File Offset: 0x000188CC
		private void PopStack()
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackV);
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackposV);
			this._ilg.Emit(OpCodes.Dup);
			this._ilg.Emit(OpCodes.Ldc_I4_1);
			this._ilg.Emit(OpCodes.Add);
			this._ilg.Emit(OpCodes.Stloc_S, this._stackposV);
			this._ilg.Emit(OpCodes.Ldelem_I4);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001A75B File Offset: 0x0001895B
		private void PopDiscardStack()
		{
			this.PopDiscardStack(1);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001A764 File Offset: 0x00018964
		private void PopDiscardStack(int i)
		{
			this._ilg.Emit(OpCodes.Ldloc_S, this._stackposV);
			this.Ldc(i);
			this._ilg.Emit(OpCodes.Add);
			this._ilg.Emit(OpCodes.Stloc_S, this._stackposV);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001A7B4 File Offset: 0x000189B4
		private void DoReplace()
		{
			this._ilg.Emit(OpCodes.Stelem_I4);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001A7B4 File Offset: 0x000189B4
		private void DoPush()
		{
			this._ilg.Emit(OpCodes.Stelem_I4);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001A7C6 File Offset: 0x000189C6
		private void Back()
		{
			this._ilg.Emit(OpCodes.Br, this._backtrack);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001A7E0 File Offset: 0x000189E0
		private void Goto(int i)
		{
			if (i < this._codepos)
			{
				Label l = this.DefineLabel();
				this.Ldloc(this._trackposV);
				this.Ldc(this._trackcount * 4);
				this.Ble(l);
				this.Ldloc(this._stackposV);
				this.Ldc(this._trackcount * 3);
				this.BgtFar(this._labels[i]);
				this.MarkLabel(l);
				this.ReadyPushTrack();
				this.Ldc(this.AddGoto(i));
				this.DoPush();
				this.BrFar(this._backtrack);
				return;
			}
			this.BrFar(this._labels[i]);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001A88C File Offset: 0x00018A8C
		private int NextCodepos()
		{
			return this._codepos + RegexCode.OpcodeSize(this._codes[this._codepos]);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001A8A7 File Offset: 0x00018AA7
		private Label AdvanceLabel()
		{
			return this._labels[this.NextCodepos()];
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001A8BA File Offset: 0x00018ABA
		private void Advance()
		{
			this._ilg.Emit(OpCodes.Br, this.AdvanceLabel());
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001A8D2 File Offset: 0x00018AD2
		private void CallToLower()
		{
			if ((this._options & RegexOptions.CultureInvariant) != RegexOptions.None)
			{
				this.Call(RegexCompiler.s_getInvariantCulture);
			}
			else
			{
				this.Call(RegexCompiler.s_getCurrentCulture);
			}
			this.Call(RegexCompiler.s_chartolowerM);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001A908 File Offset: 0x00018B08
		private void GenerateForwardSection()
		{
			this._labels = new Label[this._codes.Length];
			this._goto = new int[this._codes.Length];
			for (int i = 0; i < this._codes.Length; i += RegexCode.OpcodeSize(this._codes[i]))
			{
				this._goto[i] = -1;
				this._labels[i] = this._ilg.DefineLabel();
			}
			this._uniquenote = new int[10];
			for (int j = 0; j < 10; j++)
			{
				this._uniquenote[j] = -1;
			}
			this.Mvfldloc(RegexCompiler.s_textF, this._textV);
			this.Mvfldloc(RegexCompiler.s_textstartF, this._textstartV);
			this.Mvfldloc(RegexCompiler.s_textbegF, this._textbegV);
			this.Mvfldloc(RegexCompiler.s_textendF, this._textendV);
			this.Mvfldloc(RegexCompiler.s_textposF, this._textposV);
			this.Mvfldloc(RegexCompiler.s_trackF, this._trackV);
			this.Mvfldloc(RegexCompiler.s_trackposF, this._trackposV);
			this.Mvfldloc(RegexCompiler.s_stackF, this._stackV);
			this.Mvfldloc(RegexCompiler.s_stackposF, this._stackposV);
			this._backpos = -1;
			for (int i = 0; i < this._codes.Length; i += RegexCode.OpcodeSize(this._codes[i]))
			{
				this.MarkLabel(this._labels[i]);
				this._codepos = i;
				this._regexopcode = this._codes[i];
				this.GenerateOneCode();
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001AA8C File Offset: 0x00018C8C
		private void GenerateMiddleSection()
		{
			this.DefineLabel();
			this.MarkLabel(this._backtrack);
			this.Mvlocfld(this._trackposV, RegexCompiler.s_trackposF);
			this.Mvlocfld(this._stackposV, RegexCompiler.s_stackposF);
			this.Ldthis();
			this.Callvirt(RegexCompiler.s_ensurestorageM);
			this.Mvfldloc(RegexCompiler.s_trackposF, this._trackposV);
			this.Mvfldloc(RegexCompiler.s_stackposF, this._stackposV);
			this.Mvfldloc(RegexCompiler.s_trackF, this._trackV);
			this.Mvfldloc(RegexCompiler.s_stackF, this._stackV);
			this.PopTrack();
			Label[] array = new Label[this._notecount];
			for (int i = 0; i < this._notecount; i++)
			{
				array[i] = this._notes[i]._label;
			}
			this._ilg.Emit(OpCodes.Switch, array);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001AB6C File Offset: 0x00018D6C
		private void GenerateBacktrackSection()
		{
			for (int i = 0; i < this._notecount; i++)
			{
				RegexCompiler.BacktrackNote backtrackNote = this._notes[i];
				if (backtrackNote._flags != 0)
				{
					this._ilg.MarkLabel(backtrackNote._label);
					this._codepos = backtrackNote._codepos;
					this._backpos = i;
					this._regexopcode = (this._codes[backtrackNote._codepos] | backtrackNote._flags);
					this.GenerateOneCode();
				}
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		protected void GenerateFindFirstChar()
		{
			this._textposV = this.DeclareInt();
			this._textV = this.DeclareString();
			this._tempV = this.DeclareInt();
			this._temp2V = this.DeclareInt();
			if ((this._anchors & 53) != 0)
			{
				if (!this._code.RightToLeft)
				{
					if ((this._anchors & 1) != 0)
					{
						Label l = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textbegF);
						this.Ble(l);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Stfld(RegexCompiler.s_textposF);
						this.Ldc(0);
						this.Ret();
						this.MarkLabel(l);
					}
					if ((this._anchors & 4) != 0)
					{
						Label l2 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textstartF);
						this.Ble(l2);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Stfld(RegexCompiler.s_textposF);
						this.Ldc(0);
						this.Ret();
						this.MarkLabel(l2);
					}
					if ((this._anchors & 16) != 0)
					{
						Label l3 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Ldc(1);
						this.Sub();
						this.Bge(l3);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Ldc(1);
						this.Sub();
						this.Stfld(RegexCompiler.s_textposF);
						this.MarkLabel(l3);
					}
					if ((this._anchors & 32) != 0)
					{
						Label l4 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Bge(l4);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Stfld(RegexCompiler.s_textposF);
						this.MarkLabel(l4);
					}
				}
				else
				{
					if ((this._anchors & 32) != 0)
					{
						Label l5 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Bge(l5);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textbegF);
						this.Stfld(RegexCompiler.s_textposF);
						this.Ldc(0);
						this.Ret();
						this.MarkLabel(l5);
					}
					if ((this._anchors & 16) != 0)
					{
						Label l6 = this.DefineLabel();
						Label l7 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Ldc(1);
						this.Sub();
						this.Blt(l6);
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textendF);
						this.Beq(l7);
						this.Ldthisfld(RegexCompiler.s_textF);
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Callvirt(RegexCompiler.s_getcharM);
						this.Ldc(10);
						this.Beq(l7);
						this.MarkLabel(l6);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textbegF);
						this.Stfld(RegexCompiler.s_textposF);
						this.Ldc(0);
						this.Ret();
						this.MarkLabel(l7);
					}
					if ((this._anchors & 4) != 0)
					{
						Label l8 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textstartF);
						this.Bge(l8);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textbegF);
						this.Stfld(RegexCompiler.s_textposF);
						this.Ldc(0);
						this.Ret();
						this.MarkLabel(l8);
					}
					if ((this._anchors & 1) != 0)
					{
						Label l9 = this.DefineLabel();
						this.Ldthisfld(RegexCompiler.s_textposF);
						this.Ldthisfld(RegexCompiler.s_textbegF);
						this.Ble(l9);
						this.Ldthis();
						this.Ldthisfld(RegexCompiler.s_textbegF);
						this.Stfld(RegexCompiler.s_textposF);
						this.MarkLabel(l9);
					}
				}
				this.Ldc(1);
				this.Ret();
				return;
			}
			if (this._bmPrefix != null && this._bmPrefix.NegativeUnicode == null)
			{
				LocalBuilder tempV = this._tempV;
				LocalBuilder tempV2 = this._tempV;
				LocalBuilder temp2V = this._temp2V;
				Label label = this.DefineLabel();
				Label l10 = this.DefineLabel();
				Label l11 = this.DefineLabel();
				Label l12 = this.DefineLabel();
				this.DefineLabel();
				Label l13 = this.DefineLabel();
				int num;
				int index;
				if (!this._code.RightToLeft)
				{
					num = -1;
					index = this._bmPrefix.Pattern.Length - 1;
				}
				else
				{
					num = this._bmPrefix.Pattern.Length;
					index = 0;
				}
				int i = (int)this._bmPrefix.Pattern[index];
				this.Mvfldloc(RegexCompiler.s_textF, this._textV);
				if (!this._code.RightToLeft)
				{
					this.Ldthisfld(RegexCompiler.s_textendF);
				}
				else
				{
					this.Ldthisfld(RegexCompiler.s_textbegF);
				}
				this.Stloc(temp2V);
				this.Ldthisfld(RegexCompiler.s_textposF);
				if (!this._code.RightToLeft)
				{
					this.Ldc(this._bmPrefix.Pattern.Length - 1);
					this.Add();
				}
				else
				{
					this.Ldc(this._bmPrefix.Pattern.Length);
					this.Sub();
				}
				this.Stloc(this._textposV);
				this.Br(l12);
				this.MarkLabel(label);
				if (!this._code.RightToLeft)
				{
					this.Ldc(this._bmPrefix.Pattern.Length);
				}
				else
				{
					this.Ldc(-this._bmPrefix.Pattern.Length);
				}
				this.MarkLabel(l10);
				this.Ldloc(this._textposV);
				this.Add();
				this.Stloc(this._textposV);
				this.MarkLabel(l12);
				this.Ldloc(this._textposV);
				this.Ldloc(temp2V);
				if (!this._code.RightToLeft)
				{
					this.BgeFar(l11);
				}
				else
				{
					this.BltFar(l11);
				}
				this.Rightchar();
				if (this._bmPrefix.CaseInsensitive)
				{
					this.CallToLower();
				}
				this.Dup();
				this.Stloc(tempV);
				this.Ldc(i);
				this.BeqFar(l13);
				this.Ldloc(tempV);
				this.Ldc(this._bmPrefix.LowASCII);
				this.Sub();
				this.Dup();
				this.Stloc(tempV);
				this.Ldc(this._bmPrefix.HighASCII - this._bmPrefix.LowASCII);
				this.Bgtun(label);
				Label[] array = new Label[this._bmPrefix.HighASCII - this._bmPrefix.LowASCII + 1];
				for (int j = this._bmPrefix.LowASCII; j <= this._bmPrefix.HighASCII; j++)
				{
					if (this._bmPrefix.NegativeASCII[j] == num)
					{
						array[j - this._bmPrefix.LowASCII] = label;
					}
					else
					{
						array[j - this._bmPrefix.LowASCII] = this.DefineLabel();
					}
				}
				this.Ldloc(tempV);
				this._ilg.Emit(OpCodes.Switch, array);
				for (int j = this._bmPrefix.LowASCII; j <= this._bmPrefix.HighASCII; j++)
				{
					if (this._bmPrefix.NegativeASCII[j] != num)
					{
						this.MarkLabel(array[j - this._bmPrefix.LowASCII]);
						this.Ldc(this._bmPrefix.NegativeASCII[j]);
						this.BrFar(l10);
					}
				}
				this.MarkLabel(l13);
				this.Ldloc(this._textposV);
				this.Stloc(tempV2);
				for (int j = this._bmPrefix.Pattern.Length - 2; j >= 0; j--)
				{
					Label l14 = this.DefineLabel();
					int num2;
					if (!this._code.RightToLeft)
					{
						num2 = j;
					}
					else
					{
						num2 = this._bmPrefix.Pattern.Length - 1 - j;
					}
					this.Ldloc(this._textV);
					this.Ldloc(tempV2);
					this.Ldc(1);
					this.Sub(this._code.RightToLeft);
					this.Dup();
					this.Stloc(tempV2);
					this.Callvirt(RegexCompiler.s_getcharM);
					if (this._bmPrefix.CaseInsensitive)
					{
						this.CallToLower();
					}
					this.Ldc((int)this._bmPrefix.Pattern[num2]);
					this.Beq(l14);
					this.Ldc(this._bmPrefix.Positive[num2]);
					this.BrFar(l10);
					this.MarkLabel(l14);
				}
				this.Ldthis();
				this.Ldloc(tempV2);
				if (this._code.RightToLeft)
				{
					this.Ldc(1);
					this.Add();
				}
				this.Stfld(RegexCompiler.s_textposF);
				this.Ldc(1);
				this.Ret();
				this.MarkLabel(l11);
				this.Ldthis();
				if (!this._code.RightToLeft)
				{
					this.Ldthisfld(RegexCompiler.s_textendF);
				}
				else
				{
					this.Ldthisfld(RegexCompiler.s_textbegF);
				}
				this.Stfld(RegexCompiler.s_textposF);
				this.Ldc(0);
				this.Ret();
				return;
			}
			if (this._fcPrefix == null)
			{
				this.Ldc(1);
				this.Ret();
				return;
			}
			LocalBuilder temp2V2 = this._temp2V;
			LocalBuilder tempV3 = this._tempV;
			Label l15 = this.DefineLabel();
			Label l16 = this.DefineLabel();
			Label l17 = this.DefineLabel();
			Label l18 = this.DefineLabel();
			Label l19 = this.DefineLabel();
			this.Mvfldloc(RegexCompiler.s_textposF, this._textposV);
			this.Mvfldloc(RegexCompiler.s_textF, this._textV);
			if (!this._code.RightToLeft)
			{
				this.Ldthisfld(RegexCompiler.s_textendF);
				this.Ldloc(this._textposV);
			}
			else
			{
				this.Ldloc(this._textposV);
				this.Ldthisfld(RegexCompiler.s_textbegF);
			}
			this.Sub();
			this.Stloc(temp2V2);
			this.Ldloc(temp2V2);
			this.Ldc(0);
			this.BleFar(l18);
			this.MarkLabel(l15);
			this.Ldloc(temp2V2);
			this.Ldc(1);
			this.Sub();
			this.Stloc(temp2V2);
			if (this._code.RightToLeft)
			{
				this.Leftcharnext();
			}
			else
			{
				this.Rightcharnext();
			}
			if (this._fcPrefix.GetValueOrDefault().CaseInsensitive)
			{
				this.CallToLower();
			}
			if (!RegexCharClass.IsSingleton(this._fcPrefix.GetValueOrDefault().Prefix))
			{
				this.Ldstr(this._fcPrefix.GetValueOrDefault().Prefix);
				this.Call(RegexCompiler.s_charInSetM);
				this.BrtrueFar(l16);
			}
			else
			{
				this.Ldc((int)RegexCharClass.SingletonChar(this._fcPrefix.GetValueOrDefault().Prefix));
				this.Beq(l16);
			}
			this.MarkLabel(l19);
			this.Ldloc(temp2V2);
			this.Ldc(0);
			if (!RegexCharClass.IsSingleton(this._fcPrefix.GetValueOrDefault().Prefix))
			{
				this.BgtFar(l15);
			}
			else
			{
				this.Bgt(l15);
			}
			this.Ldc(0);
			this.BrFar(l17);
			this.MarkLabel(l16);
			this.Ldloc(this._textposV);
			this.Ldc(1);
			this.Sub(this._code.RightToLeft);
			this.Stloc(this._textposV);
			this.Ldc(1);
			this.MarkLabel(l17);
			this.Mvlocfld(this._textposV, RegexCompiler.s_textposF);
			this.Ret();
			this.MarkLabel(l18);
			this.Ldc(0);
			this.Ret();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001B74F File Offset: 0x0001994F
		protected void GenerateInitTrackCount()
		{
			this.Ldthis();
			this.Ldc(this._trackcount);
			this.Stfld(RegexCompiler.s_trackcountF);
			this.Ret();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001B774 File Offset: 0x00019974
		private LocalBuilder DeclareInt()
		{
			return this._ilg.DeclareLocal(typeof(int));
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001B78B File Offset: 0x0001998B
		private LocalBuilder DeclareIntArray()
		{
			return this._ilg.DeclareLocal(typeof(int[]));
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001B7A2 File Offset: 0x000199A2
		private LocalBuilder DeclareString()
		{
			return this._ilg.DeclareLocal(typeof(string));
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001B7BC File Offset: 0x000199BC
		protected void GenerateGo()
		{
			this._textposV = this.DeclareInt();
			this._textV = this.DeclareString();
			this._trackposV = this.DeclareInt();
			this._trackV = this.DeclareIntArray();
			this._stackposV = this.DeclareInt();
			this._stackV = this.DeclareIntArray();
			this._tempV = this.DeclareInt();
			this._temp2V = this.DeclareInt();
			this._temp3V = this.DeclareInt();
			this._textbegV = this.DeclareInt();
			this._textendV = this.DeclareInt();
			this._textstartV = this.DeclareInt();
			this._labels = null;
			this._notes = null;
			this._notecount = 0;
			this._backtrack = this.DefineLabel();
			this.GenerateForwardSection();
			this.GenerateMiddleSection();
			this.GenerateBacktrackSection();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0001B88C File Offset: 0x00019A8C
		private void GenerateOneCode()
		{
			this.Ldthis();
			this.Callvirt(RegexCompiler.s_checkTimeoutM);
			int regexopcode = this._regexopcode;
			if (regexopcode <= 285)
			{
				if (regexopcode <= 164)
				{
					switch (regexopcode)
					{
					case 0:
					case 1:
					case 2:
					case 64:
					case 65:
					case 66:
						goto IL_1438;
					case 3:
					case 4:
					case 5:
					case 67:
					case 68:
					case 69:
						goto IL_1604;
					case 6:
					case 7:
					case 8:
					case 70:
					case 71:
					case 72:
						goto IL_18EF;
					case 9:
					case 10:
					case 11:
					case 73:
					case 74:
					case 75:
						break;
					case 12:
						goto IL_1024;
					case 13:
					case 77:
						goto IL_11F6;
					case 14:
					{
						Label l = this._labels[this.NextCodepos()];
						this.Ldloc(this._textposV);
						this.Ldloc(this._textbegV);
						this.Ble(l);
						this.Leftchar();
						this.Ldc(10);
						this.BneFar(this._backtrack);
						return;
					}
					case 15:
					{
						Label l2 = this._labels[this.NextCodepos()];
						this.Ldloc(this._textposV);
						this.Ldloc(this._textendV);
						this.Bge(l2);
						this.Rightchar();
						this.Ldc(10);
						this.BneFar(this._backtrack);
						return;
					}
					case 16:
					case 17:
						this.Ldthis();
						this.Ldloc(this._textposV);
						this.Ldloc(this._textbegV);
						this.Ldloc(this._textendV);
						this.Callvirt(RegexCompiler.s_isboundaryM);
						if (this.Code() == 16)
						{
							this.BrfalseFar(this._backtrack);
							return;
						}
						this.BrtrueFar(this._backtrack);
						return;
					case 18:
						this.Ldloc(this._textposV);
						this.Ldloc(this._textbegV);
						this.BgtFar(this._backtrack);
						return;
					case 19:
						this.Ldloc(this._textposV);
						this.Ldthisfld(RegexCompiler.s_textstartF);
						this.BneFar(this._backtrack);
						return;
					case 20:
						this.Ldloc(this._textposV);
						this.Ldloc(this._textendV);
						this.Ldc(1);
						this.Sub();
						this.BltFar(this._backtrack);
						this.Ldloc(this._textposV);
						this.Ldloc(this._textendV);
						this.Bge(this._labels[this.NextCodepos()]);
						this.Rightchar();
						this.Ldc(10);
						this.BneFar(this._backtrack);
						return;
					case 21:
						this.Ldloc(this._textposV);
						this.Ldloc(this._textendV);
						this.BltFar(this._backtrack);
						return;
					case 22:
						this.Back();
						return;
					case 23:
						this.PushTrack(this._textposV);
						this.Track();
						return;
					case 24:
					{
						LocalBuilder tempV = this._tempV;
						Label l3 = this.DefineLabel();
						this.PopStack();
						this.Dup();
						this.Stloc(tempV);
						this.PushTrack(tempV);
						this.Ldloc(this._textposV);
						this.Beq(l3);
						this.PushTrack(this._textposV);
						this.PushStack(this._textposV);
						this.Track();
						this.Goto(this.Operand(0));
						this.MarkLabel(l3);
						this.TrackUnique2(5);
						return;
					}
					case 25:
					{
						LocalBuilder tempV2 = this._tempV;
						Label l4 = this.DefineLabel();
						Label l5 = this.DefineLabel();
						Label l6 = this.DefineLabel();
						this.PopStack();
						this.Dup();
						this.Stloc(tempV2);
						this.Ldloc(tempV2);
						this.Ldc(-1);
						this.Beq(l5);
						this.PushTrack(tempV2);
						this.Br(l6);
						this.MarkLabel(l5);
						this.PushTrack(this._textposV);
						this.MarkLabel(l6);
						this.Ldloc(this._textposV);
						this.Beq(l4);
						this.PushTrack(this._textposV);
						this.Track();
						this.Br(this.AdvanceLabel());
						this.MarkLabel(l4);
						this.ReadyPushStack();
						this.Ldloc(tempV2);
						this.DoPush();
						this.TrackUnique2(6);
						return;
					}
					case 26:
						this.ReadyPushStack();
						this.Ldc(-1);
						this.DoPush();
						this.ReadyPushStack();
						this.Ldc(this.Operand(0));
						this.DoPush();
						this.TrackUnique(1);
						return;
					case 27:
						this.PushStack(this._textposV);
						this.ReadyPushStack();
						this.Ldc(this.Operand(0));
						this.DoPush();
						this.TrackUnique(1);
						return;
					case 28:
					{
						LocalBuilder tempV3 = this._tempV;
						LocalBuilder temp2V = this._temp2V;
						Label l7 = this.DefineLabel();
						Label l8 = this.DefineLabel();
						this.PopStack();
						this.Stloc(tempV3);
						this.PopStack();
						this.Dup();
						this.Stloc(temp2V);
						this.PushTrack(temp2V);
						this.Ldloc(this._textposV);
						this.Bne(l7);
						this.Ldloc(tempV3);
						this.Ldc(0);
						this.Bge(l8);
						this.MarkLabel(l7);
						this.Ldloc(tempV3);
						this.Ldc(this.Operand(1));
						this.Bge(l8);
						this.PushStack(this._textposV);
						this.ReadyPushStack();
						this.Ldloc(tempV3);
						this.Ldc(1);
						this.Add();
						this.DoPush();
						this.Track();
						this.Goto(this.Operand(0));
						this.MarkLabel(l8);
						this.PushTrack(tempV3);
						this.TrackUnique2(7);
						return;
					}
					case 29:
					{
						LocalBuilder tempV4 = this._tempV;
						LocalBuilder temp2V2 = this._temp2V;
						Label l9 = this.DefineLabel();
						this.DefineLabel();
						Label[] labels = this._labels;
						this.NextCodepos();
						this.PopStack();
						this.Stloc(tempV4);
						this.PopStack();
						this.Stloc(temp2V2);
						this.Ldloc(tempV4);
						this.Ldc(0);
						this.Bge(l9);
						this.PushTrack(temp2V2);
						this.PushStack(this._textposV);
						this.ReadyPushStack();
						this.Ldloc(tempV4);
						this.Ldc(1);
						this.Add();
						this.DoPush();
						this.TrackUnique2(8);
						this.Goto(this.Operand(0));
						this.MarkLabel(l9);
						this.PushTrack(temp2V2);
						this.PushTrack(tempV4);
						this.PushTrack(this._textposV);
						this.Track();
						return;
					}
					case 30:
						this.ReadyPushStack();
						this.Ldc(-1);
						this.DoPush();
						this.TrackUnique(0);
						return;
					case 31:
						this.PushStack(this._textposV);
						this.TrackUnique(0);
						return;
					case 32:
						if (this.Operand(1) != -1)
						{
							this.Ldthis();
							this.Ldc(this.Operand(1));
							this.Callvirt(RegexCompiler.s_ismatchedM);
							this.BrfalseFar(this._backtrack);
						}
						this.PopStack();
						this.Stloc(this._tempV);
						if (this.Operand(1) != -1)
						{
							this.Ldthis();
							this.Ldc(this.Operand(0));
							this.Ldc(this.Operand(1));
							this.Ldloc(this._tempV);
							this.Ldloc(this._textposV);
							this.Callvirt(RegexCompiler.s_transferM);
						}
						else
						{
							this.Ldthis();
							this.Ldc(this.Operand(0));
							this.Ldloc(this._tempV);
							this.Ldloc(this._textposV);
							this.Callvirt(RegexCompiler.s_captureM);
						}
						this.PushTrack(this._tempV);
						if (this.Operand(0) != -1 && this.Operand(1) != -1)
						{
							this.TrackUnique(4);
							return;
						}
						this.TrackUnique(3);
						return;
					case 33:
						this.ReadyPushTrack();
						this.PopStack();
						this.Dup();
						this.Stloc(this._textposV);
						this.DoPush();
						this.Track();
						return;
					case 34:
						this.ReadyPushStack();
						this.Ldthisfld(RegexCompiler.s_trackF);
						this.Ldlen();
						this.Ldloc(this._trackposV);
						this.Sub();
						this.DoPush();
						this.ReadyPushStack();
						this.Ldthis();
						this.Callvirt(RegexCompiler.s_crawlposM);
						this.DoPush();
						this.TrackUnique(1);
						return;
					case 35:
					{
						Label l10 = this.DefineLabel();
						Label l11 = this.DefineLabel();
						this.PopStack();
						this.Ldthisfld(RegexCompiler.s_trackF);
						this.Ldlen();
						this.PopStack();
						this.Sub();
						this.Stloc(this._trackposV);
						this.Dup();
						this.Ldthis();
						this.Callvirt(RegexCompiler.s_crawlposM);
						this.Beq(l11);
						this.MarkLabel(l10);
						this.Ldthis();
						this.Callvirt(RegexCompiler.s_uncaptureM);
						this.Dup();
						this.Ldthis();
						this.Callvirt(RegexCompiler.s_crawlposM);
						this.Bne(l10);
						this.MarkLabel(l11);
						this.Pop();
						this.Back();
						return;
					}
					case 36:
						this.PopStack();
						this.Stloc(this._tempV);
						this.Ldthisfld(RegexCompiler.s_trackF);
						this.Ldlen();
						this.PopStack();
						this.Sub();
						this.Stloc(this._trackposV);
						this.PushTrack(this._tempV);
						this.TrackUnique(9);
						return;
					case 37:
						this.Ldthis();
						this.Ldc(this.Operand(0));
						this.Callvirt(RegexCompiler.s_ismatchedM);
						this.BrfalseFar(this._backtrack);
						return;
					case 38:
						this.Goto(this.Operand(0));
						return;
					case 39:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 50:
					case 51:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
					case 58:
					case 59:
					case 60:
					case 61:
					case 62:
					case 63:
						goto IL_1AE4;
					case 40:
						this.Mvlocfld(this._textposV, RegexCompiler.s_textposF);
						this.Ret();
						return;
					case 41:
					case 42:
						this.Ldthis();
						this.Ldloc(this._textposV);
						this.Ldloc(this._textbegV);
						this.Ldloc(this._textendV);
						this.Callvirt(RegexCompiler.s_isECMABoundaryM);
						if (this.Code() == 41)
						{
							this.BrfalseFar(this._backtrack);
							return;
						}
						this.BrtrueFar(this._backtrack);
						return;
					case 76:
						goto IL_110B;
					default:
						switch (regexopcode)
						{
						case 131:
						case 132:
						case 133:
							goto IL_184F;
						case 134:
						case 135:
						case 136:
							goto IL_19D9;
						case 137:
						case 138:
						case 139:
						case 140:
						case 141:
						case 142:
						case 143:
						case 144:
						case 145:
						case 146:
						case 147:
						case 148:
						case 149:
						case 150:
						case 163:
							goto IL_1AE4;
						case 151:
							this.PopTrack();
							this.Stloc(this._textposV);
							this.Goto(this.Operand(0));
							return;
						case 152:
							this.PopTrack();
							this.Stloc(this._textposV);
							this.PopStack();
							this.Pop();
							this.TrackUnique2(5);
							this.Advance();
							return;
						case 153:
							this.PopTrack();
							this.Stloc(this._textposV);
							this.PushStack(this._textposV);
							this.TrackUnique2(6);
							this.Goto(this.Operand(0));
							return;
						case 154:
						case 155:
							this.PopDiscardStack(2);
							this.Back();
							return;
						case 156:
						{
							LocalBuilder tempV5 = this._tempV;
							Label l12 = this.DefineLabel();
							this.PopStack();
							this.Ldc(1);
							this.Sub();
							this.Dup();
							this.Stloc(tempV5);
							this.Ldc(0);
							this.Blt(l12);
							this.PopStack();
							this.Stloc(this._textposV);
							this.PushTrack(tempV5);
							this.TrackUnique2(7);
							this.Advance();
							this.MarkLabel(l12);
							this.ReadyReplaceStack(0);
							this.PopTrack();
							this.DoReplace();
							this.PushStack(tempV5);
							this.Back();
							return;
						}
						case 157:
						{
							Label l13 = this.DefineLabel();
							LocalBuilder tempV6 = this._tempV;
							this.PopTrack();
							this.Stloc(this._textposV);
							this.PopTrack();
							this.Dup();
							this.Stloc(tempV6);
							this.Ldc(this.Operand(1));
							this.Bge(l13);
							this.Ldloc(this._textposV);
							this.TopTrack();
							this.Beq(l13);
							this.PushStack(this._textposV);
							this.ReadyPushStack();
							this.Ldloc(tempV6);
							this.Ldc(1);
							this.Add();
							this.DoPush();
							this.TrackUnique2(8);
							this.Goto(this.Operand(0));
							this.MarkLabel(l13);
							this.ReadyPushStack();
							this.PopTrack();
							this.DoPush();
							this.PushStack(tempV6);
							this.Back();
							return;
						}
						case 158:
						case 159:
							this.PopDiscardStack();
							this.Back();
							return;
						case 160:
							this.ReadyPushStack();
							this.PopTrack();
							this.DoPush();
							this.Ldthis();
							this.Callvirt(RegexCompiler.s_uncaptureM);
							if (this.Operand(0) != -1 && this.Operand(1) != -1)
							{
								this.Ldthis();
								this.Callvirt(RegexCompiler.s_uncaptureM);
							}
							this.Back();
							return;
						case 161:
							this.ReadyPushStack();
							this.PopTrack();
							this.DoPush();
							this.Back();
							return;
						case 162:
							this.PopDiscardStack(2);
							this.Back();
							return;
						case 164:
						{
							Label l14 = this.DefineLabel();
							Label l15 = this.DefineLabel();
							this.PopTrack();
							this.Dup();
							this.Ldthis();
							this.Callvirt(RegexCompiler.s_crawlposM);
							this.Beq(l15);
							this.MarkLabel(l14);
							this.Ldthis();
							this.Callvirt(RegexCompiler.s_uncaptureM);
							this.Dup();
							this.Ldthis();
							this.Callvirt(RegexCompiler.s_crawlposM);
							this.Bne(l14);
							this.MarkLabel(l15);
							this.Pop();
							this.Back();
							return;
						}
						default:
							goto IL_1AE4;
						}
						break;
					}
				}
				else
				{
					if (regexopcode - 195 <= 2)
					{
						goto IL_184F;
					}
					if (regexopcode - 198 <= 2)
					{
						goto IL_19D9;
					}
					switch (regexopcode)
					{
					case 280:
						this.ReadyPushStack();
						this.PopTrack();
						this.DoPush();
						this.Back();
						return;
					case 281:
						this.ReadyReplaceStack(0);
						this.PopTrack();
						this.DoReplace();
						this.Back();
						return;
					case 282:
					case 283:
						goto IL_1AE4;
					case 284:
						this.PopTrack();
						this.Stloc(this._tempV);
						this.ReadyPushStack();
						this.PopTrack();
						this.DoPush();
						this.PushStack(this._tempV);
						this.Back();
						return;
					case 285:
						this.ReadyReplaceStack(1);
						this.PopTrack();
						this.DoReplace();
						this.ReadyReplaceStack(0);
						this.TopStack();
						this.Ldc(1);
						this.Sub();
						this.DoReplace();
						this.Back();
						return;
					default:
						goto IL_1AE4;
					}
				}
			}
			else if (regexopcode <= 645)
			{
				switch (regexopcode)
				{
				case 512:
				case 513:
				case 514:
					goto IL_1438;
				case 515:
				case 516:
				case 517:
					goto IL_1604;
				case 518:
				case 519:
				case 520:
					goto IL_18EF;
				case 521:
				case 522:
				case 523:
					break;
				case 524:
					goto IL_1024;
				case 525:
					goto IL_11F6;
				default:
					switch (regexopcode)
					{
					case 576:
					case 577:
					case 578:
						goto IL_1438;
					case 579:
					case 580:
					case 581:
						goto IL_1604;
					case 582:
					case 583:
					case 584:
						goto IL_18EF;
					case 585:
					case 586:
					case 587:
						break;
					case 588:
						goto IL_110B;
					case 589:
						goto IL_11F6;
					default:
						if (regexopcode - 643 > 2)
						{
							goto IL_1AE4;
						}
						goto IL_184F;
					}
					break;
				}
			}
			else
			{
				if (regexopcode - 646 <= 2)
				{
					goto IL_19D9;
				}
				if (regexopcode - 707 <= 2)
				{
					goto IL_184F;
				}
				if (regexopcode - 710 > 2)
				{
					goto IL_1AE4;
				}
				goto IL_19D9;
			}
			this.Ldloc(this._textposV);
			if (!this.IsRtl())
			{
				this.Ldloc(this._textendV);
				this.BgeFar(this._backtrack);
				this.Rightcharnext();
			}
			else
			{
				this.Ldloc(this._textbegV);
				this.BleFar(this._backtrack);
				this.Leftcharnext();
			}
			if (this.IsCi())
			{
				this.CallToLower();
			}
			if (this.Code() == 11)
			{
				this.Ldstr(this._strings[this.Operand(0)]);
				this.Call(RegexCompiler.s_charInSetM);
				this.BrfalseFar(this._backtrack);
				return;
			}
			this.Ldc(this.Operand(0));
			if (this.Code() == 9)
			{
				this.BneFar(this._backtrack);
				return;
			}
			this.BeqFar(this._backtrack);
			return;
			IL_1024:
			string text = this._strings[this.Operand(0)];
			this.Ldc(text.Length);
			this.Ldloc(this._textendV);
			this.Ldloc(this._textposV);
			this.Sub();
			this.BgtFar(this._backtrack);
			for (int i = 0; i < text.Length; i++)
			{
				this.Ldloc(this._textV);
				this.Ldloc(this._textposV);
				if (i != 0)
				{
					this.Ldc(i);
					this.Add();
				}
				this.Callvirt(RegexCompiler.s_getcharM);
				if (this.IsCi())
				{
					this.CallToLower();
				}
				this.Ldc((int)text[i]);
				this.BneFar(this._backtrack);
			}
			this.Ldloc(this._textposV);
			this.Ldc(text.Length);
			this.Add();
			this.Stloc(this._textposV);
			return;
			IL_110B:
			string text2 = this._strings[this.Operand(0)];
			this.Ldc(text2.Length);
			this.Ldloc(this._textposV);
			this.Ldloc(this._textbegV);
			this.Sub();
			this.BgtFar(this._backtrack);
			int j = text2.Length;
			while (j > 0)
			{
				j--;
				this.Ldloc(this._textV);
				this.Ldloc(this._textposV);
				this.Ldc(text2.Length - j);
				this.Sub();
				this.Callvirt(RegexCompiler.s_getcharM);
				if (this.IsCi())
				{
					this.CallToLower();
				}
				this.Ldc((int)text2[j]);
				this.BneFar(this._backtrack);
			}
			this.Ldloc(this._textposV);
			this.Ldc(text2.Length);
			this.Sub();
			this.Stloc(this._textposV);
			return;
			IL_11F6:
			LocalBuilder tempV7 = this._tempV;
			LocalBuilder temp2V3 = this._temp2V;
			Label l16 = this.DefineLabel();
			this.Ldthis();
			this.Ldc(this.Operand(0));
			this.Callvirt(RegexCompiler.s_ismatchedM);
			if ((this._options & RegexOptions.ECMAScript) != RegexOptions.None)
			{
				this.Brfalse(this.AdvanceLabel());
			}
			else
			{
				this.BrfalseFar(this._backtrack);
			}
			this.Ldthis();
			this.Ldc(this.Operand(0));
			this.Callvirt(RegexCompiler.s_matchlengthM);
			this.Dup();
			this.Stloc(tempV7);
			if (!this.IsRtl())
			{
				this.Ldloc(this._textendV);
				this.Ldloc(this._textposV);
			}
			else
			{
				this.Ldloc(this._textposV);
				this.Ldloc(this._textbegV);
			}
			this.Sub();
			this.BgtFar(this._backtrack);
			this.Ldthis();
			this.Ldc(this.Operand(0));
			this.Callvirt(RegexCompiler.s_matchindexM);
			if (!this.IsRtl())
			{
				this.Ldloc(tempV7);
				this.Add(this.IsRtl());
			}
			this.Stloc(temp2V3);
			this.Ldloc(this._textposV);
			this.Ldloc(tempV7);
			this.Add(this.IsRtl());
			this.Stloc(this._textposV);
			this.MarkLabel(l16);
			this.Ldloc(tempV7);
			this.Ldc(0);
			this.Ble(this.AdvanceLabel());
			this.Ldloc(this._textV);
			this.Ldloc(temp2V3);
			this.Ldloc(tempV7);
			if (this.IsRtl())
			{
				this.Ldc(1);
				this.Sub();
				this.Dup();
				this.Stloc(tempV7);
			}
			this.Sub(this.IsRtl());
			this.Callvirt(RegexCompiler.s_getcharM);
			if (this.IsCi())
			{
				this.CallToLower();
			}
			this.Ldloc(this._textV);
			this.Ldloc(this._textposV);
			this.Ldloc(tempV7);
			if (!this.IsRtl())
			{
				this.Dup();
				this.Ldc(1);
				this.Sub();
				this.Stloc(tempV7);
			}
			this.Sub(this.IsRtl());
			this.Callvirt(RegexCompiler.s_getcharM);
			if (this.IsCi())
			{
				this.CallToLower();
			}
			this.Beq(l16);
			this.Back();
			return;
			IL_1438:
			LocalBuilder tempV8 = this._tempV;
			Label l17 = this.DefineLabel();
			int num = this.Operand(1);
			if (num == 0)
			{
				return;
			}
			this.Ldc(num);
			if (!this.IsRtl())
			{
				this.Ldloc(this._textendV);
				this.Ldloc(this._textposV);
			}
			else
			{
				this.Ldloc(this._textposV);
				this.Ldloc(this._textbegV);
			}
			this.Sub();
			this.BgtFar(this._backtrack);
			this.Ldloc(this._textposV);
			this.Ldc(num);
			this.Add(this.IsRtl());
			this.Stloc(this._textposV);
			this.Ldc(num);
			this.Stloc(tempV8);
			this.MarkLabel(l17);
			this.Ldloc(this._textV);
			this.Ldloc(this._textposV);
			this.Ldloc(tempV8);
			if (this.IsRtl())
			{
				this.Ldc(1);
				this.Sub();
				this.Dup();
				this.Stloc(tempV8);
				this.Add();
			}
			else
			{
				this.Dup();
				this.Ldc(1);
				this.Sub();
				this.Stloc(tempV8);
				this.Sub();
			}
			this.Callvirt(RegexCompiler.s_getcharM);
			if (this.IsCi())
			{
				this.CallToLower();
			}
			if (this.Code() == 2)
			{
				this.Ldstr(this._strings[this.Operand(0)]);
				this.Call(RegexCompiler.s_charInSetM);
				this.BrfalseFar(this._backtrack);
			}
			else
			{
				this.Ldc(this.Operand(0));
				if (this.Code() == 0)
				{
					this.BneFar(this._backtrack);
				}
				else
				{
					this.BeqFar(this._backtrack);
				}
			}
			this.Ldloc(tempV8);
			this.Ldc(0);
			if (this.Code() == 2)
			{
				this.BgtFar(l17);
				return;
			}
			this.Bgt(l17);
			return;
			IL_1604:
			LocalBuilder tempV9 = this._tempV;
			LocalBuilder temp2V4 = this._temp2V;
			Label l18 = this.DefineLabel();
			Label l19 = this.DefineLabel();
			int num2 = this.Operand(1);
			if (num2 != 0)
			{
				if (!this.IsRtl())
				{
					this.Ldloc(this._textendV);
					this.Ldloc(this._textposV);
				}
				else
				{
					this.Ldloc(this._textposV);
					this.Ldloc(this._textbegV);
				}
				this.Sub();
				if (num2 != 2147483647)
				{
					Label l20 = this.DefineLabel();
					this.Dup();
					this.Ldc(num2);
					this.Blt(l20);
					this.Pop();
					this.Ldc(num2);
					this.MarkLabel(l20);
				}
				this.Dup();
				this.Stloc(temp2V4);
				this.Ldc(1);
				this.Add();
				this.Stloc(tempV9);
				this.MarkLabel(l18);
				this.Ldloc(tempV9);
				this.Ldc(1);
				this.Sub();
				this.Dup();
				this.Stloc(tempV9);
				this.Ldc(0);
				if (this.Code() == 5)
				{
					this.BleFar(l19);
				}
				else
				{
					this.Ble(l19);
				}
				if (this.IsRtl())
				{
					this.Leftcharnext();
				}
				else
				{
					this.Rightcharnext();
				}
				if (this.IsCi())
				{
					this.CallToLower();
				}
				if (this.Code() == 5)
				{
					this.Ldstr(this._strings[this.Operand(0)]);
					this.Call(RegexCompiler.s_charInSetM);
					this.BrtrueFar(l18);
				}
				else
				{
					this.Ldc(this.Operand(0));
					if (this.Code() == 3)
					{
						this.Beq(l18);
					}
					else
					{
						this.Bne(l18);
					}
				}
				this.Ldloc(this._textposV);
				this.Ldc(1);
				this.Sub(this.IsRtl());
				this.Stloc(this._textposV);
				this.MarkLabel(l19);
				this.Ldloc(temp2V4);
				this.Ldloc(tempV9);
				this.Ble(this.AdvanceLabel());
				this.ReadyPushTrack();
				this.Ldloc(temp2V4);
				this.Ldloc(tempV9);
				this.Sub();
				this.Ldc(1);
				this.Sub();
				this.DoPush();
				this.ReadyPushTrack();
				this.Ldloc(this._textposV);
				this.Ldc(1);
				this.Sub(this.IsRtl());
				this.DoPush();
				this.Track();
				return;
			}
			return;
			IL_184F:
			this.PopTrack();
			this.Stloc(this._textposV);
			this.PopTrack();
			this.Stloc(this._tempV);
			this.Ldloc(this._tempV);
			this.Ldc(0);
			this.BleFar(this.AdvanceLabel());
			this.ReadyPushTrack();
			this.Ldloc(this._tempV);
			this.Ldc(1);
			this.Sub();
			this.DoPush();
			this.ReadyPushTrack();
			this.Ldloc(this._textposV);
			this.Ldc(1);
			this.Sub(this.IsRtl());
			this.DoPush();
			this.Trackagain();
			this.Advance();
			return;
			IL_18EF:
			LocalBuilder tempV10 = this._tempV;
			int num3 = this.Operand(1);
			if (num3 != 0)
			{
				if (!this.IsRtl())
				{
					this.Ldloc(this._textendV);
					this.Ldloc(this._textposV);
				}
				else
				{
					this.Ldloc(this._textposV);
					this.Ldloc(this._textbegV);
				}
				this.Sub();
				if (num3 != 2147483647)
				{
					Label l21 = this.DefineLabel();
					this.Dup();
					this.Ldc(num3);
					this.Blt(l21);
					this.Pop();
					this.Ldc(num3);
					this.MarkLabel(l21);
				}
				this.Dup();
				this.Stloc(tempV10);
				this.Ldc(0);
				this.Ble(this.AdvanceLabel());
				this.ReadyPushTrack();
				this.Ldloc(tempV10);
				this.Ldc(1);
				this.Sub();
				this.DoPush();
				this.PushTrack(this._textposV);
				this.Track();
				return;
			}
			return;
			IL_19D9:
			this.PopTrack();
			this.Stloc(this._textposV);
			this.PopTrack();
			this.Stloc(this._temp2V);
			if (!this.IsRtl())
			{
				this.Rightcharnext();
			}
			else
			{
				this.Leftcharnext();
			}
			if (this.IsCi())
			{
				this.CallToLower();
			}
			if (this.Code() == 8)
			{
				this.Ldstr(this._strings[this.Operand(0)]);
				this.Call(RegexCompiler.s_charInSetM);
				this.BrfalseFar(this._backtrack);
			}
			else
			{
				this.Ldc(this.Operand(0));
				if (this.Code() == 6)
				{
					this.BneFar(this._backtrack);
				}
				else
				{
					this.BeqFar(this._backtrack);
				}
			}
			this.Ldloc(this._temp2V);
			this.Ldc(0);
			this.BleFar(this.AdvanceLabel());
			this.ReadyPushTrack();
			this.Ldloc(this._temp2V);
			this.Ldc(1);
			this.Sub();
			this.DoPush();
			this.PushTrack(this._textposV);
			this.Trackagain();
			this.Advance();
			return;
			IL_1AE4:
			throw new NotImplementedException("Unimplemented state.");
		}

		// Token: 0x04000302 RID: 770
		private static FieldInfo s_textbegF = RegexCompiler.RegexRunnerField("runtextbeg");

		// Token: 0x04000303 RID: 771
		private static FieldInfo s_textendF = RegexCompiler.RegexRunnerField("runtextend");

		// Token: 0x04000304 RID: 772
		private static FieldInfo s_textstartF = RegexCompiler.RegexRunnerField("runtextstart");

		// Token: 0x04000305 RID: 773
		private static FieldInfo s_textposF = RegexCompiler.RegexRunnerField("runtextpos");

		// Token: 0x04000306 RID: 774
		private static FieldInfo s_textF = RegexCompiler.RegexRunnerField("runtext");

		// Token: 0x04000307 RID: 775
		private static FieldInfo s_trackposF = RegexCompiler.RegexRunnerField("runtrackpos");

		// Token: 0x04000308 RID: 776
		private static FieldInfo s_trackF = RegexCompiler.RegexRunnerField("runtrack");

		// Token: 0x04000309 RID: 777
		private static FieldInfo s_stackposF = RegexCompiler.RegexRunnerField("runstackpos");

		// Token: 0x0400030A RID: 778
		private static FieldInfo s_stackF = RegexCompiler.RegexRunnerField("runstack");

		// Token: 0x0400030B RID: 779
		private static FieldInfo s_trackcountF = RegexCompiler.RegexRunnerField("runtrackcount");

		// Token: 0x0400030C RID: 780
		private static MethodInfo s_ensurestorageM = RegexCompiler.RegexRunnerMethod("EnsureStorage");

		// Token: 0x0400030D RID: 781
		private static MethodInfo s_captureM = RegexCompiler.RegexRunnerMethod("Capture");

		// Token: 0x0400030E RID: 782
		private static MethodInfo s_transferM = RegexCompiler.RegexRunnerMethod("TransferCapture");

		// Token: 0x0400030F RID: 783
		private static MethodInfo s_uncaptureM = RegexCompiler.RegexRunnerMethod("Uncapture");

		// Token: 0x04000310 RID: 784
		private static MethodInfo s_ismatchedM = RegexCompiler.RegexRunnerMethod("IsMatched");

		// Token: 0x04000311 RID: 785
		private static MethodInfo s_matchlengthM = RegexCompiler.RegexRunnerMethod("MatchLength");

		// Token: 0x04000312 RID: 786
		private static MethodInfo s_matchindexM = RegexCompiler.RegexRunnerMethod("MatchIndex");

		// Token: 0x04000313 RID: 787
		private static MethodInfo s_isboundaryM = RegexCompiler.RegexRunnerMethod("IsBoundary");

		// Token: 0x04000314 RID: 788
		private static MethodInfo s_isECMABoundaryM;

		// Token: 0x04000315 RID: 789
		private static MethodInfo s_chartolowerM;

		// Token: 0x04000316 RID: 790
		private static MethodInfo s_getcharM;

		// Token: 0x04000317 RID: 791
		private static MethodInfo s_crawlposM;

		// Token: 0x04000318 RID: 792
		private static MethodInfo s_charInSetM = RegexCompiler.RegexRunnerMethod("CharInClass");

		// Token: 0x04000319 RID: 793
		private static MethodInfo s_getCurrentCulture;

		// Token: 0x0400031A RID: 794
		private static MethodInfo s_getInvariantCulture;

		// Token: 0x0400031B RID: 795
		private static MethodInfo s_checkTimeoutM;

		// Token: 0x0400031C RID: 796
		protected ILGenerator _ilg;

		// Token: 0x0400031D RID: 797
		private LocalBuilder _textstartV;

		// Token: 0x0400031E RID: 798
		private LocalBuilder _textbegV;

		// Token: 0x0400031F RID: 799
		private LocalBuilder _textendV;

		// Token: 0x04000320 RID: 800
		private LocalBuilder _textposV;

		// Token: 0x04000321 RID: 801
		private LocalBuilder _textV;

		// Token: 0x04000322 RID: 802
		private LocalBuilder _trackposV;

		// Token: 0x04000323 RID: 803
		private LocalBuilder _trackV;

		// Token: 0x04000324 RID: 804
		private LocalBuilder _stackposV;

		// Token: 0x04000325 RID: 805
		private LocalBuilder _stackV;

		// Token: 0x04000326 RID: 806
		private LocalBuilder _tempV;

		// Token: 0x04000327 RID: 807
		private LocalBuilder _temp2V;

		// Token: 0x04000328 RID: 808
		private LocalBuilder _temp3V;

		// Token: 0x04000329 RID: 809
		protected RegexCode _code;

		// Token: 0x0400032A RID: 810
		protected int[] _codes;

		// Token: 0x0400032B RID: 811
		protected string[] _strings;

		// Token: 0x0400032C RID: 812
		protected RegexPrefix? _fcPrefix;

		// Token: 0x0400032D RID: 813
		protected RegexBoyerMoore _bmPrefix;

		// Token: 0x0400032E RID: 814
		protected int _anchors;

		// Token: 0x0400032F RID: 815
		private Label[] _labels;

		// Token: 0x04000330 RID: 816
		private RegexCompiler.BacktrackNote[] _notes;

		// Token: 0x04000331 RID: 817
		private int _notecount;

		// Token: 0x04000332 RID: 818
		protected int _trackcount;

		// Token: 0x04000333 RID: 819
		private Label _backtrack;

		// Token: 0x04000334 RID: 820
		private int _regexopcode;

		// Token: 0x04000335 RID: 821
		private int _codepos;

		// Token: 0x04000336 RID: 822
		private int _backpos;

		// Token: 0x04000337 RID: 823
		protected RegexOptions _options;

		// Token: 0x04000338 RID: 824
		private int[] _uniquenote;

		// Token: 0x04000339 RID: 825
		private int[] _goto;

		// Token: 0x020000AC RID: 172
		private sealed class BacktrackNote
		{
			// Token: 0x060004CE RID: 1230 RVA: 0x0001D388 File Offset: 0x0001B588
			public BacktrackNote(int flags, Label label, int codepos)
			{
				this._codepos = codepos;
				this._flags = flags;
				this._label = label;
			}

			// Token: 0x0400033A RID: 826
			internal int _codepos;

			// Token: 0x0400033B RID: 827
			internal int _flags;

			// Token: 0x0400033C RID: 828
			internal Label _label;
		}
	}
}
