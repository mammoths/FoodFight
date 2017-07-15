using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Right_VR_Cont : MonoBehaviour
{

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    Input_Listeners IPL;
    // Use this for initialization
    void Start()
    {
        IPL = GameObject.Find("GM").GetComponent<Input_Listeners>();
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.GetPressDown(triggerButton))
        {
            IPL.SetRightTriggerInteracting(true);

        }
        if (controller.GetPressUp(triggerButton))
        {
            IPL.SetRightTriggerInteracting(false);
        }
    }

}
