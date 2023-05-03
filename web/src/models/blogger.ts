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
    background: string;
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
    selected: boolean;
}

export interface CategoryDto {
    id: string;
    name: string;
    path: string;
    description: string;
    createdTime: string;
    count: number;
}