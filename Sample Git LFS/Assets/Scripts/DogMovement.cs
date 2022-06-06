using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class DogMovement : MonoBehaviour { 
    Vector3 Vec;
    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
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

