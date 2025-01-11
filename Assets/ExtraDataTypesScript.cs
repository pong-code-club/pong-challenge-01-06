using UnityEngine;
public enum WeaponType
{
    None = 0,
    Sword = 1,
    Axe = 2,
    Bow = 3,
    Spear = 4,
    Mace = 5
}

public class ExtraDataTypesScript : MonoBehaviour
{
    //Unity Vector3 Struct
    public Vector3 MyVector3;

    //Unity KeyCode Enum
    public KeyCode MyKeyCode;

    public WeaponType MyWeaponType;

    public Transform MyTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
