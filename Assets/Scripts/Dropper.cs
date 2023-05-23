using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        //.enabled = false;
        renderer.enabled = false;
        rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(Time.time + "Time has elapsed since the gane has started: "); 
           if (Time.time > timeToWait)
                {
            //Debug.Log("3 Seconds has elapsed.");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
