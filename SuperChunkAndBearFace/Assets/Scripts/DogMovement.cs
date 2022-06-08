using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DogMovement : MonoBehaviour { 
    Vector3 Vec;
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

    // Start is called before the first frame update  
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    // Update is called once per frame  
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;

        if (Input.GetKey(KeyCode.A))
    {
        transform.Translate(0.1f, 0f, 0f);
    }
        if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(-0.1f, 0f, 0f);
    }
        if (Input.GetKey(KeyCode.S))
    {
        transform.Translate(0.0f, 0f, -0.1f);
    }
        if (Input.GetKey(KeyCode.W))
    {
        transform.Translate(0.0f, 0f, 0.1f);
    }
    Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;
}
}