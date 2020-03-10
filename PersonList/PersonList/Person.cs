using System;
using System.Collections.Generic;

namespace PersonList
{
    private class Person{
        var personName;
        var personAge;
        public Person(var name, var age)
        {
            personName = name;
            personAge = age;
        }
        public override string ToString()
        {
            return "Name: " + personName;
        }

    }
}

// 3. Create a Person class to represent a person, having (1) a name, and (2) at least one other piece
//    of data. Do not use any public fields.
// 4. Implement 1 or more constructors, to enforce a requirement that a Person can't exist without a
//    name.
// 5. Override ToString method, to return the name of each Person.


