using Microsoft.AspNetCore.Mvc;
using VsaApiTemplate.Features.Models;
using VsaApiTemplate.Features.Services;

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

	[HttpGet]
	public async Task<ActionResult<IReadOnlyList<Feature>>> GetAsync() => Ok(await _featuresService.GetFeatures());
}
