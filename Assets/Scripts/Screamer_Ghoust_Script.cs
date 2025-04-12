using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Screamer_Ghoust_Script : MonoBehaviour
{
    public GameObject colider;
    public GameObject scream_Pos;
    public GameObject black_Guy;
    public AudioClip scream;
    public bool value = false;

    void ScreamofFun()
    {
        black_Guy.transform.position = scream_Pos.transform.position;
        GetComponent<AudioSource>().PlayOneShot(scream);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Scr1"))
        {
            Destroy(black_Guy);
        }
    }
    private void OnCollisionEnter(Collision collision) // checks if player toches key pad
    {
        if (collision.gameObject.CompareTag("ScrKey1") && value == false)
        {
            value = true;
            ScreamofFun();
            print("OMG");
            
        }

    }
}
