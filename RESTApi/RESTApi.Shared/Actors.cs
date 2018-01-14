using System;
using System.Collections.Generic;
using System.Text;

namespace RESTApi
{
  public class ActorsMovy
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public string ReleaseYear { get; set; }
    public string Description { get; set; }
    public int DirectorId { get; set; }
  }

  public class Actors
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string PhotoUrl { get; set; }
    public string BirthDate { get; set; }
    public List<ActorsMovy> ActorsMovies { get; set; }
  }
}
