using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockState : EnemyState
{
    GameObject goal;
    public int blockTimer = 2;


    private readonly EnemyStatePattern enemy;
    public BlockState(EnemyStatePattern enemy_State_Pattern)
    {
        enemy = enemy_State_Pattern;


    }



    public void StartState() { }
    public void UpdateState()
    {


        if (!enemy.stateChange)
        {
            enemy.moveTo.StopMovement();
            enemy.animator.Play("Block");
            enemy.stateChange = true;
            Debug.Log("Current State is Block");
            enemy.ActionChooserStart(blockTimer);


        }
    }



    public void toHelloState() { }
    public void toBlockState() { }
    public void toThrowState() { }
    public void toVulnerableState() { }
    public void toWalkState() { }
    public void toSpinState() { }




}
