# Practise3
[task3.txt](https://github.com/SushmaSrinivasan/Practise3/files/12714373/task3.txt)
C# Practice Collection - Encapsulation, inheritance and polymorphism
Continuously in the assignments there are some knowledge questions (starting with "F:"). These questions are answered as
comments in the code. The code does not need to receive input from a user.
3.1) Encapsulation
1. Create a Class Person and give it the following private fields:
age, fName, lName, height, weight
Create public properties with get and set that get or set assigned variable.
Instantiate a person in Program.cs, can you directly access the variables?
Implement validation in the created properties:
● Age can only be assigned a value greater than 0.
● FName is mandatory and must not be less than 2 characters or longer than 10
sign.
● LName is mandatory and cannot be less than 3 characters or greater than 15
sign.
Throw an exception of type ArgumentException in each property if its
validation is not completed, the exception shall contain a descriptive
message.
Be sure to handle the exceptions in the Program class with a try-catch block.

2. To encapsulate the Person objects further, we will create the class PersonHandler -
a class whose purpose is to create and manage your Person objects.
In the PersonHandler class, create the method:
public void SetAge(Person pers, int age)
Use the submitted person's Age property to set the person's age attribute
via the SetAge method. Instead of just using one property, we now have
abstracted by two layers.

3. In the PersonHandler, type a method that creates a person with specified values:
public Person CreatePerson(int age, string fname,
string lname, double height, double weight)

4. Continue creating methods in PersonHandler to be able to handle all
operations that one may want to do with a Person

5. When this class is complete, comment away your previous instance of Person from
Program.cs, and instantiate a PersonHandler instead. In doing so, create some
people and test your methods.

3.2) Polymorphism
1. Create the UserError abstract class
2. Create the abstract method UEMessage() that has the string return type.
3. Create a regular NumericInputError class that inherits from UserError
4. Write an override for UEMessage() so that it returns "You tried to use a
numeric input in a text only field. This fired an error!"
5. Create a regular TextInputError class that inherits from UserError
6. Write an override for UEMessage() so that it returns "You tried to use a text
input in a numeric only field. This fired an error!"
7. In Program.cs Main Method: Create a list of UserErrors and populate it with
instances of NumericInputError and TextInputError.
8. Print all UserErrors UEMessage() through a foreach loop.
9. Now create three custom classes with three custom definitions on UEMessage()
10. Test and see how it works.

3.3) Inheritance
1. Create the Abstract Animal class
2. Fill the Animal class with properties that all animals should have. Tex name,
weight, age.
3. Create an abstract method called DoSound().
4. Add a constructor.
5. Create the subclasses (inherit from Animal): Horse, Dog, Hedgehog, Worm and
Bird, Wolf.
6. Give these at least one unique characteristic each. What characteristic it is is not the important thing here.
Example Worm: IsPoisonous, Hedgehog: NrOfSpikes, Bird: WingSpan etc.
7. Implement so that the DoSound() method prints how the animal sounds.
8. Now create the following three classes: Pelican, Flamingo, and Swan. These will inherit
from Bird.
9. Give these at least one unique characteristic each.
10. Create the interface (interface) IPerson with a method declaration Talk();
11. Create the Wolfman class that inherits from Wolf and implements IPerson
Interface.
12. Implement Talk() that prints what Wolfman says.
13. Q: If during evolution we conclude that all birds need a new
attribute, in which class should we put it?
14. Q: If all animals need the new attribute, where would you put it?

3.4) More polymorphism
1. Create the Stats() method of the Animal class that has the string return type.
The method shall be surmountable in its Subclasses. The method should return all
characteristics of the animal.
2. Write an override for Stats() in the subclasses of Animal so it returns all
properties of that animal.
3. Create an Animals list in Program.cs that receive animals.
4. Create some animals (of different type) in your list.
5. Print which animals are in the list using a foreach loop
6. Also call the Animals Sound() method in the foreach loop.
7. Do a check in the for loop if an animal is also of the type IPerson, if it is
type-cast to IPerson and call its Talk() method.
8. Create a list for dogs
9. Q: Try adding a horse to the list of dogs. Why doesn't it work?
10. Q: What type must the list be for all classes to be stored together?
11. Print all Animals Stats() through a foreach loop.
12. Test and see how it works.
13. Q: Explain what's going on.
14. Print the Stats() method only for all dogs through a foreach of
Animals.
15. Create a new method with any name in the Dog class that returns only an optional
string.
16. Can you access that method from the Animals list?
17. Q: Why not?
18. Find a way to print your new method of death through a foreach on Animals.
Good luck

