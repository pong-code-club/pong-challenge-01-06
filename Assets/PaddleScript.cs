using UnityEngine;

//PaddleScript class definition - let the computer know you want to make a class
public class PaddleScript : MonoBehaviour
{
    //Declaring reference data types
    public Transform MyTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Declaring Function called "Start"
    void Start()
    {
        //find a component on the same GameObject by calling GetComponent
        MyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetKey(KeyCode.RightArrow));

        //conditional statement
        //more specifically the if statement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyTransform.Translate(3.5f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MyTransform.Translate(-3.5f * Time.deltaTime, 0, 0);
        }

        //Example of multi line comment
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MyTransform.Translate(0, 1 * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MyTransform.Translate(0, -1 * Time.deltaTime, 0);
        }
        */

        //MyTransform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
