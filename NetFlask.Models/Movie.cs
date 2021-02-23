using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class Movie
    {
        #region Fields
        private int _idMovie; 
        private string _title;
        private string _cast, _directors, _genres;
        private string _image;
        private TimeSpan _duration;
        private double _rating;
        private double _criticsRating; 
        #endregion

        #region Props
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Cast
        {
            get
            {
                return _cast;
            }

            set
            {
                _cast = value;
            }
        }

        public string Directors
        {
            get
            {
                return _directors;
            }

            set
            {
                _directors = value;
            }
        }

        public string Genres
        {
            get
            {
                return _genres;
            }

            set
            {
                _genres = value;
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }

            set
            {
                _rating = value;
            }
        }

        public double CriticsRating
        {
            get
            {
                return _criticsRating;
            }

            set
            {
                _criticsRating = value;
            }
        }

        public int IdMovie
        {
            get
            {
                return _idMovie;
            }

            set
            {
                _idMovie = value;
            }
        }
        #endregion
    }
}