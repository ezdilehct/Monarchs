namespace Monarchs.Domain.Entities
{
    public class Monarch
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string NickName { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int HouseId { get; set; }

        public House House { get; set; }

        public int RuledFrom { get; set; }

        public int RuledTill { get; set; }
    }
}
