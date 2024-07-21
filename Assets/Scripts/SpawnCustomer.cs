using UnityEngine;

public class SpawnCustomer : MonoBehaviour
{
    [SerializeField] private GameObject[] Customers;

    [SerializeField] private Transform customerSpawnTransform;
    private GameObject _customer;

    public void CustomerSpawn()
    {
        _customer = Instantiate(Customers[Random.Range(0, Customers.Length)], customerSpawnTransform);
    }

    public void CustomerDespawn()
    {
        Destroy(_customer);
    }
}
