using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CharacterSystem.Interfaces;

public class LittleRedEnemy : MonoBehaviour, IHealthManager
{
    public int health = 20;
    public int damageDealing = 10;

    public GameObject target; //the enemy's target
    public float moveSpeed = 3; //move speed
    private float calcDistance;
    public float distance;

    public int expDrop = 20;

    void Update()
    {
        calcDistance = Vector3.Distance(target.transform.position, transform.position);

        if (calcDistance <= distance)
        {
            Vector3 targetDir = target.transform.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);
            transform.Translate((Vector3.up * moveSpeed) * Time.deltaTime);
        }
    }
    public int GetHealth()
    {
        return health;
    }

    public int GetMaxHealth()
    {
        throw new System.NotImplementedException();
    }

    public void GiveHealth(int amount)
    {
        throw new System.NotImplementedException();
    }

    public void MoreMaxHealth(int amount)
    {
        throw new System.NotImplementedException();
    }

    public void TakeHealth(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {

    }
}