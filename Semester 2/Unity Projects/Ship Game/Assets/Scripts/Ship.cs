using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    [SerializeField]
    GameObject BulletPreFab;

    [SerializeField]
    float Speed = 8;

    Vector3 velocity = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {

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
            GameObject newBall = Instantiate(BulletPreFab);
            newBall.transform.position = transform.position;
            newBall.GetComponent<Bullet>().velocity = LookAtDirection(transform.eulerAngles.z);
        }
    }

    void MovementWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            velocity += Vector3.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity += Vector3.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right;
        }
    }

    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }
}
