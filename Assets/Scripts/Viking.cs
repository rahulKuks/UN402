using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viking : MonoBehaviour {

    public float speed = 5f;
    public bool left = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(left)
        {
            transform.position = transform.position + (Vector3.left * Time.deltaTime * speed);
        }
        else
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * speed);
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "EnemyDirectionTrigger")
        {
            left = !left;
        }
    }
}
