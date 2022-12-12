using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class VictimAnimationController : MonoBehaviour
{
    // this script is to enable victim animations at a certain point in a YarnDialogue Script
    public Animator VictimAnimatorController;
    public InMemoryVariableStorage YarnInMemoryStorage;

    [YarnCommand("SlowWalk")]

    public void SlowWalk()
    {
        VictimAnimatorController.Play("Slow Walk");
    }

    public void angrytalk()
    {
        VictimAnimatorController.Play("angry talk"); 
    }

    public void IdleScratchHead()
    {
        VictimAnimatorController.Play("Idle Scratch Head"); 
    }

    public void IdleWaiting()
    {
        VictimAnimatorController.Play("Idle Waiting"); 
    }
}
