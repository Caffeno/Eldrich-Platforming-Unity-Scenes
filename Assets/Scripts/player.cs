
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool slow = false;
    private float speed = 0f;
    private Vector3 spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        speed += 0.05f * Time.unscaledDeltaTime;
        if (transform.position.y < -6f)
        {
            transform.position = spawnLocation;
            speed = 0f;
        }

        transform.position += new Vector3(0f, -1f, 0f) * speed;
    }
}
