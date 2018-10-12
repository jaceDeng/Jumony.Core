using System.Collections;
using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	public class DoctypeDeclaration : Regex
	{
		public DoctypeDeclaration()
		{
			base.pattern = "\\G(<!(?i:DOCTYPE)\\s+(?<declaration>.*?)>)$";
			base.roptions = (RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
			base.factory = new DoctypeDeclarationFactory6();
			base.capnames = new Hashtable();
			base.capnames.Add("0", 0);
			base.capnames.Add("declaration", 1);
			base.capslist = new string[2];
			base.capslist[0] = "0";
			base.capslist[1] = "declaration";
			base.capsize = 2;
			base.InitializeReferences();
		}
	}
}
