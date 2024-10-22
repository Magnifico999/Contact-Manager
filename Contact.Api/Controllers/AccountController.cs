using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Contact.Api.DTO;
using Contact.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Contact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<UserProfile> _signInManager;
        private readonly UserManager<UserProfile> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<AccountController> _logger;
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration, ILogger<AccountController> logger, IMapper mapper, SignInManager<UserProfile> signInManager, UserManager<UserProfile> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _configuration = configuration;
        }


        [HttpPost]
        [Route("UserLogin")]
        public async Task<ActionResult<ResponseDto>> Login(LoginDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            try
            {
                _logger.LogInformation($"Attempt user login via {userDto.Email}");
                var user = await _userManager.FindByEmailAsync(userDto.Email);
                if (user == null)
                {
                    _logger.LogError($"Something went wrong with the {userDto.Email}");
                    return BadRequest();
                }
                var validatePassword = await _userManager.CheckPasswordAsync(user, userDto.Password);
                if (validatePassword == false)
                {
                    return Unauthorized(userDto);
                }

                string token = await GenerateToken(user);
                var response = new ResponseDto()
                {
                    Email = user.Email,
                    TokenString = token,
                    UserId = user.Id,
                    UserName = user.UserName
                };
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(Login)} method with {userDto.Email}");
            }

            return Ok();
        }


        [HttpPost]
        [Route("UserRegister")]

        public async Task<IActionResult> Register(UserDTO userDto)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            try
            {
                // var user = new UserProfile();

                /* user.Email = userDto.Email;
                 user.FirstName = userDto.FirstName;
                 user.LastName = userDto.LastName;*/
                _logger.LogInformation($"Attempt user Registration via {userDto.Email}");
                var user = _mapper.Map<UserProfile>(userDto);
                var userName = userDto.Email.Split('@')[0];
                user.UserName = userName;
                user.ProfilePicture = " ";
                var success = await _userManager.CreateAsync(user, userDto.Password);
                if (success.Succeeded == false)
                {
                    _logger.LogError($"Something went wrong with the {userDto.Email}");
                    foreach (var item in success.Errors)
                    {
                        ModelState.AddModelError(item.Code, item.Description);
                        return BadRequest(ModelState);
                    }
                }
                _logger.LogInformation($"Attempt User register and apply user roles to {userDto.Email}");
                await _userManager.AddToRoleAsync(user, "user");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(Register)} method with user {userDto.Email}");
                return Problem(ex.ToString());
            }
            
            return Ok();
        }


        private async Task<string> GenerateToken(UserProfile user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jWTSetting:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();


            var userClaims = await _userManager.GetClaimsAsync(user);
            var Claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            }.Union(userClaims).Union(roleClaims);
            var token = new JwtSecurityToken(
                issuer: _configuration["JWTSetting:Issuer"],
                audience: _configuration["JwtSetting:Audience"],
                claims: Claims,
                expires: DateTime.Now.AddMinutes(30),  //UtcNow.AddHours(Convert.ToInt32(_configuration["JwtSetting:Duration"])),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
