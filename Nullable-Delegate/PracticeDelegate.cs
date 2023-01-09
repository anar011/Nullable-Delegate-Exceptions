using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Delegate
{
    internal class PracticeDelegate
    {

        #region Predicate


        //public delegate bool CheckNums(int num);

        //public bool CheckNumByOdd(int number)
        //{
        //    return number % 2 == 1; 
        //}

        //public bool CheckNumByEven(int number) =>  number % 2 == 0;


        //public bool CheckNumThanFive(int number)
        //{
        //    return number > 5;
        //}
        //public void CheckDelegate()
        //{

        //    List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

        //    //Console.WriteLine(SumOfListItem(CheckNumByOdd, nums));

        //    //Console.WriteLine(SumOfListItem(CheckNumByEven, nums));

        //    //Console.WriteLine(SumOfListItem(CheckNumThanFive, nums));

        //    //nums.FindAll(m => m > 5 );
        //    //Console.WriteLine(SumOfListItem(m=> m > 5, nums));

        //    var res = nums.FindAll(m => m %2== 0 && m > 5 ).Sum(m=>m);

        //}

        //public int SumOfListItem(Predicate<int> func, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }

        //    }


        //    return sum;
        //}



        //public int SumOfListItem(CheckNums func, List<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }

        //    }


        //    return sum;
        //}








        #endregion


        #region Action



        //public delegate void ChangeString(string str);

        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());

        //}

        //public void StringToLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());
        //}

        //public void CheckWord()
        //{
        //    //ShowWord(StringToUpper, "Cavid");
        //ShowWord(StringToLower, "Cavid");

        //ChangeString changeString = new ChangeString(StringToUpper);

        //ChangeString changeString = StringToUpper;
        //changeString += StringToLower;

        //changeString += delegate (string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //};

        //changeString +=  (string str)=>Console.WriteLine(str.ToLower());


        //changeString.Invoke("Pervin");

        //changeString("Pervin");

        //    Action<string> action = StringToUpper;

        //    //action += StringToLower;
        //    action +=  (string str) => Console.WriteLine(str.ToLower());
        //    action("Pervin");


        //}

        //public void ShowWord(ChangeString func, string str)
        //{
        //   func(str);
        //}


        #endregion


        #region Func



        //public delegate int CheckString(string str);

        //public int GetStringLength(string word)
        //{
        //    return word.Length;
        //}



        //public void ShowStringLength(CheckString func, string text)
        //{
        //    Console.WriteLine(func(text));
        //}


        //public void ShowString()
        //{
        //    ShowStringLength(GetStringLength, "Cavid");
        //}

        //public delegate int CheckString(string str,int age);

        //public int GetStringLength(string word, int num)
        //{
        //    return word.Length + num;
        //}

        //public void ShowStringLength(CheckString func, string text)
        //{
        //    Console.WriteLine(func(text, 10));
        //}

        //public void ShowString()
        //{
        //    ShowStringLength(GetStringLength, "Cavid");
        //}



        //public int GetStringLength(string word, int num)
        //{
        //    return word.Length + num;
        //} 

        //public void ShowStringLength(Func<string,int,int> func, string text)
        //{
        //    Console.WriteLine(func(text, 10));
        //}

        //public void ShowString()
        //{
        //    //ShowStringLength(GetStringLength, "Cavid");

        //    Func<string, int, int> func = GetStringLength;

        //    Console.WriteLine( func.Invoke("Cahandar", 6));


        //}


        #endregion







    }




}
