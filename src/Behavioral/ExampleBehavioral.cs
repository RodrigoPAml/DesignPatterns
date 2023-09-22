using DesignPatterns.Behavioral.Iterator.Entities;
using DesignPatterns.Behavioral.TemplateMethod.Implemenations;
using DesignPatterns.Behavioral.TemplateMethod.Skeleton;
using DesignPatterns.Behavioral.Observer.Concrete;
using DesignPatterns.Behavioral.Observer.Interfaces;
using DesignPatterns.Behavioral.State.Context;
using DesignPatterns.Behavioral.Strategy.Context;
using DesignPatterns.Behavioral.Strategy.Strategies;
using System.Xml.Linq;
using DesignPatterns.Behavioral.Visitor.Elements;
using File = DesignPatterns.Behavioral.Visitor.Elements.File;
using DesignPatterns.Behavioral.Visitor.Visitors;
using DesignPatterns.Behavioral.Memento.Originator;
using DesignPatterns.Behavioral.Memento.Memento;
using DesignPatterns.Behavioral.Memento.Caretaker;
using DesignPatterns.Behavioral.ChainsOfResponsability.Interfaces;
using DesignPatterns.Behavioral.ChainsOfResponsability.Handlers;
using DesignPatterns.Behavioral.ChainsOfResponsability.Request;
using DesignPatterns.Behavioral.Mediator.Interface;
using DesignPatterns.Behavioral.Mediator.Mediator;
using DesignPatterns.Behavioral.Mediator.Entities;

namespace DesignPatterns.Behavioral
{
    public static class ExampleBehavioral
    {
        public static void Method()
        {
            Recipe coffeeRecipe = new CoffeeRecipe();
            Recipe teaRecipe = new TeaRecipe();

            Console.WriteLine("Making coffee:");
            coffeeRecipe.PrepareRecipe();

            Console.WriteLine("Making tea:");
            teaRecipe.PrepareRecipe();
        }
         
        public static void Strategy()
        {
            var intList = new List<int> { 5, 1, 4, 2, 8 };
            var stringList = new List<string> { "banana", "apple", "grape", "cherry" };

            var bubbleSorter = new Sorter<int>(new BubbleSortStrategy<int>());
            bubbleSorter.SortList(intList);

            var quickSorter = new Sorter<string>(new QuickSortStrategy<string>());
            quickSorter.SortList(stringList);
        }

        public static void Observer()
        {
            IObservableStore store = new ComputerStore();

            IStoreObserver client1 = new Client();
            IStoreObserver client2 = new Client();

            store.RegisterObserver(client1);
            store.RegisterObserver(client2);

            store.AddProduct("Iphone 15");
        }

        public static void Iterator()
        {
            // Create a simple binary tree
            var root = new TreeNode<int>(1);
            root.Left = new TreeNode<int>(2);
            root.Right = new TreeNode<int>(3);
            root.Left.Left = new TreeNode<int>(4);
            root.Left.Right = new TreeNode<int>(5);
            root.Right.Left = new TreeNode<int>(6);
            root.Right.Right = new TreeNode<int>(7);

            // Create some iterators for the tree
            var iterator1 = new DepthTreeIterator<int>(root);
            var iterator2 = new BreadthTreeIterator<int>(root);

            while (iterator1.HasNext())
            {
                var node = iterator1.GetNext();
                Console.WriteLine(node);
            }

            Console.WriteLine();

            while (iterator2.HasNext())
            {
                var node = iterator2.GetNext();
                Console.WriteLine(node);
            }
        }

        public static void State()
        {
            AudioPlayer player = new AudioPlayer();

            player.Play(); // Starts playing
            player.Pause(); // Pauses
            player.Pause(); // Already paused
            player.Stop(); // Stops

            player.Pause(); // Cannot pause. Audio is stopped
            player.Play(); // Starts playing
            player.Stop(); // Stops
        }

        public static void Visitor()
        {
            // Entities
            Folder root = new Folder("root");
            Folder folder1 = new Folder("folder1");

            File fileTxt = new File("teste.txt", 10);
            File fileCsv = new File("teste.csv", 20);

            root.Childrens.Add(fileTxt);
            root.Childrens.Add(folder1);
            folder1.Childrens.Add(fileCsv);

            // Visitors
            ListPath listPath = new ListPath();
            TotalSizeCalculator sizeCalculator = new TotalSizeCalculator();

            foreach(var file in listPath.Visit(root) as List<string>)
                Console.WriteLine(file);

            foreach (var file in listPath.Visit(folder1) as List<string>)
                Console.WriteLine(file);

            Console.WriteLine(sizeCalculator.Visit(root));
            Console.WriteLine(sizeCalculator.Visit(folder1));
            Console.WriteLine(sizeCalculator.Visit(fileCsv));
        }

        public static void Memento()
        {
            TextEditor textEditor = new TextEditor();
            History history = new History(textEditor);

            textEditor.Write("Hi, ");
            history.Backup();

            textEditor.Write("my name is Rodrigo!");
            history.Backup();

            textEditor.Write("I hahad 338 ne3");
            history.Backup();

            history.Undo();
            history.Undo();

            Console.WriteLine(textEditor.GetContent());
        }

        public static void ChainsOfResponsability()
        {
            Handler handler1 = new ValidateName();
            Handler handler2 = new ValidateValue();

            handler1.SetSuccessor(handler2);

            InvoiceNoteRequest request = new InvoiceNoteRequest("note1", 10); // put -10 to trigger an error

            try
            {
                handler1.HandleRequest(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Meaditor()
        {
            // Create an air traffic control tower
            IAirTrafficControlTower tower = new AirTrafficControlTower();

            // Create passenger aircraft and register with the tower
            var aircraft1 = new Boeing737("Flight 123", tower);
            var aircraft2 = new Cesnna172("Flight 456", tower);

            // Aircraft communicate through the tower
            aircraft1.Send("Requesting permission to land.");
            aircraft2.Send("Acknowledged, Flight 123. You are clear to land.");
        }
    }
}
