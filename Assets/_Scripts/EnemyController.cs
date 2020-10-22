/*
 *  EnemyController.cs Script
    Nicolas Plumb / 101078622 / October 22 2020
    MODIFICATIONS:
    changed everything horizontal to be vertical and made appropriate adjustments to make it all work.
    _CheckBounds and _Move were the two functions changed to apply this.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //public float horizontalSpeed;
    //public float horizontalBoundary;
    [Header("_Move")]
    public float verticalSpeed;
    [Header("_CheckBounds")]
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //private void _Move()
    //{
    //    transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    //}
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    //private void _CheckBounds()
    //{
    //    // check right boundary
    //    if (transform.position.x >= horizontalBoundary)
    //    {
    //        direction = -1.0f;
    //    }

    //    // check left boundary
    //    if (transform.position.x <= -horizontalBoundary)
    //    {
    //        direction = 1.0f;
    //    }
    //}
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
