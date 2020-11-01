using System;

namespace Game_Store.Data.Entities
{
    public class UserGame
    {
        public UserGame()
        {
            IsDeleted = false;
        }

        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Guid GameId { get; set; }

        public Game Game { get; set; }

        public bool IsDeleted { get; set; }
    }
}
