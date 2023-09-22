# DesignPatterns
Design patterns implemented in C#

## Creational 
Creational design patterns in C# are a set of design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable for the situation. 
They abstract the instantiation process, making it more flexible, efficient, and independent of the system's architecture.

### Singleton

* Intent: The singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.
* Usage: When exactly one object of a class is required to coordinate actions across the system, such as a configuration manager, thread pool, or database connection pool.
* Example: In a game, you might have a game manager that handles high-level game logic and resources. You want to ensure there's only one instance of the game manager throughout the game's lifecycle.
  
![Singleton](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/2029c9b8-c2ce-4eee-b0d0-1a0fa19119a6)

Example
```C#
// Singleton with unique instance and alloced on demand (lazy)
var engine = Engine.GetInstance();
engine.Play();

// Singleton with static class, always existing
Utils.GetPI();
Utils.GetTime();
```
### Factory Method

* Intent: The factory method pattern defines an interface for creating an object but allows subclasses to alter the type of objects that will be created.
* Usage: When a class cannot anticipate the type of objects it needs to create, and you want to delegate the responsibility of object creation to its subclasses.
* Example: In a document processing application, you might have different document types (e.g., PDF, Word, Text). Each document type can have a factory method responsible for creating instances of that specific type of document.

![FactoryMethod](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/b8d2b1c6-4fae-4018-881c-8fbfe82278d2)

Example
```C#
// Factory method with example used for creating cars of diferent types,
// Optionally from different factories in this case
IVehicleFactory fordFactory = new FordFactory();
IVehicleFactory yamahaFactory = new YamahaFactory();

IVehicle fiesta = fordFactory.CreateVehicle(VehicleEnum.EcoSport);
IVehicle ecoSport = fordFactory.CreateVehicle(VehicleEnum.EcoSport);
IVehicle fazer = yamahaFactory.CreateVehicle(VehicleEnum.Fazer);

fiesta.Accelerate();
ecoSport.Accelerate();
fazer.Accelerate();
```

### Abstract Factory

* Intent: The abstract factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
* Usage: When your system needs to be independent of how its objects are created, composed, and represented, and you want to ensure that the created objects work together seamlessly.
* Example: Imagine a GUI framework where you need to create buttons, text fields, and other GUI components that should be consistent in style and functionality. An abstract factory can create different versions of these components based on the chosen theme (e.g., light or dark)
  
![AbstractFactory](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/2a0a03f4-39a7-435a-a759-6d6ac8413ed7)

Example 
```C#
// Instantiate a family of integration methods
IInvoiceIntegrationFactory brIntegration = new BrazilianInvoiceIntegrationFactory();
IInvoiceIntegrationFactory amIntegration = new AmericanInvoiceIntegrationFactory();

// Send for Brazilian
InvoiceIntegration integration = new InvoiceIntegration(brIntegration);
integration.Send(1);
integration.Cancel(1);

// Send for American
integration = new InvoiceIntegration(amIntegration);
integration.Send(2);
integration.Cancel(2);
```

### Builder

* Intent: The builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
* Usage: When an object needs to be constructed with many optional components or configurations, and you want to keep the construction code clean and maintainable.
* Example: Building a complex SQL query with multiple optional clauses (e.g., WHERE, GROUP BY, ORDER BY). A builder can help construct the query step by step, allowing for different combinations of clauses.

![Builder](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/db997412-e45b-4ad4-b9a7-f753cc84cf4c)

Example
```C#
// Builder pattern with example for building SQL queries
QueryBuilder postgresBulder = new PostgresQueryBuilder();
QueryBuilder mariaDBBuilder = new MariaDBQueryBuilder();

var postgresQuery = postgresBulder
    .Select("id", "name")
    .From("users")
    .Where("name = 'Admin'")
    .Build();

var mariaQuery = mariaDBBuilder
    .Select("id", "name")
    .From("users")
    .Where("name = 'Admin'")
    .Build();

Console.WriteLine(postgresQuery);
Console.WriteLine(mariaQuery);
```
### Prototype

* Intent: The prototype pattern creates new objects by copying an existing object, known as the prototype.
* Usage: When you want to create new objects that are similar to existing objects, and the cost of creating the object from scratch is high or complex.
* Example: In a graphics application, you can use a prototype pattern to clone an existing graphic element (e.g., a shape) to create new instances with the same attributes (e.g., color, size) without re-specifying those attributes.

![Prototype](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/e81c009a-8f9a-4207-af90-6f1edf9ddf7e)

Example 
```C#
// Cloning object withou knowing their concrete classes
IShape circle = new Circle(10);
IShape clonedCircle = circle.Clone();

IShape react = new Rectangle(10, 20);
IShape clonedRect = react.Clone();
```

