using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed;
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
        animator.SetTrigger("Stumble");
        GameManager.Instance.Lose();
        return null;
    }
    void Update()
    {
        if (GameManager.lost == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed, Space.World);
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                
                animator.SetTrigger("Jump");
            }
        }

    }
}
