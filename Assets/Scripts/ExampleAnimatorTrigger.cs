using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ExampleAnimatorTrigger : MonoBehaviour
{
    public Animator boyAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand ("SillyDance")]
    public void SillyDance()
    {
        boyAnimator.Play("Silly Dance");
    }

    public void AngryTalk()
    {
        boyAnimator.Play("angry talk");
    }

}
