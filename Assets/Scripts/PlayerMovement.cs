using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] FloatingJoystick floatingJoystick;
    [SerializeField] float speed;
    [SerializeField] float turnspeed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(floatingJoystick.Horizontal * turnspeed, 0, 0);

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2, 2);
        transform.position = pos;
    }
    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "+7":
                speed = 7;
                turnspeed = 0.1f;
                break;
            case "+8":
                speed = 8;
                turnspeed = 0.135f;
                break;
            case "+9":
                speed = 9;
                turnspeed = 0.17f;
                break;
            case "+10":
                speed = 10;
                turnspeed = 0.2f;
                break;
        }
    }
}
