using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class Review
    {
        private Movie _movie; 
        private string _user, _magazine;
        private DateTime _reviewDate;
        private double _criticsRating, _readersRating;

        public Movie Movie
        {
            get
            {
                return _movie;
            }

            set
            {
                _movie = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string Magazine
        {
            get
            {
                return _magazine;
            }

            set
            {
                _magazine = value;
            }
        }

        public DateTime ReviewDate
        {
            get
            {
                return _reviewDate;
            }

            set
            {
                _reviewDate = value;
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

        public double ReadersRating
        {
            get
            {
                return _readersRating;
            }

            set
            {
                _readersRating = value;
            }
        }
    } 
    
}