using UnityEngine;



// SKIP Lecture ...
namespace Assignment.StudentSolution.LCT02
{
    public class Dog
    {
        // properties including name, breed, age ...

        public string name;
        public string breed;
        public int age;

        // end of properties ...

        // สร้าง constructor ที่รับ parameter 3 ตัว และกำหนดค่าให้กับ properties ของ class
        // โดยทั้ง 3 parameter คือ name, breed, age ตามลำดับ
        public Dog(string myName, string myBreed, int age)
        {
            name = myName;
            breed = myBreed;
            this.age = age;
        }

        /// behaviors ...

        public void Bark()
        {
            Debug.Log($"{name} Bark!");
        }

        public void WagTail()
        {
            Debug.Log($"{name} Wagging..");
        }

        public void StopBarking()
        {
            Debug.Log($"{name} stop barking..");
        }

        // end of behaviors ...
    }

    public class LCT02ClassConstructor
    {
        Dog dog1;

        public void Start()
        {
            // สร้าง object dog1 ของ class Dog โดยใช้ constructor ที่รับ parameter 3 ตัว
            // และกำหนดค่าให้กับ properties ของ object นั้น
            // กำหนดให้ name = "Buddy", breed = "Golden Retriever", age = 3

            // Student code starts HERE ...
            // ...

            dog1 = new Dog("NekTant", "Golden Retriever", 21);
            var dog2 = new Dog("Hong HOng", "Chihuahua", 5);

            // ...
            // Student code ends HERE ...

            // เรียกใช้ method ของ object นั้น

            dog1.Bark();
            dog1.WagTail();
            dog1.StopBarking();
        }
    }
}
