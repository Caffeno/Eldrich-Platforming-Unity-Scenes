using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dir = Input.GetAxis("Horizontal");
        Vector3 desiredPosition = transform.position + (new Vector3(moveSpeed, 0, 0) * dir);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);
        transform.position = smoothPosition;
    }
}
