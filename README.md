# Project

Repository for studies

* Design patterns implemented by myself in C#
* SOLID
* Clean Architecture
* IoC
* DDD, TDD and BDD

Some explanations on this file are retrieved from the internet

# Design Patterns

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

# SOLID

The SOLID principles are a set of five design principles in object-oriented programming and software development that promote maintainability, extensibility, and readability of code. These principles were introduced by Robert C. Martin and have become fundamental guidelines for writing high-quality, maintainable software. The SOLID acronym represents the following principles:

* Single Responsibility Principle (SRP):

This principle states that a class should have only one reason to change, meaning it should have only one responsibility or job. It promotes the idea that a class should be focused on doing one thing well.
Following SRP makes code more maintainable because changes to one responsibility won't affect other unrelated parts of the code.

* Open/Closed Principle (OCP):

The Open/Closed Principle states that software entities (classes, modules, functions) should be open for extension but closed for modification. In other words, you should be able to add new functionality to a system without changing existing code.
OCP encourages the use of abstraction and polymorphism to allow for the addition of new features or behavior without altering existing code.

* Liskov Substitution Principle (LSP):

This principle is named after Barbara Liskov and emphasizes that objects of a derived class should be able to replace objects of the base class without affecting the correctness of the program.
Adhering to LSP ensures that inheritance hierarchies are well-defined and that derived classes truly extend the behavior of the base class.

* Interface Segregation Principle (ISP):

ISP suggests that clients should not be forced to depend on interfaces they do not use. It promotes the idea of having small, specific interfaces rather than large, monolithic ones.
By adhering to ISP, you can avoid situations where classes are forced to implement methods they don't need, leading to cleaner, more focused interfaces.

* Dependency Inversion Principle (DIP):

The Dependency Inversion Principle states that high-level modules should not depend on low-level modules. Both should depend on abstractions. Additionally, abstractions should not depend on details; details should depend on abstractions.
DIP encourages the use of dependency injection, inversion of control containers, and the use of interfaces to decouple high-level and low-level modules, making the codebase more flexible and testable.

Adhering to the SOLID principles can lead to more maintainable, flexible, and extensible code. These principles help prevent common issues such as tightly coupled code, code fragility when making changes, and difficulty in testing and reusing code. By following SOLID, developers aim to create software that is easier to understand, modify, and maintain over time.

# Clean Architecture

A Clean Architecture is a software architecture pattern designed to promote separation of concerns and maintain clean and understandable code. It is based on design principles and best practices aimed at creating highly testable, flexible, and sustainable software systems.

![image](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/192308ce-b836-4fd4-b312-2fbf8f7314c1)

The Clean Architecture proposes a well-defined layering structure, with each layer having specific responsibilities and one-way dependencies. The core layers typically include:

- **Presentation Layer** - This layer is responsible for handling user interactions and delivering data to the user interface. In a .NET Core Web API, this layer comprises the controllers and other components that handle HTTP requests and responses.

- **Application Layer** - The application layer contains the business logic and use cases of the application. It acts as an intermediary between the presentation layer and the domain layer. This layer is independent of any specific UI or infrastructure concerns.

- **Domain Layer** - The domain layer represents the application’s core, encapsulating business rules, entities, and domain-specific logic. It should be technology-agnostic and contain no dependencies on external frameworks or libraries.

- **Infrastructure Layer** - The infrastructure layer deals with external concerns such as databases, external services, and frameworks. It contains implementations of interfaces defined in the application layer and interacts with external resources.

One of the key goals of Clean Architecture is to maintain one-way dependencies, meaning that inner layers should not be aware of implementation details of outer layers. This facilitates testability, maintenance, and code evolution, as changes in an outer layer do not affect the inner layers.

Clean Architecture is a generic approach and can be applied to various programming languages and project types. It encourages writing clean, testable, and high-quality code, which is essential for long-lasting software projects that need to be easily adaptable to changing requirements.

# IoC (Inversion of Control)

Inversion of Control (IoC) is a design principle in which a software component is designed to receive its dependencies from an external source, rather than creating them itself. This is in contrast to traditional software design, where a component is responsible for creating and managing its own dependencies.

