using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierInput : MonoBehaviour
{
    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            myAnim.SetInteger("Run", 1);
        }
      
    }
}
