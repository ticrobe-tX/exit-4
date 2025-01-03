namespace tX.httpStore;

public class tXhttpStoreInterface
{
    Task<object> postAsync(object input);
    Task<object> getAsync(string id);
    Task<object> putAsync(object input);
    Task<object> deleteAsync(string id);
}
