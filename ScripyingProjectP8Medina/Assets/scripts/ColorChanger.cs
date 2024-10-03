using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}

