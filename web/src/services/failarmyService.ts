import { UpdateFailarmyDto } from './../models/blogger';
import { CreateFailarmyDto } from "../models/blogger";
import request from "../utils/request";

class FailarmyService {
    public static getList(keyword: string, page: number, pageSize: number): Promise<any> {
        return request.get("/api/v1/Failarmies/List", {
            params: {
                keyword,
                page,
                pageSize
            }
        });
    }

    public static create(dto: CreateFailarmyDto) {
        return request.post("/api/v1/Failarmies", dto);
    }

    public static update(dto: UpdateFailarmyDto) {
        return request.put("/api/v1/Failarmies", dto);
    }

    public static delete(id: string) {
        return request.delete("/api/v1/Failarmies/" + id);
    }
}

export {
    FailarmyService
}