using tX.interfaceStore;
using tX.modelStore;

namespace tX.repositoryStore;

public class tXidRepository : tXidRepositoryInterface
{
    public tXidRepository()
    {

    }
    public async Task<tXidModel> postAsync(tXidPostRequest _tXidPostRequest)
    {
        return await Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o =>
        {
            tXidModel tXid = new();
            // get tXid from the tXutil.api here
            return tXid;
        });
    }
}