csharp in depth
===============
work my way through snippets in http://csharpindepth.com/

General Notes
=============

Evoltion of Product type, showing greater encapsulation, stronger typing, and
ease of initialization over time.
--------------------------------------------------------------------------------

C# 1
----
* read-only properties
* weakly typed collections

C# 2
----
* private property setters
* strongly typed collections

C# 3 
----
* automatically implemented properties
* enhanced collections and object initialization

C# 4
----
* named arguements for clearer constructor and method calls.


Features involved in making sorting easier in C# 2 and 3.
---------------------------------------------------------

C# 1
----
* weakly typed compartor
* no delegate sorting option

C# 2
----
* strongly typed comparator
* delegate comparisons
* anonympous methods

C# 3
----
* lambda expressions
* extension methods
* options of leaving list unsorted


Anonymous methods and lambda expressions in C# 2 and 3 aid seperation of concerns and readability.
--------------------------------------------------------------------------------------------------

C# 1
----
* Strong coupling between condition and action.
* Both are hardcoded.

C# 2
----
* seperate condition from action invoked.
* Anonymous methods make delegates simple.

C# 3
----
* lambda expressions make the condition even easier to read.

Handling the absence of data
----------------------------

If decimal were a reference type, you could just use null to reprsent the unknown price, but since
it's a value type, you can't. How would you represent this in C# 1?

There are three common alternatives:
1. Create a reference type wrapper around decimal.
2. Maintain a separate Boolean flag indicating whether the price is known.
3. Use a "magic value" (decimal.MinValue, for example) to represent the unknown price.

They all suck!

C# 2 alternatives

e.g. 
	decimal? price;
	public decimal? Price
	{
		get { return price; }
		private set { price = value; }
	}

	The constructor paramter changes to decimal?, and then you can pass in null as the
	argument, or Price = null; within the class. The meaning of the null changes from
	"a special reference that doesn't refer to any object" to "a special value of any
	nullable type representing the absence of other data," where all reference types and
	all Nullable<T>-based types count as nullable types.

Options for working with missing data
-------------------------------------

C# 1
----
* choice between extra work maintaining a flag
* changing to reference type semantics
* or the hack of a magic value

C# 2
----
* nullable type make the "extra work" option simple
* syntactic sugar improves matters even further.

C# 3
----
* optional parameters allow simple defaulting
e.g.
	public Product(string name, decimal? price = null)
	{
		this.name = name;
		this.price = price;
	}







