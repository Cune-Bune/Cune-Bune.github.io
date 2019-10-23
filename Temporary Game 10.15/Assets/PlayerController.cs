using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 4.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
    }
   
    void OnCollisionEnter(Collision colReport)
    {
        if (colReport.gameObject.CompareTag("Collectible"))
        {
            Destroy(colReport.gameObject);
        }
        //What makes the collectible disappear on contact
    }
}