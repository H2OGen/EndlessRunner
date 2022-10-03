using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed;
    public float LeftRightSpeed;
    void Update()
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

    }
}
