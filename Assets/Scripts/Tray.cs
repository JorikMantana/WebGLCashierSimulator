using System.Collections.Generic;
using UnityEngine;

public class Tray : MonoBehaviour
{
    [SerializeField] private Transform[] positions;

    public List<GameObject> FoodOnTray = new List<GameObject>();

    public GameObject MainFood;

    //Спавн продуктов на подносе
    public void SpawnFood()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            if(positions[i].childCount == 0)
            {
                Instantiate(MainFood, positions[i]);
                FoodOnTray.Add(MainFood);
                return;
            }
        }
    }
}
