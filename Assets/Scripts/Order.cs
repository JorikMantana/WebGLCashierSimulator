using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Order : MonoBehaviour
{
    public List<GameObject> OrderFood = new List<GameObject>();
    [SerializeField] private GameObject[] Food;

    [SerializeField] private Transform[] spawnTrans;

    [SerializeField] private Score score;

    public List<GameObject> _newOrder = new List<GameObject>();
    private Tray _tray;

    //Рандомный заказ клиента
    public void RandomFoodOrder()
    {
        for (int i = 0; i < Random.Range(1, 5); i++)
        {
            OrderFood.Add(Food[Random.Range(0, Food.Length)]);
        }

        for (int i = 0; i < OrderFood.Count; i++)
        {
            GameObject aboba = Instantiate(OrderFood[i], spawnTrans[i]);
            //aboba.transform.localScale = new Vector3(3, 3, 3);
            _newOrder.Add(aboba);
        }
    }

    //Проверка правильности собранного заказа
    public void CheckOrder()
    {
        _tray = FindObjectOfType<Tray>();

        if(_tray.FoodOnTray.Count != OrderFood.Count)
        {
            score.MinusScore();
            return;
        }


        for (int i = 0; i < _tray.FoodOnTray.Count; i++)
        {
            for (int x = 0; x < OrderFood.Count; x++)
            {
                if(_tray.FoodOnTray[i] == OrderFood[x])
                {
                    OrderFood.Remove(OrderFood[x]);
                    break;
                }
            }            
        }
        if(OrderFood.Count != 0)
        {
            score.MinusScore();
            return;
        }

        score.PlusScore();
    }
}
