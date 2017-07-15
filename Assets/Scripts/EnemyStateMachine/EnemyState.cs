using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface EnemyState
{

    void StartState();
    void UpdateState();

    void toHelloState();
    void toBlockState();
    void toThrowState();
    void toVulnerableState();
    void toWalkState();
    void toSpinState();
    

}
