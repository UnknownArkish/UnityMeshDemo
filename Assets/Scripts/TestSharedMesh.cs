using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSharedMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh cubeSharedMesh = meshFilter.sharedMesh;
        cubeSharedMesh.Clear();
        
        Vector3[] vertices = new Vector3[]
        {
            Vector3.zero,
            new Vector3( 0, 1, 0 ),
            new Vector3( 1, 0, 0 ),
            new Vector3( 1, 1, 0 ),
        };
        cubeSharedMesh.vertices = vertices;

        int[] triangles = new int[]
        {
            0, 1, 2,
            1, 3, 2,
        };
        cubeSharedMesh.triangles = triangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
