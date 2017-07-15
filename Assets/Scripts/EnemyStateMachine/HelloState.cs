using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloState : EnemyState {

    public int helloTimer = 1; 
    private readonly EnemyStatePattern enemy;
    public HelloState(EnemyStatePattern enemy_State_Pattern)
    {
        enemy = enemy_State_Pattern;

    }

   
    

    public void StartState() {  }
    public void UpdateState()
    { 
        enemy.moveTo.StopMovement();
        enemy.animator.Play("Hello");
       

        if (enemy.animator.GetCurrentAnimatorStateInfo(0).normalizedTime>1 && !enemy.stateChange)
        {
            Debug.Log("Current State is Hello");
            enemy.stateChange = true;
            enemy.ActionChooserStart(helloTimer);
            
        }    
    }


    public void toHelloState() { }
    public void toBlockState() { }
    public void toThrowState() { }
    public void toVulnerableState() { }
    public void toWalkState() { enemy.currentState = enemy.walkState; }
    public void toSpinState() { }



    
}
