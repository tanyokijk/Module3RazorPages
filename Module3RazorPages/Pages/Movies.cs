using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace Module3RazorPages.Pages;

public class MoviesModel : PageModel
{
    private readonly IDataService<Movie> _movieService;

    public MoviesModel(IDataService<Movie> movieService)
    {
        _movieService = movieService;
        Movies = _movieService.GetAll();
    }

    public List<Movie> Movies = null;

    public void OnGet(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            Movies = _movieService.GetAll();
            RedirectToPage();
        }
        else
        {
            OnGetSearch(text);
        }
     }

    public void OnGetSearch(string text)
    {
        text = text.ToLower();

        List<Movie> searchResults = new List<Movie>();

        foreach (var movie in Movies)
        {
            string nameLower = movie.Name.ToLower();
            string descriptionLower = movie.Description.ToLower();
            string producerLower = movie.Producer.ToLower();

            if (nameLower == text || nameLower.Contains(text) ||
                descriptionLower == text || descriptionLower.Contains(text) ||
                producerLower == text || producerLower.Contains(text))
            {
                searchResults.Add(movie);
            }

            foreach (var style in movie.Styles)
            {
                string styleLower = style.Name.ToLower();

                if (styleLower == text || styleLower.Contains(text))
                {
                    searchResults.Add(movie);
                    break;
                }
            }
        }

        if (searchResults.Count > 0)
        {
            Movies = searchResults;
        }
        else
        {
            Movies = new List<Movie>();
            TempData["Message"] = "Результатів пошуку не знайдено.";
        }

        RedirectToPage();
    }
}
