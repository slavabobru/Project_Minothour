using UnityEngine;

public class Key_Script : MonoBehaviour
{
    public bool[] key;
    
    public bool value = false;

    public GameObject Sekret_Door;
    public GameObject Sekret_Door_Pos;
    public GameObject Key1;
    public GameObject Key1_Pos;
    void Start()
    {
        //key = new bool[3];
        //key[0] = false;
        //key[1] = false;
        //key[2] = false;
    }
    void Update()
    {
        if (value == true)
            Open_sek_dr();
    }
    private void Open_sek_dr()
    {
        Sekret_Door.transform.position = Sekret_Door_Pos.transform.position;
        Key1.transform.position = Key1_Pos.transform.position;
        value = false;
    }
    private void OnCollisionEnter(Collision collision) // checks if player toches key pad
    {
        if (collision.gameObject.CompareTag("Key1"))
        {
            value = true;
        }
        //if (collision.gameObject.CompareTag("Key2"))
        //{
            //key[1] = true;
        //}
        //if (collision.gameObject.CompareTag("Key3"))
        //{
           // key[2] = true;
        //}
    }
}
