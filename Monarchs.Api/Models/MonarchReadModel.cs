using Monarchs.Domain.Entities;

namespace Monarchs.Api.Models
{
    public class MonarchReadModel
    {
        public MonarchReadModel(Monarch monarch)
        {
            Id = monarch.Id;
            Name = $"{monarch.FirstName} {monarch.NickName}";
            RuledFrom = monarch.RuledFrom;
            RuledTill = monarch.RuledTill;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int RuledFrom { get; set; }

        public int RuledTill { get; set; }
    }
}
