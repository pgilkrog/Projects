using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public GameObject target;
    public float speed = 5f;
    private float minDistance = 8f;
    private float range;
    private Animator anim;
    private bool isDead;
    private GameObject soundManager;

    enum EnemyStates
    {
        STATE_IDLE,
        STATE_WALKING,
        STATE_ATTACKING,
        STATE_DEAD
    }
    
    // Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        target = GameObject.Find("Gangster");
        isDead = false;
        soundManager = GameObject.Find("SoundManager");
	}

    void Update()
    {
        if (!isDead)
        {
            range = Vector2.Distance(transform.position, target.transform.position);
            if (target.transform.position.x > transform.position.x)
            {
                //face right
                transform.localScale = new Vector3(1.5f, 1.5f, 1);
            }
            else if (target.transform.position.x < transform.position.x)
            {
                //face left
                transform.localScale = new Vector3(-1.5f, 1.5f, 1);
            }

            if (range <= minDistance)
            {
                SetState(EnemyStates.STATE_WALKING);
                //transform.Translate(Vector2.MoveTowards(transform.position, target.position, range) * speed * Time.deltaTime);
            }
            if (range <= 1)
                SetState(EnemyStates.STATE_ATTACKING);
        }
    }

    void SetState(EnemyStates currentState)
    {
        switch(currentState){
            case EnemyStates.STATE_IDLE:
                break;
            case EnemyStates.STATE_WALKING:
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                anim.SetBool("isWalking", true);
                break;
            case EnemyStates.STATE_ATTACKING:
                AttackPlayer();
                break;
            case EnemyStates.STATE_DEAD:
                Dying();
                break;
        }
    }

    public void AttackPlayer()
    {
        anim.SetTrigger("isAttacking");
        if (target.transform.position.x > transform.position.x)
        {
            //face right
            target.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(20f, 10f));
        }
        else if (target.transform.position.x < transform.position.x)
        {
            //face left
            target.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-20f, 10f));
        }
    }

    public void Dying()
    {
        anim.SetTrigger("isDead");
        isDead = true;
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1, 0.3f);
        soundManager.GetComponent<SoundController>().PlayRandomSaying();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            SetState(EnemyStates.STATE_DEAD);
        }
    }
}
