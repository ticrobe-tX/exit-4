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
    public async Task<tXticrobeNameListModel> getListAsync(string listId, int from, int count)
    {
        return await this._tXticrobeNameListRepository.getListAsync(listId, from, count);
    }
    public async Task<tXticrobeNameListModel> getAsync()
    {
        return await this._tXticrobeNameListRepository.getAsync();
    }
    public async Task<tXticrobeNameListModel> postAsync(tXticrobeNameListPostRequest _tXticrobeNameListPostRequest)
    {
        return await this._tXticrobeNameListRepository.postAsync(_tXticrobeNameListPostRequest);
    }
}