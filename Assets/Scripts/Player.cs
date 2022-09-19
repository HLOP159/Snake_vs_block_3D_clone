using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public List<GameObject> BoneSnake = new List<GameObject>();
    public float Zoffset;
    public GameObject BonePrefab;
    public float MoveSpeed;

    private void Start()
    {
        BoneSnake[0] = gameObject;
    }
    public void AddBone()
    {
        Vector3 newBonePosition = BoneSnake[BoneSnake.Count - 1].transform.position;
        newBonePosition.z -=Zoffset; 

        BoneSnake.Add(GameObject.Instantiate(BonePrefab,newBonePosition,Quaternion.identity) as GameObject);
    }
    public void DestroyBone()
    {
        Destroy(BoneSnake[BoneSnake.Count - 1]);
        BoneSnake.RemoveAt(BoneSnake.Count - 1);
        
    }
    void Update()
    {
        Vector3 motion = new Vector3(0, 0, MoveSpeed);
        transform.position += motion * Time.deltaTime;
    }
}
