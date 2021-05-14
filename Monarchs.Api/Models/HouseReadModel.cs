using Monarchs.Domain.Entities;

namespace Monarchs.Api.Models
{
    public class HouseReadModel
    {
        public HouseReadModel(House house)
        {
            Id = house.Id;
            Name = house.Name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}