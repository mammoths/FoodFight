using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Listeners : MonoBehaviour
{

    public bool leftTriggerInteractive = false;
    public bool rightTriggerInteractive = false;
    public bool leftGripInteractive = false;
    public bool rightGripInteractive = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool GetLeftTriggerInteracting()
    {
        return leftTriggerInteractive;
    }
    public bool GetRightTriggerInteracting()
    {
        return rightTriggerInteractive;
    }
    public void SetLeftTriggerInteracting(bool val)
    {
        leftTriggerInteractive = val;
    }
    public void SetRightTriggerInteracting(bool val)
    {
        rightTriggerInteractive = val;
    }

    public void SetLeftGripped(bool val)
    {
        leftGripInteractive = val;
    }
    public void SetRightGripped(bool val)
    {
        rightGripInteractive = val;
    }

    void OnEnable()
    {
        Singleton_Service.RegisterSingletonInstance(this);
    }
    void OnDisable()
    {
        Singleton_Service.UnregisterSingletonInstance(this);
    }
}