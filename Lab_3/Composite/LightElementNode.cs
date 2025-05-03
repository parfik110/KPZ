using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public Dictionary<string, string> Styles { get; } = new();

        private IElementState _state = new VisibleState();
        private LightLifecycleHooks _lifecycleHooks = new DefaultLifecycleHooks();

        public LightElementNode(string tagName, DisplayType display, TagCloseType closeType)
        {
            TagName = tagName;
            Display = display;
            CloseType = closeType;

            _lifecycleHooks.OnCreated(this);
        }

        public void SetLifecycleHooks(LightLifecycleHooks hooks)
        {
            _lifecycleHooks = hooks;
        }

        public void AddClass(string className)
        {
            if (!CssClasses.Contains(className))
                CssClasses.Add(className);
        }

        public void RemoveClass(string className)
        {
            CssClasses.Remove(className);
        }

        public void AddChild(LightNode node)
        {
            Children.Add(node);
            _lifecycleHooks.OnInserted(this);
        }

        public void AddStyle(string key, string value)
        {
            Styles[key] = value;
        }

        private string RenderStyle()
        {
            if (Styles.Count == 0) return "";
            return $" style=\"{string.Join("; ", Styles.Select(s => $"{s.Key}: {s.Value}"))}\"";
        }

        public void SubscribeEvent(string eventType, Action handler)
        {
            _eventManager.Subscribe(eventType, handler);
        }

        public void TriggerEvent(string eventType)
        {
            _eventManager.Trigger(eventType);
        }

        public void SetState(IElementState newState)
        {
            _state = newState;
            _state.ApplyState(this);
        }

        public void Remove()
        {
            _lifecycleHooks.OnRemoved(this);
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
                _lifecycleHooks.OnRendered(this);

                string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
                string styleAttr = RenderStyle();

                if (CloseType == TagCloseType.Single)
                    return $"<{TagName}{classAttr}{styleAttr}/>";
                else
                    return $"<{TagName}{classAttr}{styleAttr}>{InnerHTML}</{TagName}>";
            }
        }
    }
}
