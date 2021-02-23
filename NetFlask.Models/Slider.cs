using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class Slider
    {
        #region Field
        private string _link, _picture;
        #endregion

        #region Props
        public string Link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        }

        public string Picture
        {
            get
            {
                return _picture;
            }

            set
            {
                _picture = value;
            }
        } 
        #endregion
    }
}