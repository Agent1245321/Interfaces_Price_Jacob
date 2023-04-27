using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Price_Jacob
{
    /// <summary>
    /// This is the Interface IGenre, it is used to make sure that each class contains the propertys and methods described in it.
    /// This Interface has three string propertys and one string Method
    /// </summary>
    interface IGenre
    {

        //The ESBR property
        public string ESBR
        {
            get; set;
        }

        //The Genre property
        public string Genre
        {
            get; set;
        }

        //The Title property
        public string Title
        {
            get; set;
        }

        //The Describe() method with a string return type
        public string Describe();
    }
}
