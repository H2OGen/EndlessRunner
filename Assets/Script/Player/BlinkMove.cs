using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkMove : MonoBehaviour
{
    public float MoveSpeed;
    public string anim1name;
    public string anim2name;
    public ParticleSystem BlinkFX;
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
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x-3 > -3.5f)
                {
                    BlinkFX.Play();
                    Vector3 pos = gameObject.transform.position;
                    gameObject.transform.position = new Vector3(pos.x-3, pos.y, pos.z);
                }

            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x+3 < 3.5f)
                {
                    BlinkFX.Play();
                    Vector3 pos = gameObject.transform.position;
                    gameObject.transform.position = new Vector3(pos.x + 3, pos.y, pos.z);
                }

            }
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                animator.SetTrigger(anim1name);
            }
        }
    }
}
