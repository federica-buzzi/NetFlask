using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class FeaturedTodayElement
    {
        #region Fields
        private string _elementCaption;
        private Movie _movie; 
        #endregion

        #region Props

        public string ElementCaption
        {
            get
            {
                return _elementCaption;
            }

            set
            {
                _elementCaption = value;
            }
        }

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
        #endregion
    }
}