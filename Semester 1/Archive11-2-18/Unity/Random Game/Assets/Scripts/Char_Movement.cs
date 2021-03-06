﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Movement : MonoBehaviour {

    float jump = 4;
    float Speed = 10;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rbody.velocity;
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity = velocity + Vector3.up * jump;
            AudioManager.Instance.PlayOnShot(SoundEffect.Jump);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity = velocity + Vector3.left * Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity = velocity + Vector3.right * Speed;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1f - Time.deltaTime * 5), velocity.y, 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f), 0);
    }
}
