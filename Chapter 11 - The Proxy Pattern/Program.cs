using System;
using Chapter_11___The_Proxy_Pattern.Virtual_Proxy;

namespace Chapter_11___The_Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageProxy = new ImageProxy();

            imageProxy.PaintIcon(400, 400);
            imageProxy.PaintIcon(400, 400);
        }
    }
}