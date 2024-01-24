using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using Font = iTextSharp.text.Font;

namespace GeStionB.Ordonnances
{
    internal class PdfCreator
    {
        public void CreatePDF(string filePath, string id_o, string nom_m, string date_o, string nom_p, string libelle_med, string posologie,string duree, string instructions) {

            String OutFile = filePath + "\\ordonnance " + id_o + ".pdf";
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(OutFile, FileMode.Create));
            doc.Open();

            BaseColor noir = new BaseColor(0, 0, 0);

            Font policeTitre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD, noir);
            Font policeParagraphe = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL, noir);


            Paragraph InfoMedecin = new Paragraph("DR."+nom_m+ "\nLaboratoires GSB \n21 rue des Lisette, 92220 Bagneux",policeTitre);
            InfoMedecin.Alignment = Element.ALIGN_LEFT;
            doc.Add(InfoMedecin);
  

            Paragraph separateur = new Paragraph("======================================================");
            separateur.Alignment = Element.ALIGN_CENTER;
            doc.Add(separateur);

            Paragraph date = new Paragraph("Fait le"+ date_o , policeParagraphe);
            date.Alignment = Element.ALIGN_RIGHT;
            doc.Add(date);
            doc.Add(separateur);

            Paragraph Patient = new Paragraph("Ordonnance medicale pour : Mr/Mme "+ nom_p);
            Patient.Alignment = Element.ALIGN_LEFT;
            doc.Add(Patient);
            doc.Add(separateur);

            Paragraph Contenu  = new Paragraph("Medicament prescrit: " + libelle_med + "\n" + posologie + " pendant " + duree + " jours");
            Contenu.Alignment = Element.ALIGN_CENTER;
            doc.Add(Contenu);
            doc.Add(separateur);

            Paragraph Instructions = new Paragraph(instructions);
            Instructions.Alignment = Element.ALIGN_CENTER;
            doc.Add(Instructions);
            doc.Add(separateur);

            doc.Close();
            //ferme le document
            Process.Start(new ProcessStartInfo
            {
                FileName = OutFile,
                UseShellExecute = true
            });

        }
    }
}
 