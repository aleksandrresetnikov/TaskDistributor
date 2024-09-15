using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TaskDistributor.Components
{
    internal class InteractiveIcon : PictureBox
    {
        [Category("CatAppearance")]
        [Localizable(true)]
        [Bindable(true)]
        public Image commonImage;

        [Category("CatAppearance")]
        [Localizable(true)]
        [Bindable(true)]
        public Image hoverImage;

        [Category("CatAppearance")]
        [Localizable(true)]
        [Bindable(true)]
        public Image pressedImage;

        public InteractiveIcon() : base()
        {
            base.SizeMode = PictureBoxSizeMode.StretchImage;

            base.MouseEnter += this.MouseEntering;
            base.MouseLeave += this.MouseEntering;
            base.MouseDown  += this.MouseDowning;
            base.MouseUp    += this.MouseUpping;
        }

        private void MouseEntering(object sender, System.EventArgs e)
        {
            base.Image = this.hoverImage;
        }

        private void MouseLeaving(object sender, System.EventArgs e)
        {
            base.Image = this.commonImage;
        }

        private void MouseDowning(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            base.Image = this.pressedImage;
        }

        private void MouseUpping(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            base.Image = this.hoverImage;
        }
    }
}
