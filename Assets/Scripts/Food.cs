using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private GameObject foodPrefab;

    private Tray _tray;

    //Выбор еды
    public void ChangeMainFood()
    {
        _tray = FindObjectOfType<Tray>();

        _tray.MainFood = foodPrefab;

        _tray.SpawnFood();    
    }    
}
