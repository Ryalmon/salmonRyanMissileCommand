using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileController : MonoBehaviour
{
    public int missileSpeed = 2;

    public int baseTarget;

    public Transform baseTarget1;
    public Transform baseTarget2;
    public Transform baseTarget3;
    public Transform baseTarget4;
    public Transform baseTarget5;
    public Transform baseTarget6;

    // Start is called before the first frame update
    void Start()
    {
        baseTarget = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (baseTarget == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, baseTarget1.transform.position, missileSpeed * Time.deltaTime);
        }
        else if (baseTarget == 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, baseTarget2.transform.position, missileSpeed * Time.deltaTime);
        }
        else if (baseTarget == 3)
        {
            transform.position = Vector2.MoveTowards(transform.position, baseTarget3.transform.position, missileSpeed * Time.deltaTime);
        }
        else if (baseTarget == 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, baseTarget4.transform.position, missileSpeed * Time.deltaTime);
        }
        else if (baseTarget == 5)
        {
            transform.position = Vector2.MoveTowards(transform.position, baseTarget5.transform.position, missileSpeed * Time.deltaTime);
        }
        else if (baseTarget == 6)
        {
            transform.position = Vector2.MoveTowards(transform.position, baseTarget6.transform.position, missileSpeed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
