﻿using System;

namespace NetFlask.Entities
{
    public class RatingEntity
    {
        #region Fields
        private int _idMovie, _idUser;
        private double _score;
        private DateTime _dateRating;
        #endregion

        #region Props
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

        public int IdUser
        {
            get
            {
                return _idUser;
            }

            set
            {
                _idUser = value;
            }
        }

        public double Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }

        public DateTime DateRating
        {
            get
            {
                return _dateRating;
            }

            set
            {
                _dateRating = value;
            }
        } 
        #endregion
    }
}
