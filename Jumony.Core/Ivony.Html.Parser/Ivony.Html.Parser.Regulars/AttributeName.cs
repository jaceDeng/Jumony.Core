using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class AttributeName : Regex
	{
		public AttributeName()
		{
			base.pattern = "^(?<attrName>[\\w:_\\-]+)$";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new AttributeNameFactory2();
			base.capnames = new Hashtable();
			base.capnames.Add("attrName", 1);
			base.capnames.Add("0", 0);
			base.capslist = new string[2];
			base.capslist[0] = "0";
			base.capslist[1] = "attrName";
			base.capsize = 2;
			base.InitializeReferences();
		}
	}
}
