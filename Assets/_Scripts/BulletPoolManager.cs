using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets

    //----------------------

    private GameObject Prefab_Bullet;
    private Queue<GameObject> BulletPool = new Queue<GameObject>();
    private int Num_Bullets = 8;    // We will start with 8 bullets for now
    //------------------------


    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool


        //-------------------------------------
        for(int slot = 0 ; slot < Num_Bullets  ; slot++ )
        {
            bullet = Instantiate(Prefab_Bullet);  

            BulletPool.Enqueue(bullet);      //Adds it to the queue

            bullet.SetActive(false);         //Set for false for now till activated
        }
       


        //--------------------------------------
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        if(BulletPool.Count > 0)
        {
            bullet = BulletPool.Dequeue();  //Removes it from the queue
            bullet.SetActive(true);          //Bullet is ready to fire
            return bullet;
        }

        else

        {
            bullet = Instantiate(Prefab_Bullet);
            return bullet;
        }

       
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {

        BulletPool.Enqueue(bullet);  //puts the bullet back
        bullet.SetActive(false);

    }
}
