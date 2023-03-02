using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Creating an instance of Rigidbody
    public Rigidbody rb;
    //Defining Force values
    public float forwardForce = 1000f;
    public float rightForce = 500f;
    public float leftForce = -500f;

    // Start is called before the first frame update
    // void Start()
    // {
    //    Debug.Log("Hello, World!");
    //    rb.useGravity = false;
    // }

    // FixedUpdate is used whenever we mess with physics
    void FixedUpdate()
    {
        //Changing force on input values
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(leftForce * Time.deltaTime,0,0);
        }
    }
}
