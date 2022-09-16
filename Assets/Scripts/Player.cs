using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public List<GameObject> BoneSnake = new List<GameObject>();
    public float Zoffset = -0.5f;
    public GameObject BonePrefab;

    private void Start()
    {
        BoneSnake.Add(gameObject);
    }
    public void AddBone()
    {
        Vector3 newBonePosition = BoneSnake[BoneSnake.Count - 1].transform.position;
        newBonePosition.z -= Zoffset; 

        BoneSnake.Add(GameObject.Instantiate(BonePrefab,newBonePosition,Quaternion.identity) as GameObject);
    }    
}
