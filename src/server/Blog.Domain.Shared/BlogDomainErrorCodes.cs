namespace Blog;

public static class BlogDomainErrorCodes
{
    private const string Default = "Blog:";

    public const string ColumnHeadingsCannotBeEmpty = Default + "ColumnHeadingsCannotBeEmpty";

    public const string ColumnTitleAlreadyExists = Default + "ColumnTitleAlreadyExists";

    public const string TagNameAlreadyExists = Default + "TagNameAlreadyExists";

    /* You can add your business exception error codes here, as constants */
}