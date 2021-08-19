using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace DataLand
{
    public class VoidButton : Button
    {
        // Colors
        private Color hoverForeColor = Color.FromArgb(24, 173, 254);
        private Color nonHoverForeColor = Color.FromArgb(4, 153, 234);

        // Images
        private Image hoverPicture;

        [
            Category("Hover Options"),
            Description("Sets the fore color when mouse is down on the button."),
        ]
        public Color HoverForeColor
        {
            get
            {
                return hoverForeColor;
            }
            set
            {
                hoverForeColor = value;
                this.Invalidate();
            }
        }

        [
            Category("Hover Options"),
            Description("Sets the image when mouse is down on the button."),
        ]
        public Image HoverPicture
        {
            get
            {
                return hoverPicture;
            }
            set
            {
                hoverPicture = value;
                this.Invalidate();
            }
        }

        public VoidButton()
        {
            // Button Colors
            this.BackColor = Color.FromArgb(24, 30, 54);
            this.ForeColor = nonHoverForeColor;

            // Button Flat Appearance
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.MouseDownBackColor = this.BackColor;
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.FlatAppearance.BorderSize = 0;

            // Button Text Options
            this.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ImageAlign = ContentAlignment.MiddleRight;

            // Button Size
            this.Size = new Size(200, 50);

            // Button Padding
            this.Padding = new Padding(15, 0, 15, 0);

            // Button Cursor
            this.Cursor = Cursors.Hand;
        }

        // Hover Method
        protected override void OnMouseEnter(EventArgs e)
        {
            this.ForeColor = HoverForeColor;
            this.Image = hoverPicture;
        }

        // NonHover Method
        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = nonHoverForeColor;
            this.Image = this.Image;
        }
    }
}