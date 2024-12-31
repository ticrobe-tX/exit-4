using tX.modelStore;

namespace tX.interfaceStore;

public interface tXticrobeNameListRepositoryInterface {
    Task<tXticrobeNameListModel> getListAsync(string listId, int from, int count);
    Task<tXticrobeNameListModel> getAsync();
    Task<tXticrobeNameListModel> postAsync(tXticrobeNameListPostRequest _tXticrobeNameListPostRequest);
}