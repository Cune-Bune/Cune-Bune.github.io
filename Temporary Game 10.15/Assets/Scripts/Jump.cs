using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public bool isGrounded;
    public bool canWalljump;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        } //This makes it so whenever touching an object tagged "Ground" you get the status "isGrounded"
        if (col.gameObject.tag == ("Jumpable") && canWalljump == false)
        {
            canWalljump = true;
        } //Touching an object named "Jumpable" will give the status "canWallJump"
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            isGrounded = false;
        } //If you press space anything with the status "isGrounded" will be sent upward
        if (Input.GetKeyDown(KeyCode.Space) && canWalljump)
        {
            rb.AddForce(new Vector3(4, 7, 0), ForceMode.Impulse);
            canWalljump = false;
        } //If you press space with the status "canWallJump" you will move upward and slightly horizontally
    }
}