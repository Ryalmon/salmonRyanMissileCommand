using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    IEnumerator DeathTimer()
    {

        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
