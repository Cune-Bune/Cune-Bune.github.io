using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {  if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(laser, out hit, 10000f))
            {
                Debug.Log("Hit something! The" + hit.transform.gameObject.name + " didn't like that.");


                Destroy (hit.transform.gameObject);
                
            }
            else { Input.GetMouseButtonDown(1); Input.GetMouseButtonDown(2); }
        }
    }
}
