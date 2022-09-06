using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBlockie();
    }

    //Printing the instructions for the Game
    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Avoid all the obstacles and make it to the goal");
        Debug.Log("Good Luck!");
    }

    //Moving Player
    void MoveBlockie()
    {
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;//change x value with up and down keys, frame independent
        float zValue = -(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed);//change z value with left and right keys, frame independent

        transform.Translate(xValue, 0, zValue);
    }
    
}
