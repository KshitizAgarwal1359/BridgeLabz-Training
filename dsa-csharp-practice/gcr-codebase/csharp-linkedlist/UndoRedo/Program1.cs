using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.UndoRedo
{
    class Program
    {
        static void Main()
        {
            TextEditorHistory editor = new TextEditorHistory(10);

            editor.AddState("Hello");
            editor.AddState("Hello World");
            editor.AddState("Hello World!");
            editor.AddState("Hello World! Welcome");

            Console.WriteLine("\nCurrent State:");
            editor.DisplayCurrentState();

            Console.WriteLine("\nUndo:");
            editor.Undo();

            Console.WriteLine("\nUndo:");
            editor.Undo();

            Console.WriteLine("\nRedo:");
            editor.Redo();

            Console.WriteLine("\nAdd New State:");
            editor.AddState("Hello World! Welcome to C#");

            Console.WriteLine("\nRedo Attempt:");
            editor.Redo();
        }
    }

}
