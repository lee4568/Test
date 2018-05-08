using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour {

    Animation anim;
	
	void Start ()
    {
        anim = GetComponent<Animation>();
	}
	
	
	void Update ()
    {
		
	}


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {

        }
    }


}
