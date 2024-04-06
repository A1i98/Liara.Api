namespace Liara.Api.Types;

public class User
{
    [JsonProperty("fullname")] public string Fullname { get; set; }

    [JsonProperty("nationalCode")] public string NationalCode { get; set; }

    [JsonProperty("email")] public string Email { get; set; }

    [JsonProperty("phone")] public string Phone { get; set; }

    [JsonProperty("joined_at")] public DateTime? JoinedAt { get; set; }

    [JsonProperty("balance")] public double? Balance { get; set; }

    [JsonProperty("hasPassword")] public bool? HasPassword { get; set; }

    [JsonProperty("minCreditAmount")] public int? MinCreditAmount { get; set; }

    [JsonProperty("emailVerifiedAt")] public DateTime? EmailVerifiedAt { get; set; }

    [JsonProperty("phoneVerifiedAt")] public DateTime? PhoneVerifiedAt { get; set; }

    [JsonProperty("accountType")] public string AccountType { get; set; }

    [JsonProperty("isVerified")] public bool? IsVerified { get; set; }

    [JsonProperty("storage")] public Storage Storage { get; set; }

    [JsonProperty("avatar")] public string Avatar { get; set; }

    [JsonProperty("legacyNetworkFeature")] public bool? LegacyNetworkFeature { get; set; }

    [JsonProperty("privateNetworkFeature")]
    public bool? PrivateNetworkFeature { get; set; }

    [JsonProperty("legacyObjectStorageFeature")]
    public bool? LegacyObjectStorageFeature { get; set; }

    [JsonProperty("legacyDomainsFeature")] public bool? LegacyDomainsFeature { get; set; }
}