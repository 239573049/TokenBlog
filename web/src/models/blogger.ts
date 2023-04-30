export interface GetArticleListDto {
    id: string;
    title: string;
    content: string;
    publishTime: string;
    userId: string;
    userName: string;
    readCount: number;
    like: number;
    categoryId: string;
    creationTime: string;
    categoryName: string;
}

export interface TabDto {
    id: string;
    name: string;
}