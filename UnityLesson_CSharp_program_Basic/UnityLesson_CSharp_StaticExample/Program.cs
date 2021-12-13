using System;

namespace UnityLesson_CSharp_StaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "김아무개";

            Person person2 = new Person();
            person2.name = "이아무개";

            Person.typename = "사람 타입";
            Orc.typename = "오크 타입";

            Person.SayTypeName();
        }
    }


        // static으로 정의된 클래스는 객체생성 불가. 인스턴트화 불가.



    class Orc
    {
        static public string typename;
    }

    class Person
    {
        // 접근제한자 : 자료형 앞에 붙여준다.
        // public, private, protected
        // public : 다른 클래스가 접근 할 수 있다.
        // private : 다른 클래스가 접근할 수 없다(아무것도 안쓰면 암묵적으로 private로 설정됨).
        // protected : 상속자만 접근할 수 있다.

        public int age;                //정수형
        public float height;           //실수형
        public bool isFemale;          //논리형
        public char gendreChar;        //문자형
        public string name;            //문장열형

        static public string typename; //타입이름

        static public void SayTypeName()
        {
            Console.WriteLine(typename);
        }

        public void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SaygenderChar();
            SayIsFemale();
            SayName();
        }

        public void SayAge()
        {
            Console.WriteLine($"나이 : {age}");
        }

        public void SayHeight()
        {
            Console.WriteLine($"키 : {height}");
        }

        public void SayIsFemale()
        {
            Console.WriteLine($"여자인가? : {isFemale}");
        }

        public void SaygenderChar()
        {
            Console.WriteLine($"성별문자 : {gendreChar}");
        }

        public void SayName()
        {
            Console.WriteLine($"이름 : {name}");
        }


    }

}
