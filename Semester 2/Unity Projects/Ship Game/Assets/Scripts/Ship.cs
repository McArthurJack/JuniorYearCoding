using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    [SerializeField]
    GameObject BulletPreFab;

    [SerializeField]
    GameObject Astroid;

    [SerializeField]
    float Speed = 6;

    Vector3 velocity = new Vector3(0, 0, 0);

    float timer = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
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
            newBall.transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            newBall.GetComponent<Bullet>().velocity = LookAtDirection(transform.eulerAngles.z);
        }

        if (timer >= 2)
        {
            int switchnumber = Random.Range(0, 4);
            GameObject newBall = Instantiate(Astroid);
            switch (switchnumber)
            {
                case 1:
                    newBall.transform.position = new Vector3(transform.position.x + 4f, transform.position.y, 1);
                    newBall.GetComponent<Astroids>().velocity = new Vector3(-1 * transform.position.x, transform.position.y, -1 * transform.position.z);
                    timer = 0;
                    break;
                case 2:
                    newBall.transform.position = new Vector3(transform.position.x - 4f, transform.position.y, 1);
                    newBall.GetComponent<Astroids>().velocity = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    timer = 0;
                    break;
                case 3:
                    newBall.transform.position = new Vector3(transform.position.x, transform.position.y + 4f, 1);
                    newBall.GetComponent<Astroids>().velocity = new Vector3(transform.position.x, -1 * transform.position.y, transform.position.z);
                    timer = 0;
                    break;
                case 4:
                    newBall.transform.position = new Vector3(transform.position.x, transform.position.y - 4f, 1);
                    newBall.GetComponent<Astroids>().velocity = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    timer = 0;
                    break;

            }
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
