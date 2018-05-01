using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public float speed = 10f;
    public float rotspeed = 100f;

	void Start ()
    {
		
	}	

	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * h * rotspeed * Time.deltaTime);
    }
}
