using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class PlayerControls : MonoBehaviour
    {
        private GameObject soundManager;
        private Animator animator;

        private float speed;
        private bool canJump;
        private bool facingLeft;

        public GameObject bullet;

        private Rigidbody2D rb2d;
        public enum PlayerState
        {
            STATE_STANDING,
            STATE_WALKING,
            STATE_JUMPING,
            STATE_SHOOTING
        };

        // Use this for initialization
        void Start()
        {
            speed = 5f;
            animator = this.GetComponent<Animator>();
            rb2d = GetComponent<Rigidbody2D>();
            canJump = true;
            soundManager = GameObject.Find("SoundManager");
            facingLeft = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
                StateSelect(PlayerState.STATE_SHOOTING);
            if (Input.GetKeyDown(KeyCode.Space))
                StateSelect(PlayerState.STATE_JUMPING);
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
                StateSelect(PlayerState.STATE_WALKING);
            if (Input.anyKey == false)
                StateSelect(PlayerState.STATE_STANDING);
        }

        void StateSelect(PlayerState currentState)
        {
            switch (currentState)
            {
                case PlayerState.STATE_STANDING:
                    animator.SetBool("isIdle", true);
                    animator.SetBool("isWalking", false);
                    break;
                case PlayerState.STATE_WALKING:
                    Walking();
                    break;
                case PlayerState.STATE_JUMPING:
                    Jumping();
                    break;
                case PlayerState.STATE_SHOOTING:
                    ShottBullet();
                    break;
            }
        }

        private void Jumping()
        {
            if (canJump)
            {
                rb2d.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
                animator.SetTrigger("isJumping");
                canJump = false;
                soundManager.GetComponent<SoundController>().grounded = false;
            }
        }

        private void Walking()
        {
            var horizontal = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(horizontal, 0f, 0f);
            transform.position += movement * speed * Time.deltaTime;

            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);

            if (Input.GetKey(KeyCode.A))
            {
                Vector3 theScale = transform.localScale;
                theScale.x = +1.5f;
                transform.localScale = theScale;
                facingLeft = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Vector3 theScale = transform.localScale;
                theScale.x = -1.5f;
                transform.localScale = theScale;
                facingLeft = false;
            }
            else if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log("Går ikke mere");
                StateSelect(PlayerState.STATE_STANDING);
            }
        }
        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Ground")
            {
                canJump = true;
                StateSelect(PlayerState.STATE_STANDING);
                soundManager.GetComponent<SoundController>().grounded = true;
            }
        }
        public void ShottBullet()
        {
            animator.SetTrigger("isShooting");
            soundManager.GetComponent<SoundController>().gunShot.Play();

            Vector3 bulletPos = gameObject.GetComponent<Rigidbody2D>().transform.position;
            bulletPos += new Vector3(0f, 0.3f, -1f);
            GameObject clone = (GameObject)Instantiate(bullet, bulletPos, Quaternion.identity);
            if (facingLeft)
            {
                clone.GetComponent<Rigidbody2D>().AddForce((Vector2.left * 50000) * Time.deltaTime);
            }
            else
            {
                clone.GetComponent<Rigidbody2D>().AddForce((Vector2.right * 50000) * Time.deltaTime);
            }

            Destroy(clone, 0.5f);
        }
    }
}
