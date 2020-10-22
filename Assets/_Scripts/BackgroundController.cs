/*
 *  BackgroundController.cs Script
    Nicolas Plumb / 101078622 / October 22 2020
    MODIFICATIONS:
    changed everything horizontal to be vertical and made appropriate adjustments to make it all work.
    _CheckBounds / _Move and _Reset were the three functions changed to apply this.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //public float verticalSpeed;
    //public float verticalBoundary;
    [Header("_CheckBounds")]
    public float horizontalSpeed;
    [Header("_Move")]
    [Header("_RESET")]
 public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;//+= was -=
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)//horizontalBoundary was -horizontalBoundary
        {
            _Reset();
        }
    }
}
