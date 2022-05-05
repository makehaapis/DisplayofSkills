using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    Transform target2;
    [SerializeField]
    Transform target3;
    Transform randomTarget;

    void OnCollisionEnter(Collision collision)
    {
        int randomInt = Random.Range(0, 2);
        if (randomInt == 0)
        {
            randomTarget = target;
        }
        if (randomInt == 1)
        {
            randomTarget = target2;
        }
        else
        {
            randomTarget = target3;
        }
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Wall")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            transform.LookAt(randomTarget);
        }
    }
}
