using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class EndTagRunner5 : RegexRunner
	{
        protected override void Go()
		{
			string runtext = base.runtext;
			int runtextstart = base.runtextstart;
			int runtextbeg = base.runtextbeg;
			int runtextend = base.runtextend;
			int num = base.runtextpos;
			int[] runtrack = base.runtrack;
			int runtrackpos = base.runtrackpos;
			int[] runstack = base.runstack;
			int runstackpos = base.runstackpos;
			runtrack[--runtrackpos] = num;
			runtrack[--runtrackpos] = 0;
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			if (num == base.runtextstart && 2 <= runtextend - num && runtext[num] == '<' && runtext[num + 1] == '/')
			{
				num += 2;
				runstack[--runstackpos] = -1;
				runstack[--runstackpos] = 0;
				runtrack[--runtrackpos] = 2;
				goto IL_01c7;
			}
			goto IL_033b;
			IL_025b:
			int num2;
			int num3 = (num2 = runtextend - num) + 1;
			while (--num3 > 0)
			{
				if (runtext[num++] != '>')
				{
					continue;
				}
				num--;
				break;
			}
			if (num2 > num3)
			{
				runtrack[--runtrackpos] = num2 - num3 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 8;
			}
			goto IL_02c1;
			IL_03cd:
			num = runtrack[runtrackpos++];
			num3 = runtrack[runtrackpos++];
			if (num3 > 0)
			{
				runtrack[--runtrackpos] = num3 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 3;
			}
			goto IL_0197;
			IL_0332:
			base.runtextpos = num;
			return;
			IL_0197:
			num3 = runstack[runstackpos++];
			Capture(1, num3, num);
			runtrack[--runtrackpos] = num3;
			runtrack[--runtrackpos] = 4;
			goto IL_01c7;
			IL_033b:
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
				case 6:
					break;
				default:
					goto IL_03a4;
				case 1:
					runstackpos++;
					continue;
				case 2:
					runstackpos += 2;
					continue;
				case 3:
					goto IL_03cd;
				case 4:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				case 5:
					goto IL_043c;
				case 7:
					num3 = runtrack[runtrackpos++];
					runstack[--runstackpos] = runtrack[runtrackpos++];
					runstack[--runstackpos] = num3;
					continue;
				case 8:
					goto IL_04ca;
				}
				break;
				IL_043c:
				if ((num3 = runstack[runstackpos++] - 1) >= 0)
				{
					goto IL_0450;
				}
				runstack[runstackpos] = runtrack[runtrackpos++];
				runstack[--runstackpos] = num3;
			}
			goto IL_00e4;
			IL_04ca:
			num = runtrack[runtrackpos++];
			num3 = runtrack[runtrackpos++];
			if (num3 > 0)
			{
				runtrack[--runtrackpos] = num3 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 8;
			}
			goto IL_02c1;
			IL_01c7:
			num3 = runstack[runstackpos++];
			int num18 = num2 = runstack[runstackpos++];
			runtrack[--runtrackpos] = num2;
			if ((num18 != num || num3 < 0) && num3 < 1)
			{
				runstack[--runstackpos] = num;
				runstack[--runstackpos] = num3 + 1;
				runtrack[--runtrackpos] = 5;
				if (runtrackpos > 40 && runstackpos > 30)
				{
					goto IL_00e4;
				}
				runtrack[--runtrackpos] = 6;
				goto IL_033b;
			}
			runtrack[--runtrackpos] = num3;
			runtrack[--runtrackpos] = 7;
			goto IL_025b;
			IL_00e4:
			runstack[--runstackpos] = num;
			runtrack[--runtrackpos] = 1;
			if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\u0004\0A[a{"))
			{
				num3 = (num2 = runtextend - num) + 1;
				while (--num3 > 0)
				{
					if (RegexRunner.CharInClass(runtext[num++], "\0\n\0-/0;A[_`a{"))
					{
						continue;
					}
					num--;
					break;
				}
				if (num2 > num3)
				{
					runtrack[--runtrackpos] = num2 - num3 - 1;
					runtrack[--runtrackpos] = num - 1;
					runtrack[--runtrackpos] = 3;
				}
				goto IL_0197;
			}
			goto IL_033b;
			IL_03a4:
			num = runtrack[runtrackpos++];
			goto IL_0332;
			IL_0450:
			num = runstack[runstackpos++];
			runtrack[--runtrackpos] = num3;
			runtrack[--runtrackpos] = 7;
			goto IL_025b;
			IL_02c1:
			if (num < runtextend && runtext[num++] == '>' && num >= runtextend - 1 && (num >= runtextend || runtext[num] == '\n'))
			{
				num3 = runstack[runstackpos++];
				Capture(0, num3, num);
				runtrack[--runtrackpos] = num3;
				runtrack[--runtrackpos] = 4;
				goto IL_0332;
			}
			goto IL_033b;
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
			base.runtrackcount = 10;
		}
	}
}
