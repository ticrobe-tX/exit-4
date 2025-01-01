using Microsoft.AspNetCore.Mvc;
using tX.interfaceStore;
using tX.modelStore;
using Microsoft.AspNetCore.Cors;

namespace tX.controllerStore;

[ApiController]
[Route("[controller]")]
public class tXticrobeNameListController : ControllerBase
{
    private readonly tXticrobeNameListServiceInterface _tXticrobeNameListService;

    private readonly ILogger<tXticrobeNameListController> _logger;

    public tXticrobeNameListController(ILogger<tXticrobeNameListController> logger
    , tXticrobeNameListServiceInterface tXticrobeNameListService)
    {
        _logger = logger;
        _tXticrobeNameListService = tXticrobeNameListService;
    }

    #region the crud
    [HttpGet]
    public async Task<tXticrobeNameListModel> GetAsync(string tNameListId)
    {
        return await _tXticrobeNameListService.getAsync(tNameListId);
    }    
    #endregion the crud
}
