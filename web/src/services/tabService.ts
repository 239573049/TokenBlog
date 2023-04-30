import request from "../utils/request";

class TabService {
    public static getTabs(): Promise<any> {
        return request.get("/api/v1/Tabs/List");
    }
}

export{
    TabService
}