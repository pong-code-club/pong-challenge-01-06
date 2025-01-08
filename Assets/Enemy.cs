using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform MyTransform;
    // Declare some variables
    // [public or private keyword] [Data Type] [Identifier]
    public float MyHealth;
    public string MyName;
    public int MyLevel;
    public bool MyIsAlive;

    // Declaring a function
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyHealth = 5;
        MyName = "Bob";
        MyLevel = 50;
        MyIsAlive = true;
        transform.localScale = new Vector3(MyHealth, MyHealth, MyHealth);
    }

    // Declaring a function
    // Update is called once per frame
    void Update()
    {
        //MyHealth = MyHealth + 1;
    }

    void OnMouseDown()
    {
        //Calling a function
        Injure(); 
    }

    //function declaration
    void Injure()
    {
        MyHealth = MyHealth - 1;
        transform.localScale = new Vector3(MyHealth, MyHealth, MyHealth);

    }

    //[public or private keyword] [data type returned] [identifier] [parameters]

    //public function returns nothing and has 0 parameters
    public float AddTwoNumbers(float num1, float num2)
    {
        float answer = num1 + num2;
        //return is a keyword used when you need the function to output something
        return answer;
    }

    private void Hello(string greeting)
    {
        Debug.Log(greeting);
    }
}
