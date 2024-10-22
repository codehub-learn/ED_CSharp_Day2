using CSharp_Day2;
using System.Linq;

Cat cat = new Cat();
Console.WriteLine(cat.Name); //Cat

Animal cat2 = cat;
Console.WriteLine(cat2.Name); //Cat

Cat cat3 = new Cat();

Console.WriteLine(cat == cat2); //True
Console.WriteLine(cat == cat3); //False

cat3 = cat; //Assign the memory position of the object in cat to cat3
cat.Name = "New Cat Name";
Console.WriteLine(cat3.Name); //New Cat Name

Customer anna = new Customer()
{
    FirstName = "Anna",
    LastName = "Karenina"
};

Customer annika = anna with { FirstName = "Annika" }; //New Object
Console.WriteLine(anna == annika); //False

annika.FirstName = "Anna";
Console.WriteLine(anna == annika);

//Retains the last name Karenina because it is a different object than anna
Console.WriteLine(annika.LastName);

int x = 0; //ints are value types
int y = 5;

x = y; //Assigns the value 5 in the variable X
//x = 5; //Same as above

x = 10;
Console.WriteLine(x); //10
Console.WriteLine(y); //5

IShape shape = new Triangle();
IShape shape2 = new Square();

Triangle trinagle = new Triangle();

List<IShape> shapes = new List<IShape>();
shapes.Add(shape);
shapes.Add(shape2);
shapes.Add(trinagle);

foreach(IShape myshape in shapes)
{
    Console.WriteLine(shape.GetArea());
}

trinagle.baseCM = 10;

int[] ints = new int[10];
Cat[] cats = new Cat[5];

ints[1] = 5;
ints[2] = 10;
ints[1] = 1;

//Array of 5 positions initialized with given values
int[] ints2 = { 1, 2, 3, 4, 5 };
List<int> listfromarray = new(ints2); //Create a list with copies of values from an array

List<int> intslist = new List<int>();
List<Cat> catslist = new List<Cat>();

intslist.Add(1);
intslist.Add(2);
//intslist.Remove(1); //Removes the first apperance of the value 1
//intslist.RemoveAll(x => x == 1);
intslist.Insert(1, 5);


//Find the index of the element with the value 2 and replace it with 10
int position = intslist.FindIndex(x => x == 2);
intslist[position] = 10;

int[] intsarr = { 1,2,3,4,5};

int arrposition = Array.IndexOf(intsarr, 3);
intsarr[arrposition] = 30;

var intslistfromarr = intslist.ToArray(); //Convert list to array

Cat cadife = new Cat();
Cat annie = new Cat();

Dictionary<string, Cat> catsdic = new Dictionary<string, Cat>();
catsdic.Add("cadife", cadife);
catsdic.Add("annie", annie);

Cat retrievedCat = catsdic["annie"];
//Cat ghost = catsdic["random"]; //Exception

catsdic.Remove("cadife");
Console.WriteLine("");

Cat[] catsarr = {cadife, annie};
//List<Cat> catsarrlist = catsarr.ToList();
//Dictionary<string,Cat> catsdict2 = catsarrlist.ToDictionary<string, Cat>(c => c.Name, c => c);




for (int i = intslist.Count-1; i >=0; i--)
{
    if (intslist[i] == 1) {
        intslist.RemoveAt(i);
    }
}

Console.WriteLine(intslist);

Cat RedCat = new()
{
    Name = "My Red Cat",
    Fur = FurColor.Red
};

List<Question<int, string>> questions = new List<Question<int, string>>();  


