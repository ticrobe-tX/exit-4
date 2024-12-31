using tX.modelStore;

namespace tX.interfaceStore;

public interface tXidRepositoryInterface {
    Task<tXidModel> postAsync(tXidPostRequest _tXidPostRequest);
}