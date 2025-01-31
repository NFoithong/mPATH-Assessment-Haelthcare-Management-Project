[Route("api/[controller]")]
[ApiController]
public class RecommendationsController : ControllerBase
{
    private readonly HealthcareContext _context;

    public RecommendationsController(HealthcareContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetRecommendations()
    {
        var recommendations = _context.Recommendations.ToList();
        return Ok(recommendations);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateRecommendation(int id, [FromBody] Recommendation recommendation)
    {
        var existingRecommendation = _context.Recommendations.FirstOrDefault(r => r.Id == id);
        if (existingRecommendation == null) return NotFound();

        existingRecommendation.Status = recommendation.Status;
        _context.SaveChanges();
        return NoContent();
    }
}
