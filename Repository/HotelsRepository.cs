using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelRepository
    {
        public HotelsRepository(HotelListingDBContext context) : base(context)
        {
        }
    }
}
