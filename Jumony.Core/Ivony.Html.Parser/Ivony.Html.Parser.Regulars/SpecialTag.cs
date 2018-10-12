using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class SpecialTag : Regex
	{
		public SpecialTag()
		{
			base.pattern = "\\G<(?<symbol>[\\?\\%\\#\\$])(?<specialText>.*?)\\k<symbol>>";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new SpecialTagFactory8();
			base.capnames = new Hashtable();
			base.capnames.Add("0", 0);
			base.capnames.Add("symbol", 1);
			base.capnames.Add("specialText", 2);
			base.capslist = new string[3];
			base.capslist[0] = "0";
			base.capslist[1] = "symbol";
			base.capslist[2] = "specialText";
			base.capsize = 3;
			base.InitializeReferences();
		}
	}
}
