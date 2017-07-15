using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeakspot : MonoBehaviour {


    Animator m_animator;
    MoveTo moveTo;

	// Use this for initialization
	void Start () {
        m_animator = GetComponentInParent<Animator>();
        moveTo = GetComponentInParent<MoveTo>();
     
  
	}

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            { return;  }
        moveTo.agent.ResetPath(); 
        m_animator.SetBool("isHit", true);
        Debug.Log("Enemy was hit by " + other);
         
        Destroy(this.gameObject.transform.parent.gameObject, 2);


    }

}
