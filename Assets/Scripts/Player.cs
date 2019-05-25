using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 3.0f;
    public float jumpForce = 5f;
    public Rigidbody2D rigidbody;
    public bool isGrounded;
    public HealthManager healthManager;
    // Use this for initialization
    void Start () {
	}

	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (Vector3.left * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            Debug.LogError("Jumping");
            rigidbody.AddForce(jumpForce * Vector3.up, ForceMode2D.Impulse);
        }
	}


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isGrounded = true;
        }
        if(collision.gameObject.tag == "Enemy")
        {
            healthManager.LoseLife();
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
