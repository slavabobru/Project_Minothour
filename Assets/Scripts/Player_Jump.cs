using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody rb;
    public bool ifonland = false;
    public float jumpSp = 7.0f;
    void Start()
    {
        
    }
    void Update()
    {
        if (ifonland && Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpSp, rb.linearVelocity.z);
        ifonland = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("land"))
        {
            ifonland = true;
        }
    }
}
