using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class CommentTag : Regex
	{
		public CommentTag()
		{
			base.pattern = "\\G<!--(?<commentText>(.|\\n)*?)-->";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new CommentTagFactory7();
			base.capnames = new Hashtable();
			base.capnames.Add("0", 0);
			base.capnames.Add("commentText", 1);
			base.capslist = new string[2];
			base.capslist[0] = "0";
			base.capslist[1] = "commentText";
			base.capsize = 2;
			base.InitializeReferences();
		}
	}
}
