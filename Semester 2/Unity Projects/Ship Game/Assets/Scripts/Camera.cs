using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject ship;
    Vector3 goalVector = new Vector3();
    float hspeed = 5f;
    float vspeed = 5f;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(ship.transform.position.x, ship.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        goalVector = new Vector3(ship.transform.position.x, ship.transform.position.y, -10);
        goalVector += new Vector3(ship.GetComponent<Rigidbody2D>().velocity.x,
            ship.GetComponent<Rigidbody2D>().velocity.y, 0);
        Vector3 velocity = goalVector - transform.position;

        transform.position += new Vector3(velocity.x * Time.deltaTime * hspeed, velocity.y * Time.deltaTime * vspeed, 0);
    }
}
