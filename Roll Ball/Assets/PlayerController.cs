using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    float score = 0;
    public Text scoreText;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    //modify score when collides with pickup
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
            score = score + 10;
        scoreText.text = "score:" + score;
        {
            other.gameObject.SetActive(false);
        }
    }
}
