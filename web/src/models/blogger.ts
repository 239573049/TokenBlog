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
    id: number;
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

export interface CreateArticleDto {
    title: string;
    content: string;
    categoryId: string;
    tabs: string;
}

export interface ResourceDto {
    id: string;
    title: string;
    description: string;
    url: string;
    downloadCount: number;
    referee: number;
    userName: string | null;
    href: string | null;
}

export interface CreateResourceDto {
    title: string;
    description: string;
    url: string;
    userName: string | null;
    href: string | null;
}

export interface UpdateResourceDto {
    id: string;
    title: string;
    url: string;
    description: string;
    userName: string | null;
    href: string | null;
}