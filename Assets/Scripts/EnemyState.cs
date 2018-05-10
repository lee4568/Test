using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour {

    public Enemystate enemystate;

    Animator anim;

    public GameObject target;

    float HP = 100f;

    public enum Enemystate
    {
        IDLE,
        WALK,
        ATTACK,
        DEAD
    }

	void Awake ()
    {
        anim = GetComponent<Animator>();
	}
	
	void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

	void Update ()
    {
        float distance = (target.transform.position - transform.position).magnitude;

        switch (enemystate)
        {
            case Enemystate.IDLE:

                if(distance >= 2f)
                {
                   enemystate = Enemystate.WALK;
                }

                break;

            case Enemystate.WALK:

                if (distance <= 2f)
                {
                    enemystate = Enemystate.ATTACK;
                }

                break;
            case Enemystate.ATTACK:

                
                if (distance >= 2f)
                {
                    enemystate = Enemystate.WALK;
                }

                break;
            case Enemystate.DEAD:

                if(HP <= 0)
                {
                    Destroy(gameObject,3f);
                }

                break;
        }
    }

}
