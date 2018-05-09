using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -2.0f;
    public float columnMax = 2.0f;

    private GameObject[] columns;
    private Vector2 ObjectPoolPosition = new Vector2(-15f, -25f); // Setting the initialized position of the columns
    private float TimeSinceLastSpawned;
    private float columnXposition = 10.0f;
    private int currentColumn = 0;

	// Use this for initialization
	void Start () {

        columns = new GameObject[columnPoolSize];

        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, ObjectPoolPosition, Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void Update () {

        TimeSinceLastSpawned += Time.deltaTime;

        if(GameController.instance.gameOver == false && TimeSinceLastSpawned >= spawnRate)
        {
            TimeSinceLastSpawned = 0;
            float columnYposition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(columnXposition, columnYposition);
            currentColumn++;

            // make the current column 0 for the next instantiation
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }

        }

	}
}
