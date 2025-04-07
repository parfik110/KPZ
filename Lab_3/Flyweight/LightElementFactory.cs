namespace Flyweight
{
    public static class LightElementFactory
    {
        private static readonly Dictionary<string, LightElementNode> _elements = new();

        public static LightElementNode GetElement(string tagName)
        {
            if (!_elements.ContainsKey(tagName))
            {
                var element = new LightElementNode(tagName, DisplayType.Block, TagCloseType.Pair);
                _elements[tagName] = element;
            }

            var baseElement = _elements[tagName];
            var copy = new LightElementNode(baseElement.TagName, baseElement.Display, baseElement.CloseType);
            copy.CssClasses.AddRange(baseElement.CssClasses);
            return copy;
        }

        public static int Count => _elements.Count;
    }
}
