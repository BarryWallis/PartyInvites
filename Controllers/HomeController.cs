using Microsoft.AspNetCore.Mvc;

using PartyInvites.Models;

namespace PartyInvites.Controllers;
public class HomeController : Controller
{
    /// <summary>
    /// Show the home page.
    /// </summary>
    /// <returns>The result of showing the page.</returns>
    public IActionResult Index() => View();

    /// <summary>
    /// Show the RSVP form.
    /// </summary>
    /// <returns>The result of showing the RSVP form.</returns>
    [HttpGet]
    public ViewResult RsvpForm() => View();

    /// <summary>
    /// Store the guest's response.
    /// </summary>
    /// <param name="guestResponse">The guest's information and response.</param>
    /// <returns>
    /// The Thanks view if all the fields are valid; otherwise the RsvpForm showing the errors.
    /// </returns>
    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse); // TODO: Store response from guest 
        }
        else
        {
            return View();
        }
    }

    /// <summary>
    /// Show a list of people who will be coming to the party.
    /// </summary>
    /// <returns>A view with the list of people coming to the party.</returns>
    public ViewResult ListResponses()
        => View(Repository.GuestResponses.Where(gr => gr.WillAttend is true));
}
