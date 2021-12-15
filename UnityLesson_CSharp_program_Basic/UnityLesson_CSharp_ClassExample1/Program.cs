using System;

namespace UnityLesson_CSharp_ClassExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.weight = 200.0f;
            orc1.isRest = false;
            orc1.gendreChar = '남';
            orc1.age = 140;

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.height = 140.4f;
            orc2.weight = 120.0f;
            orc2.isRest = true;
            orc2.gendreChar = '여';
            orc2.age = 60;

            orc1.SayName();
            orc1.SayAge();
            orc1.SayHeight();
            orc1.Sayweight();
            orc1.SaygenderChar();
            orc1.SayisRest();
            
            if(orc1.isRest)
            {
                orc1.Smash();
                orc1.Jump();
            }
            else
            {
                Console.WriteLine($"{orc1.name} (이)가 존나 바빠서 휘두르거나 뛰질 못한다.");
            }
            

                Console.Write("\n");

            orc2.SayName();
            orc2.SayAge();
            orc2.SayHeight();
            orc2.Sayweight();
            orc2.SaygenderChar();
            orc2.SayisRest();

            if (orc2.isRest)
            {
                orc2.Smash();
                orc2.Jump();
            }
            else
            {
                Console.WriteLine($"{orc2.name} (이)가 존나 바빠서 휘두르거나 뛰질 못한다");
            }



        }
    }

    class Orc
    {

        public int age;            
        public float height;
        public float weight;
        public bool isRest;     
        public char gendreChar;   
        public string name;
        
        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘두르기를 시전했다!");
        }

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프를 한다");
        }

        public void SayAge()
        {
            Console.WriteLine($"나이 : {age}");
        }

        public void SayHeight()
        {
            Console.WriteLine($"키 : {height}");
        }

        public void Sayweight()
        {
            Console.WriteLine($"몸무게 : {weight}");
        }

        public void SayisRest()
        {
            Console.WriteLine($"놀고있는가? : {isRest}");
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
