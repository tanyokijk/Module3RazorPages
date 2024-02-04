namespace Entities;
public class Movie
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Producer { get; set; }

    public string Description { get; set; }

    public string? Photo { get; set; }

    public List<Style>? Styles { get; set; }

    public List<Session>? Sessions { get; set; }
}
