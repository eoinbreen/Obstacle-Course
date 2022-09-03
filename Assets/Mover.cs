using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");//change x value with left and right keys
        float zValue = Input.GetAxis("Vertical");//change z value with up and down keys
        transform.Translate(xValue, 0, zValue);
    }

    
}
