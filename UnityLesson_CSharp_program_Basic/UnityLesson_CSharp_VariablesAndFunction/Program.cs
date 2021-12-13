using System;

namespace UnityLesson_CSharp_VariablesAndFunction
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // CamelCase (이름 설정 규칙 중 하나)
        // class, function, namespace 등은 대문자로 시작한다.
        // 변수는 소문자로 시작한다.
        // 단어가 바뀔경우 첫 문자는 대문자로한다.
        // 줄임말은 되도록 사용하지 않는다.
        // 이름을 보았을때 어떤 기능, 목적인지 알 수 있도록 작성한다.
        // 애매한부분이 있으면 주석을 달아준다.

        class Person
        {
           int age;            //정수형
           float height;       //실수형
           bool isFemale;      //논리형
           char gendreChar;    //문자형
           string name;        //문장열형


           void SayAllInfo()
           {
               SayAge();
               SayHeight();
               SaygenderChar();
               SayIsFemale();
               SayName();
           }

            void SayAge()
           {
                Console.WriteLine($"나이 : {age}");
           }

           void SayHeight()
           {
                Console.WriteLine($"키 : {height}");
           }

           void SayIsFemale()
           {
               Console.WriteLine($"여자인가? : {isFemale}");
           }

           void SaygenderChar()
           {
               Console.WriteLine($"성별문자 : {gendreChar}");
           }

           void SayName()
           {
               Console.WriteLine($"이름 : {name}");
           }

        }
    }
}
