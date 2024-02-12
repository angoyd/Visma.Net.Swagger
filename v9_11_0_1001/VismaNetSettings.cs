using System;

namespace VismaNetIntegrations.v9_11_0_1001
{
    public class VismaNetSettings
    {
        public string Token { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public string ApplicationName { get; set; }
        public DateTimeOffset? tokenExpires { get; set; }
        public string ClientID { get; set; } 
        public string ClientSecret { get; set; }
        public string tenantId { get; set; }
    }
}