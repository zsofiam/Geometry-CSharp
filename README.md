# Geometry

## Story

Online learning is a hot topic these days. Your company just won
a state tender for an e-learning tool that helps high school students
learn maths.

Your team has just started planning a geometry module.
Hierarchical object-oriented modelling seemed a natural choice here:
after all, every square _is a_ rectangle, isn't it? So you came up with
a class hierarchy for six basic shapes, and now your job is to implement
the core features (such as area and perimeter) of these shape types.

You also need to add a simple console UI to list and add shapes
to a shape repository. This will be replaced with GUI later.
Oh, and don't forget to contribute to the emerging
documentation, so please draw a UML class diagram as well.

## What are you going to learn?

- Draw UML class diagrams.
- Use inheritance.
- Override methods.
- Understand when static contexts (the `static` keyword) can be useful.
- Understand hiding (the `new` keyword) vs overriding (the `override` keyword).
- Use `sealed`.
- Represent objects with strings.


## Tasks

1. Implement the constructors and the required methods in shape subclasses. The shapes must be immutable. that is, their state (stored in attributes) cannot be changed.
    - All attributes are immutable.
    - All attributes are private, and only the methods used by other classes are not private.
    - All shape subclasses have an overridden version for calculating the corresponding perimeter and area.
    - All shape subclasses have their custom `ToString()` representation. The representation includes the name of the shape (such as `"Rectangle"`) and the names and values of its base attributes (in this case `"r=...`").

2. Implement `ShapeCollection` to manage a list of shapes. The collection can consist of any subtype of `Shape`.
    - It is possible to add shapes to the collection using the `AddShape` method.
    - The `GetShapesTable()` method returns a printable table with all the
shapes in the collection and their parameter values.
The table looks like the example in `example_table.txt`.
    - The `GetLargestShapeByPerimeter()` method returns the shape instance with the largest perimeter in the collection.
    - The `GetLargestShapeByArea()` method returns the shape instance with the largest area in the collection.

3. Show a main menu upon starting the program that provides access to basic operations on a shape collection.
    - By choosing the "Add new shape" option, the user can select from a list of existing shapes (such as circle). Then the user must specify the required parameters (such as the radius).
    - By choosing the "Show all shapes" option, the table view provided by the shape collection is displayed.
    - Choosing the "Show shape with the largest perimeter" option displays the shape with the largest perimeter in the collection.
    - Choosing the "Show shape with the largest area" option displays the shape with the largest area in the collection
    - By choosing the "Show formulas" option, the user can select from a list of existing shapes (such as circle), and the stored formulas for the shape class (such as `Circle area formula: π×r×r, Circle perimeter formula: 2×π×r`) are displayed.
    - The user can exit the program by selecting "Exit".

4. Create a class diagram based on the existing project skeleton structure and keep extending it when extending the code. Use [PlantUML](https://plantuml.com/class-diagram) to generate it.
    - The PlantUML source file named `uml.txt` and a rendered diagram named `uml.png` are updated in the repository.
    - Relation indicators on the diagram represent the actual state of code (such as inheritance or composition between classes).
    - All fields are indicated on the diagram.
    - All fields are indicated on the diagram.

## General requirements

None

## Hints

- Remember that polymorphism enables you to reduce the amount
  of code to write. Use it to avoid data and logic redundancy.
- Remember that a field _should_ be a class member
  (static) if all the instances share the same value, and
  a method _can_ be static if no instances are needed to perform its task.
  For example, if there is no need to store the state between invocations.
    - For example, the radius of a circle (`r`) is a field of
      a specific circle instance, but the written formula of
      its perimeter (`"2×π×r"`) is the same for all circles.
      This string should be stored only once in a class field.
    - Correspondingly, the method which calculates the actual area
      is an instance method (since it needs the value of `r`), while
      the method that returns the formula can be static (since it only
      needs access to a static field).
- Consider using the online editor for PlantUML, there is a link to it in
  the Background materials section. You can generate an image by clicking "View
  as PNG" under the code box.

## Background materials

- <i class="far fa-exclamation"></i> [UML - Unified Modeling Language](project/curriculum/materials/pages/general/uml-unified-modeling-language.md)
- <i class="far fa-exclamation"></i> [PlantUML class diagram editor online](https://plantuml.com/class-diagram)
- [OOP basics](project/curriculum/materials/pages/csharp/basics-of-object-oriented-programming.md)
- [Abstraction, abstract classes and interfaces](project/curriculum/materials/pages/csharp/abstraction.md)
- [Using the static keyword](https://www.geeksforgeeks.org/static-keyword-in-c-sharp/)
- [new modifier](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier)
- [Few words about inheritance](https://www.w3schools.com/cs/cs_inheritance.asp)
- [Few words about abstract methods](https://www.c-sharpcorner.com/UploadFile/93126e/importance-and-use-of-versioning-in-C-Sharp/)
- [String representation of objects](https://www.dotnetperls.com/tostring)

