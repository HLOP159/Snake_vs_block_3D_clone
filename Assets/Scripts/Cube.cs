using UnityEngine;
using System.Collections.Generic;

public class Cube : MonoBehaviour
{
    public int Damage;
    public List<Material> CubeMaterials = new List<Material>();
    public Renderer CubeMaterial;

    public void Start()
    {
        Damage = Random.Range(1, Damage + 1);
        CubeMaterial = GetComponent<Renderer>();
        if (Damage <= 5)
        {
            CubeMaterial.material = CubeMaterials[0];
        }
        if (Damage <= 10 & Damage > 5)
        {
            CubeMaterial.material = CubeMaterials[1];
        }
        if (Damage <= 15 & Damage > 10)
        {
            CubeMaterial.material = CubeMaterials[2];
        }
        if (Damage <= 20 & Damage > 15)
        {
            CubeMaterial.material = CubeMaterials[3];
        }
        if (Damage <= 25 & Damage > 20)
        {
            CubeMaterial.material = CubeMaterials[4];
        }
        if (Damage <= 30 & Damage > 25)
        {
            CubeMaterial.material = CubeMaterials[5];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < Damage; i++)
            {
                other.GetComponent<Player>().DestroyBone();
            }
            Destroy(gameObject);
        }
    }
}
