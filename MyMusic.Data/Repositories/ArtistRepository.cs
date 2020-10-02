using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(MyMusicDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Artist>> GetAllWithMusicAsync()
        {
            return await MyMusicDbContext.Artists
                .Include(a => a.Musics)
                .ToListAsync();
        }

        public async Task<Artist> GetWithMusicByIdAsync(int id)
        {
            return await MyMusicDbContext.Artists
                .Include(a => a.Musics)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        private MyMusicDbContext MyMusicDbContext
        {
            get { return Context as MyMusicDbContext; }
        }
    }
}
