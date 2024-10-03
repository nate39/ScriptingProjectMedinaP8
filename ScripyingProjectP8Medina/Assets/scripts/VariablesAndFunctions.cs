using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a veriable of type integer
    int myInt = 35;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run myInt thru my function to multiply it by two
        myInt = MultiplyByTwo(myInt);

            //I'm going to print the reusluts to the console
            Debug.Log(myInt);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creating a function that takes a int parmeter and multipies
    int MultiplyByTwo(int number)
    {
        //creating a variable to store my results
        int results;
        //multiplying the passed parmeter by 2
        results = number * 2;

        //Returning the results
        return results;

    }

}
