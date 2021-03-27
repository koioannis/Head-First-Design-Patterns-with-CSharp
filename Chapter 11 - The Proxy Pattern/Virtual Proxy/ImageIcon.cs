using System;

namespace Chapter_11___The_Proxy_Pattern.Virtual_Proxy
{
    public class ImageIcon : IICon
    {
        public int IconWidth { get; init; }
        public int IconHeight { get; init; }
        public void PaintIcon(int x, int y)
        {
            Console.WriteLine("An Album Cover");
        }
    }
}