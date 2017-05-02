using System.Collections.Generic;

namespace RA.Enums
{
    public class HeaderType 
    {
        public static readonly HeaderType ContentType = new HeaderType("Content-Type", "Content Type");
        public static readonly HeaderType Accept = new HeaderType("Accept", "Accept");
        public static readonly HeaderType AcceptEncoding = new HeaderType("Accept-Encoding", "Accept Encoding");
        public static readonly HeaderType AcceptCharset = new HeaderType("Accept-Charset", "Accept Charset");

        public static IEnumerable<HeaderType> All => new List<HeaderType>
        {
            ContentType,
            Accept,
            AcceptEncoding,
            AcceptCharset
        };

        private HeaderType(string value, string displayName)
        {
            Value = value;
            DisplayName = displayName;
        }

        public string Value { get; }

        public string DisplayName { get; }
    }
}
