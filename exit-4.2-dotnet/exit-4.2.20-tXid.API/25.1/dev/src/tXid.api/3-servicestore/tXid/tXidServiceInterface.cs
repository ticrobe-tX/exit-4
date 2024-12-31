using tX.modelStore;

namespace tX.interfaceStore;

public interface tXidServiceInterface {
    Task<tXidModel> postAsync(tXidPostRequest _tXidPostRequest);
}