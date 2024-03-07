using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace Module3RazorPages.Pages;

public class UpdateModel : PageModel
{
    public List<Style> AllStyles;
    private readonly IDataService<Movie> _movieService;

    public UpdateModel(IDataService<Movie> movieService)
    {
        _movieService = movieService;
        AllStyles = SeedData.GetInitialStyles();
    }

    public void OnGet(int id, string? name, string? producer, string? description, string? photo)
    {
        string[] selectedStylesString = Request.Query["styles"].ToArray();
        if (id == 0)
        {
            TempData["MessageUpdate"] = "Заповніть всі поля.";
        }
        else
        {
            List<Style> selectedStyles = AllStyles.Where(style => selectedStylesString.Contains(style.Name)).ToList();
            OnGetAddMovie(id, name, producer, description, photo, selectedStyles);
        }
    }

    public void OnGetAddMovie(int id, string? name, string? producer, string? description, string? photo, List<Style> selectedStyles)
    {
        var movie = _movieService.GetById(id);
        if (!string.IsNullOrEmpty(name))
            movie.Name = name;
        if (!string.IsNullOrEmpty(producer))
            movie.Producer = producer;
        if (!string.IsNullOrEmpty(description))
            movie.Description = description;
        if (!string.IsNullOrEmpty(photo))
            movie.Photo = photo;
        if (selectedStyles.Count != 0)
            movie.Styles = selectedStyles;

        _movieService.Update(movie);
        TempData["MessageUpdate"] = "Фільм оновлено";
    }
}