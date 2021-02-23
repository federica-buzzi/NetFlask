using NetFlask.DAL.Repositories;
using NetFlask.Entities;
using NetFlask.Models;
using Netflask_again.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Repositories
{
    // alias du DataContext
    public class UnitOfWork
    {
        IConcreteRepository<MovieEntity> _movieRepo;
        IConcreteRepository<GenreEntity> _genreRepo;
        IConcreteRepository<CrewEntity> _crewRepo;
        IConcreteRepository<MessageEntity> _messageRepository; 

        public UnitOfWork(string connectionString)
        {
            _movieRepo = new MovieRepository(connectionString);
            _genreRepo = new GenreRepository(connectionString);
            _crewRepo = new CrewRepository(connectionString);
            _messageRepository = new MessageRepository(connectionString); 
        }


        #region Movies
        public HeaderMovie GetHeaderMovie()
        {
            //Instanciation de mon repo
            //for Movie 
            MovieEntity movieFromDB = _movieRepo.GetOne(330457);
            //for Genre 
            List<GenreEntity> genresFromDB = ((GenreRepository)_genreRepo).GetFromMovie(330457);
            string genres = " "; 
            foreach (GenreEntity item in genresFromDB)
            {
                genres += item.Label + ", "; 
            }
            genres = genres.Substring(0, genres.Length - 2); 

            // for Crew
            List<CrewEntity> DirectorsFromDB = ((CrewRepository)_crewRepo).GetDirectors(330457);
            string directors = "";
            foreach (CrewEntity item in DirectorsFromDB)
            {
                directors += item.FirstName + " " + item.LastName + ", "; 
            }
            directors = directors.Substring(0, directors.Length - 2); 

            //Mapping de l'entity vers le model
            HeaderMovie movieForController = new HeaderMovie();
            movieForController.Title = movieFromDB.Title; 
            movieForController.Age = "All Age";
            movieForController.Director = directors;
            movieForController.Rating = movieFromDB.Rating;
            movieForController.CriticsRating = movieFromDB.CriticsRating; 
            movieForController.Genre = genres ;
            movieForController.Release = movieFromDB.ReleaseDate.Value; //new DateTime(2014, 11, 7);
            movieForController.Description = movieFromDB.ShortDescription; //"The special bond that develops between plus-sized inflatable robot Baymax, and prodigy Hiro Hamada, who team up with a group of friends to form a band of high-tech heroes.";
            movieForController.VideoLink = movieFromDB.Trailer; //"#";
            movieForController.BigPicture = "https://www.themoviedb.org/t/p/original" + movieFromDB.Picture;

            return movieForController; 

        }
        #endregion

        public List<Review> GetAllReviewMovies()
        {
            return _movieRepo.Get()
                .Select(m =>
                new Review()
                {
                    Movie = new Movie()
                    {
                        IdMovie = m.IdMovie,
                        Title = m.Title,
                        Genres = String.Join(",",((GenreRepository)_genreRepo).GetFromMovie(m.IdMovie).Select(p=>p.Label)),
                        Directors = String.Join(",", ((CrewRepository)_crewRepo).GetDirectors(m.IdMovie).Select(p => p.FirstName +" "+ p.LastName)),
                        Duration = new TimeSpan(m.Duration), 
                    }
                }
                ).ToList(); 
        }
        public List<Movie> GetAllMovies()
        {
            return _movieRepo.Get().Select(m => 
            new Movie() {Title = m.Title, Duration = new TimeSpan(m.Duration)}).ToList(); 
        }

        #region Contact

        public bool SaveContact(Contact cm)
        {

            // mapping du model vers l'entité 
            MessageEntity me = new MessageEntity();
            me.Nom = cm.Nom;
            me.Email = cm.Nom;
            me.Phone = cm.Phone; 
            me.Information = cm.Message;

            //appel de la methode insert dans mon repository
            return _messageRepository.Insert(me); 
        }
        #endregion
    }
}
