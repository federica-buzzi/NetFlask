using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class VideoElement
    {
        #region Fields
        private string _imageName, _imageLink, _imageDescription, _videoLink;
        private bool _isLastColumn; 
        #endregion

        #region Props
        public string ImageName
        {
            get
            {
                return _imageName;
            }

            set
            {
                _imageName = value;
            }
        }

        public string ImageLink
        {
            get
            {
                return _imageLink;
            }

            set
            {
                _imageLink = value;
            }
        }

        public string ImageDescription
        {
            get
            {
                return _imageDescription;
            }

            set
            {
                _imageDescription = value;
            }
        }

        public bool IsLastColumn
        {
            get
            {
                return _isLastColumn;
            }

            set
            {
                _isLastColumn = value;
            }
        }

        public string VideoLink
        {
            get
            {
                return _videoLink;
            }

            set
            {
                _videoLink = value;
            }
        }

        #endregion
    }
}