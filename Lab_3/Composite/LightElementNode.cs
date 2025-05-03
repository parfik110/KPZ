using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public TagCloseType CloseType { get; }
        public List<string> CssClasses { get; } = new();
        public List<LightNode> Children { get; } = new();
        private readonly EventManager _eventManager = new();

        public LightElementNode(string tagName, DisplayType display, TagCloseType closeType)
        {
            TagName = tagName;
            Display = display;
            CloseType = closeType;
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
        }

        public void SubscribeEvent(string eventType, Action handler)
        {
            _eventManager.Subscribe(eventType, handler);
        }

        public void TriggerEvent(string eventType)
        {
            _eventManager.Trigger(eventType);
        }
        public void RemoveClass(string className)
        {
            CssClasses.Remove(className);
        }
        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                    sb.Append(child.OuterHTML);
                return sb.ToString();
            }
        }

        public override string OuterHTML
        {
            get
            {
                string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

                if (CloseType == TagCloseType.Single)
                    return $"<{TagName}{classAttr}/>";
                else
                    return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
            }
        }
    }

}
