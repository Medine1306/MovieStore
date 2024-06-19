using MovieStore.Models.Domain;

namespace MovieStore.Models.DTO
{
    public class MovieListVm
    {
        public IQueryable<Movie> MovieList{ get; set; }
    }
}
