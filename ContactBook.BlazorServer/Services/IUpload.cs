using BlazorInputFile;

namespace ContactBook.BlazorServer.Services
{
    public interface IUpload
    {
        public void UploadFile(IFileListEntry file, MemoryStream str, string fileName);
        public void RemoveFile(string fileName);
    }
}
