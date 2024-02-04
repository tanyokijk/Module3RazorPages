using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace Module3RazorPages.Pages;

public class MoviesModel : PageModel
{
    private readonly IDataService<Movie> _movieService;

    public List<Movie> Movies { get; set; }

    public MoviesModel(IDataService<Movie> movieService)
    {
        _movieService = movieService;
    }

    public void OnGet()
    {
        Movies = _movieService.GetAll();
    }
}
