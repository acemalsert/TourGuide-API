﻿using TourGuide.Application.Bases;
using TourGuide.Application.Features.Auth.Exceptions;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExist(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }
    }
}
