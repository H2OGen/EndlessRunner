using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed;
    public float LeftRightSpeed;
    public string anim1name;
    public string anim2name;
    bool lost = false;
    Animator animator;
    private void Start()
    {
        animator = this.GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
           StartCoroutine("Stumble", other.gameObject);
        }
    }
    IEnumerator Stumble(GameObject Obstacle)
    {
        animator.SetTrigger(anim2name);
        lost = true;
        return null;
    }
    void Update()
    {
        if (lost == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed, Space.World);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.LeftBoundary)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed, Space.World);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.RightBoundary)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * LeftRightSpeed, Space.World);
                }

            }
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                animator.SetTrigger(anim1name);
            }
        }
    }
}
