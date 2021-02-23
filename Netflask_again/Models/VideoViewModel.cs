using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflask_again.Models
{
    public class VideoViewModel
    {
        #region Fields
        private List<VideoElement> _gridElements;
        #endregion

        public VideoViewModel()
        {

            GridElements = new List<VideoElement>();
            GridElements.Add(new VideoElement() { ImageName= "A1", ImageLink = "gridallbum1.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink= "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A2", ImageLink = "gridallbum2.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/7gDKbT_l2us" });
            GridElements.Add(new VideoElement() { ImageName = "A3", ImageLink = "gridallbum3.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/ph6FkwzJJkc" });
            GridElements.Add(new VideoElement() { ImageName = "A4", ImageLink = "gridallbum4.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = true, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A5", ImageLink = "gridallbum5.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A6", ImageLink = "gridallbum6.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A7", ImageLink = "gridallbum7.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A8", ImageLink = "gridallbum8.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = true, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A9", ImageLink = "gridallbum9.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A10", ImageLink = "gridallbum10.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false , VideoLink= "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A11", ImageLink = "gridallbum11.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = false, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
            GridElements.Add(new VideoElement() { ImageName = "A12", ImageLink = "gridallbum1.jpg", ImageDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastColumn = true, VideoLink = "https://www.youtube.com/embed/2LqzF5WauAw" });
        }

        #region Props
        public List<VideoElement> GridElements
        {
            get
            {
                return _gridElements;
            }

            set
            {
                _gridElements = value;
            }
        }
        #endregion
    }
}