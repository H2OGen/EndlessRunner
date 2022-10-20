using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkMove : MonoBehaviour
{
    public ParticleSystem BlinkFX;

    void Update()
    {
        if (GameManager.lost == false)
        {
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
        }
    }
}
