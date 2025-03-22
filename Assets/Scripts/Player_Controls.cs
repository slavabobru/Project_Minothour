using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    public float vertical;
    //private Vector3 moveVector; // for broken funktion

    public int speed = 100; // player's speed
    public GameObject player_st_pos; // position where you will spawn
    public GameObject player; // charackter
    public Rigidbody rb; // player's rigidbody
    

    void FixedUpdate()
    {
        //MovementLogic(); // broken funktion

        vertical = Input.GetAxis("Vertical");

        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical); // for going forward and backward
            //transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal); // it's for turning around but it's too buggy
        }
        
        if (Input.GetKey(KeyCode.A)) // for turning left
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.D)) // for turning right
        {
            transform.Rotate(0, 2, 0);
        }
        if (Input.GetKey(KeyCode.R)) // for respawn if you are stuck
        {
            player.transform.position = player_st_pos.transform.position;
            player.transform.rotation = player_st_pos.transform.rotation;
        }
    }
    //private void MovementLogic() //we will delete this whole code bcz it's not working properly 
    //{
        //moveVector.x = Input.GetAxis("Horizontal");

        //moveVector.z = Input.GetAxis("Vertical");

        //rb.MovePosition(moveVector * speed * Time.deltaTime);
    //}
}