## Structural

 Structural design patterns in C# focus on simplifying the composition of objects and classes to form larger structures. They help in building relationships between objects, making the system more flexible and easier to maintain. 

### Facade

* Intent: The facade pattern provides a simplified interface to a complex subsystem. It encapsulates a group of interfaces into a single interface, making it easier to use.
* Usage: When you have a complex system with many components, and you want to provide a simple, unified interface for clients to interact with it.
* Example: Creating a multimedia player where the facade simplifies tasks like playing audio, video, and handling playlists.

![Facade](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/b646705f-bcfd-4140-a261-57caaef4101f)

Example
```C#
// The ideia of a facade is actually hide the complexity, take a look inside
IPeopleConsult consultService = new PeopleConsult();
consultService.GetPeople(2);
```

### Adapter

* Intent: The adapter pattern allows the interface of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code.
* Usage: When you want to reuse an existing class but its interface does not match the one you need, or when you want to create a unified interface for multiple classes.
* Example: Adapting an older library with its own interface to work with a new system.
  
![Adapter](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/3599cd1e-9ba8-4930-92b4-52e62b6c850c)

Example
```C#
// Legacy code, not compatible at all and can't modify
// We need to adapt to the new interface that the system expect
CelsiusTemperatureProvider temperatureProvider = new CelsiusTemperatureProvider();

// Adapter to new system interface
ITemperatureProvider kelvinTemperatureProvider = new KelvinTemperatureAdapter(temperatureProvider);
ITemperatureProvider celsiusTemperatureProvider = new CelsiusTemperatureAdapter(temperatureProvider);
ITemperatureProvider fahrenheitTemperatureProvider = new FahrenheitTemperatureAdapter(temperatureProvider);

kelvinTemperatureProvider.GetTemperature();
celsiusTemperatureProvider.GetTemperature();
fahrenheitTemperatureProvider.GetTemperature();
```

### Bridge

* Intent: The bridge pattern separates an object's abstraction from its implementation so that they can vary independently. It is used to avoid a permanent binding between an abstraction and its implementation.
* Usage: When you want to avoid a situation where changes in the implementation code affect the abstraction, and vice versa. Useful for creating platform-independent code.
* Example: Developing a drawing application where you have different shapes (abstraction) that can be drawn using different rendering methods (implementation).

![Bridge](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/3b9ca7f6-35ae-4717-b6b4-e43366bc45af)

Example
```C#
// Change of implementation here, do not affect the abstracted gui elements
IGuiRenderer windowsRenderer = new WindowsGuiRenderer();
IGuiRenderer linuxRenderer = new LinuxGuiRenderer();

GuiElement linuxTextBox = new TextBox(linuxRenderer, "Enter your name");
GuiElement windowsButton = new Button(windowsRenderer, "OK");

windowsButton.Render();
linuxTextBox.Render();
```

### Decorator

* Intent: The decorator pattern attaches additional responsibilities to objects dynamically. It is a structural alternative to subclassing for extending functionality.
* Usage: When you want to add new behaviors or responsibilities to objects without modifying their code. Useful for situations where you have a set of core classes with optional features.
* Example: Enhancing a text editor with various formatting options (e.g., bold, italic) without creating a separate class for each combination of formatting.

![Decorator](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/15b16420-8904-4227-afcd-6911170d1b13)

Example
```C#
// Default behavior
ITextFormatter plainFormatter = new PlainTextFormatter();
Console.WriteLine(plainFormatter.Format("This is text."));

// Add remove space behavior
ITextFormatter removeSpaceFormatter = new RemoveSpaceDecorator(plainFormatter);
Console.WriteLine(removeSpaceFormatter.Format("This is text."));

// Add to upper behaviour
ITextFormatter removeAndUpperFormmater = new ToUpperDecorator(removeSpaceFormatter);
Console.WriteLine(removeAndUpperFormmater.Format("This is text."));
```
### Flyweight

* Intent: The flyweight pattern minimizes memory or computational overhead by sharing as much as possible with similar objects. It is used when many small, similar objects need to be created.
* Usage: When you have a large number of objects that can be divided into intrinsic (shared) and extrinsic (unique) properties. The shared properties are reused to conserve resources.
* Example: Managing characters in a word processing application, where the character's font, size, and style are intrinsic properties, and their position in the document is extrinsic.
  
![Flyweight](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/e26a6f90-9faa-43ef-b903-572735098154)

Example
```C#
AirplaneFactory airplaneFactory = new AirplaneFactory();

// Plane 1 and Plane2 will share the same intrisic state
var plane1 = airplaneFactory.CreateAirPlane(100, 200, 10, "airplane1.jpg", "red");
var plane2 = airplaneFactory.CreateAirPlane(250, 100, 5, "airplane1.jpg", "red");

// New instricit state here
var plane3 = airplaneFactory.CreateAirPlane(250, 100, 5, "airplane2.jpg", "blue");
```

