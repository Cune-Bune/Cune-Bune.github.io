using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemAnim : MonoBehaviour
{

    Animator myAnim;

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("State", 0);
        if (Input.GetKey(KeyCode.Space))
        {
            myAnim.SetInteger("State", 1);
        }
    }
}