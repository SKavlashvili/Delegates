namespace TestConsoleAPP
{
    public class Store
    {
        private string _shopName;
        private Article[] _articles;
        private int _size;
        private int _logicalSize;
        public Store(string shopName)
        {
            _shopName = shopName;
            _articles = new Article[1];
            _size = 1;
            _logicalSize = 0;
        }

        public void AddArticle(Article article)
        {
            if (_logicalSize == _size)
            {
                Article[] temp = _articles;
                _articles = new Article[_size * 2];
                for(int i = 0; i < _size; i++)
                {
                    _articles[i] = temp[i];
                }
                _size *= 2;
            }
            article.ShopName = _shopName;
            _articles[_logicalSize] = article;
            _logicalSize++;
        }
        private int GetArticleIndexWithName(string name)
        {
            for(int i = 0; i < _logicalSize; i++)
            {
                if (_articles[i].GetName().Equals(name)) return i;
            }
            return -1;
        }
        public string this[string name]
        {
            get
            {
                if (GetArticleIndexWithName(name) == -1) return "there is not Article with this name";
                return _articles[GetArticleIndexWithName(name)].ToString();
            }
        }
    }
}
