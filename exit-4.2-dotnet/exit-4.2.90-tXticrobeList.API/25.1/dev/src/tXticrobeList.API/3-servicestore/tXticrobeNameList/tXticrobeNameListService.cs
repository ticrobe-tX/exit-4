using tX.interfaceStore;
using tX.modelStore;
using tX.repositoryStore;

namespace tX.serviceStore;

public class tXticrobeNameListService : tXticrobeNameListServiceInterface
{
    private readonly tXticrobeNameListRepositoryInterface _tXticrobeNameListRepository;
    public tXticrobeNameListService(tXticrobeNameListRepositoryInterface tXticrobeNameListRepository)
    {
        this._tXticrobeNameListRepository = tXticrobeNameListRepository;
    }
    public async Task<tXticrobeNameListModel> getAsync(string? tNameListId)
    {
        return await this._tXticrobeNameListRepository.getAsync(tNameListId);
    }
    public async Task<tXticrobeNameListModel> postAsync(tXticrobeNameListPostRequest _tXticrobeNameListPostRequest)
    {
        return await this._tXticrobeNameListRepository.postAsync(_tXticrobeNameListPostRequest);
    }
}