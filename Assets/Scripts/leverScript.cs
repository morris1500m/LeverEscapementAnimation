using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leverScript : MonoBehaviour
{
    public float torque=300f;
    public Rigidbody rb;
    private GameObject horn;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;
        horn = UnityEngine.GameObject.Find("horn2");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCheckboxChange(bool value) {
        horn.SetActive(value);
    }

    public void OnButtonPress()
    {
        int direction = -1;

        if (transform.up.z < 0) {
            direction = 1;
        }
        rb.AddRelativeTorque(0, torque * direction, 0, ForceMode.Impulse);
    }

    public void OnRestartButtonPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
