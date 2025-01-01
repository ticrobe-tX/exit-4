using tX.modelStore;

namespace tX.interfaceStore;

public interface tXticrobeNameListServiceInterface {
    Task<tXticrobeNameListModel> getAsync(string? tNameListId);
    Task<tXticrobeNameListModel> postAsync(tXticrobeNameListPostRequest _tXticrobeNameListPostRequest);
}