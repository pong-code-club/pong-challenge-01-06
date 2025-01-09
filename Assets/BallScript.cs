using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Declaring primitive data types
    //[public or private keyword] [data type] [identifier]
    //Declaring primitive data types
    public int MyScore;
    public float MyHealth;
    public bool MyIsAlive;
    public string MyName;

    //Declaring reference data types
    public Transform MyTransform;
    public Rigidbody MyRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find a component on the same GameObject by calling GetComponent
        MyTransform = GetComponent<Transform>();
        MyRigidbody = GetComponent<Rigidbody>();

        //run the code inside here { }
        Debug.Log("Inside Start Function");
        //calling a function
        MyCustomFunction();

        //Call AddForce function on Rigidbody component
        MyRigidbody.AddForce(450, 450, 0);
        MyRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //run the code inside here { }
        //Debug.Log("Inside Update Function");
    }

    //function declaration
    void MyCustomFunction()
    {
        Debug.Log("Running code inside MyCustomFunction");
    }
}
