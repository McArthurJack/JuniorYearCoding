using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroids : MonoBehaviour {

    public Vector3 velocity = new Vector3(0, 0, 0);
    float speed = 4f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity.Normalize();
        transform.position += velocity * Time.deltaTime * speed;
    }
}
