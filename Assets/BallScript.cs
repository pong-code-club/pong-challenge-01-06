using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Ball Hit Something");
        //check to see if I hit a game object named "Lava"
        if (collision.gameObject.name == "Lava")
        {
            Debug.Log("Hit Lava");
            SceneManager.LoadScene("DemoDay4");
        }

        //check to see if I hit a game object with a tag of "WALL"
        if (collision.gameObject.tag == "WALL")
        {
            Debug.Log("Hit a Wall");
            GameObject.Find("ScoreUI").GetComponent<ScoreScript>().AddToScore();
        }

        /*
        if (collision.gameObject.name == "TopWall")
        {
            Debug.Log("Hit TopWall");
        }
        if (collision.gameObject.name == "LeftWall")
        {
            Debug.Log("Hit LeftWall");
        }
        if (collision.gameObject.name == "RightWall")
        {
            Debug.Log("Hit RightWall");
        }
        */


    }

    //function declaration
    void MyCustomFunction()
    {
        Debug.Log("Running code inside MyCustomFunction");
    }
}
