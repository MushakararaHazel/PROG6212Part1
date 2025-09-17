namespace CMCS.Models
{
    public class SupportingDocument
    {
        public int Id { get; set; }                 
        public int ClaimId { get; set; }           
        public string FileName { get; set; } = "";
        public string FileType { get; set; } = "";
        public DateTime UploadedOn { get; set; } = DateTime.UtcNow;
        public string? Description { get; set; }
    }
}
