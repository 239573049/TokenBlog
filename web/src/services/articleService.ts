import request from "../utils/request";

class ArticleService {
    public static getList(keyword: string, categoryId: string | null, page: number = 1, pageSize: number = 20): Promise<any> {
        if(categoryId){
            return request.get("/api/v1/Articles/List", {
                keyword,
                categoryId,
                page,
                pageSize
            });
        }else{
            return request.get("/api/v1/Articles/List", {
                keyword,
                page,
                pageSize
            });
        }
    }

    public static get(id: string): Promise<any> {
        return request.get(`/api/v1/Articles/${id}`);
    }

    public static getRanking(){
        return request.get("/api/v1/Articles/Ranking");
    }
}

export {
    ArticleService
}