using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMeshCombine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 收集要合并的物体的所有Mesh信息
        MeshFilter[] childMeshFilters = GetComponentsInChildren<MeshFilter>();

        CombineInstance[] destCombineInstances = new CombineInstance[childMeshFilters.Length];
        for ( int i = 0; i < childMeshFilters.Length; i++)
        {
            destCombineInstances[i] = new CombineInstance();
            destCombineInstances[i].mesh = childMeshFilters[i].mesh;
            destCombineInstances[i].transform = childMeshFilters[i].transform.localToWorldMatrix;

            // 隐藏子物体，或者Destory
            childMeshFilters[i].gameObject.SetActive(false);
        }
        Mesh destMesh = new Mesh();
        // 进行合并
        destMesh.CombineMeshes(destCombineInstances, true);
        destMesh.RecalculateNormals();

        // 将合并后的mesh赋给当前的MeshFilter
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null) meshFilter = gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = destMesh;

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if( meshRenderer == null)
        {
            meshRenderer = gameObject.AddComponent<MeshRenderer>();
            // 设置MeshRenderer的material
            Material material = new Material(Shader.Find("Standard"));
            meshRenderer.material = material;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
