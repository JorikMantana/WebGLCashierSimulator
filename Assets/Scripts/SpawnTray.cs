using UnityEngine;

public class SpawnTray : MonoBehaviour
{
    [SerializeField] private GameObject tray;

    [SerializeField] private Transform traySpawnTransform;

    [SerializeField] private Order someOrder;

    private Tray someTray;


    //Спавн подноса
    public void TraySpawn()
    {
        Instantiate(tray, traySpawnTransform);
    }

    //Деспавн подноса(Выдача заказа)
    public void TrayDespawn()
    {
        someTray = FindObjectOfType<Tray>();
        for (int i = 0; i < someOrder.OrderFood.Count; i++)
        {
            someOrder.OrderFood.Remove(someOrder.OrderFood[i]);
        }

        for (int i = 0; i < someOrder._newOrder.Count; i++)
        {
            Destroy(someOrder._newOrder[i]);
        }
        Destroy(someTray.gameObject);
    }
}
