using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MysticOracle.Services;
using System;
using System.Linq;

namespace MysticOracle.Pages;

public class IndexModel : PageModel
{
    private readonly FortuneService _fortuneService;
    //[BindProperty] tells ASP.NET to bind the html input with
    //matching "name" to this C# property
    [BindProperty]
    public string Name { get; set; } = string.Empty;

    // This property will hold the result for the HTML to display
    // We *don't* bind it, because the user isn't sending it.
    public string CurrentFortune { get; set; } = string.Empty;

    // This is "Constructor Injection"
    // ASP.NET "injects" the registered FortuneService for us
    public IndexModel(FortuneService fortuneService)
    {
        _fortuneService = fortuneService;
    }
    
    //this method runs when the form is posted(submitted)
    public void OnPost()
    {
        // Names that trigger the "too hot" special state. Comparison is
        // case-insensitive and trims surrounding whitespace.
        var hotNames = new[] { "Gaya", "Valentine", "Valentine Gaya", "Len", "Wang'Pala", "Wang'pala" };

        // Check for invalid input
        if (string.IsNullOrWhiteSpace(Name))
        {
            ViewData["State"] = "shake-invalid"; // A state for bad input
            return;
        }

        // Normalize and check if the provided name matches any hot name (case-insensitive)
        var trimmed = Name.Trim();
        if (hotNames.Any(h => string.Equals(trimmed, h, StringComparison.OrdinalIgnoreCase)))
        {
            // set the flirty state and message
            ViewData["State"] = "shake-hot";
            ViewData["SpecialMessage"] = $"{Name} is too hot! 🥵System cooling down...please wait... ";
        }
        else
        {
            // Normal user
            ViewData["State"] = "normal";
        }

        CurrentFortune = _fortuneService.GetRandomFortune();
    }

    // this runs when the page is first loaded
    public void OnGet()
    {

    }
}
