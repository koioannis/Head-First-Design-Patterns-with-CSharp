using System;
using System.Threading;

namespace Chapter_11___The_Proxy_Pattern.Virtual_Proxy
{
    public class ImageProxy : IICon
    {
        public int IconWidth => ImageIcon?.IconHeight ?? 800;

        public int IconHeight => ImageIcon?.IconHeight ?? 600;
        
        public ImageIcon ImageIcon { private get; set; }

        private bool _retrieving = false;

        public void PaintIcon(int x, int y)
        {
            if (ImageIcon is not null)
            {
                ImageIcon.PaintIcon(x, y);
                return;
            }
        
            // Pretend to download and display an image from the url
            if (!_retrieving)
            {
                Console.WriteLine("Loading Album Cover, please wait...");
                _retrieving = true;
                var thread = CreateThread(x, y);
                thread.Start();
            }
        }

        private Thread CreateThread(int x, int y)
        {
            var thread = new Thread(() =>
            {
                Console.WriteLine("Downloading Image");
                for (var i = 0; i <= 100; i+=10)
                {
                    Console.Write($"{i}% ");
                    Thread.Sleep(400);
                }

                Console.WriteLine("\nImage Downloaded");
                
                // Then we finally create the image icon and display it...
                ImageIcon = new ImageIcon
                {
                    IconHeight = 400,
                    IconWidth = 400,
                };
                ImageIcon.PaintIcon(x, y);
                _retrieving = false;
            });

            return thread;
        }
    }
}