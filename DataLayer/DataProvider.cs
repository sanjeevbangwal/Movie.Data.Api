using MoviewAppAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviewAppAPI.DataLayer
{
    public class DataProvider
    {
        public static List<movieModel> getMovieModels()
        {
            List<movieModel> movieModels = new List<movieModel>();
            movieModel movieModel1 = new movieModel();
            movieModel1.Language = "ENGLISH";
            movieModel1.Location = "PUNE";
            movieModel1.Plot = "Forced to spend his summer holidays with his muggle relations, Harry Potter gets a real shock when he gets a surprise visitor: Dobby the house-elf, who warns Harry Potter against returning to Hogwarts, for terrible things are going to happen. Harry decides to ignore Dobby's warning and continues with his pre-arranged schedule. But at Hogwarts, strange and terrible things are indeed happening: Harry is suddenly hearing mysterious voices from inside the walls, muggle-born students are being attacked, and a message scrawled on the wall in blood puts everyone on his/her guard -";
            movieModel1.Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTcxODgwMDkxNV5BMl5BanBnXkFtZTYwMDk2MDg3._V1_SX300.jpg";
			movieModel1.SoundEffects = new string[] { "DOLBY", "DTS" };
            movieModel1.Stills = new string[] { "https://i.imgur.com/3fJ1P48.gif", "https://i.imgur.com/j6ECXmD.gif", "https://i.imgur.com/v0ooIH0.gif" };
			movieModel1.Title = "Harry Potter and the Chamber of Secrets";
            movieModel1.imdbID = "tt0295297";
            movieModel1.listingType = "NOW_SHOWING";
            movieModel1.imdbRating = "7.4";

			movieModel movieModel2 = new movieModel();
			movieModel2.Language = "HINDI";
			movieModel2.Location = "DELHI";
			movieModel2.Plot = "Harry, Ron, and Hermione continue their quest of finding and destroying the Dark Lord's three remaining Horcruxes, the magical items responsible for his immortality. But as the mystical Deathly Hallows are uncovered, and Voldemort finds out about their mission, the biggest battle begins and life as they know it will never be the same again.";
			movieModel2.Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIyZGU4YzUtNDkzYi00ZDRhLTljYzctYTMxMDQ4M2E0Y2YxXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_SX300.jpg";
			movieModel2.SoundEffects = new string[] { "RX6", "SDDS" };
			movieModel2.Stills = new string[] { "https://i.imgur.com/i3aD05u.png", "https://i.imgur.com/ABinULO.gif", "https://i.imgur.com/Wflfyct.gif" };
			movieModel2.Title = "Harry Potter and the Deathly Hallows: Part 2";
			movieModel2.imdbID = "tt1201607";
			movieModel2.listingType = "NOW_SHOWING";
			movieModel2.imdbRating = "7.6";

			movieModel movieModel3 = new movieModel();
			movieModel3.Language = "ENGLISH";
			movieModel3.Location = "DELHI";
			movieModel3.Plot = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.";
			movieModel3.Poster = "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg";
			movieModel3.SoundEffects = new string[] { "RX6", "SDDS" };
			movieModel3.Stills = new string[] { "https://m.media-amazon.com/images/M/MV5BNTYxOTYyMzE3NV5BMl5BanBnXkFtZTcwOTMxNDY3Mw@@._V1_UY99_CR24,0,99,99_AL_.jpg", "https://m.media-amazon.com/images/M/MV5BNzAwOTk3MDg5MV5BMl5BanBnXkFtZTcwNjQxNDY3Mw@@._V1_UY99_CR29,0,99,99_AL_.jpg", "https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL__QL50.jpg" };
			movieModel3.Title = "The Shawshank Redemption";
			movieModel3.imdbID = "tt0111161";
			movieModel3.listingType = "NOW_SHOWING";
			movieModel3.imdbRating = "9.2";

			movieModel movieModel4 = new movieModel();
			movieModel4.Language = "HINDI";
			movieModel4.Location = "BANGALORE";
			movieModel4.Plot = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.";
			movieModel4.Poster = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_QL50_SY1000_CR0,0,704,1000_AL_.jpg";
			movieModel4.SoundEffects = new string[] { "RX6", "SDDS" };
			movieModel4.Stills = new string[] { "https://m.media-amazon.com/images/M/MV5BYTgzZTJlMDUtMGIxNy00ODJiLWI3NjAtYzQ4OTQ3MGQ3ZGYwXkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_UX99_CR0,0,99,99_AL_.jpg", "https://m.media-amazon.com/images/M/MV5BMTczMTk5MjkwOF5BMl5BanBnXkFtZTgwMDI0Mjk1NDM@._V1_UY99_CR12,0,99,99_AL_.jpg", "https://m.media-amazon.com/images/M/MV5BMTI2ODEzMTI1MF5BMl5BanBnXkFtZTYwNjI3MDU2._V1_UX100_CR0,0,100,100_AL_.jpg" };
			movieModel4.Title = "The Godfather";
			movieModel4.imdbID = "tt0068646";
			movieModel4.listingType = "UP_COMING";
			movieModel4.imdbRating = "8.1";

			movieModels.Add(movieModel1);
			movieModels.Add(movieModel2);
			movieModels.Add(movieModel3);
			movieModels.Add(movieModel4);

			return movieModels;
		}

    }
}
