using UnityEngine;
using System.Collections;

using Globals;
using FlipperValues;

public class FlipperRightBehaviour : MonoBehaviour {
    HingeJoint2D hinge;
    JointMotor2D motor;
    Values.FlipperState state = Values.FlipperState.down;

    void Update() {
        hinge = GetComponent<HingeJoint2D>();
        motor = hinge.motor;

        if (hinge.limitState == JointLimitState2D.UpperLimit && state != Values.FlipperState.goingDown) {
            state = Values.FlipperState.up;
        }
        if (hinge.limitState == JointLimitState2D.LowerLimit && state != Values.FlipperState.goingUp) {
            state = Values.FlipperState.down;
        }

        if (Input.GetKey(KeyCode.D)) {
            if (state == Values.FlipperState.up) {
                motor.motorSpeed = 0f;
            }
            else if(state == Values.FlipperState.down || state == Values.FlipperState.goingDown) {
                motor.motorSpeed = Globals.Flipper.speed;
                state = Values.FlipperState.goingUp;
            }
        }
        else {
            if (state == Values.FlipperState.down) {
                motor.motorSpeed = 0f;
            }
            else if(state == Values.FlipperState.up) {
                motor.motorSpeed = -Globals.Flipper.speed;
                state = Values.FlipperState.goingDown;
            }
        }

        hinge.motor = motor;
    }
}
