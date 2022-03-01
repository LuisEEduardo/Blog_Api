namespace Blog
{
    public static class Configuration
    {
        // Chave send-grid : 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

        public static string JwtKey = "c32a8882c8504ee9a7bbfb39c4a1ceac";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_4d7084b0-5d47-4bbf-b463-9437e712883b";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
