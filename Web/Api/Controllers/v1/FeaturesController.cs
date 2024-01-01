using Microsoft.AspNetCore.Mvc;
using VsaTemplate.Features.Models;
using VsaTemplate.Features.Services;

namespace Api.Controllers.v1;

[ApiController]
[Route("/features")]
public class FeaturesController : ControllerBase
{
	private FeaturesService _featuresService { get; set; }

	public FeaturesController(FeaturesService featuresService)
	{
		_featuresService = featuresService;
	}

	public ActionResult<IEnumerable<Feature>> Get()
	{
		return Ok(_featuresService.GetFeatures());
	}
}
