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
    [HttpGet("list/{listId}/from/{from}/count/{count}")]
    public async Task<tXticrobeNameListModel> GetListAsync(string listId, int from, int count)
    {
        return await _tXticrobeNameListService.getListAsync(listId, from, count);
    }
    [HttpGet]
    public async Task<tXticrobeNameListModel> GetAsync()
    {
        return await _tXticrobeNameListService.getAsync();
    }    
    #endregion the crud
}
