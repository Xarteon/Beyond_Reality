using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private float DriftValue = -1f;
    private float NormalValueDrift = 1.0f;
    private float PushingForce = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * Time.deltaTime * 90, 0);
        rb.velocity = new Vector3(transform.forward.x * vertical * speed, rb.velocity.y, transform.forward.z * vertical * speed);

        if (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift))
        {
            rb.angularDrag = DriftValue;
            rb.AddForce(-horizontal * PushingForce * transform.right, ForceMode.Impulse);
        }
        else
        {
            rb.angularDrag = NormalValueDrift;
        }
    }
}