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
    show: boolean;
}
export interface ArticleDto {
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
    tabs: string;
}

export interface TabDto {
    id: string;
    name: string;
}

export interface CategoryDto {
    id: string;
    name: string;
    path: string;
    description: string;
    createdTime: string;
    count: number;
}