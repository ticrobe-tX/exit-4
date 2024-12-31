namespace tX.modelStore;

public class tXticrobeNameListModel {
    public string? parentId {get; set;}
    public List<tXticrobeNameModel> tNameList {get; set;}

    public tXticrobeNameListModel() {
        this.parentId = null;
        this.tNameList = new();
    }
}