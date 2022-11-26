using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Functions;

public class BumperActivatorCircleBehaviour : MonoBehaviour {
    public GameObject ballObject;
    float bumperForce = 6000f;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.Equals(ballObject)) {
            ballObject.GetComponent<Rigidbody2D>().AddForce(
                VectorFunctions.AngularToCartesian(
                    bumperForce,
                    Vector2.Angle(
                        this.GetComponent<Rigidbody2D>().position,
                        ballObject.GetComponent<Rigidbody2D>().position)
                    )
                );
        }
    }
}
