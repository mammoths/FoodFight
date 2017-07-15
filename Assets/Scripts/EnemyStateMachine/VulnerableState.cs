using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VulnerableState : EnemyState
{
    GameObject goal;
    public int vulnerableTimer = 2;


    private readonly EnemyStatePattern enemy;
    public VulnerableState (EnemyStatePattern enemy_State_Pattern)
    {
        enemy = enemy_State_Pattern;


    }



    public void StartState() { }
    public void UpdateState()
    {


        if (!enemy.stateChange)
        {
            enemy.moveTo.StopMovement();
            enemy.animator.Play("Vulnerable");
            enemy.stateChange = true;
            Debug.Log("Current State is Vulnerable");
            enemy.ActionChooserStart(vulnerableTimer);


        }
    }



    public void toHelloState() { }
    public void toBlockState() { }
    public void toThrowState() { }
    public void toVulnerableState() { }
    public void toWalkState() { }
    public void toSpinState() { }




}
