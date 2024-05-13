﻿using CMS.Application.UseCases.Auth;
using CMS.Application.UseCases.StudentCases.Commands;
using CMS.Application.UseCases.TeacherCases.Commands;
using CMS.Domain.Entities.Auth;
using CMS.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CMS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IAuthServise _authServise;
        private readonly IMediator _mediatr;
        public AuthController(UserManager<User> userManager, IAuthServise authServise,IMediator mediator)
        {
            _authServise = authServise;
            _userManager = userManager;
            _mediatr = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> TeacherRegister(RegisterTeacherCommand command)
        {
           return await _mediatr.Send(command);
            
        }
        [HttpPost]
        public async Task<ResponseModel> StudentRegister(RegisterStudentCommand command)
        {
            return await _mediatr.Send(command);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if(user == null)
            {
                throw new Exception();
            }
            var checker = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (!checker)
            {
                throw new Exception();
            }
            var token = await _authServise.GenerateToken(user);
            return Ok(token);
        }
    }
}