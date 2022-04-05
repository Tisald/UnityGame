using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerAttackingTrain : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject boss;
    public float targetDistance;
    public int health = 3;
    public int health2 = 3;
    public int bossHealth = 10;
    public Text XP;
    public int[] exp = new int[3];


    // Update is called once per frame
    void Update()
    {

        float distance = Mathf.Abs(enemy.transform.position.magnitude - player.transform.position.magnitude);
        float distance2 = Mathf.Abs(enemy2.transform.position.magnitude - player.transform.position.magnitude);
        float bossDistance = Mathf.Abs(boss.transform.position.magnitude - player.transform.position.magnitude);



        if ((distance <= 2f) && Input.GetMouseButtonDown(0))
        {

            health--;
        }
        if ((distance <= 2f) && Input.GetMouseButtonDown(1))
        {
            health = health - 2;
        }
        if (health <= 0)
        {
            enemy.SetActive(false);
            exp[0] = 100;
        }
        //

        if ((distance2 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health2--;
        }
        if ((distance2 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health2 = health2 - 2;
        }
        if (health2 <= 0)
        {
            enemy2.SetActive(false);
            exp[1] = 100;
        }

        
        //
        if ((bossDistance <= 2f) && Input.GetMouseButtonDown(0))
        {
            bossHealth--;
        }
        if ((bossDistance <= 2f) && Input.GetMouseButtonDown(1))
        {
            bossHealth = bossHealth - 2;
        }
        if (bossHealth <= 0)
        {
            boss.SetActive(false);
            exp[4] = 500;


        }

        XP.text = "Experience:" + (exp[0] + exp[1] + exp[2]);

    }
}