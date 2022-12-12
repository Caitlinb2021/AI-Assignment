using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity; 


public class RobberAnimationController : MonoBehaviour
{
    // This script is to control when the robber animation plays during a YarnDialogue 
    public Animator RobberAnimatorController;
    public InMemoryVariableStorage YarnInMemoryStorage;

    [YarnCommand("Walk")]

    public void Walk()
    {
        RobberAnimatorController.Play("Walk"); 
    }

    public void RobberyinAction()
    {
        RobberAnimatorController.Play("angry talk");
    }

    public void RunFast()
    {
        RobberAnimatorController.Play("Run Fast M");
    }

}
