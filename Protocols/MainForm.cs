using System.Drawing;
using System.Windows.Forms;
using Protocols.Libs.Models.Protocols;

namespace Protocols
{
    public partial class MainForm : Form
    {
        private ProtocolRepository _repository = new ProtocolRepository();
        private Pen _blackPen = new Pen(Color.Black);
        private Font _arialFont = new Font("Arial", 12);
        private SolidBrush _blackBrush = new SolidBrush(Color.Black);
        private Point _basePoint;

        public MainForm()
        {
            InitializeComponent();
            this._basePoint.X = this.MainPictureBox.Width / 2;
            this._basePoint.Y = this.MainPictureBox.Height / 2;
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(this._blackPen, 20, 40, 20, 80);

            Protocol protocol = _repository.SelectById(1);

            Point baseIdPoint = new Point(
                this._basePoint.X - this._basePoint.X + 20,
                this._basePoint.Y - this._basePoint.Y + 40
                );
            

            Point baseRectanglePoint = new Point(15, 35);

            DrawStrings(e.Graphics, protocol, this._arialFont, this._blackBrush, baseIdPoint);
            DrawRectangle(e.Graphics, this._blackPen, baseRectanglePoint, 100, 400);
        }

        public static void DrawStrings(Graphics graphics, Protocol protocol, Font font, SolidBrush brush, Point point)
        {
            graphics.DrawString(protocol.Id.ToString(), font, brush, point);
            graphics.DrawString(protocol.Device, font, brush, point.X, point.Y + 20);
            graphics.DrawString(protocol.Address, font, brush, point.X, point.Y + 40);
        }

        public static void DrawRectangle(Graphics graphics, Pen pen, Point point, int height, int width)
        {
            graphics.DrawRectangle(pen, point.X, point.Y, width, height);
        }

        private void MainPictureBox_Resize(object sender, System.EventArgs e)
        {
            this.MainPictureBox.Refresh();
        }
    }
}
