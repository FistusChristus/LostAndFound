using System;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Data;
using System.Data.SqlClient;

namespace Gmap_Markers
{
    public partial class Form1 : Form
    {
        //public static GMapMarker item { get; set; } 
        public static bool flag { get; set; }
        public static string login { get; set; }

        // Класс маркер с картинкой
        class GMapMarkerImage : GMapMarker
        {   // Картинка

           private Image image;
           public Image Image
            {
                // Получить картинку
                get
                {
                    return image;
                }

                // Размер картинки
                set
                {
                    image = value;
                    if (image != null)
                    {
                        Size = new Size(image.Width, image.Height);
                    }
                }
            }

            public Pen Pen { get; set; }

            public Pen OutPen { get; set; }

            public GMapMarkerImage(PointLatLng p, Image image): base(p)
            {
                Size = new Size(image.Width, image.Height);
                Offset =  new Point(-Size.Width / 2, -Size.Height / 2);
                this.image = image;
                Pen = null;
                OutPen = null;
            }

            public override void OnRender(Graphics g)
            {
                if (image == null)
                    return;

                Rectangle rect = new Rectangle(LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
                g.DrawImage(image, rect);

                if (Pen != null)
                    g.DrawRectangle(Pen, rect);

                if (OutPen != null)
                    g.DrawEllipse(OutPen, rect);
            }
        }

        public Form1()
        {
            InitializeComponent();
           
        }

        // Переменная отвечающая за состояние нажатия ЛКМ
        private bool isLeftButtonDown = false;

        // Переменная нового класса, для замены стандартного маркера.
        private GMapMarkerImage currentMarker;

        // Слой
        private GMapOverlay markersOverlay;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            model model = new model();
            model.Sort_Db();
       





            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Zoom = 15;
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider =GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(55.75393, 37.620795);
            markersOverlay = new GMapOverlay(gMapControl1, "marker");
            gMapControl1.MouseClick += new MouseEventHandler(mapControl_MouseClick);
            gMapControl1.MouseDown += new MouseEventHandler(mapControl_MouseDown);
            gMapControl1.MouseUp += new MouseEventHandler(mapControl_MouseUp);
           // gMapControl1.MouseMove += new MouseEventHandler(mapControl_MouseMove);
           
            gMapControl1.OnMarkerEnter += new MarkerEnter(mapControl_OnMarkerEnter);
            gMapControl1.Overlays.Add(markersOverlay);
           


        }

        // Метод, отвечающий за перемещение маркера ЛКМ по карте и отображения подсказки с текущими координатами маркера
        //void mapControl_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //Проверка, что нажата ЛКМ
        //    if (e.Button == MouseButtons.Left && isLeftButtonDown)
        //    {
        //        if (currentMarker != null)
        //        {
        //            // Точку которую выбрали на карте
        //            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
        //            // Получение координат маркера
        //            currentMarker.Position = point;
        //            // Вывод координат маркера в подсказке
        //            currentMarker.ToolTipText = string.Format("{0},{1}", point.Lat, point.Lng);
        //        }
        //    }
        //}

        void mapControl_MouseUp(object sender, MouseEventArgs e)
        {
            //Выполняем проверку, какая клавиша мыши была отпущена, если левая, то устанавливаем переменной значение false.
            if (e.Button == MouseButtons.Left)
                isLeftButtonDown = false;        
        }

        void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            // Выполняем проверку, какая клавиша мыши была нажата, если левая, то устанавливаем переменной значение true.

            if (e.Button == MouseButtons.Left && currentMarker!=null )
            {
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                if (Convert.ToInt32(currentMarker.Position.Lat) == Convert.ToInt32(point.Lat) && Convert.ToInt32(currentMarker.Position.Lng) == Convert.ToInt32(point.Lng))
                {
                    Settings settings = new Settings();
                    foreach (var item in Db_Ad.AdList)
                    {
                        if(item.PointX-e.X<5 && item.PointY-e.Y< 5 || item.PointX - e.X > -5 && item.PointY - e.Y > 5)
                        {
                            
                            
                            Settings.Item = item;
                            
                        }
                    }
                    settings.ShowDialog();
                }
                currentMarker = null;
            }
            isLeftButtonDown = true;
        }

        // Устанавливаем вокруг маркера красный квадрат
        void mapControl_OnMarkerEnter(GMapMarker item)
        {
            if (item is GMapMarkerImage)
            {

                
                currentMarker = item as GMapMarkerImage;
                currentMarker.Pen = new Pen(Brushes.Red, 2);
            }
            
           
               
            
        }

        void mapControl_MouseClick(object sender, MouseEventArgs e)
        {

            // Выполняем проверку, какая клавиша мыши была нажата, если правая, то выполняем установку маркера.
            if (e.Button == MouseButtons.Right)
            {
                // Если надо установить только один маркер, то выполняем очистку списка маркеров
                
                PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y); 

                //Инициализируем новую переменную изображения и загружаем в нее изображение маркера, лежащее возле исполняемого файла
                Bitmap bitmap = Bitmap.FromFile(Application.StartupPath+@"\marker.png") as Bitmap; 

                // Инициализируем новый маркер с использованием созданного нами маркера.
                GMapMarker marker = new GMapMarkerImage(point, bitmap);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

                // Добавляем маркер в список маркеров.
                markersOverlay.Markers.Add(marker);
                Db_Ad Newitem =  new Db_Ad();
                Newitem.PointX = e.X;
                Newitem.PointY = e.Y;
                Db_Ad.AdList.Add(Newitem);
                PointSettings pointSettings = new PointSettings();
                pointSettings.ShowDialog();

            }
        }

       
        private void gMapControl1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            markersOverlay.Markers.Clear();
            for (int i = 0; i < Db_Ad.AdList.Count; i++)
            {


                PointLatLng point = gMapControl1.FromLocalToLatLng(Db_Ad.AdList[i].PointX, Db_Ad.AdList[i].PointY);

                //Инициализируем новую переменную изображения и загружаем в нее изображение маркера, лежащее возле исполняемого файла
                Bitmap bitmap = Bitmap.FromFile(Application.StartupPath + @"\marker.png") as Bitmap;

                // Инициализируем новый маркер с использованием созданного нами маркера.
                GMapMarker marker = new GMapMarkerImage(point, bitmap);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

                // Добавляем маркер в список маркеров.
                markersOverlay.Markers.Add(marker);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            markersOverlay.Markers.Clear();
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSet txtSet = new txtSet();
            txtSet.ShowDialog();
        }
    }
}