### Proxy

* Intent: The proxy pattern provides a surrogate or placeholder for another object to control access to it. It is often used to add a level of control or functionality to an object.
* Usage: When you want to add an extra layer of control or functionality around an object, such as lazy initialization, access control, or logging.
* Example: Implementing a proxy for expensive database connections to establish the connection only when necessary, or creating a security proxy to control access to sensitive resources.

![Proxy](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/18bef69d-d59e-4b40-8f81-3fe51a918d61)

Example
```C#
// Lazy image initialization with proxy
IImage image1 = new ProxyImage("image1.jpg");
IImage image2 = new ProxyImage("image2.jpg");

// Real loading occurs only when Display is called
image1.Display();
image2.Display();
```

### Composite

* Intent: The composite pattern lets you compose objects into tree structures to represent part-whole hierarchies. It allows clients to treat individual objects and compositions of objects uniformly.
* Usage: When you want to represent objects in a hierarchical structure, and you need to work with both individual objects and compositions of objects in a consistent manner.
* Example: Representing a graphical user interface where both simple elements like buttons and complex elements like windows are treated uniformly.

![Composite](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/a519b8fd-0bf6-44c4-9ce2-a50a802c0e3f)

Example
```C#
// Create a tree of shapes to draw and calculate total area
IShape rect1 = new Rectangle(10, 10);
IShape rect2 = new Rectangle(5, 5);

IShape circle1 = new Circle(2);
IShape circle2 = new Circle(2);

GroupOfShapes groupRoot = new GroupOfShapes();
GroupOfShapes groupRootRects = new GroupOfShapes();
GroupOfShapes groupRootCircles = new GroupOfShapes();

groupRoot.Add(groupRootCircles);
groupRoot.Add(groupRootRects);

groupRootRects.Add(rect1);
groupRootRects.Add(rect2);

groupRootCircles.Add(circle1);
groupRootCircles.Add(circle2);
   
// Draw all group
groupRoot.Draw();

// Calculate total area and per type
double totalArea = groupRoot.CalculateArea();
double totalRects = groupRootRects.CalculateArea();
double totalCircles = groupRootCircles.CalculateArea();

Console.WriteLine($"Total area to draw {totalArea}");
Console.WriteLine($"Total area to draw of circles {totalCircles}");
Console.WriteLine($"Total area to draw of rects {totalRects}");
```

## Behavioral

Behavioral design patterns in C# focus on how objects and classes interact and communicate with each other. They define patterns of communication between objects, making the system more flexible and easier to maintain

### Chains of Reponsability

* Intent: The chain of responsibility pattern passes a request along a chain of handlers. Each handler decides either to process the request or pass it to the next handler in the chain.
* Usage: When you want to decouple senders and receivers of a request and allow multiple objects to handle the request without the sender needing to know which object will process it.
* Example: Implementing request handling in a web framework where middleware components can process, modify, or pass along HTTP requests.

![ChainsOfReponsability](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/56206dad-7143-4ea2-8cdd-fd1a4659c034)

Example
```C#
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
```

### Iterator

* Intent: The iterator pattern provides a way to access elements of an aggregate object sequentially without exposing its underlying representation.
* Usage: When you want to provide a consistent way to traverse different data structures (e.g., lists, trees) without exposing their internal details.
* Example: Creating an iterator to loop through elements in a collection, such as an array or a linked list, without exposing the collection's internal structure.

![Iterator](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/e3e431b5-a4e4-4a95-bdd5-be1ba8aa4228)

Example
```C#
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
```

### Mediator

* Intent: The mediator pattern defines an object that encapsulates how objects interact with each other. It promotes loose coupling by keeping objects from referring to each other explicitly.
* Usage: When you have a complex system with many interactions between objects, and you want to centralize the communication to reduce dependencies and make the system more maintainable.
* Example: Building a chat application where a mediator handles message distribution between multiple users without direct user-to-user communication.

![Mediator](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/abcd1fc2-8dd5-4951-99f5-ceb7137ade06)

Example
```C#
// Create an air traffic control tower
IAirTrafficControlTower tower = new AirTrafficControlTower();

// Create passenger aircraft and register with the tower
var aircraft1 = new Boeing737("Flight 123", tower);
var aircraft2 = new Cesnna172("Flight 456", tower);

// Aircraft communicate through the tower
aircraft1.Send("Requesting permission to land.");
aircraft2.Send("Acknowledged, Flight 123. You are clear to land.");
```

### Memento

