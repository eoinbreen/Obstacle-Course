using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")//dont increment score if obstacle has already been hit
        {
            score++;
            Debug.Log("You have bumped into something " + score + " times");
        }

        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("You have made it to the finish tile, Good Job!!");
        }
    }
}
