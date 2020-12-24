using System.Text.RegularExpressions;

namespace Parser.Parsers
{
    public class PathSegmentModel
    {
        private static Regex TestParam = new Regex(@"^\s*{(.*)}\s*$", RegexOptions.Compiled);
        public PathSegmentModel(string segment)
        {
            var match = TestParam.Match(segment);
            if (match.Success)
            {
                IsParameter = true;
                Value = match.Groups[1].Value;
            }
            else
            {
                Value = segment;
            }
        }
        public string Value { get; }

        public bool IsParameter { get; }
    }
}