* Intent: The memento pattern captures and externalizes an object's internal state so that it can be restored to that state later. It is often used for undo/redo functionality.
* Usage: When you need to capture an object's state at a specific point in time and later restore it to that state without exposing its internal structure.
* Example: Implementing undo functionality in a text editor, where you can save the editor's state as a memento and later restore it.

![Memento](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/6097bbb0-17ff-4259-839b-9c37f447e633)

Example
```C#
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
```

### Observer

* Intent: The observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
* Usage: When you want to establish a relationship where one object (the subject) maintains a list of observers that are notified of state changes without coupling the subject to specific observer classes.
* Example: Implementing event handling in a user interface, where UI elements (observers) respond to changes in data (the subject).

![Observer](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/ae01de1f-c84b-480f-9a18-e0b6bae8ed26)

Example
```C#
 IObservableStore store = new ComputerStore();

IStoreObserver client1 = new Client();
IStoreObserver client2 = new Client();

store.RegisterObserver(client1);
store.RegisterObserver(client2);

// Client got notified
store.AddProduct("Iphone 15");
```

### State

* Intent: The state pattern allows an object to alter its behavior when its internal state changes. It encapsulates state-specific logic in separate classes.
* Usage: When an object's behavior needs to change dynamically based on its state, and you want to avoid using conditional statements to manage state transitions.
* Example: Implementing a vending machine, where the machine's behavior (e.g., dispensing items or returning change) depends on its current state (e.g., in-use, out-of-stock).

![State](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/1c73a44e-e667-4490-9a0e-4e87538897ae)

Example
```C#
AudioPlayer player = new AudioPlayer();

player.Play(); // Starts playing
player.Pause(); // Pauses
player.Pause(); // Already paused
player.Stop(); // Stops

player.Pause(); // Cannot pause. Audio is stopped
player.Play(); // Starts playing
player.Stop(); // Stops
```

### Strategy

* Intent: The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows clients to choose the appropriate algorithm at runtime.
* Usage: When you have multiple algorithms that can be used interchangeably, and you want to decouple the algorithm's implementation from the client code.
* Example: Implementing different sorting algorithms (e.g., bubble sort, quicksort) where the choice of algorithm can be made at runtime.

![Strategy](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/a67078e2-2304-46d1-8361-7637d2c9a063)

Example
```C#
var intList = new List<int> { 5, 1, 4, 2, 8 };
var stringList = new List<string> { "banana", "apple", "grape", "cherry" };

var bubbleSorter = new Sorter<int>(new BubbleSortStrategy<int>());
bubbleSorter.SortList(intList);

var quickSorter = new Sorter<string>(new QuickSortStrategy<string>());
quickSorter.SortList(stringList);
```

### Template Method

* Intent: The template method pattern defines the skeleton of an algorithm in a method, but lets subclasses override specific steps of the algorithm without changing its structure.
* Usage: When you want to define a common algorithm structure but allow variations in the implementation of specific steps.
* Example: Creating a document generation framework where the structure of document generation is predefined, but subclasses can provide custom content for different document types.

![TemplateMethod](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/76824ea0-f66d-4ba0-b41e-30d9ea610f45)

Example
```C#
Recipe coffeeRecipe = new CoffeeRecipe();
Recipe teaRecipe = new TeaRecipe();

Console.WriteLine("Making coffee:");
coffeeRecipe.PrepareRecipe();

Console.WriteLine("Making tea:");
teaRecipe.PrepareRecipe();
```

### Visitor

* Intent: The visitor pattern represents an operation to be performed on elements of an object structure. It lets you define a new operation without changing the classes of the elements on which it operates.
* Usage: When you have a complex object structure with multiple types of elements, and you want to add new operations to these elements without modifying their classes.
* Example: Implementing a document processing system where you want to perform different operations (e.g., printing, exporting) on various elements (e.g., paragraphs, images) within documents.

![Visitor](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/c36a1dcb-12bf-49f7-ae1d-dd05d101efb4)

Example
```C#
// Entities
Folder root = new Folder("root");
Folder folder1 = new Folder("folder1");

File fileTxt = new File("teste.txt", 10);
File fileCsv = new File("teste.csv", 20);

root.Childrens.Add(fileTxt);
root.Childrens.Add(folder1);
folder1.Childrens.Add(fileCsv);

// Visitors
IVisitor listPath = new ListPath();
IVisitor sizeCalculator = new TotalSizeCalculator();

foreach(var file in listPath.Visit(root) as List<string>)
    Console.WriteLine(file);

foreach (var file in listPath.Visit(folder1) as List<string>)
    Console.WriteLine(file);

Console.WriteLine(sizeCalculator.Visit(root));
Console.WriteLine(sizeCalculator.Visit(folder1));
Console.WriteLine(sizeCalculator.Visit(fileCsv));
```
