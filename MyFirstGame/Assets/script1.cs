using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting");
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W was pressed");
        }
        if (input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S was pressed");
        }
    }
}
