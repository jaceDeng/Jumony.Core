using System.Text.RegularExpressions;

namespace Ivony.Html.Parser.Regulars
{
	internal class BeginTagFactory4 : RegexRunnerFactory
	{
		protected override RegexRunner CreateInstance()
		{
			return new BeginTagRunner4();
		}
	}
}
