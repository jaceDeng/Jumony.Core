using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class TagName : Regex
	{
		public TagName()
		{
			base.pattern = "^(?<tagName>[A-Za-z][A-Za-z0-9\\-_:\\.]*)$";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new TagNameFactory1();
			base.capnames = new Hashtable();
			base.capnames.Add("tagName", 1);
			base.capnames.Add("0", 0);
			base.capslist = new string[2];
			base.capslist[0] = "0";
			base.capslist[1] = "tagName";
			base.capsize = 2;
			base.InitializeReferences();
		}
	}
}
