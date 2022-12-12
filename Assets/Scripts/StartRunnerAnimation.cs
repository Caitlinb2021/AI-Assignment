using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class StartRunnerAnimation : MonoBehaviour
{
    public Animator RunnerAnimator;
    public InMemoryVariableStorage YarnInMemoryStorage;

    [YarnCommand("RunningAnimationSelector")]
    public void RunningAnimationSelector()
    {
        string RunningAnimation;
        YarnInMemoryStorage.TryGetValue("$RunningAnimation", out RunningAnimation);

        if (RunningAnimation == "IsRunning") 
        {
            RunnerAnimator.Play("Start Run");
        }

    }
        
}
