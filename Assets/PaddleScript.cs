using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    //Declaring reference data types
    public Transform MyTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find a component on the same GameObject by calling GetComponent
        MyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MyTransform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
