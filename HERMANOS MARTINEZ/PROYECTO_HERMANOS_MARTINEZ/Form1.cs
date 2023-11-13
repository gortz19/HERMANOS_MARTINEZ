using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PROYECTO_HERMANOS_MARTINEZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
   
            int borderRadius = 6;

            GraphicsPath path1 = new GraphicsPath();
            path1.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Esquina superior izquierda
            path1.AddArc(LIBROS_GENERALESBTN.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Esquina superior derecha
            path1.AddArc(LIBROS_GENERALESBTN.Width - borderRadius * 2, LIBROS_GENERALESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Esquina inferior derecha
            path1.AddArc(0, LIBROS_GENERALESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Esquina inferior izquierda
            LIBROS_GENERALESBTN.Region = new Region(path1);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Esquina superior izquierda
            path2.AddArc(ASIGNAR_VIAJESBTN.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Esquina superior derecha
            path2.AddArc(ASIGNAR_VIAJESBTN.Width - borderRadius * 2, ASIGNAR_VIAJESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Esquina inferior derecha
            path2.AddArc(0, ASIGNAR_VIAJESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Esquina inferior izquierda
            ASIGNAR_VIAJESBTN.Region = new Region(path2);

            GraphicsPath path3 = new GraphicsPath();
            path3.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Esquina superior izquierda
            path3.AddArc(GENERAR_REPORTESNTN.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Esquina superior derecha
            path3.AddArc(GENERAR_REPORTESNTN.Width - borderRadius * 2, VALESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Esquina inferior derecha
            path3.AddArc(0, GENERAR_REPORTESNTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Esquina inferior izquierda
            GENERAR_REPORTESNTN.Region = new Region(path3);

            GraphicsPath path4 = new GraphicsPath();
            path4.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Esquina superior izquierda
            path4.AddArc(FACTURASBTN.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Esquina superior derecha
            path4.AddArc(FACTURASBTN.Width - borderRadius * 2, FACTURASBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Esquina inferior derecha
            path4.AddArc(0, FACTURASBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Esquina inferior izquierda
            FACTURASBTN.Region = new Region(path4);

            GraphicsPath path5 = new GraphicsPath();
            path5.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Esquina superior izquierda
            path5.AddArc(REPORTESBTN.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Esquina superior derecha
            path5.AddArc(REPORTESBTN.Width - borderRadius * 2, REPORTESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Esquina inferior derecha
            path5.AddArc(0, REPORTESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Esquina inferior izquierda
            REPORTESBTN.Region = new Region(path5);

            GraphicsPath path6 = new GraphicsPath();
            path6.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Esquina superior izquierda
            path6.AddArc(VALESBTN.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Esquina superior derecha
            path6.AddArc(VALESBTN.Width - borderRadius * 2, VALESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Esquina inferior derecha
            path6.AddArc(0, VALESBTN.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Esquina inferior izquierda
            VALESBTN.Region = new Region(path6);

            int Radius = 8;

            REGISTRAR_EMPLEADOSBTN.FlatStyle = FlatStyle.Flat;
            REGISTRAR_EMPLEADOSBTN.FlatAppearance.BorderColor = Color.DarkOrchid;

            REGISTRAR_VIAJESBTN.FlatStyle = FlatStyle.Flat;
            REGISTRAR_VIAJESBTN.FlatAppearance.BorderColor = Color.DarkOrchid;

            GraphicsPath path7 = new GraphicsPath();
            path7.AddArc(0, 0, Radius * 2, Radius * 2, 180, 90); // Esquina superior izquierda
            path7.AddArc(REGISTRO_VEHICULOSBTN.Width - Radius * 2, 0, Radius * 2, Radius * 2, 270, 90); // Esquina superior derecha
            path7.AddArc(REGISTRO_VEHICULOSBTN.Width - Radius * 2, REGISTRO_VEHICULOSBTN.Height - Radius * 2, Radius * 2, Radius * 2, 0, 90); // Esquina inferior derecha
            path7.AddArc(0, REGISTRO_VEHICULOSBTN.Height - Radius * 2, Radius * 2, Radius * 2, 90, 90); // Esquina inferior izquierda
            REGISTRO_VEHICULOSBTN.Region = new Region(path7);

            GraphicsPath path8 = new GraphicsPath();
            path8.AddArc(0, 0, Radius * 2, Radius * 2, 180, 90); // Esquina superior izquierda
            path8.AddArc(REGISTRAR_EMPLEADOSBTN.Width - Radius * 2, 0, Radius * 2, Radius * 2, 270, 90); // Esquina superior derecha
            path8.AddArc(REGISTRAR_EMPLEADOSBTN.Width - Radius * 2, REGISTRAR_EMPLEADOSBTN.Height - Radius * 2, Radius * 2, Radius * 2, 0, 90); // Esquina inferior derecha
            path8.AddArc(0, REGISTRAR_EMPLEADOSBTN.Height - Radius * 2, Radius * 2, Radius * 2, 90, 90); // Esquina inferior izquierda
            REGISTRAR_EMPLEADOSBTN.Region = new Region(path8);

            GraphicsPath path9 = new GraphicsPath();
            path9.AddArc(0, 0, Radius * 2, Radius * 2, 180, 90); // Esquina superior izquierda
            path9.AddArc(REGISTRAR_VIAJESBTN.Width - Radius * 2, 0, Radius * 2, Radius * 2, 270, 90); // Esquina superior derecha
            path9.AddArc(REGISTRAR_VIAJESBTN.Width - Radius * 2, REGISTRAR_VIAJESBTN.Height - Radius * 2, Radius * 2, Radius * 2, 0, 90); // Esquina inferior derecha
            path9.AddArc(0, REGISTRAR_VIAJESBTN.Height - Radius * 2, Radius * 2, Radius * 2, 90, 90); // Esquina inferior izquierda
            REGISTRAR_VIAJESBTN.Region = new Region(path9);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Restaura la ventana al estado normal
            }


        }

        
        private void LIBROS_GENERALESBTN_Click(object sender, EventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
