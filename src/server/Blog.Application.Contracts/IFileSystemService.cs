using System.IO;
using System.Threading.Tasks;

namespace Blog;

public interface IFileSystemService
{
    /// <summary>
    /// 上传保存
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="fileName"></param>
    /// <returns></returns>
    Task<string> Uploading(Stream stream, string fileName);
}