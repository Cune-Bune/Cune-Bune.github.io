using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	public float boomAmt = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
  if (Input.GetMouseButton(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(laser, out hit, 10000f))
            {
             
                Debug.Log("Hit something! The " + hit.transform.gameObject.name + " didn't like that.");

                Destroy(hit.transform.gameObject); // destroy the object hit

 /*if (hit.rigidbody) {
                  hit.rigidbody.AddForce(Vector3.up * boomAmt);
  }*/
            }
            else { Input.GetMouseButton(1); Input.GetMouseButton(2);
                 }
        }
    }
}
