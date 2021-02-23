using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlask.Entities
{
    public class GenreEntity
    {
        #region Fields
        private int _idGenre;
        private string _label;

        #endregion

        #region Props
        public int IdGenre
        {
            get
            {
                return _idGenre;
            }

            set
            {
                _idGenre = value;
            }
        }

        public string Label
        {
            get
            {
                return _label;
            }

            set
            {
                _label = value;
            }
        } 
        #endregion
    }
}
