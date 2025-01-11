using UnityEngine;

public class ZombieManagerScript : MonoBehaviour
{
    //primitive data types
    public int MyInt;
    public float MyFloat;
    public bool MyBool;
    public string MyString;

    //compound data types
    public Transform MyTransform;
    public Rigidbody MyRigidbody;
    public GameObject MyGameObject;

    //primitive data type arrays
    public int[] MyIntArray;
    public float[] MyFloatArray;
    public bool[] MyBoolArray;
    public string[] MyStringArray;

    //compound data type arrays
    public Transform[] MyTransformArray;
    public GameObject[] MyGameObjectArray;

    public ZombieScript[] MyZombieScriptArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //how to access array by element
        Debug.Log(MyIntArray[0]);
        Debug.Log(MyIntArray[1]);
        Debug.Log(MyIntArray[2]);

        Debug.Log("Changed the value in MyIntArray[2]");
        MyIntArray[2] = 1100;

        Debug.Log("Log the new value of MyIntArray[2]");
        Debug.Log(MyIntArray[2]);

        //for loop
        //used to run code multiple times
        Debug.Log("using for loop to log all elements in MyIntArray");
        for (int i = 0; i < MyIntArray.Length; i++)
        {
            Debug.Log(MyIntArray[i]);
        }
    }

    public void SpawnZombie()
    {
        //Instantiate
        //Destroy
    }

    private void OnMouseDown()
    {
        for (int i = 0;i < MyZombieScriptArray.Length;i++)
        {
            MyZombieScriptArray[i].Jump();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
