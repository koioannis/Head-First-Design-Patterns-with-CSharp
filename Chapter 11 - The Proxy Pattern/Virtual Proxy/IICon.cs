namespace Chapter_11___The_Proxy_Pattern.Virtual_Proxy
{
    public interface IICon
    {
        int IconWidth { get; }
        
        int IconHeight { get; }

        void PaintIcon(int x, int y);
    }
}