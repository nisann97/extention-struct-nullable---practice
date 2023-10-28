using extention__struct_nullable_classroom.Helpers.Extentions;
using extention__struct_nullable_classroom;


////int number = 100;

////number.ShowNum();


////int num1 = 50;
////num1.ShowNum(30);


////int num1 = 10;

////int num2 = 100;

////Console.WriteLine(num1.SumOfNums(num2));


////string str = "Salam Rufet bey , ";

////var result = str.ShowText("Niye hazirlasmirsiniz?");
////Console.WriteLine(result);


////string text = "salam2";
////var res = text.CheckDigitForStr();

////if (res)
////{
////    Console.WriteLine(" yes digit");
////}

////else
////{
////    Console.WriteLine("no digit");



////string email = "tunzale@gmail.com";

////Console.WriteLine(email.CheckEmail());


////Console.WriteLine("Please add your email:");

////string email = Console.ReadLine();

////Console.WriteLine(email.CheckEmail());

////Console.WriteLine(email.CheckStr("@"));
////Console.WriteLine(email.CheckStr(@"\d"));
////Console.WriteLine(email.CheckStr(@"[A-Z]"));
////Console.WriteLine(email.CheckStr(@"[A-Za-z]"));


////Person person = new("semedgmail.com");

////int num = 4;

////Console.WriteLine(num.FindFactorial());

//Console.WriteLine("Please add your email:");
//Email: string email = Console.ReadLine();



//if (!email.CheckEmailAndPassword("@"))
//{
//    Console.WriteLine("Email incorrect");
//    goto Email;
//}

//Console.WriteLine("Please add your password:");
//Password: string password = Console.ReadLine();

//if (!password.CheckEmailAndPassword(@"\W"))
//{
//    Console.WriteLine("password incorrect");
//    goto Password;
//}

//    Console.WriteLine("Login success");


//int number = 5;

//Console.WriteLine(number.PowofNum(3));


//string a = "567";
//Console.WriteLine(a.IsConvertStringToNumber());

//Car car = new Car();
//car.name = "nissan";

//Console.WriteLine(car.name);

//Car car = new();
//Console.WriteLine(car.name);


//Car car;
//car.Name = "Nissan";
//Console.WriteLine(car.Name);

//string name = null;

//Console.WriteLine(name);


//int? age = null;
//Console.WriteLine(age);

//Nullable<int> age = null;

//Console.WriteLine(age);

//static void CreatedDate(String name, string surname, int? age = null)
//{
//    if (name == null || surname == null || age == null)
//    {
//        Console.WriteLine("Please fill all inputs");
//        return;
//    }
//    Console.WriteLine(name + " " + surname + " " + age);
//}

//CreatedDate("Tunzale", "Memmedova");

//static void Register(User user)
//{
   
//        Console.WriteLine(user.Weight);
    
//}

//Register(new User { Id = 1, FullName = "XXX", Email = "nnnn", Password = "fff" });

// static void Register(User user)
//{
//    if (user.FullName != null & user.Email != null && user.Password != null) 
//    {
//        Console.WriteLine("Registered success");
//    }
//    else
//    {
//        Console.WriteLine( "register failed");
//    }
//}
//Register(new User { Id = 1, FullName = "XXX", Email = "nnnn", Password = "fff" });


static void Register(User user)
{
    if(!string.IsNullOrEmpty(user.Email.Trim()) && !string.IsNullOrEmpty(user.FullName.Trim()) && !string.IsNullOrEmpty(user.Password.Trim()))
    {
        Console.WriteLine("Register success");
    }
    else
    {
        Console.WriteLine("failed");
    }
}
Register(new User { Id = 1, FullName = "XXX", Email = "nnnn", Password = "fff" });
