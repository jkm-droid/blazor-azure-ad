using Newtonsoft.Json;

namespace AzureAdDemo.Client.Models;

public class UserInfoResponse
{
    [JsonProperty("mail")]
    public string Mail { get; set; }
    [JsonProperty("mailNickname")]
    public string MailNickname { get; set; }
    [JsonProperty("createdDateTime")]
    public string CreatedDateTime { get; set; }
    [JsonProperty("userPrincipalName")]
    public string UserPrincipalName { get; set; }
    [JsonProperty("displayName")]
    public string DisplayName { get; set; }
}