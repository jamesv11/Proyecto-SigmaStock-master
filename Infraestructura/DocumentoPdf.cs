using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(IList<Persona> Clientes, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create); 

            Document document = new Document(iTextSharp.text.PageSize.LETTER, 80, 80, 40, 40);
            Paragraph parrafo = new Paragraph("INFORME DE CLIENTES REGISTRADOS");
            parrafo.Font.Size = 12;
            parrafo.Font.SetFamily("Times New Roman");
            PdfWriter writer = PdfWriter.GetInstance(document, stream); 
            document.AddAuthor("Aplicacion SigmaStock"); document.Open(); 
            document.Add(parrafo); 
            document.Add(new Paragraph("\n")); document.Add(LlenarTabla(Clientes)); 
            document.Close();
        }
        private PdfPTable LlenarTabla(IList<Persona> Clientes)
        {
            PdfPTable tabla = new PdfPTable(7);
            tabla.AddCell(new Paragraph("IDENTIFICACION")); 
            tabla.AddCell(new Paragraph("PRIMER_NOMBRE")); 
            tabla.AddCell(new Paragraph("PRIMER_APELLIDO")); 
            tabla.AddCell(new Paragraph("SEGUNDO_NOMBRE")); 
            tabla.AddCell(new Paragraph("DIRECCION"));
            tabla.AddCell(new Paragraph("TELEFONO"));
            tabla.AddCell(new Paragraph("TIPO_PERSONA"));

            foreach (var item in Clientes) { 
                tabla.AddCell(new Paragraph(item.DireccionPersona)); 
                tabla.AddCell(new Paragraph(item.PrimerNombre)); 
                tabla.AddCell(new Paragraph(item.SegundoApellido)); 
                tabla.AddCell(new Paragraph(item.DireccionPersona)); 
                tabla.AddCell(new Paragraph(item.NumeroTelefonico));
                tabla.AddCell(new Paragraph(item.TipoPersona));

            }
            return tabla;
        }
          
    }
}
