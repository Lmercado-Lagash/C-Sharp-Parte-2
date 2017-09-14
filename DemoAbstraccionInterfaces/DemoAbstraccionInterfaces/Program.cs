using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstraccionInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("USO DE CLASES ABSTRACTAS");
            Console.WriteLine("========================");
            Console.WriteLine("");

            // Control c = new Control();   <---- No se puede instanciar desde una clase abstracta directamente

            // Pero si a las clases que derivan de una clase abstracta como Button y TextBlock

            Control button = new Button(0, 0, "Click Me!");
            Control textBlock = new TextBlock(20, 20, "Hola Mundo");

            List<Control> controls = new List<Control>();
            controls.Add(button);
            controls.Add(textBlock);

            foreach(Control ctrl in controls)
            {
                ctrl.DrawMe();
            }

            Console.WriteLine("");
            Console.WriteLine("========================");
            Console.WriteLine("USO DE INTERFACES");
            Console.WriteLine("========================");
            Console.WriteLine("");

            var myDoc = new Document();
            myDoc.Print();
            myDoc.CountCharacters();

            // Printable mySecondDoc = new Printable(); <--- No se puede instanciar desde main o alguna clase q no implemente la interfaz

            Printable printableItem = myDoc;
            printableItem.Print();
            // printableItem.CountCharacters(); <- no se puede llamar desde un item interfaz a un 
            //                                      metodo o atributo de una clase que lo implementa
            //                                      SALVO QUE SE USE LA SIGUIENTE FORMA:
            Document theDoc = printableItem as Document; //

            if (theDoc != null)
                theDoc.CountCharacters();

            string contents = theDoc.Read();
            Console.WriteLine("contents: " + contents);

            theDoc.Write();
        }
    }
}
