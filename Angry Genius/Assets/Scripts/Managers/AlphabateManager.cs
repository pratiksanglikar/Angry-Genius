using UnityEngine;
using System.Collections;
using System;

public class AlphabateManager : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public GameObject number;
    public GameObject decoratedNumber;

    void Start()
    {

        NumTextGen NumberGen = new NumTextGenImpl();
        AlphaTargetTextManager.target_number = NumberGen.getTargetNumber();
        Debug.Log("Target Text is " + NumberGen.getTargetNumber());
        NumberFactory numberFactory;
        long timestamp = DateTime.Now.Millisecond;
        if (timestamp % 2 == 0)
        {
            numberFactory = gameObject.AddComponent<NumberCylinder>();
        }
        else
        {
            numberFactory = gameObject.AddComponent<NumberCube>();
        }

        number = numberFactory.getGameObject();
        InvokeRepeating("SpawnNumbers", spawnTime, spawnTime);
    }

    void SpawnNumbers()
    {
        Debug.Log("In SpawnNumbers");
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = UnityEngine.Random.Range(0, spawnPoints.Length);

        number.tag = "Pickup";

        if (!number.activeSelf)
            number.SetActive(true);


        ConcreteComponent c = new ConcreteComponent(number);
        NumberDecorator d1 = new NumberDecorator();
        ColorDecorator d2 = new ColorDecorator();

        // Link decorators
        d1.SetComponent(c);
        d2.SetComponent(d1);



        decoratedNumber = d2.getGameObject();



        Debug.Log("Tage name is" + decoratedNumber.tag);

        Instantiate(decoratedNumber, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
