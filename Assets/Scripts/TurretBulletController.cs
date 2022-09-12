using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBulletController : MonoBehaviour
{
    private Vector2 mouseTarget;
    public float bulletSpeed = 5f;
    private float speedometer;
    public Rigidbody2D bulletRB;
    public GameObject turretExplosionPrefab;


    // Start is called before the first frame update
    void Start()
    {
        mouseTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, mouseTarget, bulletSpeed * Time.deltaTime);

        if (transform.position == (Vector3)mouseTarget)
        {
            Instantiate(turretExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
