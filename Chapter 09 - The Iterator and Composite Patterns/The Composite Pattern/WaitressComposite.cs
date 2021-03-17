namespace Chapter_09___The_Iterator_and_Composite_Patterns.The_Composite_Pattern
{
    public class WaitressComposite
    {
        private readonly MenuComponent _allMenus;

        public WaitressComposite(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}