using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    private float screenOffset = 0.5f;

    private float leftX;
    private float rightX;

    public GameObject Base1;
    public GameObject Base2;
    public GameObject Base3;
    public GameObject Base4;
    public GameObject Base5;
    public GameObject Base6;

    private bool missileSpawn = true;

    private float randomMissileSpawn;
    private float topY;

    // Start is called before the first frame update
    void Start()
    {
        leftX = Camera.main.ViewportToWorldPoint(new Vector2(0, 1)).x;
        rightX = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)).x;


        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }


        if (Base1 == null && Base2 == null && Base3 == null && Base4 == null && Base5 == null && Base6 == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        if (missileSpawn == true)
        {
            StartCoroutine(MissileTimer());
        }
    }


    IEnumerator MissileTimer()
    {
        missileSpawn = false;
        randomMissileSpawn = Random.Range(leftX, rightX);
        topY = Camera.main.ViewportToWorldPoint(new Vector2(0, 1)).y;
        Instantiate(enemyMissilePrefab, new Vector2(randomMissileSpawn, topY + screenOffset), Quaternion.identity);
        yield return new WaitForSeconds(3);
        missileSpawn = true;
    }
    
}
