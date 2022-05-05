using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float minDistance = 4;
    [SerializeField]
    int movementSpeed;
    [SerializeField]
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        float randomRotation = Random.Range(0f, 180f);
        transform.Rotate(Vector3.down * randomRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < minDistance)
        {
            transform.LookAt(target);
            movementSpeed = 3;
            minDistance = 10;
        }
        else
        {
            minDistance = 4;
            movementSpeed = 2;
        }
        
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
} 
