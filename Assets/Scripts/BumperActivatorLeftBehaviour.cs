using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Functions;

public class BumperActivatorLeftBehaviour : MonoBehaviour {
    public GameObject ballObject;
    Vector2 bumperForceVector = Vector2.one;

    // Start is called before the first frame update
    void Start() {
        bumperForceVector = VectorFunctions.AngularToCartesian(6000f, -this.GetComponent<Transform>().eulerAngles.z);
    }

    // Update is called once per frame
    void Update() {
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.Equals(ballObject)) {
            ballObject.GetComponent<Rigidbody2D>().AddForce(bumperForceVector);
        }
    }
}
