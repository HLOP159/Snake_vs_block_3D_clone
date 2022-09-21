using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Cube : MonoBehaviour
{
    public int Damage;
    public List<Material> CubeMaterials = new List<Material>();
    public Renderer CubeMaterial;
    public float Delay;

    public void Start()
    {
        Damage = Random.Range(1, Damage + 1);
        CubeMaterial = GetComponent<Renderer>();
        if (Damage <= 5)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[0];
        }
        if (Damage <= 10 & Damage > 5)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[1];
        }
        if (Damage <= 15 & Damage > 10)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[2];
        }
        if (Damage <= 20 & Damage > 15)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[3];
        }
        if (Damage <= 25 & Damage > 20)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[4];
        }
        if (Damage <= 30 & Damage > 25)
        {
            CubeMaterial.sharedMaterial = CubeMaterials[5];
        }
    }

    public IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().OffMoveSpeed();

            for (int i = 0; i < Damage; i++)
            {
                other.GetComponent<Player>().DestroyBone();
                yield return new WaitForSeconds(Delay);
            }
            other.GetComponent<Player>().ReturnMoveSpeed();
            Destroy(gameObject);
        }
    }
}
