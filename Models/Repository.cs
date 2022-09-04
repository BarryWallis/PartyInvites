namespace PartyInvites.Models;

/// <summary>
/// The repository of guest responses.
/// </summary>
public static class Repository
{
    private static readonly List<GuestResponse> _guestResponses = new();
    /// <value>The list of guest responses.</value>
    public static IEnumerable<GuestResponse> GuestResponses => _guestResponses;

    public static void AddResponse(GuestResponse guestResponse)
    {
        Console.WriteLine(guestResponse);

        _guestResponses.Add(guestResponse);
    }
}
