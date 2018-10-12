using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class TagNameRunner1 : RegexRunner
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
			int num4;
			if (num <= runtextbeg)
			{
				runstack[--runstackpos] = num;
				runtrack[--runtrackpos] = 1;
				if (num < runtextend && RegexRunner.CharInClass(runtext[num++], "\0\u0004\0A[a{"))
				{
					int num3;
					num4 = (num3 = runtextend - num) + 1;
					while (--num4 > 0)
					{
						if (RegexRunner.CharInClass(runtext[num++], "\0\n\0-/0;A[_`a{"))
						{
							continue;
						}
						num--;
						break;
					}
					if (num3 > num4)
					{
						runtrack[--runtrackpos] = num3 - num4 - 1;
						runtrack[--runtrackpos] = num - 1;
						runtrack[--runtrackpos] = 2;
					}
					goto IL_0134;
				}
			}
			goto IL_01bf;
			IL_0231:
			num = runtrack[runtrackpos++];
			num4 = runtrack[runtrackpos++];
			if (num4 > 0)
			{
				runtrack[--runtrackpos] = num4 - 1;
				runtrack[--runtrackpos] = num - 1;
				runtrack[--runtrackpos] = 2;
			}
			goto IL_0134;
			IL_0134:
			num4 = runstack[runstackpos++];
			Capture(1, num4, num);
			runtrack[--runtrackpos] = num4;
			runtrack[--runtrackpos] = 3;
			if (num >= runtextend - 1 && (num >= runtextend || runtext[num] == '\n'))
			{
				num4 = runstack[runstackpos++];
				Capture(0, num4, num);
				runtrack[--runtrackpos] = num4;
				runtrack[--runtrackpos] = 3;
				goto IL_01b6;
			}
			goto IL_01bf;
			IL_01bf:
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
					goto IL_0231;
				case 3:
					runstack[--runstackpos] = runtrack[runtrackpos++];
					Uncapture();
					continue;
				}
				break;
			}
			num = runtrack[runtrackpos++];
			goto IL_01b6;
			IL_01b6:
			base.runtextpos = num;
		}

        protected override bool FindFirstChar()
		{
			if (base.runtextpos > base.runtextbeg)
			{
				base.runtextpos = base.runtextend;
				return false;
			}
			return true;
		}

        protected override void InitTrackCount()
		{
			base.runtrackcount = 6;
		}
	}
}
