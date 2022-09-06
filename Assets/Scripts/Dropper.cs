using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer dropperRenderer;
    [SerializeField] float dropTime = 3f;//time before object drops
    // Start is called before the first frame update
    void Start()
    {
        dropperRenderer = GetComponent<MeshRenderer>();
        dropperRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTime)//Turn on renderer and gravity after a certain ammount of time has passed
        {
            dropperRenderer.enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
        
    }
}
