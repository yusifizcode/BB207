using ProniaBB207.Core.Models;
using ProniaBB207.Core.RepositoryAbstracts;
using ProniaBB207.Data.DAL;

namespace ProniaBB207.Data.RepositoryConcretes;

public class SliderRepository : GenericRepository<Slider>, ISliderRepository
{
    public SliderRepository(AppDbContext context) : base(context)
    {
    }
}
