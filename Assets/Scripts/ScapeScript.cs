using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScapeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float torque = 200f;

    private float maxVelocity = 400f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(new Vector3(0f, 0f, -1 * torque*Time.deltaTime));
    }
}
