using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public Basestate activeState;
   

    public void Initialise() 
    {
        
        ChangeState(new PatrolState());
    
    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activeState!=null)
        {
            activeState.Perform();
        }
    }
    public void ChangeState (Basestate newState)
    {

        if (activeState != null)
        {
            activeState.Exit();
        }
        activeState = newState;
        if (activeState != null)
        {
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();
        }
    }
}
