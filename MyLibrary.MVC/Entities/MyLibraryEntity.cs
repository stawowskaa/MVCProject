namespace MyLibrary.MVC.Entities
{
    public class MyLibraryEntity
    {
        public int Id { get; set; }
        public string Author { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string? Reader { get; set; }
        public string? DateOfReturn { get; set; }
        public string? Contact { get; set; }



    }
}
