using UnityEngine;
using System.Collections;

using Globals;

public class BallLauncherBehaviour : MonoBehaviour {
    public GameObject ballObject;
    bool isBallLaunched = true;

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.Equals(ballObject)) {
            isBallLaunched = false;
        }
    }

    void OnCollisionExit2D(Collision2D coll) {
        if (coll.gameObject.Equals(ballObject)) {
            isBallLaunched = true;
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallLaunched) {
            GetComponent<Rigidbody2D>().AddForce(Globals.Launch.forceVector);
        }
    }
}