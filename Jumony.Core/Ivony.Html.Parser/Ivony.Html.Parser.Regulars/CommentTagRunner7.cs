using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class CommentTagRunner7 : RegexRunner
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
			if (runtextpos == base.runtextstart && 4 <= runtextend - runtextpos && runtext[runtextpos] == '<' && runtext[runtextpos + 1] == '!' && runtext[runtextpos + 2] == '-' && runtext[runtextpos + 3] == '-')
			{
				runtextpos += 4;
				runstack[--runstackpos] = runtextpos;
				runtrack[--runtrackpos] = 1;
				runstack[--runstackpos] = -1;
				runtrack[--runtrackpos] = 1;
				goto IL_013d;
			}
			goto IL_0252;
			IL_0252:
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
					goto IL_02c8;
				case 3:
					runstack[runstackpos] = runtrack[runtrackpos++];
					continue;
				case 4:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				}
				break;
				IL_02c8:
				runtextpos = runtrack[runtrackpos++];
				runstack[--runstackpos] = runtextpos;
				runtrack[--runtrackpos] = 3;
				if (runtrackpos > 28 && runstackpos > 21)
				{
					if (runtextpos < runtextend && RegexRunner.CharInClass(runtext[runtextpos++], "\0\u0001\0\0"))
					{
						goto IL_013d;
					}
				}
				else
				{
					runtrack[--runtrackpos] = 5;
				}
			}
			runtextpos = runtrack[runtrackpos++];
			goto IL_0249;
			IL_0249:
			base.runtextpos = runtextpos;
			return;
			IL_013d:
			int num8;
			int num9 = num8 = runstack[runstackpos++];
			if (num8 != -1)
			{
				runtrack[--runtrackpos] = num8;
			}
			else
			{
				runtrack[--runtrackpos] = runtextpos;
			}
			if (num9 != runtextpos)
			{
				runtrack[--runtrackpos] = runtextpos;
				runtrack[--runtrackpos] = 2;
			}
			else
			{
				runstack[--runstackpos] = num8;
				runtrack[--runtrackpos] = 3;
			}
			num8 = runstack[runstackpos++];
			Capture(1, num8, runtextpos);
			runtrack[--runtrackpos] = num8;
			runtrack[--runtrackpos] = 4;
			if (3 <= runtextend - runtextpos && runtext[runtextpos] == '-' && runtext[runtextpos + 1] == '-' && runtext[runtextpos + 2] == '>')
			{
				runtextpos += 3;
				num8 = runstack[runstackpos++];
				Capture(0, num8, runtextpos);
				runtrack[--runtrackpos] = num8;
				runtrack[--runtrackpos] = 4;
				goto IL_0249;
			}
			goto IL_0252;
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
