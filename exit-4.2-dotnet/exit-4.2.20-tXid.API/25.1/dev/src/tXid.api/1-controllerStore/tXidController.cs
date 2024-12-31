using Microsoft.AspNetCore.Mvc;
using tX.interfaceStore;
using tX.modelStore;
using Microsoft.AspNetCore.Cors;

namespace tX.controllerStore;

[ApiController]
[Route("[controller]")]
public class tXidController : ControllerBase
{
    private readonly tXidServiceInterface _tXidService;

    private readonly ILogger<tXidController> _logger;

    public tXidController(ILogger<tXidController> logger
    , tXidServiceInterface tXidService)
    {
        _logger = logger;
        _tXidService = tXidService;
    }

    #region the crud
    [HttpPost]
    public async Task<tXidModel> postAsync(tXidPostRequest _tXidPostRequest)
    {
        return await _tXidService.postAsync(_tXidPostRequest);
    }  
    #endregion the crud
}
