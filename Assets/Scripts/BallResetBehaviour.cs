using UnityEngine;
using System.Collections;

public class BallResetBehaviour : MonoBehaviour {
    Vector2 START_POSITION = new Vector2(3.7055f, 1.87372f);

    public GameObject launcher;
    public GameObject launcherBlock;

    void Update() {
        // if ball falls below a certain position
        if(transform.position.y < -1f) {
            // reset ball position to launcher
            GetComponent<Rigidbody2D>().MovePosition(START_POSITION);
            GetComponent<Rigidbody2D>().inertia = 0f;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.Equals(launcher)) {
            // reset launcher block
            launcherBlock.GetComponent<SpriteRenderer>().enabled = false;
            launcherBlock.GetComponent<BoxCollider2D>().isTrigger = true;
            launcherBlock.GetComponent<BoxCollider2D>().usedByEffector = false;
        }
    }
}