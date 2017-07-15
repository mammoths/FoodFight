using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatePattern : MonoBehaviour
{
    public bool stateChange = false;
    public bool isYellow = false;
    bool walk; 

    //[HideInInspector] public UnityEngine.AI.NavMeshAgent agent; 
    [HideInInspector] public MoveTo moveTo;
    public static EnemyStatePattern instance;
    [HideInInspector] public Animator animator;
    [HideInInspector] public EnemyState currentState;
    [HideInInspector] public HelloState helloState;
    [HideInInspector] public BlockState blockState;
    [HideInInspector] public WalkState walkState;
    [HideInInspector] public ThrowState throwState;
    [HideInInspector] public SpinState spinState;
    [HideInInspector] public VulnerableState vulnerableState;



    void Awake()
    {
        instance = this;
        helloState = new HelloState(this);
        walkState = new WalkState(this);
        blockState = new BlockState(this);
        vulnerableState = new VulnerableState(this);

    }

    void Start()
    {
        currentState = helloState;
        moveTo = GetComponent<MoveTo>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        currentState.UpdateState();

    }

    public void ActionChooserStart(int timer)
    {

      
        StartCoroutine(ActionChooser(timer));
    }



   public IEnumerator ActionChooser(int timer)
    {

        yield return new WaitForSeconds(timer);
        int randomAction = Random.Range(1, 7);
        Debug.Log("Random number generated: " + randomAction);

        switch (randomAction)
        {
            case 1:
                Debug.Log("Blocking!");
                currentState = blockState;
                break;
            case 2:
            case 3:
            case 4:
                currentState = walkState;
                Debug.Log("Walking!");
                break;
            case 5:
                currentState = helloState;
                Debug.Log("Hello!");
                break;
            case 6:
                currentState = vulnerableState;
                Debug.Log("Vulnerable");
                break;
            default:
                currentState = walkState;
                break;
        }
        stateChange = false;


    }


}
