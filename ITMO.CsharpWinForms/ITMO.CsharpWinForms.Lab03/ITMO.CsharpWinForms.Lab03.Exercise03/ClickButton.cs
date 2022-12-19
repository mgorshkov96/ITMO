using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpWinForms.Lab03.Exercise03
{
    public class ClickButton : System.Windows.Forms.Button
    {
        int mClicks;

        public int Clicks
        {
            get { return mClicks; }
        }

        //Переопределите метод OnClick, чтобы инкрементировать закрытую
        //переменную mClicks каждый раз, когда щелкается кнопка
        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }

        //Переопределите метод OnPaint, чтобы отобразить количество
        //щелчков в правом нижнем углу элемента управления
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            System.Drawing.Graphics g = pevent.Graphics;
            System.Drawing.SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);
            g.DrawString(Clicks.ToString(), this.Font,
            System.Drawing.SystemBrushes.ControlText,
            this.Width - stringsize.Width - 3, this.Height -
            stringsize.Height - 3);
        }
    }
}
