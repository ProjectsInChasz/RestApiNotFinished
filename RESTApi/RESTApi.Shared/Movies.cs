using System;
using System.Collections.Generic;
using System.Text;

namespace RESTApi
{
  public class MovieCategory
  {
    public int Id { get; set; }
    public string CategoryName { get; set; }
  }

  public class MovieActor
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }

    public string Name
    {
      get { return FirstName + " " + SurName; }
    }

    public string BirthDate { get; set; }
  }

  public class Movie
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public string ReleaseYear { get; set; }
    public string Description { get; set; }
    public string PosterUrl { get; set; }
    public List<MovieCategory> MovieCategories { get; set; }
    public List<MovieActor> MovieActors { get; set; }

    public string Categories
    {
      get
      {
        string pom = "";
        foreach (var movieCategory in MovieCategories)
        {
          pom += movieCategory.CategoryName + ", ";
        }
        return pom;
      }
    }
  }
}