We can achieve Inversion of Control through various mechanisms such as: Strategy design pattern, Template method pattern, Service Locator pattern, Factory pattern, and Dependency Injection (DI).

There are two types of IoC: type 1 (interface-based) and type 2 (template-based).

* Type 1, also known as "Hollywood Principle" states "Don't call us, we'll call you" meaning, the system will call the dependent objects when it needs them, rather than the dependent objects calling the system when they need something.
* Type 2, also called "template method" pattern, defines the skeleton of an algorithm in a base class, and allows derived classes to fill in specific details.

## Key Concepts

Here are some key concepts related to IoC:

1. **Dependency Injection (DI)**: One of the most common ways to implement IoC is through Dependency Injection. DI is a technique where the dependencies (e.g., objects, services, or configurations) that a class needs are provided to it from the outside (usually by a framework or container) rather than the class creating them itself. This reduces tight coupling between classes and makes the code more testable and maintainable.

2. **IoC Containers**: IoC containers are frameworks or libraries that manage the creation and lifecycle of objects (dependencies) in an application. Popular IoC containers include Spring (for Java), Unity (for C#), and Dagger (for Android). These containers allow you to configure how dependencies are injected into your classes.

3. **Service Providers**: In some cases, IoC can be implemented through service providers, which are responsible for locating and providing the necessary services or components to other parts of the application.

4. **Event-driven and Message-driven Architectures**: In IoC, control flow can also be inverted by using event-driven or message-driven architectures, where components or objects respond to events or messages rather than explicitly calling each other's methods.

5. **Setter Injection**: IoC dependencies can be also injected into a class using setter methods. Setter injection allows for optional dependencies, as you can set them after the object has been created.

6. **Loose Coupling**: IoC promotes loose coupling between components, which means that changes in one part of the system should have minimal impact on other parts. This makes the codebase more flexible and easier to maintain.

## Benefits of IoC

IoC is a powerful concept in software development because it helps improve code organization, maintainability, and scalability. It is commonly used in the development of enterprise-level applications, web applications, and frameworks where modularization and decoupling are essential for managing complexity and promoting code reusability.

## Implementing IoC 

![image](https://github.com/RodrigoPAml/DesignPatterns/assets/41243039/80e05430-704b-4521-a13f-84290cafdb6c)

Suppose your class depends on a logger service, where there is a text logger and csv logger. Instead of instantiating the two specific concrete classes
and make us depend on them, we can externalize this dependency using the factory pattern.

- We create a factory to get any logger (csv or text) and using DIP we create an abstract class that will be implemented by the loggers and returned by the factory class
- We implemented dependency injection to receive the factory class into our class
- We use the factory class to instantiate any type of logger, depending only on its abstract class (DIP)
- Now the code is decoupled and extensible

# Software development methodologies

## Test-Driven-Development (TDD)

Test-Driven-Development is a software engineering process that uses the test-first approach. It means the test should be written prior the main feature business logic. The idea behind the methodology is that developer focuses on the requirements and can reduce errors and bugs and save money and resources by testing the expected behavior of software before establishing its functionality.
TDD approach is simple:

* Start with simple test cases. Before moving to complex test cases, start with the most straightforward possible test you can think of. This will help you clearly understand the process while still being effective.
* Write your tests before developing code. Following the TDD approach, you must write the test cases before writing the code. This will help you stay focused and ensure that you are writing code that meets the requirements of the test cases.
* Execute the test and watch it fail.
* Modify the code and add just enough functionality to make the test pass.
* Repeat the cycle as many times as needed to prepare the full functionality.
* Run your tests frequently. Running your tests frequently will help ensure your test cases catch the bugs and errors you seek.

![image](https://github.com/RodrigoPAml/Design-patterns-principles-and-Code-Architecture/assets/41243039/bf6b0586-13d0-41d1-aaf4-e3cd44c87eb4)

The practice shows that the TDD helps ensure the resulting code is effective, efficient, and bug-free.

Advantages

* Increases code quality and readability: Helps developers focus on writing good code that meets specifications, ensuring the principle is clear, concise, and easy to read, even for those who didn’t write the code.
* Faster bug fixing: Since TDD helps developers write better code, it makes bug discovery and fixing much quicker.
* Increases planning and design: By focusing on the user requirements, developers can craft software that meets the end user's needs better.

Disadvantages

* Increased time and effort required: To write code using the TDD approach, software development teams need more time, resources, and action.
* Resistance to change: Some experienced developers may resist the TDD methodology because it requires them to change their development habits in favor of a more structured approach.

## Behavior-Driven-Development (BDD)

Behavior-Driven-Development (BDD) emphasizes requirements and specifications first and then develops code based on those requirements. BDD is a collaborative approach, with developers, testers, and business analytics working together to define requirements, set expectations, and measure outcomes.

The BDD process is divided into four key phases: Discovery, Formulation, Automation, and Analysis.

* The Discovery phase involves identifying the desired behaviors of the software by collaborating with business stakeholders, analyzing user feedback, and identifying potential risks. During this step, a team could use any tool or technique to evaluate input parameters and outcome results, such as flowchart, behavior, UML, Domain Specific Language, Given-When-Then (GWT) technic, and even simple natural-human language.
* The Formulation phase involves translating the discovered behaviors into understandable acceptance criteria, scenarios, and user stories that development and testing teams can use to build and test the software.
* The Automation phase writes code to automate the tests. In the scope of this step, the TDD could be used.
* The Analysis phase involves analyzing the results of the tests to determine whether the software meets the desired behaviors.

![image](https://github.com/RodrigoPAml/Design-patterns-principles-and-Code-Architecture/assets/41243039/2522c83f-f4cf-4460-92c8-a1c623e076d6)

Advantages

* Improves communication and collaboration within the development team. By involving all team members in defining requirements and expectations, BDD ensures that everyone clearly understands what needs to be developed and what the end product should look like.
* It helps streamline the development process, as tests are written as early as possible in the development cycle, even before any code has been written. This helps identify potential issues early on, reducing costs, time, and risk.

Disadvantages

* Reliance on collaboration can slow down the development process if team members have different schedules, workloads, or understandings of the requirements. Additionally, some stakeholders may have difficulty articulating their needs or requirements clearly, which can result in misunderstandings or incorrect assumptions.
* Implementing it can be challenging and require significant upfront effort to establish a shared understanding of requirements.

## Domain-Driven-Development (DDD)

Domain-Driven-Development (DDD) is a software engineering methodology that builds software around the domain model. A domain model represents a business or organization’s key concepts and processes and how they relate. DDD divides complex domains into smaller, more manageable domains that can be easily understood and modeled. In DDD methodology, software developers work closely with domain experts to identify domain models, entity relationships, and business functionalities.

DDD methodology comprises four phases: discovery, modeling, implementation, and refinement.

* The Discovery phase involves domain experts and software developers working together to identify the business requirements and develop an initial domain model.
* The Modeling phase involves software architects and developers creating detailed domain models and identifying entity relationships and business functionalities.
* The Implementation phase involves software developers using the domain model to design and develop the system.
* The Refinement phase involves reviewing the system and making necessary changes to the domain model.

Advantages

* Alignment with Business Domain: DDD helps establish a common understanding between developers and business stakeholders by focusing on the terminology and processes of the business domain. This alignment can increase efficiency, better communication, and reduce development time.
* Refactoring: DDD encourages continuous refactoring, which helps to maintain the application’s quality and ensures that it remains aligned with the business domain.
* Modularization: DDD enables the creation of independent and modular software components, making the code more maintainable and easier to test.

Disadvantages

* Complexity: Implementing DDD can be challenging, particularly for inexperienced developers, due to the level of complexity involved.
* Time-Consuming: DDD is a time-consuming approach that requires developers to spend more time on the design and development phases.
* Cost-Intensive: DDD is a resource-intensive approach that can be costly for small to medium-sized enterprises.

# Sources

https://www.linkedin.com/pulse/tdd-vs-bdd-ddd-vitalii-serdiuk/

https://medium.com/@edin.sahbaz/getting-started-with-clean-architecture-in-net-core-fa9151bc5918

