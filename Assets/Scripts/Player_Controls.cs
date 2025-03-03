using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    //public float vertical;
    public int speed = 100;
    public GameObject player_st_pos;
    public GameObject player;
    public Rigidbody rb;
    private Vector3 moveVector;

    void FixedUpdate()
    {
        MovementLogic();
        //vertical = Input.GetAxis("Vertical");
        //{
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        // transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //transform.Rotate(0, -1, 0);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //transform.Rotate(0, 1, 0);
        //}
        if (Input.GetKey(KeyCode.R))
        {
            player.transform.position = player_st_pos.transform.position;
            player.transform.rotation = player_st_pos.transform.rotation;
        }
    }
    private void MovementLogic()
    {
        moveVector.x = Input.GetAxis("Horizontal");

        moveVector.z = Input.GetAxis("Vertical");

        rb.MovePosition(moveVector * speed * Time.deltaTime);
    }
}
