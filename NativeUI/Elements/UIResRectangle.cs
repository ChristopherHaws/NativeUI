using System.Drawing;
using GTA.Native;
using GTA.UI;

namespace NativeUI
{
    /// <summary>
    /// A rectangle in 1080 pixels height system.
    /// </summary>
    public class UIResRectangle : ContainerElement
    {
        public UIResRectangle()
        { }

        public UIResRectangle(PointF pos, SizeF size) : base(pos, size)
        { }

        public UIResRectangle(PointF pos, SizeF size, Color color) : base(pos, size, color)
        { }
        
        public override void Draw(SizeF offset)
        {
            if (!Enabled) return;
            int screenw = GTA.UI.Screen.Resolution.Width;
            int screenh = GTA.UI.Screen.Resolution.Height;
            const float height = 1080f;
            float ratio = (float)screenw / screenh;
            var width = height * ratio;

            float w = Size.Width/width;
            float h = Size.Height/height;
            float x = ((Position.X + offset.Width)/width) + w*0.5f;
            float y = ((Position.Y + offset.Height)/height) + h*0.5f;

            Function.Call(Hash.DRAW_RECT, x, y, w, h, Color.R, Color.G, Color.B, Color.A);
        }

        public static void Draw(float xPos, float yPos, float boxWidth, float boxHeight, Color color)
        {
            int screenw = GTA.UI.Screen.Resolution.Width;
            int screenh = GTA.UI.Screen.Resolution.Height;
            const float height = 1080f;
            float ratio = (float)screenw / screenh;
            var width = height * ratio;

            float w = boxWidth / width;
            float h = boxHeight / height;
            float x = ((xPos) / width) + w * 0.5f;
            float y = ((yPos) / height) + h * 0.5f;

            Function.Call(Hash.DRAW_RECT, x, y, w, h, color.R, color.G, color.B, color.A);
        }
    }
}