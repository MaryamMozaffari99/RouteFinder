using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
         PrintInestruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    
    void PrintInestruction()
    {
        Debug.Log("Welcom to the Game!");
        Debug.Log("Move your Player with WASD or arrow keys.");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue, 0, zvalue);
    }
}
