using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using NuevaLibPDF;

﻿namespace LeerArchivosPDF;
class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"archivospdf"; // Cambia esta ruta a la carpeta donde están tus PDFs

        // Obtener todos los archivos PDF en la carpeta
       // string[] pdfFiles = Directory.GetFiles(folderPath, "*.pdf");
        // Obtener todos los archivos PDF en la carpeta y convertirlos a List<string>
        List<string> pdfFiles = new List<string>(Directory.GetFiles(folderPath, "*.pdf"));
       /* List<string> pdfFiles = Directory.GetFiles(folderPath, "*.pdf")
                                         .OrderBy(f => File.GetCreationTime(f))
                                         .ToList();*/
        pdfFiles.Sort();
        foreach (string pdfFile in pdfFiles)
        {
            Console.WriteLine(pdfFile); // Aquí puedes realizar acciones con cada archivo PDF
        }
        string outputPdf = "pdfFusionado.pdf";
        NuevaFusionarPDF p1=new NuevaFusionarPDF(pdfFiles,outputPdf);
        p1.MergeFiles();  
        Console.WriteLine("PDFs fusionados en: " + outputPdf);          

    }
}
