using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace Module3RazorPages.Pages;

public class AddModel : PageModel
{
    public List<Style> AllStyles;
    private readonly IDataService<Movie> _movieService;

    public AddModel(IDataService<Movie> movieService)
    {
        _movieService = movieService;
        AllStyles = SeedData.GetInitialStyles();
    }

    public void OnGet(string name, string producer, string description, string? photo)
    {
        string[] selectedStylesString = Request.Query["styles"].ToArray();
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(producer) || string.IsNullOrWhiteSpace(description) || selectedStylesString.Length == 0)
        {
            TempData["MessageAdd"] = "Заповніть всі поля.";
        }
        else
        {
            List<Style> selectedStyles = AllStyles.Where(style => selectedStylesString.Contains(style.Name)).ToList();
            OnGetAddMovie(name, producer, description, photo,  selectedStyles);
        }
    }

    public void OnGetAddMovie(string name, string producer, string description, string? photo, List<Style> selectedStyles)
    {
        var movie = new Movie { Id = _movieService.GetAll().Last().Id + 1, Name = name, Description = description, Producer = producer, Styles = selectedStyles };
        if (photo != null)
        {
            movie.Photo = photo;
        }

        this._movieService.Add(movie);
        TempData["MessageAdd"] = "Фільм додано";
    }
}
