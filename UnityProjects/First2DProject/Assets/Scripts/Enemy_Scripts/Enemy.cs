using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CharacterSystem;

public class Enemy : MonoBehaviour
{
    public GameObject target; //the enemy's target
    public float moveSpeed = 3; //move speed
    private float calcDistance;
    public float distance;

    public int expDrop = 20;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        calcDistance = Vector3.Distance(target.transform.position, transform.position);

        if (calcDistance <= distance)
        {
            Vector3 targetDir = target.transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
            transform.Translate((Vector3.up  * moveSpeed) * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
