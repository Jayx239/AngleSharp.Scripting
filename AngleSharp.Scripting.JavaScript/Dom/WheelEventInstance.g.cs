namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Events;
    using Jint;
    using Jint.Runtime;
    using Jint.Native;
    using Jint.Native.Object;
    using System;

    partial class WheelEventInstance : MouseEventInstance
    {
        readonly EngineInstance _engine;

        public WheelEventInstance(EngineInstance engine)
            : base(engine)
        {
            _engine = engine;
            FastAddProperty("DOM_DELTA_PIXEL", (UInt32)(AngleSharp.Dom.Events.WheelMode.Pixel), false, true, false);
            FastAddProperty("DOM_DELTA_LINE", (UInt32)(AngleSharp.Dom.Events.WheelMode.Line), false, true, false);
            FastAddProperty("DOM_DELTA_PAGE", (UInt32)(AngleSharp.Dom.Events.WheelMode.Page), false, true, false);
        }

        public static WheelEventInstance CreateWheelEventObject(EngineInstance engine)
        {
            var obj = new WheelEventInstance(engine);
            obj.Extensible = true;
            obj.Prototype = engine.Jint.Object.PrototypeObject;            
            return obj;
        }

        public override String Class
        {
            get { return "WheelEvent"; }
        }

        public WheelEvent RefWheelEvent
        {
            get;
            set;
        }
    }
}