using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhotoArchive.Models;

namespace PhotoArchive
{
    public static class SampleData
    {
        public static void Initialize(PhotoArchiveContext context)
        {
            var author1 = new Author
            {
                Name = "Paul",
                Surname = "Nicklen",
                Country = "Canada",
                City = "Tisland",
                ContactPhone = "250 555 0199"
            };
            var author2 = new Author
            {
                Name = "Oda",
                Surname = "Eiichiro",
                Country = "Japan",
                City = "Kumatomo",
                ContactPhone = "011 271 6677"
            };

            if (!context.Authors.Any())
            {
                context.Authors.AddRange(author1, author2);
                context.SaveChanges();
            }

            if (!context.Photos.Any())
            {
                context.Photos.AddRange(
                    new Photo
                    {
                        Name = "Elephant Seal",
                        Ref = "https://cdn.pixabay.com/photo/2020/11/09/20/00/seal-5727697_960_720.jpg",
                        Desc = "Three-week-old pup in South Georgia",
                        Year = 2021,
                        AuthorId = 1
                    },
                    new Photo
                    {
                        Name = "Ice Waterfall",
                        Ref = "https://wallpaperaccess.com/full/6543189.jpg",
                        Desc = "Beauty in the collapse of our global climate",
                        Year = 2021,
                        AuthorId = 1
                    },
                    new Photo
                    {
                        Name = "One Piece 1000 chapter",
                        Ref = "https://ani.best/uploads/posts/2020-12/1609049860_00b.jpg",
                        Desc = "I will become the pirate king!!!",
                        Year = 2020,
                        AuthorId = 2
                    }
                );
                context.SaveChanges();
            }

        }
    }
}