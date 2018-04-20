using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogerACS : MonoBehaviour {


    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        UpdateDirectionAndIsRunning();
    }

    void UpdateDirectionAndIsRunning()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        string directionName = "DirectionClockwise";
        anim.SetBool("IsRunning", horizontal != 0 || vertical != 0);
        if (horizontal == 0)
        {
            if (vertical > 0)     //prosto
            {
                anim.SetInteger(directionName, 0);
            }
            else if (vertical == 0)     //stoi
            {
                anim.SetInteger(directionName, 0);
            }
            else if (vertical < 0)     //do tylu
            {
                anim.SetInteger(directionName, 4);
            }
        }
        else if (horizontal > 0)
        {
            if (vertical > 0)     //w prawo i prosto
            {
                anim.SetInteger(directionName, 1);
            }
            else if (vertical == 0)     //w prawo
            {
                anim.SetInteger(directionName, 2);
            }
            else if (vertical < 0)     //w prawo i do tylu
            {
                anim.SetInteger(directionName, 3);
            }
        }
        else if (horizontal < 0)
        {
            if (vertical > 0)     //w lewo i prosto
            {
                anim.SetInteger(directionName, 7);
            }
            else if (vertical == 0)     //w lewo
            {
                anim.SetInteger(directionName, 6);
            }
            else if (vertical < 0)     //w lewo i do tylu
            {
                anim.SetInteger(directionName, 5);
            }
        }
    }
}
