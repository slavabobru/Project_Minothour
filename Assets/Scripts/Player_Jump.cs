using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody rb; // player's rigidbody

    public bool ifonland = false;  // changes if character standing on floor
    public float jumpSp = 10.0f; // change this for making jump higherc or lower
    
    void Update()
    {
        if (ifonland && Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump() // funktion for Jumping
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpSp, rb.linearVelocity.z);
        ifonland = false;
    }

    private void OnCollisionEnter(Collision collision) // checks if player toches floor
    {
        if (collision.gameObject.CompareTag("land"))
        {
            ifonland = true;
        }
        if (collision.gameObject.CompareTag("Key1"))
        {
            ifonland = true;
        }
    }
}
