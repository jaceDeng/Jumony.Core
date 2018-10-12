using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class Attribute : Regex
	{
		public Attribute()
		{
			base.pattern = "(\\G|\\s)(?<attribute>(?<attrName>[\\w:_\\-]+)((\\s*=\\s*(('(?<attrValue>[^']*)')|(\"(?<attrValue>[^\"]*)\")|(?<attrValue>([^'\"\\s][^\\s]*)?(?=\\s|$))))|(?=\\s|$)))";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new AttributeFactory3();
			base.capnames = new Hashtable();
			base.capnames.Add("attrName", 2);
			base.capnames.Add("0", 0);
			base.capnames.Add("attribute", 1);
			base.capnames.Add("attrValue", 3);
			base.capslist = new string[4];
			base.capslist[0] = "0";
			base.capslist[1] = "attribute";
			base.capslist[2] = "attrName";
			base.capslist[3] = "attrValue";
			base.capsize = 4;
			base.InitializeReferences();
		}
	}
}
