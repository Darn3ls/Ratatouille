﻿using Ratatouille.Models;

namespace Ratatouille.Services
{
    public class AuthService
    {
        public User? CurrentUser { get; private set; }

        public bool IsAuthenticated => CurrentUser != null;

        public void Login(User user)
        {
            CurrentUser = user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
