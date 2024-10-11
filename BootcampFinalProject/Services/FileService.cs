namespace BootcampFinalProject.Services;

public class FileService : IFileService
{
    public FileService() { }
    public void DeleteFile(string fileNameWithExtension)
    {
        if (string.IsNullOrEmpty(fileNameWithExtension))
        {
            throw new ArgumentNullException(nameof(fileNameWithExtension));
        }

        var path = Path.Combine(Directory.GetCurrentDirectory(), $"Uploads", fileNameWithExtension);

        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Invalid file path");
        }
        File.Delete(path);
    }

    public async Task<string> SaveFileAsync(IFormFile file, string[] allowedFileExtensions, int maxFileSizeMB)
    {
        if (file == null)
        {
            throw new ArgumentNullException(nameof(file));
        }
        // Check file size
        if (file?.Length > maxFileSizeMB * 1024 * 1024) // Max Image Size given MB
        {
            throw new ArgumentException($"File size exceed the limit of {maxFileSizeMB}MB");
        }
        // Check the allowed extenstions
        var ext = Path.GetExtension(file.FileName);
        if (!allowedFileExtensions.Contains(ext.Replace(".","")))
        {
            throw new ArgumentException($"Only {string.Join(",", allowedFileExtensions)} are allowed.");
        }
        var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
        if (!Directory.Exists(uploadsFolderPath))
        {
            Directory.CreateDirectory(uploadsFolderPath);
        }

        // generate a unique filename
        var fileName = $"{Guid.NewGuid().ToString()}{ext}";
        var fileNameWithPath = Path.Combine(uploadsFolderPath, fileName);
        using var stream = new FileStream(fileNameWithPath, FileMode.Create);
        await file.CopyToAsync(stream);
        return fileName;
    }
}
