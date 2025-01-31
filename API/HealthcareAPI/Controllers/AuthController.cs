[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
	private readonly HealthcareContext _context;
	private readonly JwtService _jwtService;

	public AuthController(HealthcareContext context, JwtService jwtService)
	{
		_context = context;
		_jwtService = jwtService;
	}

	[HttpPost("login")]
	public IActionResult Login([FromBody] LoginModel model)
	{
		var user = _context.Users.SingleOrDefault(u => u.Username == model.Username);
		if (user == null || !BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
		{
			return Unauthorized("Invalid username or password");
		}

		var token = _jwtService.GenerateToken(user);
		return Ok(new { token });
	}
}
