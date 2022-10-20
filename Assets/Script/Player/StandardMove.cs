using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMove : MonoBehaviour
{
    public float LeftRightSpeed;

    void Update()
    {
        if (GameManager.lost == false)
        {
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
        }
    }
}
