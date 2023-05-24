using System;

namespace TamagotchiAPI.Models
{
    public class Pets
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HungerLevel { get; set; } = 0;
        public DateTime Birthday { get; set; } = DateTime.UtcNow;
        public int HappinessLevel { get; set; } = 0;
        //public bool IsDead { get; set; }
        public DateTime LastInteraction { get; set; } = DateTime.UtcNow;






    }
}