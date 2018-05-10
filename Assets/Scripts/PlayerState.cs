using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    public Playerstate playerstate;

    public enum Playerstate
    {
        IDLE,
        WALK,
        ATTACK,
        DEAD
    }

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        switch (playerstate)
        {
            case Playerstate.IDLE:

                break;
            case Playerstate.WALK:

                break;
            case Playerstate.ATTACK:

                break;
            case Playerstate.DEAD:

                break;

            default:
                break;
        }
    }
}
