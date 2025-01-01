using tX.interfaceStore;
using tX.modelStore;

namespace tX.repositoryStore;

public class tXticrobeNameListRepository : tXticrobeNameListRepositoryInterface
{
    public tXticrobeNameListRepository()
    {

    }
    public async Task<tXticrobeNameListModel> getAsync(string? tNameListId)
    {
        return await Task.Delay(new TimeSpan(0, 0, 2)).ContinueWith(o =>
        {
            tXticrobeNameListModel tList = new();
            tList.tNameListId = tNameListId;
            for (int i = 0; i < 1; i++)
            {
                tXticrobeNameModel t = new();
                t.tId = $"t1";
                t.tName = $"test1";
                t.tIndex = 0;
                tList.tNameList.Add(t);
            }
            return tList;
        });
    }
    public async Task<tXticrobeNameListModel> postAsync(tXticrobeNameListPostRequest _tXticrobeNameListPostRequest)
    {
        return await Task.Delay(new TimeSpan(0, 0, 5)).ContinueWith(o =>
        {
            tXticrobeNameListModel tList = new();

            for (int i = 0; i < 10; i++)
            {
                tXticrobeNameModel t = new();
                //ma.maName = $"ma-{i}";
                tList.tNameList.Add(t);
            }
            return tList;
        });
    }
}