namespace ConfigurationProvider.Models
{
    public class SecurityMetaData
    {
        internal readonly object KeySettings;

        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
        public Boolean IsLocked { get; set; }
        public Boolean IsEnabled { get; set; }
    }
}
