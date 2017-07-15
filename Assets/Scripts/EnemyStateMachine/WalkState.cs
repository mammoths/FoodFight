using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : EnemyState
{
    GameObject goal;

    public int walkTimer = 4;

    private readonly EnemyStatePattern enemy;
    public WalkState(EnemyStatePattern enemy_State_Pattern)
    {
        enemy = enemy_State_Pattern;

    }



    public void StartState() { Debug.Log("Start state runs");  }
    public void UpdateState()
    {

        if (!enemy.stateChange)
        {
            enemy.moveTo.StartMovement();
            enemy.animator.Play("Walk");
            enemy.stateChange = true;
            Debug.Log("Current State is Walk");
            enemy.ActionChooserStart(walkTimer);
        }
     
   }


  

    public void toHelloState() { enemy.currentState = enemy.helloState; }
    public void toBlockState() { enemy.currentState = enemy.blockState; }
    public void toThrowState() { }
    public void toVulnerableState() { }
    public void toWalkState() { enemy.currentState = enemy.walkState; }
    public void toSpinState() { }


    
}
