using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace Laba_5 
{ 
    class Replacement
    {
        static void Main()
        {
            string f_path = "D:\\C\\Shablon.docx";
            string n_path = "D:\\C\\New.docx";

            string carName = "CarName";
            string carType = "CarType";
            string carModel = "CarModel";

            File.Copy(f_path, n_path, true);

            using (WordprocessingDocument newInstance = WordprocessingDocument.Open(n_path, true))
            {
                var heandle = newInstance.MainDocumentPart.Document.Body;
                foreach (var paragraph in heandle.Descendants<Paragraph>())
                {
                    foreach (var text in paragraph.Descendants<Text>())
                    {
                        if (text.Text.Contains(carName)) 
                            text.Text = text.Text.Replace(carName, Car.CarName);
                        if (text.Text.Contains(carType))
                            text.Text = text.Text.Replace(carType, Car.CarType);
                        if (text.Text.Contains(carModel))
                            text.Text = text.Text.Replace(carModel, Car.CarModel); 
                    }
                }
                newInstance.MainDocumentPart.Document.Save();
            }
        }
    }
}