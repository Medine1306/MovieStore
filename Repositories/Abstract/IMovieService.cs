using MovieStore.Models.Domain;
using MovieStore.Models.DTO;

namespace MovieStore.Repositories.Abstract
{
	public interface IMovieService
	{
		bool Add(Movie model);
        bool Update(Movie model);
        Movie GetById(int id);
        bool Delete(int id);
        MovieListVm List();
        bool Update(Genre model);
    }
}
