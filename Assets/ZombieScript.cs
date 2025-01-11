using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        MyRigidbody.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    }

}
