using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set the x position to loop between 0 and 3
        transform.position =  new Vector3( transform.position.x, Mathf.PingPong(Time.time, 3), transform.position.z);
        //transform.position = new Vector3(Mathf.PingPong(Time.time, 3), transform.position.y, transform.position.z);
    }
}
