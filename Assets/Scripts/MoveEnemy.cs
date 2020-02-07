using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speedMove;
    private Rigidbody enemyRb;
    private float zDestroy = -6.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.forward*-speedMove);
        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
