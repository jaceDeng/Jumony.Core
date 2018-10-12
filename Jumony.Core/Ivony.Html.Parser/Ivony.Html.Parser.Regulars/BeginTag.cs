using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class BeginTag : Regex
	{
		public BeginTag()
		{
			base.pattern = "\\G<(?<tagName>[A-Za-z][A-Za-z0-9\\-_:\\.]*)(?<attributes>([^=]|(?>=\\w*'[^']*')|(?>=\\w*\"[^\"]*\")|=)*?)(?<selfClosed>/)?>$";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new BeginTagFactory4();
			base.capnames = new Hashtable();
			base.capnames.Add("tagName", 1);
			base.capnames.Add("0", 0);
			base.capnames.Add("attributes", 2);
			base.capnames.Add("selfClosed", 3);
			base.capslist = new string[4];
			base.capslist[0] = "0";
			base.capslist[1] = "tagName";
			base.capslist[2] = "attributes";
			base.capslist[3] = "selfClosed";
			base.capsize = 4;
			base.InitializeReferences();
		}
	}
}
