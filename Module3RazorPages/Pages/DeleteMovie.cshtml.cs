using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

namespace Module3RazorPages.Pages;

public class DeleteMovieModel : PageModel
{
    private readonly IDataService<Movie> _movieService;

    public DeleteMovieModel(IDataService<Movie> movieService)
    {
        _movieService = movieService;
    }

    public void OnGet(int id)
    {
        if (id != 0)
        {
            OnGetDeleteMovie(id);
        }
    }

    public void OnGetDeleteMovie(int id)
    {
        this._movieService.Delete(id);
        TempData["MessageDelete"] = "Фільм видалено";
    }
}
