using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    private Rigidbody PlayerRb;
    private float speed = 10.0f;
    public float horizontalInput;
    public float xRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        //adds rigidbody to our player
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes our player move left to right and makes it so it can't move off the screen
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 25)
        {
            transform.position = new Vector3(25, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

    }
    
}
