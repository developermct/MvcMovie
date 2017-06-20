using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        #region Title
            [StringLength(60, MinimumLength = 3)]
            [Required]
            public string Title { get; set; }
        #endregion

        #region ReleaseDate
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [Display(Name = "Release Date")]
            [DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }
        #endregion

        #region Genre
            [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
            [Required]
            [StringLength(30)]
            public string Genre { get; set; }
        #endregion

        #region Price
            [Range(1, 100)]
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }
        #endregion

        #region Rating
            [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
            [StringLength(5)]
            [Required]
            public string Rating { get; set; }
        #endregion
    }
}