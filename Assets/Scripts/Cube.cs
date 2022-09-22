using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Cube : MonoBehaviour
{
    public int Damage;
    public List<Material> CubeMaterials = new List<Material>();
    public Renderer CubeMaterial;
    public float Delay;
    public int HPCube;
    private Player player;

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
        HPCube = Damage;
    }

    public IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<Player>();
            player.OffMoveSpeed();

            for (int i = 0; i < Damage; i++)
            {
                player.DestroyBone();
                yield return new WaitForSeconds(Delay);
                HPCube--;
            }
            player.ReturnMoveSpeed();
            Destroy(gameObject);
        }
    }
}
