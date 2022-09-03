using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
    //Movement Speed
    //[SerializeField] float xSpeed = 0;
    //[SerializeField] float ySpeed = 0;
    [SerializeField] float zSpeed = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, 0, zValue);
    }

    
}
