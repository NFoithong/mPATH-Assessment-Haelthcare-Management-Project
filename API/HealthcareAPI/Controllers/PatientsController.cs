[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly HealthcareContext _context;

    public PatientsController(HealthcareContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetPatients([FromQuery] string search = "")
    {
        var patients = _context.Patients.Where(p => p.Name.Contains(search)).ToList();
        return Ok(patients);
    }

    [HttpGet("{id}")]
    public IActionResult GetPatient(int id)
    {
        var patient = _context.Patients.FirstOrDefault(p => p.Id == id);
        if (patient == null) return NotFound();

        return Ok(patient);
    }
}
