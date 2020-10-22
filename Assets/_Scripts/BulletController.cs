/*
 * BulletController.cs Script
 Nicolas Plumb / 101078622 / October 22 2020
   MODIFICATIONS:
changed everything Vertical to be horizontal and made appropriate adjustments to make it all work.
    _CheckBounds and _Move were the two functions changed to apply this.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    //public float verticalSpeed;
    //public float verticalBoundary;
    [Header("_Move")]
    public float horizontalSpeed;
    [Header("_CheckBounds")]
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;//-= was +=
    }

    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
