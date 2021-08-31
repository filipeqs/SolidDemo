using System;
using System.Collections.Generic;

namespace ISPDemo
{
    public interface IDVD : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }
        List<string> Actors { get; set; }
    }
}
