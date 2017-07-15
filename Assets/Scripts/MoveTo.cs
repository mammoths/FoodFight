// MoveTo.cs
using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{

    GameObject goal;
   [HideInInspector] public UnityEngine.AI.NavMeshAgent agent;
    public bool isMoving; 
   

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        goal = GameObject.FindGameObjectWithTag("Goal");
        agent.destination =  goal.transform.position;
        

      
    }


    private void Update()
    {
      
        agent.transform.localRotation.SetLookRotation(Vector3.forward);
      

    }


    public void StopMovement()
    {

        agent.isStopped = true;
        isMoving = false; 
    }

    public void StartMovement()
    {
        agent.isStopped = false;
        isMoving = true;
    }



}

//Reset Path clears path until SetDestination is used again. 
//Plan: CoRoutine?? 