using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
   
        Debug.Log("Welcome to The Number Wizard!");
        Debug.Log("Pick a number, please");
        Debug.Log("The highest number is: "+ max);
        Debug.Log("The lowest number is: "+ min);
        Debug.Log("Tell me if your number is higher or lower than my guess");
        Debug.Log("Push UP if your number is higher. Push DOWN if your number is lower. Push ENTER if my guess is correct.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Ok, your number is higher");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Ok, your number is lower");
            max = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ok, it's magic!");
        }
    }
}
