using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class HtmlTag : Regex
	{
		public HtmlTag()
		{
			base.pattern = "\\G(?<tag>\\<.+?\\>)";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new HtmlTagFactory9();
			base.capnames = new Hashtable();
			base.capnames.Add("tag", 1);
			base.capnames.Add("0", 0);
			base.capslist = new string[2];
			base.capslist[0] = "0";
			base.capslist[1] = "tag";
			base.capsize = 2;
			base.InitializeReferences();
		}
	}
}
