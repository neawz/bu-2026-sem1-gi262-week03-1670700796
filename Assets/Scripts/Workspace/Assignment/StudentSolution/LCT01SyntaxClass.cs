using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float Speed;
        public string Color;

        public void Move()
        {
            // Code
        }

        public void Turn()
        {
            // Code
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...

            Car car1 = new Car();
            car1.Name = "Ferrari";
            car1.Speed = 100f;

            Car car2 = new Car();
            car2.Name = "Lamboghini";
            car2.Speed = 50f;

            Debug.Log("Hello bro");

            // Student code ends HERE 
        }
    }
}
