using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour {

    public float speed;
    public float rotspeed;

    void Awake()
    {
        
    }

	void Start ()
    {
      
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * h * rotspeed * Time.deltaTime);
    }
}
