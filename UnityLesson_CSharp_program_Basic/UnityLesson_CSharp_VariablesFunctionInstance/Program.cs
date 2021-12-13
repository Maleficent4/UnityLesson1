using System;

namespace UnityLesson_CSharp_VariablesFunctionInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // .점연산자
            // 클래스의 멤버에 접근할때 사용 namespace 안의 클래스에 접근할때도 사용
            // 객체의 멤버(클래스를 구성하는 요소들)에 접근할때도 사용.
            person1.name = "김아무개";
            person1.age = 123;
            person1.height = 224.31f;
            person1.isFemale = false;
            person1.gendreChar = '남';

            Person person2 = new Person();
            person2.name = "이아무개";
            person2.age = 78;
            person2.height = 124.11f;
            person2.isFemale = true;
            person2.gendreChar = '여';

            person1.SayAge();
            person2.SayName();

        }

    }

    class Person
    {
        // 접근제한자 : 자료형 앞에 붙여준다.
        // public, private, protected
        // public : 다른 클래스가 접근 할 수 있다.
        // private : 다른 클래스가 접근할 수 없다(아무것도 안쓰면 암묵적으로 private로 설정됨).
        // protected : 상속자만 접근할 수 있다.

        public int age;            //정수형
        public float height;       //실수형
        public bool isFemale;      //논리형
        public char gendreChar;    //문자형
        public string name;        //문장열형


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
