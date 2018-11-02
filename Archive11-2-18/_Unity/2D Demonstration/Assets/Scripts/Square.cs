using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {

    [SerializeField]
    GameObject ballPreFab;

    [SerializeField]
    float Speed = 10;

    Vector3 velocity = new Vector3(0, 0, 0);

    float timer = 0f;
    float overall = 1f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }

        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * Speed;


        if (Input.GetKey(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballPreFab);
            newBall.transform.position = transform.position;
            newBall.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z);
        }

        timer += Time.deltaTime;
        if (timer > overall)
        {
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            timer = 0f;
        }
    }

    void MovementWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 0.9f)
            {
                velocity += Vector3.up;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.7f)
            {
                velocity += Vector3.left;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -.9f)
            {
                velocity += Vector3.down;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.7f)
            {
                velocity += Vector3.right;
            }
        }
    }

    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }
}
