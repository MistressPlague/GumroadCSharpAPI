using System;
using System.Collections.Generic;

namespace Plague.Gumroad
{
    public class GetSalesParams : QueryMap
    {
        public DateTime? After { get; set; }
        public DateTime? Before { get; set; }
        public string Email { get; set; }
        public int Page { get; set; } = 0;

        public override IDictionary<string, string> CreateQueryMap()
        {
            var dict = new Dictionary<string, string>();
            if (After != null) dict["after"] = ((DateTime)After).ToString("yyyy-MM-dd");
            if (Before != null) dict["before"] = ((DateTime)Before).ToString("yyyy-MM-dd");
            if (!string.IsNullOrWhiteSpace(Email)) dict["email"] = Email;
            dict["page"] = Page.ToString();
            return dict;
        }
    }
}
