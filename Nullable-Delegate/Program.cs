




using Nullable_Delegate;
using Nullable_Delegate.Constants;
using Nullable_Delegate.Exceptions;
using ServicesLayer.Services;
using ServicesLayer.Services.Interfaces;

#region Nullable


//string name = null;

//int? num = null;

//if (name == null)
//{
//    Console.WriteLine("dsds");
//}

//int? m = 5;

//GetPersonById(m);

//static void GetPersonById(int? id)
//{
//    if(id == null)
//    {
//        Console.WriteLine("Not found");
//    }
//}

#endregion


#region Practics




//PracticeDelegate calculate = new PracticeDelegate();
//calculate.CheckDelegate();

//calculate.CheckWord();


//calculate.ShowString();


//int m = 5;
//int n = 0;



//var res = m / n;

//try
//{

//	int m = 5;
//	int n = 0;

//	Divide(m, n);

//	var res = m / n;


//	int[] arr = { 1, 2, 3 };

//	arr[5] = 100;
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);

//}


//Divide(5, 0);
//static void Divide (int n, int m)
//{
//	try
//	{
//        int[] arr = { 1, 2, 3 };

//		arr[5] = 100;


//		var result = n / m;
//        Console.WriteLine(result);
//    }
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);

//	}

//}


//static void Divide(int n, int m)
//{
//    try
//    {
//        int[] arr = { 1, 2, 3 };

//        arr[5] = 100;


//        var result = n / m;
//        Console.WriteLine(result);
//    }
//    catch (IndexOutOfRangeException ex)
//    {
//        Console.WriteLine(ex.Message);

//    }

//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine(ex.Message);

//    }

//}


//Divide(5, 1);
//static void Divide(int n, int m)
//{

//    bool isSuccess = false; 
//    try
//    {
//        int[] arr = { 1, 2, 3 };
//        arr[5] = 100;
//        var result = n / m;
//        isSuccess = true;
//        Console.WriteLine(result);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message); 
//        isSuccess= false;
//    }
//    finally
//    {
//        //Console.WriteLine("You can countinue");
//        //Console.WriteLine("isSuccess");



//        string message = string.Empty;
//        if (isSuccess)
//        {

//           message= ("Register is ok");
//            //SendEmail("Register is ok");
//        }
//        else
//        {
//            message= ("Something is wrong");
//            //SendEmail("Something is wrong");
//        }
//        SendEmail(message);
//    }


//}


//static void SendEmail(string message)
//{
//    Console.WriteLine(message); 
//}

//Login("test", "pervin12345");
//Login("pervin123", "pervin12345");
//static void Login ( string username, string password)
//{
//	try
//	{

//		if(username == "pervin123" && password == "pervin12345")
//		{
//			Console.WriteLine("Login is success");
//		}
//		else
//		{
//			//throw new InvalidLoginException("username or password is wrong");

//            throw new InvalidLoginException(ExceptionsMessages.InvalidLogin);
//        }

//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);

//	}
//}

#endregion


#region Employee



//IEmployeeService service = new EmployeeService();
//Console.WriteLine(service.GetCountByAge(26));

#endregion


#region Factorial



//Factorial(-3);
//static void Factorial(int a)
//{
//	try
//	{
//		int fact = 1;

//		if (a > 0)
//		{
//			for(int i = 1; i <= a; i++)
//			{
//				fact *= i;
//			}
//			Console.WriteLine(fact);
//		}
//		else
//		{
//			throw new Exception("Not found");
//		}

//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);

//	}
//}

#endregion


#region Person


//IPersonService service = new PersonService();
//Console.WriteLine(service.GetBySalary(1000));

#endregion



