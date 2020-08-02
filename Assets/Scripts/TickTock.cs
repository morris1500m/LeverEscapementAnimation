using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickTock : MonoBehaviour
{
    private int direction = 1;
    public Slider timeSlider;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.zero;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 50f * Time.deltaTime* direction));

        if (transform.rotation.eulerAngles.z <= 130 && transform.rotation.eulerAngles.z >= 120 &&  direction > 0) {
            direction = -1;
        }
        if (transform.rotation.eulerAngles.z <= 220 && transform.rotation.eulerAngles.z >= 210 && direction < 0)
        {
            direction = 1;
        }

        Time.timeScale = timeSlider.value;
    }
}
