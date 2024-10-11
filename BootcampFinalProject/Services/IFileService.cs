namespace BootcampFinalProject.Services;

public interface IFileService
{
    Task<string> SaveFileAsync(IFormFile file, string[] allowedFileExtensions, int maxFileSizeMB = 2);
    void DeleteFile(string fileNameWithExtension);
}
