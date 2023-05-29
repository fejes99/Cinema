using Cinema.Application.Common.Users.Dtos;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Models;

public class TokenRequestModel
{
    public string userId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string username { get; set; }
    public DateTime created { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string role { get; set; }
}
