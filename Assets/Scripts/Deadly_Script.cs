using UnityEngine;

public class Deadly_Script : MonoBehaviour
{
    public GameObject player_st_pos;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = player_st_pos.transform.position;
            player.transform.rotation = player_st_pos.transform.rotation;
        }
    }
}
