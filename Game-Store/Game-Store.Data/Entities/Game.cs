using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Game_Store.Data.Entities
{
    public class Game
    {
        public Game()
        {
            Id = Guid.NewGuid();
            UserGames = new HashSet<UserGame>();
            IsDeleted = false;
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<UserGame> UserGames { get; set; }
    }
}
