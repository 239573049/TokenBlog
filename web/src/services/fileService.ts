import request from "../utils/request";

class FileService {
    public static UploadImage(form:FormData): Promise<any> {
        return request.postForm('/api/v1/Files/UploadImage', form, {
            headers: {
                'Content-Type': 'multipart/form-data'
            }
        });
    }
}

export{
    FileService
}