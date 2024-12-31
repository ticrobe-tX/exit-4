using tX.interfaceStore;
using tX.modelStore;
using tX.repositoryStore;

namespace tX.serviceStore;

public class tXidService : tXidServiceInterface
{
    private readonly tXidRepositoryInterface _tXidRepository;
    public tXidService(tXidRepositoryInterface tXidRepository)
    {
        this._tXidRepository = tXidRepository;
    }
    public async Task<tXidModel> postAsync(tXidPostRequest _tXidPostRequest)
    {
        return await this._tXidRepository.postAsync(_tXidPostRequest);
    }
}