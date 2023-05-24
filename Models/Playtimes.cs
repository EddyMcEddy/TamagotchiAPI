using System;

namespace TamagotchiAPI.Models
{
    public class Playtimes
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.UtcNow;
        public int PetId { get; set; }
        public DateTime LastPlayTime { get; set; } = DateTime.UtcNow;



        public Pets Pets { get; set; }
    }
}