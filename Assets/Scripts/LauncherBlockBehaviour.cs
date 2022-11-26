using UnityEngine;
using System.Collections;

public class LauncherBlockBehaviour : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D coll)
    {
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<BoxCollider2D>().isTrigger = false;
        GetComponent<BoxCollider2D>().usedByEffector = true;
    }
}