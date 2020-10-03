using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBlock : MonoBehaviour
{
    private Vector3 spawnLocation;
    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6f)
        {
            transform.position = spawnLocation;
            rb.velocity = new Vector3(0, 0, 0);
        }

    }
}
