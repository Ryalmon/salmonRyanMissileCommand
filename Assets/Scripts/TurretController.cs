using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public Rigidbody2D rB;
    public Camera cam;

    public GameObject bulletSpawn;
    public GameObject bulletPrefab;

    Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, bulletSpawn.transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePosition - rB.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rB.rotation = angle;
    }
}
