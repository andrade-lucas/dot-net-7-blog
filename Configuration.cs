namespace Blog;

public static class Configuration
{
    public static string JwtKey = "RXJDJWNrM3Z9KF0qWCtwb0krcjw4TTI4M0ErXTVweUo=";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "6Tj0Mn2wL#&8";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
