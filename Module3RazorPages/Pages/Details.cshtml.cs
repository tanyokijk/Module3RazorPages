using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace Module3RazorPages.Pages;

public class DetailsModel : PageModel
{
    private readonly IDataService<Movie> _movieService;

    public Movie Movie { get; set; }

    public DetailsModel(IDataService<Movie> movieService)
    {
        _movieService = movieService;
    }

    public void OnGet(int id)
    {
        Movie = _movieService.GetById(id);
    }
}
