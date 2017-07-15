using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomLocomotion : MonoBehaviour {
    
    Animator m_animator;
    MoveTo moveTo;
    UnityEngine.AI.NavMeshAgent agent; 
   public bool isYellow = false;

    bool transition = true; 
    // Use this for initialization
    void Start() {
        m_animator = GetComponent<Animator>();
        moveTo = GetComponent<MoveTo>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); 


        if (isYellow)
        {
            StartCoroutine(WalkThrow());
        }
    }



    void OnCollisionEnter(Collision collision) // Only for the Cap!
    {
        Debug.Log("The cap blocked the " + collision.collider);

    }


    IEnumerator WalkThrow()
    {
            
        while (transition)
        {
            bool walk = m_animator.GetBool("WalkNow");

            if (!walk)
            {
                agent.isStopped = false;
                //moveTo.StartMovement();

            }
            else
            { agent.isStopped = true; } // moveTo.StopMovement(); }

            m_animator.SetBool("WalkNow", !walk);
           

            

            yield return new WaitForSeconds(2);

        }
        
        }

      


}
