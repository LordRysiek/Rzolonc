using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation45 : StateMachineBehaviour
    {
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.transform.Rotate(0, 45, 0);
    }
}
