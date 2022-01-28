using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieApiI.Data
{
    public class MovieApiIContext : DbContext
    {
        public MovieApiIContext (DbContextOptions<MovieApiIContext> options)
            : base(options)
        {
        }

        public DbSet<MovieAPI.Models.Movie> Movie { get; set; }
    }
}
