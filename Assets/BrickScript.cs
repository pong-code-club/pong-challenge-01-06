using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int MyBrickHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyBrickHealth = 5; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        MyBrickHealth = MyBrickHealth - 1;
    }
}
