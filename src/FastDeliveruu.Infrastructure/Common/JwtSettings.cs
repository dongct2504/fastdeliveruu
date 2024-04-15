namespace FastDeliveruu.Infrastructure.Common;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";

    public string Secret { get; set; } = null!;

    public int ExpiryMinutes { get; set; }

    public int EmailConfirmationExpiryMinutes { get; set; }

    public string Issuer { get; set; } = null!;

    public string Audience { get; set; } = null!;
}