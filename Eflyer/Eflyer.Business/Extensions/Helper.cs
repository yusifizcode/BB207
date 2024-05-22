using Eflyer.Business.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Eflyer.Business.Extensions;

public class Helper
{
    public static string SaveFile(string rootPath, string folder, IFormFile formFile)
    {
        if (!formFile.ContentType.Contains("image/"))
            throw new FileContentTypeException("ImageFile", "ImageFile content type is not correct!");

        if (formFile.Length > 2097152)
            throw new FileSizeException("ImageFile", "ImageFile size must be lower than 2mb!");

        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName); // asdadsasda.png

        string path = rootPath + @$"\{folder}\" + fileName;

        using (FileStream fileStream = new FileStream(path, FileMode.Create))
        {
            formFile.CopyTo(fileStream);
        }

        return fileName;
    }

    public static void DeleteFile(string rootPath, string folder, string fileName)
    {
        string existImageUrlPath = rootPath + @$"\{folder}\" + fileName;
        if (!File.Exists(existImageUrlPath))
            throw new EntityFileNotFoundException("", "File not found!");

        File.Delete(existImageUrlPath);
    }
}
