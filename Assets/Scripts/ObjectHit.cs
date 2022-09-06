using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("You Hit A Wall!!");
        GetComponent<MeshRenderer>().material.color = Color.grey;
    }
}
