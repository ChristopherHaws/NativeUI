﻿using System.Drawing;

namespace NativeUI
{
    public class UIMenuCheckboxItem : UIMenuItem
    {
        private Sprite _checkedSprite;


        /// <summary>
        /// Checkbox item with a toggleable checkbox.
        /// </summary>
        /// <param name="text">Item label.</param>
        /// <param name="check">Boolean value whether the checkbox is checked.</param>
        public UIMenuCheckboxItem(string text, bool check)
            : base(text)
        {
            int y = 0;
            _checkedSprite = new Sprite("commonmenu", "shop_box_blank", new Point(260, y + 85), new Size(35, 35));
            Checked = check;
        }


        /// <summary>
        /// Change or get whether the checkbox is checked.
        /// </summary>
        public bool Checked { get; set; }


        /// <summary>
        /// Change item's position.
        /// </summary>
        /// <param name="y">New Y value.</param>
        public override void Position(int y)
        {
            base.Position(y);
            _checkedSprite.Position = new Point(260 + Offset.X, y + 85 + Offset.Y);
        }


        /// <summary>
        /// Draw item.
        /// </summary>
        public override void Draw()
        {
            base.Draw();
            if (Selected)
            {
                _checkedSprite.TextureName = Checked ? "shop_box_tickb" : "shop_box_blankb";
            }
            else
            {
                _checkedSprite.TextureName = Checked ? "shop_box_tick" : "shop_box_blank";
            }
            _checkedSprite.Draw();
        }
    }
}