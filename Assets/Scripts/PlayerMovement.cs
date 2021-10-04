using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This references the Rigidbody component in Unity and assigns it to the variable "rb"
    public Rigidbody rb;

    // Variable that can be adjusted later

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb.AddForce(0, 200, 500);
    //}

    // Update is called once per frame

    // We use FixedUpdate() when adjusting physics within unity

    void FixedUpdate()
    {
        // Add a forward force that can be changed in Unity
        rb.AddForce(0, 0, forwardForce);//* Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
