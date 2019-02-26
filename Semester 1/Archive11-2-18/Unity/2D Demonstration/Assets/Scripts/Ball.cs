using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector3 velocity = new Vector3(0, 0, 0);
    float speed = 1.5f;

    float timer = 0f;
    float overall = 1f;

    float timed = 0f;

    // Use this for initialization
    void Start () {
        //velocity += new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
	
	// Update is called once per frame
	void Update () {
        velocity.Normalize();
        transform.position += velocity * Time.deltaTime * 4;
        if (transform.position.x < -1.75f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(-1.705f, transform.position.y, 0);
        }
        if (transform.position.x > 1.75f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(1.705f, transform.position.y, 0);
        }
        if (transform.position.y < -1f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, -0.93f, 0);
        }
        if (transform.position.y > 1f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, 0.93f, 0);
        }

        timer += Time.deltaTime;
        if (timer > overall)
        {
            //GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            //timer = 0f;
        }

        timed += Time.deltaTime;
        if (timed > 6)
        {
            Destroy(gameObject);
            timed = 0f;
        }

    }
}
