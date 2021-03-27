using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;
    
    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvadores = 7;

    [SerializeField]
    float xMin = -3f;


    private void Awake()
    {
        /*
         * Gets an invader from prefab and puts in that position
        */
        float x = xMin;
        for (int i = 1; i <= nInvadores; i++)
        {
            //First row of invaders bot to top
            //Invader A
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, 0f, 0f);

            //Second row of invaders bot to top
            //Invader A
            for (int j = 1; j <= nInvadores; j++)
            {
                newInvader = Instantiate(invasorA, transform);
                newInvader.transform.position = new Vector3(x, 0.5f, 0f);
            }

            //Trird row of invaders bot to top
            //Invader B
            for (int k = 1; k <= nInvadores; k++)
            {
                newInvader = Instantiate(invasorB, transform);
                newInvader.transform.position = new Vector3(x, 1f, 0f);
            }

            //Forth row of invaders bot to top
            //Invader B
            for (int l = 1; l <= nInvadores; l++)
            {
                newInvader = Instantiate(invasorB, transform);
                newInvader.transform.position = new Vector3(x, 1.5f, 0f);
            }

            //Fifth row of invaders bot to top
            //Invader C
            for (int p = 1; p <= nInvadores; p++)
            {
                newInvader = Instantiate(invasorC, transform);
                newInvader.transform.position = new Vector3(x, 2f, 0f);
            }
            x += 1f;
        }
    }
}
