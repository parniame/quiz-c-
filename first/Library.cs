namespace ConsoleApp6
{
    public class Library <T> where T : LibraryItem
    {
        private List<T> _libraryItems = new List<T>();
        public void ADD(T item)

        {
                if(_libraryItems.Count != 0) { item.ID = _libraryItems.Last().ID+ 1; }
                else { item.ID = 0; }
                
            
            _libraryItems.Add(item);
        }
        public void REMOVE(T item) {
           
            if (item != null)
            {
                _libraryItems.Remove(item);
            }

            
        }
        public void ShowAllList()
        {
            foreach (var item in _libraryItems)
            {
                item.Display();
            }
        }
        private void ShowAllList(List<T> list)
        {
            foreach (var item in list)
            {
                item.Display();
            }
        }
        public void Search(string name)
        {
            var filtered =  _libraryItems.Where(x => x.Name == name).ToList();
            ShowAllList(filtered);
        }
        public void Search(int ID)
        {
             var filtered = _libraryItems.Where(x => x.ID == ID).ToList();
            ShowAllList(filtered);
        }

    }
}
