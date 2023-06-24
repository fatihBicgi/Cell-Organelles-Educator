using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusMovement : ExtracellularMovement
{
    [SerializeField] GameObject hitEffect;
    private GameObject retry;

    private void Start()
    {
        retry = GameObject.Find("Retry");
    }


      
    void OnCollisionEnter(Collision collision)
    {
        //ba�ka bir objeye de�erse de patlar
        //bu kas�tl� yap�ld�
        Effect();
        Destroy(gameObject);

        if(collision.gameObject.tag== "Cell Wall")
        {
            GameOver();
           
            
        }
    }
    private void GameOver()
    {
        

        Time.timeScale = 0f;
        retry.GetComponent<Image>().enabled = true;
        retry.GetComponentInChildren<Text>().enabled = true;
    }




    private void Effect()
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
    }
}
