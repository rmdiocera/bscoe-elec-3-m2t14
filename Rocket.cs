using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Rotate(Vector3.back);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Rotate(Vector3.forward);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstacle" || collision.gameObject.name == "Sphere")
        {
            transform.position = new Vector3(7.08f, 3.86f, 6.22f);
            transform.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

        }
        if (collision.gameObject.name == "Obstacle - Asteroid" || collision.gameObject.name == "Sphere")
        {
            transform.position = new Vector3(7.08f, 3.86f, 6.22f);
            transform.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

        }
        if (collision.gameObject.name == "Obstacle - Rocketship" || collision.gameObject.name == "Cylinder")
        {
            transform.position = new Vector3(7.08f, 3.86f, 6.22f);
            transform.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

        }
        if (collision.gameObject.name == "Left Wall" || collision.gameObject.name == "Cube")
        {
            transform.position = new Vector3(7.08f, 3.86f, 6.22f);
            transform.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

        }
        if (collision.gameObject.name == "Right Wall" || collision.gameObject.name == "Cube")
        {
            transform.position = new Vector3(7.08f, 3.86f, 6.22f);
            transform.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

        }
        if (collision.gameObject.name == "Top Wall" || collision.gameObject.name == "Cube")
        {
            transform.position = new Vector3(7.08f, 3.86f, 6.22f);
            transform.rotation = Quaternion.identity;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);

        }

        if (collision.gameObject.name == "Target Pod")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }


    }
}
