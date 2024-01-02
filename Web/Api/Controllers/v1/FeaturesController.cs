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

	public ActionResult<IEnumerable<Feature>> Get() => Ok(_featuresService.GetFeatures());
}
