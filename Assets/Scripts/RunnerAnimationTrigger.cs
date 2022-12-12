using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity; 

public class RunnerAnimationTrigger : MonoBehaviour
{
    public Animator RunnerAnimationController;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    [YarnCommand ("StartRun")]
    public void StartRun()
    {
        RunnerAnimationController.Play("Start Run");
    }

    public void IdleWaiting()
    {
        RunnerAnimationController.Play("Idle Waiting"); 
    }

    public void Walkneutral()
    {
        RunnerAnimationController.Play("Walk neutral"); 
    }
}
