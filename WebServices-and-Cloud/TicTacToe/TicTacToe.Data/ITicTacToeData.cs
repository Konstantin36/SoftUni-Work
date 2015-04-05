﻿namespace TicTacToe.Data
{
    using Microsoft.VisualBasic.ApplicationServices;

    using TicTacToe.Data.Repositories;
    using TicTacToe.Models;

    public interface ITicTacToeData
    {
        IRepository<User> Users { get; }

        IRepository<Game> Games { get; }

        int SaveChanges();
    }
}
