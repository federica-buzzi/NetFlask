using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class News
    {
        #region Fields
        private string _title, _description;
        private DateTime _theDate;
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

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public DateTime TheDate
        {
            get
            {
                return _theDate;
            }

            set
            {
                _theDate = value;
            }
        } 
        #endregion
    }
}