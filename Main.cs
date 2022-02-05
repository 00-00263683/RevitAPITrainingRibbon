using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RevitAPITrainingRibbon
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Revit API training"; 
            application.CreateRibbonTab(tabName); 
            string utilsFolderPach = @"C:\RevitAPITrainig\";
            
            var panel1 = application.CreateRibbonPanel(tabName, "Создание кнопок");

            var button1 = new PushButtonData("Создание кнопок", "Создание кнопок",
                Path.Combine(utilsFolderPach, "RevitAPITrainingUI.dll"),
                "RevitAPITrainingUI.Main"); 

            Uri uriImage1 = new Uri(@"C:\RevitAPITrainig\Images\RevitAPITrainingUI_32.png", UriKind.Absolute);
            BitmapImage largeImage1 = new BitmapImage(uriImage1); 
            button1.LargeImage = largeImage1; 

            panel1.AddItem(button1);

            var panel2 = application.CreateRibbonPanel(tabName, "Изменить тип стен");

            var button2 = new PushButtonData("Изменить тип стен", "Изминить тип стен",
                Path.Combine(utilsFolderPach, "RevitAPITrainingUI_5_2.dll"),
                "RevitAPITrainingUI_5_2.Main");

            Uri uriImage2 = new Uri(@"C:\RevitAPITrainig\Images\RevitAPITrainingUI_32.png", UriKind.Absolute);
            BitmapImage largeImage2 = new BitmapImage(uriImage2); 
            button2.LargeImage = largeImage2; 

            panel2.AddItem(button2); 

            return Result.Succeeded;  
        }
    }
}
