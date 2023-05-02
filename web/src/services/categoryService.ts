import request from "../utils/request";

class CategoryService {
    public static getList(): Promise<any> {
        return request.get("/api/v1/Categories/List");
    }

}

export {
    CategoryService 
}