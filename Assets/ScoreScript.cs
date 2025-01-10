using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreScript : MonoBehaviour
{
    //Declaring reference data types
    //[public or private keyword] [data type] [identifier]
    public TextMeshProUGUI MyScoreUI;
    public int MyScoreValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyScoreValue = 0;
        //find a component on the same GameObject by calling GetComponent
        MyScoreUI = GetComponent<TextMeshProUGUI>();
        MyScoreUI.text = "Score: " + MyScoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        //This is the same as doing MyScoreValue += 1
        //MyScoreValue = MyScoreValue + 1;

        /*
        MyScoreValue += 1;
        MyScoreUI.text = "Score: " + MyScoreValue;
        */
        //Calling a function
        //AddToScore();
    }

    //Declaring a function
    //[public or private keyword] [return data type] [Function Identifier] [( -put in your parameters- )]
    public void AddToScore()
    {
        MyScoreValue += 1;
        MyScoreUI.text = "Score: " + MyScoreValue;
    }
}
