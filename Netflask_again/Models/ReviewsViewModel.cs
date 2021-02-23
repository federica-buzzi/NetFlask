using NetFlask.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class ReviewsViewModel
    {
        #region Fields
        private List<Review> _reviewElements;
        private List<FeaturedTodayElement> _featuredElements;
        private List<FeaturedTodayElement> _featuredEntertainement;
        private List<FeaturedTodayElement> _mightAlsoLike;
        private List<Slider> _slider3; 

        #endregion

        public ReviewsViewModel()
        {
            //code pour la recuperation des Reviews de la DB??
            //public void paginateReviews(string sortOrder = "", string searchString = null, int page = 1)
            //{

            //    Reviews = ctx.GetAllReviewsMovies(sortOrder, searchString, page);
            //    if (searchString != null)
            //    {
            //        _maxMovie = Reviews.Count();
            //        _maxPage = Reviews.Count() / 5;
            //    }

            //}

            UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            ReviewElements = uow.GetAllReviewMovies(); 

            //ReviewElements = new List<Review>();
            ////Review 1
            //ReviewElements.Add(new Review() 
            //{   Movie = new Movie()
            //     { Image = "/images/r4.jpg", Title = "Lorem Movie Review", Directors = "Glenn Ficarra, John Requa",Cast = "Will Smith,Margot Robbie, Adrian Martinez, Rodrigo", Duration = new TimeSpan(), Genres = "Crime"},
            //    User= "Reagan Gavin Rasquinha" ,
            //    Magazine = "TNN", 
            //    ReviewDate = new DateTime(2014, 11, 7), 
            //    CriticsRating = 3.5,
            //    ReadersRating = 3.3 
            //});
            ////Review 2
            //ReviewElements.Add(new Review()
            //{
            //    Movie = new Movie()
            //    { Image = "/images/r4.jpg", Title = "Lorem Movie Review", Directors = "Glenn Ficarra, John Requa", Cast = "Will Smith,Margot Robbie, Adrian Martinez, Rodrigo", Duration = new TimeSpan(), Genres = "Crime" },
            //    User = "Reagan Gavin Rasquinha",
            //    Magazine = "TNN",
            //    ReviewDate = new DateTime(2014, 11, 7),
            //    CriticsRating = 3.5,
            //    ReadersRating = 3.3
            //});

            ////Review 3
            //ReviewElements.Add(new Review()
            //{
            //    Movie = new Movie()
            //    { Image = "/images/r4.jpg", Title = "Lorem Movie Review", Directors = "Glenn Ficarra, John Requa", Cast = "Will Smith,Margot Robbie, Adrian Martinez, Rodrigo", Duration = new TimeSpan(), Genres = "Crime" },
            //    User = "Reagan Gavin Rasquinha",
            //    Magazine = "TNN",
            //    ReviewDate = new DateTime(2014, 11, 7),
            //    CriticsRating = 3.5,
            //    ReadersRating = 3.3
            //});
            ////Review 4
            //ReviewElements.Add(new Review()
            //{
            //    Movie = new Movie()
            //    { Image = "/images/r4.jpg", Title = "Lorem Movie Review", Directors = "Glenn Ficarra, John Requa", Cast = "Will Smith,Margot Robbie, Adrian Martinez, Rodrigo", Duration = new TimeSpan(), Genres = "Crime" },
            //    User = "Reagan Gavin Rasquinha",
            //    Magazine = "TNN",
            //    ReviewDate = new DateTime(2014, 11, 7),
            //    CriticsRating = 3.5,
            //    ReadersRating = 3.3
            //});
            ////Review 5
            //ReviewElements.Add(new Review()
            //{
            //    Movie = new Movie()
            //    { Image = "/images/r4.jpg", Title = "Lorem Movie Review", Directors = "Glenn Ficarra, John Requa", Cast = "Will Smith,Margot Robbie, Adrian Martinez, Rodrigo", Duration = new TimeSpan(), Genres = "Crime" },
            //    User = "Reagan Gavin Rasquinha",
            //    Magazine = "TNN",
            //    ReviewDate = new DateTime(2014, 11, 7),
            //    CriticsRating = 3.5,
            //    ReadersRating = 3.3
            //});

            //Featured Today
            FeaturedElements = new List<FeaturedTodayElement>();
            FeaturedElements.Add(new FeaturedTodayElement() { ElementCaption = "", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f1.jpg" } });
            FeaturedElements.Add(new FeaturedTodayElement() { ElementCaption = "", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f2.jpg" } });
            FeaturedElements.Add(new FeaturedTodayElement() { ElementCaption = "", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f3.jpg" } });
            FeaturedElements.Add(new FeaturedTodayElement() { ElementCaption = "", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f4.jpg" } });
            FeaturedElements.Add(new FeaturedTodayElement() { ElementCaption = "", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f5.jpg" } });
            FeaturedElements.Add(new FeaturedTodayElement() { ElementCaption = "", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f6.jpg" } });
   

            //Featured Entertainement
            FeaturedEntertainement = new List<FeaturedTodayElement>();
            FeaturedEntertainement.Add(new FeaturedTodayElement() { ElementCaption = "Watch ‘Bombay Velvet’ trailer during WC match", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f1.jpg" }});
            FeaturedEntertainement.Add(new FeaturedTodayElement() { ElementCaption = "Watch ‘Bombay Velvet’ trailer during WC match", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f2.jpg" } });
            FeaturedEntertainement.Add(new FeaturedTodayElement() { ElementCaption = "Watch ‘Bombay Velvet’ trailer during WC match", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f3.jpg" } });
            FeaturedEntertainement.Add(new FeaturedTodayElement() { ElementCaption = "Watch ‘Bombay Velvet’ trailer during WC match", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f4.jpg" } });
            FeaturedEntertainement.Add(new FeaturedTodayElement() { ElementCaption = "Watch ‘Bombay Velvet’ trailer during WC match", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f5.jpg" } });
            FeaturedEntertainement.Add(new FeaturedTodayElement() { ElementCaption = "Watch ‘Bombay Velvet’ trailer during WC match", Movie = new Movie() { Title = "lorem movie review", Image = "/images/f1.jpg" } });
           
         
            //Might also like
            MightAlsoLike = new List<FeaturedTodayElement>();
            MightAlsoLike.Add(new FeaturedTodayElement() { ElementCaption = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movie = new Movie() {Image = "/images/mi1.jpg" } });
            MightAlsoLike.Add(new FeaturedTodayElement() { ElementCaption = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movie = new Movie() { Image = "/images/mi2.jpg" } });
            MightAlsoLike.Add(new FeaturedTodayElement() { ElementCaption = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", Movie = new Movie() { Image = "/images/mi3.jpg" } });

            //Slider
            Slider3 = new List<Slider>();
            Slider3.Add(new Slider() { Link = "#", Picture = "r1.jpg" });
            Slider3.Add(new Slider() { Link = "#", Picture = "r2.jpg" });
            Slider3.Add(new Slider() { Link = "#", Picture = "r3.jpg" });
            Slider3.Add(new Slider() { Link = "#", Picture = "r4.jpg" });
            Slider3.Add(new Slider() { Link = "#", Picture = "r5.jpg" });
            Slider3.Add(new Slider() { Link = "#", Picture = "r6.jpg" });

        }

        #region Props
        public List<Review> ReviewElements
        {
            get
            {
                return _reviewElements;
            }

            set
            {
                _reviewElements = value;
            }
        }

        public List<FeaturedTodayElement> FeaturedElements
        {
            get
            {
                return _featuredElements;
            }

            set
            {
                _featuredElements = value;
            }
        }

        public List<Slider> Slider3
        {
            get
            {
                return _slider3;
            }

            set
            {
                _slider3 = value;
            }
        }

        public List<FeaturedTodayElement> FeaturedEntertainement
        {
            get
            {
                return _featuredEntertainement;
            }

            set
            {
                _featuredEntertainement = value;
            }
        }

        public List<FeaturedTodayElement> MightAlsoLike
        {
            get
            {
                return _mightAlsoLike;
            }

            set
            {
                _mightAlsoLike = value;
            }
        }
        #endregion
    }
}