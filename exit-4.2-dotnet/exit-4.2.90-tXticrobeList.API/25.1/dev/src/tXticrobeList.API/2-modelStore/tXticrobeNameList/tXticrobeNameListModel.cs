namespace tX.modelStore;

public class tXticrobeNameListModel {
    public string? tNameListId {get; set;}
    public List<tXticrobeNameModel> tNameList {get; set;}

    public tXticrobeNameListModel() {
        this.tNameListId = null;
        this.tNameList = new();
    }
}