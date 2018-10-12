using System.Globalization;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class DoctypeDeclarationRunner6 : RegexRunner
	{
		protected override void Go()
		{
			string runtext = base.runtext;
			int runtextstart = base.runtextstart;
			int runtextbeg = base.runtextbeg;
			int runtextend = base.runtextend;
			int runtextpos = base.runtextpos;
			int[] runtrack = base.runtrack;
			int runtrackpos = base.runtrackpos;
			int[] runstack = base.runstack;
			int runstackpos = base.runstackpos;
			runtrack[--runtrackpos] = runtextpos;
			runtrack[--runtrackpos] = 0;
			runstack[--runstackpos] = runtextpos;
			runtrack[--runtrackpos] = 1;
			int num;
			if (runtextpos == base.runtextstart && 2 <= runtextend - runtextpos && runtext[runtextpos] == '<' && runtext[runtextpos + 1] == '!')
			{
				runtextpos += 2;
				if (7 <= runtextend - runtextpos && char.ToLower(runtext[runtextpos], CultureInfo.InvariantCulture) == 'd' && char.ToLower(runtext[runtextpos + 1], CultureInfo.InvariantCulture) == 'o' && char.ToLower(runtext[runtextpos + 2], CultureInfo.InvariantCulture) == 'c' && char.ToLower(runtext[runtextpos + 3], CultureInfo.InvariantCulture) == 't' && char.ToLower(runtext[runtextpos + 4], CultureInfo.InvariantCulture) == 'y' && char.ToLower(runtext[runtextpos + 5], CultureInfo.InvariantCulture) == 'p' && char.ToLower(runtext[runtextpos + 6], CultureInfo.InvariantCulture) == 'e')
				{
					runtextpos += 7;
					if (1 <= runtextend - runtextpos)
					{
						runtextpos++;
						num = 1;
						while (true)
						{
							if (!RegexRunner.CharInClass(runtext[runtextpos - num--], "\0\0\u0001d"))
							{
								break;
							}
							if (num > 0)
							{
								continue;
							}
							goto IL_01d7;
						}
					}
				}
			}
			goto IL_0340;
			IL_0296:
			num = runstack[runstackpos++];
			Capture(1, num, runtextpos);
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 4;
			if (runtextpos < runtextend && runtext[runtextpos++] == '>' && runtextpos >= runtextend - 1 && (runtextpos >= runtextend || runtext[runtextpos] == '\n'))
			{
				num = runstack[runstackpos++];
				Capture(0, num, runtextpos);
				runtrack[--runtrackpos] = num;
				runtrack[--runtrackpos] = 4;
				goto IL_0337;
			}
			goto IL_0340;
			IL_01d7:
			int num6;
			num = (num6 = runtextend - runtextpos) + 1;
			while (--num > 0)
			{
				if (RegexRunner.CharInClass(runtext[runtextpos++], "\0\0\u0001d"))
				{
					continue;
				}
				runtextpos--;
				break;
			}
			if (num6 > num)
			{
				runtrack[--runtrackpos] = num6 - num - 1;
				runtrack[--runtrackpos] = runtextpos - 1;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_024b;
			IL_0340:
			while (true)
			{
				base.runtrackpos = runtrackpos;
				base.runstackpos = runstackpos;
				EnsureStorage();
				runtrackpos = base.runtrackpos;
				runstackpos = base.runstackpos;
				runtrack = base.runtrack;
				runstack = base.runstack;
				switch (runtrack[runtrackpos++])
				{
				case 1:
					runstackpos++;
					continue;
				case 2:
					goto IL_03b6;
				case 3:
					goto IL_0406;
				case 4:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				}
				break;
				IL_0406:
				runtextpos = runtrack[runtrackpos++];
				num6 = runtrack[runtrackpos++];
				if (!RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0001\0\0"))
				{
					continue;
				}
				goto IL_043c;
			}
			runtextpos = runtrack[runtrackpos++];
			goto IL_0337;
			IL_024b:
			runstack[--runstackpos] = runtextpos;
			runtrack[--runtrackpos] = 1;
			if ((num = runtextend - runtextpos) > 0)
			{
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = runtextpos;
				runtrack[--runtrackpos] = 3;
			}
			goto IL_0296;
			IL_03b6:
			runtextpos = runtrack[runtrackpos++];
			num = runtrack[runtrackpos++];
			if (num > 0)
			{
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = runtextpos - 1;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_024b;
			IL_0337:
			base.runtextpos = runtextpos;
			return;
			IL_043c:
			if (num6 > 0)
			{
				runtrack[--runtrackpos] = num6 - 1;
				runtrack[--runtrackpos] = runtextpos;
				runtrack[--runtrackpos] = 3;
			}
			goto IL_0296;
		}

        protected override bool FindFirstChar()
		{
			if (base.runtextpos > base.runtextstart)
			{
				base.runtextpos = base.runtextend;
				return false;
			}
			return true;
		}

        protected override void InitTrackCount()
		{
			base.runtrackcount = 7;
		}
	}
}
