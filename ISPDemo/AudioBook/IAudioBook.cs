using System;
namespace ISPDemo
{
    public interface IAudioBook : ILibraryItem
    {
        public int RunTimeInMinutes { get; set; }
    }
}
