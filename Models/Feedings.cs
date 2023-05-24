using System;

namespace TamagotchiAPI.Models
{
    public class Feedings
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.UtcNow;
        public int PetId { get; set; }

        public Pets Pets { get; set; }




    }
}