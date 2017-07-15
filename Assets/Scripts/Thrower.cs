using UnityEngine;
using System.Collections;

public class Thrower : MonoBehaviour
{

    public GameObject[] prefab;
    public GameObject handSpawn;
    BallScript ballscript;
    GameObject spawn;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewBall()
    {
        int spawnObjectIndex = Random.Range(0, prefab.Length);
        GameObject ball = prefab[spawnObjectIndex];
    
        spawn = GameObject.Instantiate(ball, handSpawn.transform.position, handSpawn.transform.rotation);
        spawn.transform.parent = handSpawn.transform;
        ballscript = spawn.GetComponent<BallScript>();      
        ballscript.RBody.useGravity = false;
        ballscript.hasbeenthrown = false;

    }


    public void ThrowBall()
    {
       
 
        ballscript.ReleaseNow();

      
    }
}