using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models;

/// <summary>
/// A response from an invited party guest.
/// </summary>
/// <param name="Name">The guest's name.</param>
/// <param name="Email">The guest's email address,</param>
/// <param name="Phone">The guests phone number.</param>
/// <param name="WillAttend">
/// <see langword="true"/> if the guest will attend; 
/// otherwise <see langword="false"/>.
/// </param>
public record GuestResponse(
    [Required(ErrorMessage = "Please enter your name")] string? Name,
    [EmailAddress] string? Email,
    [Required(ErrorMessage = "Please enter your phone number")] string? Phone,
    [Required(ErrorMessage = "Please specify whether you will attemd")] bool? WillAttend)
{
}
