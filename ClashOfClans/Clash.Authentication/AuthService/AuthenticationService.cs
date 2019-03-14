using Clash.Common.DTOs;
using Clash.Common.ValueObjects;
using Clash.Domain.Entities;
using Clash.Interfaces.Builders;
using Clash.Interfaces.DTOs;
using Clash.Interfaces.Helpers;
using Clash.Interfaces.Repositories;
using Clash.Interfaces.Services;
using Clash.ValueObjectEntity.EntityManipulation;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Clash.Authentication.AuthService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppSettings _appSettings;
        private readonly IUserRepository<User> _userRepository;
        private readonly IUserBuilder<User> _userBuilder;

        public AuthenticationService(IOptions<AppSettings> appSettings, IUserRepository<User> userRepository, IUserBuilder<User> userBuilder)
        {
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
            _userBuilder = userBuilder;
        }

        public (string token, int userId) GenerateToken(IAuthUser authUser)
        {
            User user = _userRepository.GetUserByNameAndPassword(authUser);

            if (user == null)
            {
                _userRepository.Insert(_userBuilder.WithUserName(authUser.UserName)
                                                   .WithPassword(authUser.Password)
                                                   .WithRole(authUser.Role)
                                                   .Build());
            }

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, authUser.Role ?? string.Empty)
                }),
                Expires = DateTime.UtcNow.AddYears(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return (tokenHandler.WriteToken(token), user.Id);
        }

        public IAuthUserDTO Login(IAuthUser authUser)
        {
            if (ValidateUser(authUser))
            {
                var (token, userId) = GenerateToken(authUser);
                return AuthUserDTO.Create(userId, token);
            }

            throw new UnauthorizedAccessException("Usuário ou senha incorretos");
        }

        public bool ValidateUser(IAuthUser authUser)
        {
            User user = _userRepository.GetUserByNameAndPassword(authUser);

            if (user != null)
            {
                return true;
            }

            return false;
        }

        public VOUser GetCurrentUser(int id)
        {
            User user = _userRepository.GetById(id);
            return new VOUser(user.UserName, string.Empty, user.Id, user.Role);
        }
    }
}