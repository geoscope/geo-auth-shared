namespace geo_auth_shared.Models
{
    public class AppSettings
    {
        public string JwtSharedSecret { get; set; }
        public string SystemPasswordSalt { get; set; }
        public string SystemVerificationSalt { get; set; }
        public bool JwtValidateAudience { get; set; }
        public bool JwtValidateIssuer { get; set; }
        public bool JwtValidateLifetime { get; set; }
        public string CacheHost { get; set; }
        public string CacheInstanceName { get; set; }
        public int AuthExpiryHours { get; set; }
        public int DefaultCacheMinutes { get; set; }
        public long DefaultStoreId { get; set; }
        public int StoreHostNameCacheMinutes { get; set; }
    }
}