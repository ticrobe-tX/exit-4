using tX.interfaceStore;
using tX.modelStore;

namespace tX.repositoryStore;

public class tXticrobeNameListRepository : tXticrobeNameListRepositoryInterface
{
    public tXticrobeNameListRepository()
    {

    }
    public async Task<tXticrobeNameListModel> getListAsync(string listId, int from, int count)
    {
        return await Task.Delay(new TimeSpan(0, 0, 2)).ContinueWith(o =>
        {
            tXticrobeNameListModel tList = new();
            tList.parentId = listId;
            for (int i = from; i < from + count; i++)
            {
                tXticrobeNameModel ta = new();
                ta.tIndex = i;
                ta.tId = $"t{i}";
                tList.tNameList.Add(ta);
            }
            return tList;
        });
    }
    public async Task<tXticrobeNameListModel> getAsync()
    {
        return await Task.Delay(new TimeSpan(0, 0, 2)).ContinueWith(o =>
        {
            tXticrobeNameListModel tList = new();
            tList.parentId = "tList1a";
            for (int i = 0; i < 1; i++)
            {
                tXticrobeNameModel t = new();
                t.tIndex = 0;
                t.tId = $"t1";
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