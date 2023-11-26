using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public Vector3 initialImpulse = new Vector3(0.03f, 0, 0);
    public GameObject position_initiale;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Lorsqu'on appuie sur la barre espace, le jeu commence, la balle est lancée depuis le milieu
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = position_initiale.transform.position;
            GetComponent<Rigidbody>().velocity = initialImpulse;
        }
    }
}








