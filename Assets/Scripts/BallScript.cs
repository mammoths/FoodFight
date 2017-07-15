using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class BallScript : MonoBehaviour
{

    
    public GameObject ParentBone;
    public Rigidbody RBody;
    public float Force;
    public bool hasbeenthrown = false; 


    // Use this for initialization
    void Start()
    {
      
    
    }

    // Update is called once per frame
    void Update()
    {

        /*if (!hasbeenthrown)
        {

            transform.position = ParentBone.transform.position;
        }*/
    }

  
    public void ReleaseNow()
    {
        transform.parent = null; 
        Debug.Log(transform.parent);
       
        RBody.useGravity = true;
       // transform.rotation = ParentBone.transform.rotation;
        RBody.AddForce(transform.forward * Force);
        hasbeenthrown = true;
        Debug.Log(hasbeenthrown);

    }
}